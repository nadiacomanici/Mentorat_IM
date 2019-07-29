using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesSample_StudentName.Classes
{
    public class Student
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // daca avem subscriberi, atunci declansam evenimentul, cu parametrii necesari
                // ca si cum am apela o metoda
                if (OnNameChanged != null)
                {
                    OnNameChanged(_name, value);
                }
                _name = value;
            }
        }

        // evenimentul e un obiect de tipul delegatui
        public event NameChanged OnNameChanged;

        public Student(string name)
        {
            this.Name = name;
        }
    }
}
