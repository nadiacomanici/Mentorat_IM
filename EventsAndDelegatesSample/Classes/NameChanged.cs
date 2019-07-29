using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesSample_StudentName.Classes
{
    // un tip care defineste o semnatura de metoda
    public delegate void NameChanged(string oldName, string newName);
}
