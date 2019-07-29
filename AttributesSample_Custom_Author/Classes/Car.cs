namespace AttributesSample_Custom_Author.Classes
{
    public class Car
    {
        [Author("Nadia Comanici")]
        public string IdentificationNumber { get; private set; }

        [Author("Nadia Comanici")]
        public string Make { get; private set; }

        [Author("Ion Popescu")]
        public int Speed { get; private set; }

        [Author("Nadia Comanici", Note = "Speed is not included")]
        public Car(string id, string make)
        {
            IdentificationNumber = id;
            Make = make;
        }

        [Author("Ion Popescu")]
        public void IncreaseSpeedBy(int value)
        {
            Speed += value;
        }

        [Author("Ion Popescu")]
        public void DecreaseSpeedBy(int value)
        {
            Speed -= value;
        }
    }
}
