namespace IndexerSample_Army.Classes
{
    public class Soldier : EnrolledSoldier
    {
        public Officer SuperiorOfficer { get; set; }

        public Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
