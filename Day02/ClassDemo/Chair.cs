class Chair : Furniture
{
    // Methods
    int numLegs;
    bool hasArms;
    // Constructor
    public Chair(string m, string c, double p, bool o, int nl, bool ha) : base(m, c, p, o)
    {
        numLegs = nl;
        hasArms = ha;
    }

    public override void ChangeColor(string newColor)
    {
        Console.WriteLine($"Changed our chair from {color} to {newColor}");
        color = newColor;
        // base.ChangeColor(newColor);
    }
}