interface IDecorate
{
    // Add a field (auto-implemented property)
    int numberOfItems {get;set;}
    List<string> AllItems {get;set;}
    // Add a method
    void AddItem(string Item);
    void ShowItems();
}