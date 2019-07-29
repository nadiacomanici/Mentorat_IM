using System.Collections.Generic;
using System.Linq;

namespace EventsAndDelegatesSample_Statistics.Classes
{
    public class RegistrationList
    {
        private List<Student> _allStudents;
        private int _nextIndex;

        public event RegistrationListChangedDelegate RegistrationListChangeEvent;

        public IReadOnlyList<Student> AllStudents
        {
            get
            {
                return _allStudents.AsReadOnly();
            }
        }

        public double AverageAdmissionMark
        {
            get
            {
                if (_allStudents.Count > 0)
                {
                    return _allStudents.Average(s => s.AdmissionMark);
                }
                return 0;
            }
        }

        public RegistrationList()
        {
            _allStudents = new List<Student>();
            _nextIndex = 1;
        }

        public void RegisterStudent(string name, Gender gender, double admissionMark)
        {
            var student = new Student(_nextIndex++, name, gender, admissionMark);
            _allStudents.Add(student);

            if (RegistrationListChangeEvent != null)
            {
                RegistrationListChangeEvent(this);
            }
        }

        public void DeleteStudent(Student student)
        {
            _allStudents.Remove(student);
            if (RegistrationListChangeEvent != null)
            {
                RegistrationListChangeEvent(this);
            }
        }
    }
}
