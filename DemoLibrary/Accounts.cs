using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Accounts
    {
        public EmployeeModel Create (PersonModel model)
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
