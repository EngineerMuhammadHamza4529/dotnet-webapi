using System;
using System.Collections.Generic;

namespace project_web_api_crud_.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Age { get; set; }

    public string? Address { get; set; }
}
