using System;
using System.Diagnostics;

namespace AttributesSample_ExistingAttributes.Classes
{
    [Serializable]
    [DebuggerDisplay("id =  {_id} - {FullName}")]
    public class SerializableStudent
    {
        //[NonSerialized()]
        private int _id;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [Obsolete]
        public string FormattedDescription
        {
            get
            {
                return $"{_id}. {FullName}";
            }
        }

        public SerializableStudent(int id, string firstName, string lastName)
        {
            this._id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
