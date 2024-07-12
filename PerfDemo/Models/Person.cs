﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PerfDemo.Models;

public partial class Person
{
    public int Id { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public DateTime? HireDate { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    public string Discriminator { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual OfficeAssignment OfficeAssignment { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}