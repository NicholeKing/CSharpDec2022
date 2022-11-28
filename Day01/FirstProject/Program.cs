// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello from our first project!");

// Data Types
// What is a statically typed language?
// You have to specify the type of variable or function you want to create
// JavaScript
// var name = "Nichole";
// C#
string name = "Nichole";
int number = 7;
double dec = 3.14;
float floatvalue = 1.2f;
bool isTired = true;

// Lists and Dictionaries
// Array and List
// Arrays are fixed length
string[] groceryList = new string[4];
// [null, null, null, null]
string[] groceryList2 = {"Carrots", "Turkey", "Bread", "Milk"};
//                           0         1          2      3

groceryList[2] = "Ham";
// null, null, Ham, null
Console.WriteLine(groceryList[2]);

// Size of an Array
Console.WriteLine(groceryList.Length);

// Lists are variable length
List<int> numberList = new List<int>();
numberList.Add(3);
numberList.Add(3);
numberList.Add(3);
numberList.Add(3);
numberList.Add(4);
// This removes the value of 3
// Remove at the location index 3
// numberList.RemoveAt(3);
// First parameter is the index, second is the value
numberList.Insert(1, 5);
numberList.Remove(3);
Console.WriteLine(numberList.Count);

Console.WriteLine(numberList);
foreach(int i in numberList)
{
    Console.WriteLine(i);
}

// String vs Char
// String contains multiple letters
string words = "Hello";

// Char only contains 1 letter
// And specifically uses single quotations
char singleChar = 'd';


// Functions
static void SayHello()
{
    Console.WriteLine("Hello");
}

SayHello();

//                 parameters
static int DoMath(int x, int y)
{
    return x - y;
}
//    arguments
Console.WriteLine(DoMath(10, 20));
int answer = DoMath(40,20);
Console.WriteLine(answer);