using System.ComponentModel.DataAnnotations;

namespace IacvMembers.Entities
{
    public class BloodType
    {
        [Key]
        public short BloodTypeId { get; set; }

        [MaxLength(3)]
        public string Description { get; set; }
    }
}