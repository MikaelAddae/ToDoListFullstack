using System;
using System.Collections.Generic;

namespace ToDoListFullstack.Models;

public partial class ToDo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? HoursNeeded { get; set; }

    public bool? IsCompleted { get; set; }

    public int? AssignedTo { get; set; }

    public virtual Employee? AssignedToNavigation { get; set; }
}
