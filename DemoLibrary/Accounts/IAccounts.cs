using DemoLibrary.Applicants;

namespace DemoLibrary.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create (IApplicantModel model);
    }
}