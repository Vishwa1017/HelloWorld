// See https://aka.ms/new-console-template for more information
using HelloWorld;

Console.WriteLine("Hello, World!");

var name = "Vishwa Raman";

Console.WriteLine("Creative learner " + name);

string na;
Console.WriteLine("Enter your name");
na = Console.ReadLine();
Console.WriteLine("Entered Name" + na);
Console.WriteLine("Enter Name {0}", na);
Console.WriteLine($"Entered Name {na} cool");



DateTime td = DateTime.Now;

Console.WriteLine($"Time {td}");

Person p = new Person();
p.Name = Console.ReadLine();
p.FirstName = Console.ReadLine();
p.Age = Convert.ToInt32(Console.ReadLine());
p.setSalary();

Console.WriteLine(p.Name);
Console.WriteLine(p.FirstName);
Console.WriteLine(p.Age);
Console.WriteLine("Salary is "+ p.getSalary());
Console.WriteLine("Full Name" + p.getFullName());