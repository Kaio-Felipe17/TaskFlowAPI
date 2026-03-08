using TaskFlowAPI.Application.Enums;
using TaskFlowAPI.Domain.Common;

namespace TaskFlowAPI.Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public TaskItemStatus Status { get; set; }
    public TaskItemPriority Priority { get; set; }
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }
}
