using DemoLibrary.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Accounts
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create (IApplicantModel model)
        {
            EmployeeModel employee = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = $"{model.FirstName[..1]}{model.LastName}@krustykrabcorp.com".ToLower(),
                IsManager = true
            };
            return employee;
        }
    }
}
