using System;

namespace fightingdemo
{
    public class Character
    {
        public string Name;
        public int Damage;
        public bool isAlive;
        public string CombatStyle;
        public int WeakAttackAmount;
        public int StrongAttackAmount;

        public Character(string N, string CS, int WA, int SA)
        {
            Name = N;
            Damage = 0;
            isAlive = true;
            CombatStyle = CS;
            WeakAttackAmount = WA;
            StrongAttackAmount = SA;
        }

        public void DisplayStats()
        {
            Console.WriteLine("-----------");
            Console.WriteLine
            ($"Name:       {Name}");
            Console.WriteLine
            ($"Combat Style:    {CombatStyle}");
            Console.WriteLine("-----------");
        }

        public Character WeakAttack(Character Target)
        {
            Target.Damage += this.WeakAttackAmount;
            Console.WriteLine($"{Name} attacked {Target.Name}, dealing {WeakAttackAmount} damage!");
            Console.WriteLine($"{Target.Name} : {Target.Damage}%");
            Target.CalculateKO();
            return this;
            
        }

        public Character StrongAttack(Character Target)
        {
            Target.Damage += this.StrongAttackAmount;
            Console.WriteLine($"{Name} attacked {Target.Name}, dealing {StrongAttackAmount} damage!");
            Console.WriteLine($"{Target.Name} : {Target.Damage}%");
            Target.CalculateKO();
            return this;
            

        }
        public void CalculateKO()
        {
            Random rand = new Random();
            if (Damage > 300 && rand.Next(0, 5) >= 1)
            {
                Console.WriteLine($"KO! {Name} has been knocked out!!");
                isAlive = false;
            }

            else if (Damage > 200 && rand.Next(0, 5) >= 3)
            {
                Console.WriteLine($"KO! {Name} has been knocked out!!");
                isAlive = false;
            }

            else if (Damage > 100 && rand.Next(0, 5) == 4)
            {
                Console.WriteLine($"KO! {Name} has been knocked out!!");
                isAlive = false;
            }
        }
    }
}
