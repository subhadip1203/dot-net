// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

int x = 10;
Console.WriteLine(x);


float y = 10f;
Console.WriteLine(y);


double z = 20;
Console.WriteLine(z);

bool isTrue = false;
Console.WriteLine(isTrue);


float y1 = 2.01f;
int x1 = Convert.ToInt16(y1);
Console.WriteLine(y1);
Console.WriteLine(x1);


if (x1 < 2)
{
    Console.WriteLine("less than 2");
}
else
{
    Console.WriteLine("more or equal to 2");
}

string firstName = "subhadip ";
string lastName = "Pahari";
string name = firstName + lastName;
Console.WriteLine(name);
Console.WriteLine("string length : "+name.Length);


// Arrays have a fixed size that is set when they are created
string[] cars = new string[4];
cars[0] = "Toyota";
cars[1] = "Honda";
Console.WriteLine(cars);
Console.WriteLine(cars.Length);
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}


// Create an array of four elements and add values right away 
string[] fruits = new string[4] {  "mango" , "banana", "apple", "whatever" };
Console.WriteLine(fruits.Length);
foreach (string i in fruits)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----  After Sorting  ------");

Array.Sort(fruits);
foreach (string i in fruits)
{
    Console.WriteLine(i);
}


//  List
// lists can grow or shrink dynamically as items are added or removed
//
Console.WriteLine("------- Lists -------");

List<int> numberList = new List<int>();
numberList.Add(32);
numberList.Add(21);
foreach (int i in numberList)
{
    Console.WriteLine(i);
}

string[] animals = { "Cow", "Camel", "Elephant" };
List<string> animalsList = new List<string>();
animalsList.AddRange(animals);
foreach (string a in animalsList)
    Console.WriteLine(a);

animalsList.RemoveAt(1);
foreach (string a in animalsList)
    Console.WriteLine(a);
Console.WriteLine("index 0 : " + animalsList[0]);
Console.WriteLine("index 1 : " + animalsList[1]);
