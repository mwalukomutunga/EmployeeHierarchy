namespace EmployeeHierarchy
{
    public interface IEmployeeHierarchy
    {
        string EmployeeId { get; }
        bool IsCeo { get; }
        string ManagerId { get; }
        int Salary { get; }
    }
}