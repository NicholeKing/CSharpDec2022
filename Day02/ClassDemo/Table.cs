class Table : Furniture, IDecorate
{
    public int numberOfItems {get;set;}
    public List<string> AllItems {get;set;}
    public Table(string m, string c, double p, bool o) : base(m,c,p,o) 
    {
        numberOfItems = 0;
        AllItems = new List<string>();
    }

    public void AddItem(string Item)
    {
        numberOfItems++;
        AllItems.Add(Item);
        Console.WriteLine($"Placed a {Item} on the table");
    }

    public void ShowItems()
    {
        foreach(string item in AllItems)
        {
            Console.WriteLine(item);
        }
    }
}