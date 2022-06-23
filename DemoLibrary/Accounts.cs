﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Accounts : IAccounts
    {
        /*com as mudanças realizadas, não é mais necessário alterar esta classe para cada novo tipo de empregado
         * que for criado no sistema.
         * A classe Accounts é um ótimo exemplo de OCP, pois ela está aberta para extensão e fechada para modificação
         */
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
