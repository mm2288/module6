using System;
namespace Entities.Models
{
    public class User
    {
        public User()
        {
            [Column("UserId")]
            public Guid Id { get; set; }

            [Required(ErrorMessage = "User name is a required field.")]
            [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
            public string UserName { get; set; }

            [ForeignKey(nameof(Organization))]
            public Guid OrganizationId { get; set; }

            public Organization Organization { get; set; }
        }
    }
}
