using TaskFlowAPI.Application.Enums;
using TaskFlowAPI.Domain.Common;

namespace TaskFlowAPI.Domain.Entities;

public class TaskItem : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required DateTime DueDate { get; set; }
    public required TaskItemStatus Status { get; set; }
    public required TaskItemPriority Priority { get; set; }
    public required Guid ProjectId { get; set; }
    public Project? Project { get; set; }
}
