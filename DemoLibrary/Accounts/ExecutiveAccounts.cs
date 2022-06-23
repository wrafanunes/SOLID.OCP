using DemoLibrary.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Accounts
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create (IApplicantModel model)
        {
            EmployeeModel employee = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = $"{model.FirstName}{model.LastName}@krustykrabcorp.com".ToLower(),
                IsManager = true,
                IsExecutive = true
            };
            return employee;
        }
    }
}
