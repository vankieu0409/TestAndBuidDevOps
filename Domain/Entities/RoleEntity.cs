using EF.Support.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class RoleEntity :  IdentityRole<Guid>, IEntity
{
}