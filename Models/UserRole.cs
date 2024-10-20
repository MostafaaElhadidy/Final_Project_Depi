﻿using System;
using System.Collections.Generic;

namespace ProgrammingTutor.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public string? UserId { get; set; }

    public int? RoleId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
