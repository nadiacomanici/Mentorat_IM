namespace GenericsSample_Army.Classes.Soldiers
{
    public interface ISoldier
    {
        int Id { get; set; }
        string Name { get; set; }
        void Attack();
    }
}
