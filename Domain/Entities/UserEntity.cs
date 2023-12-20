﻿using EF.Support.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class UserEntity : IdentityUser<Guid>, IEntity
{
    public bool IsDeleted { get; set; }
    public string DisplayName { get; set; }
    public string Decriptions { get; set; }
    public string Image { get; set; }
    public string Address { get; set; }
}

