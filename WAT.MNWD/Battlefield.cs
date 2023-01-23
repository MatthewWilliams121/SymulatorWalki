using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace index
{
    internal class Battlefield
    {
        private static readonly SemaphoreSlim attack_sem = new SemaphoreSlim(1, 1);
        private static readonly SemaphoreSlim defend_sem = new SemaphoreSlim(0, 1);
        private static MainForm form;
        private static bool turn; //true - offense ; false - defense 
        public static bool Turn
        {
            get => turn;
            set => turn = value;
        }

        public static List<Unit> attackers = new List<Unit>
        {
            new Unit(),
            new Unit(),
            new Unit()
        };

        public static List<Unit> defenders = new List<Unit>
        {
            new Unit(),
            new Unit(),
            new Unit()
        };

        public static bool isFight;
        

        public static void switchSides(MainForm f1)
        {
            form = f1;
            var temp = new List<Unit>
            {
                new Unit(),
                new Unit(),
                new Unit()
            };
            temp = attackers;
            attackers = defenders;
            defenders = temp;
            form.refreshForm();
        }

        public static bool isAnyoneAlive(List<Unit> units)
        {
            foreach (var el in units)
                if (el.CurrentHealth > 0)
                    return true;
            return false;
        }

        private static int getSummarizedSoftAttack(List<Unit> units)
        {
            var sum = 0;
            foreach (var el in units)
                if (el.CurrentHealth > 0)
                    sum += el.GetSoftAttack();
            return sum;
        }

        private static int getSummarizedHardAttack(List<Unit> units)
        {
            var sum = 0;
            foreach (var el in units)
                if (el.CurrentHealth > 0)
                    sum += el.GetHardAttack();
            return sum;
        }

        public static void resolve(MainForm f1)
        {
            form = f1;
            isFight = true;
            AttackThread();
            DefendThread();
        }

        private static void AttackThread()
        {
            var attack = new Thread(Offensive);
            attack.Start();
        }

        private static void DefendThread()
        {
            var defense = new Thread(Defensive);
            defense.Start();
        }

        private static void Offensive()
        {
            while (isAnyoneAlive(attackers) && isAnyoneAlive(defenders))
            {
                attack_sem.Wait();
                turn = false;
                foreach (var el in defenders)
                    if (el.CurrentHealth > 0)
                    {
                        el.CurrentHealth = el.CurrentHealth - (getSummarizedSoftAttack(attackers) - (el.GetArmor() - getSummarizedHardAttack(attackers)));
                    }

                form.Invoke((MethodInvoker)delegate { form.refreshForm(); });

                Thread.Sleep(400);
                defend_sem.Release();
            }

            isFight = false;
        }

        private static void Defensive()
        {
            while (isAnyoneAlive(attackers) && isAnyoneAlive(defenders))
            {
                defend_sem.Wait();
                turn = true;

                foreach (var el in attackers)
                    if (el.CurrentHealth > 0)
                        el.CurrentHealth = el.CurrentHealth - (getSummarizedSoftAttack(defenders) -
                                                             (el.GetArmor() - getSummarizedHardAttack(defenders)));
                form.Invoke((MethodInvoker)delegate { form.refreshForm(); });
                Thread.Sleep(400);
                attack_sem.Release();
            }
            isFight = false;

        }
        
    }
}