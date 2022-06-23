// See https://aka.ms/new-console-template for more information

using DemoLibrary;
/*Agora em vez de existir uma lista de PersonModel, existe uma lista de IApplicantModel, onde é possível inserir
 qualquer tipo de model que implemente a interface IApplicantModel*/
List<IApplicantModel> people = new()
{
    new PersonModel{ FirstName = "Wilson", LastName = "Nunes"},
    new ManagerModel{ FirstName = "Luis", LastName = "Silva"},
    new ExecutiveModel{ FirstName = "Natan", LastName = "Aparecido"}
};

List<EmployeeModel> employees = new();
foreach (var person in people)
{
    employees.Add(person.AccountProcessor.Create(person));
}
foreach (var employee in employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} " +
        $"IsManager: {employee.IsManager} IsExecutive: {employee.IsExecutive}");
}

Console.ReadLine();

