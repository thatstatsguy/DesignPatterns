// See https://aka.ms/new-console-template for more information

using Prototype;

Console.WriteLine("Hello, World!");

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();


var employee = new Employee("Kevin", managerClone);
var employeeClone = (Employee)employee.Clone();
//with a deep copy you won't have this shared object across instances
var employeeClone2 = (Employee)employee.Clone(true);

Console.WriteLine($"Employee: {employee.Name}, with Manager {employee.Manager.Name}");

Console.WriteLine($"Employee clone: {employeeClone.Name}, with Manager {employeeClone.Manager.Name}");


//limitation of memberwise close - doesn't make a copy of the manager
managerClone.Name = "Karen";
Console.WriteLine($"Employee clone: {employeeClone.Name}, with Manager {employeeClone.Manager.Name}");


//deep copy of memberwise close - doesn't make a copy of the manager
Console.WriteLine($"Deep copy Employee clone: {employeeClone2.Name}, with Manager {employeeClone2.Manager.Name}");





