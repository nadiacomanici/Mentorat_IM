using System;

namespace GenericsSample_Army.Classes.Soldiers
{
    public class Infanterist : ISoldier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Attack from Infanterist {Name}");
        }
    }
}
