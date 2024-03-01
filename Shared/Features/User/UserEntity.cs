using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Features
{
    [Table("project_users")]
    public class UserEntity : BaseEntity
    {
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = null!;

        [Column("first_name")]
        public string FirstName { get; set; } = null!;

        [Column("last_name")]
        public string LastName { get; set; } = null!;

        [Column("sur_name")]
        public string SurName { get; set; } = null!;

        [Column("gender")]
        public string Gender { get; set; } = null!;

        /// <summary>
        /// dd/mm/yyyy
        /// </summary>
        [Column("date_of_birth")]
        public string DateOfBirth { get; set; } = null!;

        [Column("pay_card_number")]
        public string? PayCardNumber { get; set; }
        
        [Column("pay_card_type")]
        public string? PayCardType { get; set; }

        [Column("pay_phone_number")]
        public string? PayPhoneNumber { get; set; }

    }
}
