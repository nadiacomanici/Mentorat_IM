using GenericsSample_Army.Classes.Nationalities;

namespace GenericsSample_Army.Classes.Officers
{
    public class Colonel<N> : MilitaryOfficer<N> 
        where N : Nationality, new()
    {
        public Colonel() : base()
        {
        }
    }
}
