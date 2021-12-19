namespace DesignPatternsAsISeeThem.Structural.Adapter
{
    //Client interface
    public interface IFood
    {
        string Ingredients { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}