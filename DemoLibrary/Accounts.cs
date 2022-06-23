using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Accounts
    {
        //ao modificar esse método, há uma violação do OCP
        public EmployeeModel Create (PersonModel model)
        {
            EmployeeModel employee = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = $"{model.FirstName[..1]}{model.LastName}@krustykrab.com".ToLower()
            };
            //if (model.TypeOfEmployee == EmployeeType.Manager)
            //    employee.IsManager = true;
            switch (model.TypeOfEmployee)
            {
            case EmployeeType.Manager:
                employee.IsManager = true;
                break;
            case EmployeeType.Executive:
                employee.IsExecutive = true;
                employee.IsManager = true;
                break;
            }
            return employee;
        }
    }
}
