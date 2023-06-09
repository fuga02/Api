﻿using System.Data;
using Api.Enums;

namespace Api.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Role> Roles { get; set; }
}