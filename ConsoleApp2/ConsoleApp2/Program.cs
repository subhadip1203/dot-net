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



Employee emp1 = new Employee(110, "subhadip" , "pahari");
emp1.Salary = 200;
Console.WriteLine(emp1.EmployeeID);
Console.WriteLine(emp1.Salary);

class Employee
{

    private int? salary;

    public int EmployeeID { get; private set;  }

    public string? FirstName { get;  set; }

    public string? LastName { get; set; }

    public int? Salary { 
        get {
            return this.salary;
        } 
        set { 
            if (value  < 100 ) 
            {
                this.salary = value;
            }
            else
            {
                this.salary = 100;
            }
        } 
    }

    public Employee(int id)
    {
        this.EmployeeID = id;
    }

    public Employee(int id , string firstName , string lastName)
    {
        this.EmployeeID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}


