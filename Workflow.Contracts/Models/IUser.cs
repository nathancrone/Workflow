namespace Workflow.Contracts.Models
{
    public interface IUser
    {
        int? UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
