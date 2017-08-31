using System.ComponentModel.DataAnnotations;

namespace IacvMembers.Entities
{
    public class MartialStatus
    {
        [Key]
        public short MartialStatusId { get; set; }

        [MaxLength(15)]
        public string Description { get; set; }
    }
}