// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Functions , Class , objects , methods .... ");


int addNum(int a , int b)
{
    return a + b;
}

Console.WriteLine(addNum(10, 20));



// functions can be called above and defination can be written anywhere in the file
printSomething("ok ok ok");

void printSomething(string x)
{
    Console.WriteLine(x);
}

