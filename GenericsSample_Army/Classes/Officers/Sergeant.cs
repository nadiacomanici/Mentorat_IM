using GenericsSample_Army.Classes.Nationalities;

namespace GenericsSample_Army.Classes.Officers
{
    public class Sergeant<N> : MilitaryOfficer<N> 
        where N : Nationality, new()
    {
        public Sergeant() : base()
        {
        }
    }
}
