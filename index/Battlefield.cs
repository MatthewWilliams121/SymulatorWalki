using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index
{
    internal class Battlefield
    {
        static SemaphoreSlim attack_sem = new SemaphoreSlim(1, 1);
        static SemaphoreSlim defend_sem = new SemaphoreSlim(0, 1);
        static Form1 form;
        public static List<Unit> attacker = new List<Unit> {
        new NoUnit(),
        new NoUnit(),
        new NoUnit()
        };
        public static List<Unit> defender = new List<Unit> {
        new NoUnit(),
        new NoUnit(),
        new NoUnit()
        };

        static private float get_attacker_value() { return 0; }
        static private float get_defender_value() { return 0; }

        static public void switchSides(Form1 f1)
        {
            form = f1;
            List<Unit> temp = new List<Unit> {
        new NoUnit(),
        new NoUnit(),
        new NoUnit()
        };
            temp = attacker;
            attacker = defender;
            defender = temp;
            form.refreshForm();
        }

        static private bool anyoneAlive(List<Unit> units)
        {
            foreach(var el in units)
            {
                if (el.getOrganization() > 0) return true;
            }
            return false;
        }
        static private int getSummarizedSoftAttack(List<Unit> units)
        {
            int sum = 0;
            foreach (var el in units)
            {
                if(el.getOrganization()>0)sum += el.get_soft_attack();
            }
            return sum;
        }
        static private int getSummarizedHardAttack(List<Unit> units)
        {
            int sum = 0;
            foreach (var el in units)
            {
                if (el.getOrganization() > 0)sum += el.get_hard_attack();
            }
            return sum;
        }
        static public void resolve(Form1 f1)
        {
            form = f1;
            AttackThread();
            DefendThread();
        }
        static private void AttackThread()
        {
            Thread attack = new Thread(Offensive);
            attack.Start();
        }
        static private void DefendThread()
        {
            Thread defense = new Thread(Defensive);
            defense.Start();
        }

        static private void Offensive()
        {
            while (anyoneAlive(attacker) && anyoneAlive(defender))
            {
                attack_sem.Wait();
                foreach (var el in defender)
                {                    
                    if (el.getOrganization()>0)
                    {
                    el.setOrganization(el.getOrganization() - (getSummarizedSoftAttack(attacker) - (el.get_armor() - getSummarizedHardAttack(attacker))));
                    }
                }

                form.Invoke((MethodInvoker)delegate
                {
                    form.refreshForm();
                });
               
                System.Threading.Thread.Sleep(400);
                defend_sem.Release();
            }
        }
        static private void Defensive()
        {
            while (anyoneAlive(attacker) && anyoneAlive(defender))
            {
                defend_sem.Wait();
                foreach (var el in attacker)
                {
                    if (el.getOrganization() > 0)
                    {
                        el.setOrganization(el.getOrganization() - (getSummarizedSoftAttack(defender) - (el.get_armor() - getSummarizedHardAttack(defender))));
                    }
                }
                form.Invoke((MethodInvoker)delegate
                {
                    form.refreshForm();
                });
                System.Threading.Thread.Sleep(400);
                attack_sem.Release();
            }
        }
    }
}
