using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }

        public bool EstaBorrado { get; set; }

    }
}
