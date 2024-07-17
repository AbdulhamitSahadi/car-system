using CarSystem.API.Models.Domain;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.AdminPermissions.Base.IEntity;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.AdminPermissions.Base.Entity
{
    public class AdminPermissionTrackable<T> : IAdminPermissionTrackable<T> where T : class
    {
        public Admin Admin { get; set; }

        public T Entity { get; set; }
    }
}
