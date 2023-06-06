using System;
using System.Collections.Generic;

namespace ToDoListFullstack.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Hours { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ToDo> ToDos { get; set; } = new List<ToDo>();
}
