using GenericsSample_Army.Classes.Nationalities;

namespace GenericsSample_Army.Classes.Officers
{
    public class MilitaryOfficer<N>
        where N : Nationality, new()
    {
        public N Nationality { get; private set; }

        public MilitaryOfficer()
        {
            this.Nationality = new N();
        }

        public string GetFlag()
        {
            return Nationality.FlagColors();
        }
    }
}
