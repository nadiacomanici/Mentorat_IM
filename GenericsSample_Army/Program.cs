using GenericsSample_Army.Classes;
using GenericsSample_Army.Classes.Nationalities;
using GenericsSample_Army.Classes.Officers;
using GenericsSample_Army.Classes.Soldiers;

namespace GenericsSample_Army
{
    class Program
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
        static void Main(string[] args)
        {
            var popescu = new Colonel<Romanian>();
            var napoleon = new General<French>();

            var romanianRegiment = new Regiment<Infanterist, Romanian, Colonel<Romanian>>(popescu);
            romanianRegiment.RecruitSoldiers(10);
            romanianRegiment.Attack();

            var frenchRegiment = new Regiment<Tankist, French, General<French>>(napoleon);
            frenchRegiment.RecruitSoldiers(5);
            frenchRegiment.Attack();
        }
    }
}