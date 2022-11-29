Chair stool = new Chair("Wood", "Brown", 5.00, true, 1, true);
Console.WriteLine($"Can be outdoors: {stool.outdoor}");

Console.WriteLine(stool._material);
stool._material = "Metal";
Console.WriteLine(stool._material);
stool.ChangeColor("Red");

Table outdoorTable = new Table("Wicker", "brownish", 38.00, false);
Console.WriteLine(outdoorTable.outdoor);


Chair NewChair = new Chair("Metal", "Gray", 25.99, false, 4, false);

NewChair.ChangeColor("Green");

// Polymorphism

List<Furniture> AllFurniture = new List<Furniture>();
AllFurniture.Add(NewChair);
AllFurniture.Add(stool);

// List<Chair> AllChairs = new List<Chair>();
// AllChairs.Add(Chair);

Table newTable = new Table("Wood", "Magenta", 76.56, false);
newTable.AddItem("Plate set");
newTable.AddItem("Tablecloth");

newTable.ShowItems();