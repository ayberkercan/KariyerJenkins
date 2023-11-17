using System.ComponentModel.DataAnnotations;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Authorization.User.Create
{
    public class CreatedUserDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Ad Alanı Gereklidir!")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "Soyad Alanı Gereklidir!")]
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = "Sicil Numarası Gereklidir!")]
        public string Registry { get; set; } = null!;
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir!")]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "Şifre Alanı Gereklidir!")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "Email Alanı Gereklidir!")]
        public string Email { get; set; } = null!;
        public Guid RoleId { get; set; }
        public ICollection<object> Companies { get; set; }
        public ICollection<object> Menues { get; set; }
    }
}
