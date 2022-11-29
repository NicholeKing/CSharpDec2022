public abstract class Furniture
{
    // Fields describe our object
    private string material;
    public string _material {get {return material;} set {if(value != "Metal") {material = value;}}}
    protected string color;
    public string _color {get {return color;}}
    public double price;
    public bool outdoor;

    // Constructor
    public Furniture(string m, string c, double p, bool o = false)
    {
        material = m;
        color = c;
        price = p;
        outdoor = o;
    }

    public Furniture(string m, string c, double p)
    {
        material = m;
        color = c;
        price = p;
        outdoor = true;
    }

    public Furniture(string m, string c, bool o)
    {
        material = m;
        color = c;
        price = 12.00;
        outdoor = o;
    }

    // Methods - what can our object do
    // Paint our furniture
    public virtual void ChangeColor(string newColor)
    {
        Console.WriteLine($"Changed our furniture from {color} to {newColor}");
        color = newColor;
    }
}