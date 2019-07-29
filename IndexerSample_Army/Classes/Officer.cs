using System.Collections.Generic;

namespace IndexerSample_Army.Classes
{
    public class Officer : EnrolledSoldier
    {
        public List<Soldier> SoldiersUnderCommand { get; private set; }

        public void TakeUnderCommand(Soldier soldier)
        {
            SoldiersUnderCommand.Add(soldier);
            soldier.SuperiorOfficer = this;
        }

        public Officer(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SoldiersUnderCommand = new List<Soldier>();
        }
    }
}
