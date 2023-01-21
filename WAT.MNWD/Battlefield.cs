using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace index
{
    internal class Battlefield
    {
        private static readonly SemaphoreSlim attack_sem = new SemaphoreSlim(1, 1);
        private static readonly SemaphoreSlim defend_sem = new SemaphoreSlim(0, 1);
        private static MainForm form;

        public static List<Unit> attacker = new List<Unit>
        {
            new Unit(),
            new Unit(),
            new Unit()
        };

        public static List<Unit> defender = new List<Unit>
        {
            new Unit(),
            new Unit(),
            new Unit()
        };

        private static float get_attacker_value()
        {
            return 0;
        }

        private static float get_defender_value()
        {
            return 0;
        }

        public static void switchSides(MainForm f1)
        {
            form = f1;
            var temp = new List<Unit>
            {
                new Unit(),
                new Unit(),
                new Unit()
            };
            temp = attacker;
            attacker = defender;
            defender = temp;
            form.refreshForm();
        }

        private static bool anyoneAlive(List<Unit> units)
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
            while (anyoneAlive(attacker) && anyoneAlive(defender))
            {
                attack_sem.Wait();
                foreach (var el in defender)
                    if (el.CurrentHealth > 0)
                        el.CurrentHealth = el.CurrentHealth - (getSummarizedSoftAttack(attacker) -
                                                             (el.GetArmor() - getSummarizedHardAttack(attacker)));

                form.Invoke((MethodInvoker)delegate { form.refreshForm(); });

                Thread.Sleep(400);
                defend_sem.Release();
            }
        }

        private static void Defensive()
        {
            while (anyoneAlive(attacker) && anyoneAlive(defender))
            {
                defend_sem.Wait();
                foreach (var el in attacker)
                    if (el.CurrentHealth > 0)
                        el.CurrentHealth = el.CurrentHealth - (getSummarizedSoftAttack(defender) -
                                                             (el.GetArmor() - getSummarizedHardAttack(defender)));
                form.Invoke((MethodInvoker)delegate { form.refreshForm(); });
                Thread.Sleep(400);
                attack_sem.Release();
            }
        }
    }
}