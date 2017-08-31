using System.ComponentModel.DataAnnotations;

namespace IacvMembers.Entities
{
    public class EcclesiasticalFunction
    {
        [Key]
        public short EcclesiasticalFunctionId { get; set; }

        [MaxLength(20)]
        public string Description { get; set; }
    }
}