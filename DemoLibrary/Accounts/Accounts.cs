using DemoLibrary.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Accounts
{
    public class Accounts : IAccounts
    {
        /*com as mudanças realizadas, não é mais necessário alterar esta classe para cada novo tipo de empregado
         * que for criado no sistema.
         * A classe Accounts é um ótimo exemplo de OCP, pois ela está aberta para extensão e fechada para modificação
         * Essa classe também passou a respeitar o SRP, já que antes ela era responsável por definir cada tipo de
         * empregado, agora ela tem um único propósito, que é mapear as propriedades genéricas de IApplicationModel
         * para EmployeModel, os tipos ficaram sob responsabilidade de outras classes, como ManagerAccount e 
         * ExecutiveAccount*/
        public EmployeeModel Create (IApplicantModel model)
        {
            EmployeeModel employee = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = $"{model.FirstName[..1]}{model.LastName}@krustykrab.com".ToLower()
            };
            return employee;
        }
    }
}
