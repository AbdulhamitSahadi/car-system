using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.AdminPermissions.Base.IEntity
{
    public interface IAdminPermissionTrackable<T> where T : class
    {
        Admin Admin { get; set; }
        T Entity { get; set; }
    }
}
