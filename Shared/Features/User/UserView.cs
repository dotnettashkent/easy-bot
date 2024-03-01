using MemoryPack;
using Stl.Fusion.Blazor;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Shared.Features
{
    [DataContract, MemoryPackable]
    [ParameterComparer(typeof(ByValueParameterComparer))]
    public partial class UserView
    {
        [property : DataMember]
        [property : JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = null!;

        [property: DataMember]
        [property: JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null!;

        [property: DataMember]
        [property: JsonPropertyName("last_name")]
        public string LastName { get; set; } = null!;

        [property: DataMember]
        [property: JsonPropertyName("sur_name")]
        public string SurName { get; set; } = null!;

        [property: DataMember]
        [property: JsonPropertyName("gender")]
        public string Gender { get; set; } = null!;

        /// <summary>
        /// dd/mm/yyyy
        /// </summary>
        [property: DataMember]
        [property: JsonPropertyName("date_of_birth")]
        public string DateOfBirth { get; set; } = null!;

        [property: DataMember]
        [property: JsonPropertyName("pay_card_number")]
        public string? PayCardNumber { get; set; }

        [property: DataMember]
        [property: JsonPropertyName("pay_card_type")]
        public string? PayCardType { get; set; }

        [property: DataMember]
        [property: JsonPropertyName("pay_phone_number")]
        public string? PayPhoneNumber { get; set; }
    }
}
