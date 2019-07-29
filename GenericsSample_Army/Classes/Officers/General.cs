using GenericsSample_Army.Classes.Nationalities;

namespace GenericsSample_Army.Classes.Officers
{
    public class General<N> : MilitaryOfficer<N> 
        where N : Nationality, new()
    {
        public General() : base()
        {
        }
    }
}
