using System;

namespace AttributesSample_Custom_Author.Classes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Constructor,
        Inherited = false, AllowMultiple = false)]
    public class AuthorAttribute : Attribute
    {
        // mandatory, as defined in constructor as a parameter
        public string Name { get; private set; }

        // optional
        public string Note { get; set; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
