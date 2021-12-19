namespace DesignPatternsAsISeeThem.Creational.Prototype
{
    public interface IDeveloper
    {
        string Name { get; set; }
        Stack Stack { get; set; }

        Developer Clone();
    }
}