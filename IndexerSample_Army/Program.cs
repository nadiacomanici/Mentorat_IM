using System;
using IndexerSample_Army.Classes;

namespace IndexerSample_Army
{
    class Program
    {
        public static void DisplayEnrolledSoldier(EnrolledSoldier enrolledSoldier)
        {
            Console.WriteLine($"- {enrolledSoldier.FirstName} {enrolledSoldier.LastName} (id={enrolledSoldier.Id})");
        }

        static void Main(string[] args)
        {
            Army army = new Army();
            army.EnrollOfficer("Ion", "Antonescu");
            army.EnrollOfficer("Gigi", "Vasile");
            var officer = army.EnrollOfficer("Marian", "Tudor");

            var soldier1 = army.EnrollSoldier("Ion", "Vasile");
            var soldier2 = army.EnrollSoldier("Ghita", "Vasile");
            officer.TakeUnderCommand(soldier1);
            officer.TakeUnderCommand(soldier2);

            Console.WriteLine("Cautare dupa nume:");
            foreach (var enrolledSoldier in army["Vasile"])
            {
                DisplayEnrolledSoldier(enrolledSoldier);
            }

            Console.WriteLine();
            Console.WriteLine("Cautare dupa id:");
            DisplayEnrolledSoldier(army[2]);
            DisplayEnrolledSoldier(army[1]);
            DisplayEnrolledSoldier(army[10]);
        }
    }
}
