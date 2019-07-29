using System.Collections.Generic;
using GenericsSample_Army.Classes.Nationalities;
using GenericsSample_Army.Classes.Officers;
using GenericsSample_Army.Classes.Soldiers;

namespace GenericsSample_Army.Classes
{
    public class Regiment<S, N, C>
        where N : Nationality, new()
        where S : ISoldier, new()
        where C : MilitaryOfficer<N>
    {
        private int nextId;

        public List<S> Soldiers { get; private set; }

        public N Nationality { get; private set; }

        public C Commandant { get; private set; }

        public Regiment(C commandant)
        {
            nextId = 1;
            Soldiers = new List<S>();
            Nationality = new N();
            Commandant = commandant;
        }

        public void RecruitSoldiers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Soldiers.Add(new S() { Id = nextId, Name = "Soldat " + nextId });
                nextId++;
            }
        }

        public void Attack()
        {
            foreach (var soldier in this.Soldiers)
            {
                soldier.Attack();
            }
        }
    }
}