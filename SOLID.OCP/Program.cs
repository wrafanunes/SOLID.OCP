// See https://aka.ms/new-console-template for more information

using DemoLibrary;

List<PersonModel> people = new()
{
    new PersonModel{ FirstName = "Wilson", LastName = "Nunes"},
    new PersonModel{ FirstName = "Luis", LastName = "Silva"},
    new PersonModel{ FirstName = "Natan", LastName = "Aparecido"}
};

List<EmployeeModel> employees = new();
Accounts accountsProcessor = new();
foreach (var person in people)
{
    employees.Add(accountsProcessor.Create(person));
}
foreach (var employee in employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} " +
        $"IsManager: {employee.IsManager}");
}

Console.ReadLine();

