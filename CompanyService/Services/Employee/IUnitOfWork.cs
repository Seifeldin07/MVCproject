namespace CompanyService.Services.Employee
{
    internal interface IUnitOfWork
    {
        object EmployeeRepository { get; }
    }
}