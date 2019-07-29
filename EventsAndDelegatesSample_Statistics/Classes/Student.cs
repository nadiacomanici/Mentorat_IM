namespace EventsAndDelegatesSample_Statistics.Classes
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public double AdmissionMark { get; private set; }

        public Student(int id, string name, Gender gender, double admissionMark)
        {
            Id = id;
            Name = name;
            Gender = gender;
            AdmissionMark = admissionMark;
        }
    }
}
