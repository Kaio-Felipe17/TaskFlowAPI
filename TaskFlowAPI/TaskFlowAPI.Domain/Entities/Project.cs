using TaskFlowAPI.Domain.Common;

namespace TaskFlowAPI.Domain.Entities;

public class Project : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
}
