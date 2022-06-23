// See https://aka.ms/new-console-template for more information

using DemoLibrary;
/*Muitas mudanças foram feitas em um sistema que já estava funcionando, as classes Program, Accounts, EmployeeModel
 * e PersonModel foram modificadas, isso viola o OCP e coloca a aplicação em risco de apresentar bugs*/
List<PersonModel> people = new()
{
    new PersonModel{ FirstName = "Wilson", LastName = "Nunes"},
    new PersonModel{ FirstName = "Luis", LastName = "Silva", TypeOfEmployee = EmployeeType.Manager},
    new PersonModel{ FirstName = "Natan", LastName = "Aparecido", TypeOfEmployee = EmployeeType.Executive}
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
        $"IsManager: {employee.IsManager} IsExecutive: {employee.IsExecutive}");
}

Console.ReadLine();

