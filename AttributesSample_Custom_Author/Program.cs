using System;
using System.Reflection;
using AttributesSample_Custom_Author.Classes;

namespace AttributesSample_Custom_Author
{
    class Program
    {
        static void DisplayMemberByAuthor(MemberInfo[] memberInfos, string authorName)
        {
            foreach (var member in memberInfos)
            {
                foreach (var attribute in member.GetCustomAttributes(true))
                {
                    AuthorAttribute author = attribute as AuthorAttribute;
                    if (author != null && author.Name == authorName)
                    {
                        Console.WriteLine(member.Name);
                    }
                }
            }
        }
        static void DisplayAllMembersByAuthor(string authorName)
        {
            Console.WriteLine($"Defined by {authorName}:");
            DisplayMemberByAuthor(typeof(Car).GetProperties(), authorName);
            DisplayMemberByAuthor(typeof(Car).GetConstructors(), authorName);
            DisplayMemberByAuthor(typeof(Car).GetMethods(), authorName);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DisplayAllMembersByAuthor("Nadia Comanici");
            DisplayAllMembersByAuthor("Ion Popescu");
        }
    }
}
