
using System.ComponentModel.DataAnnotations.Schema;
namespace EldenRing.Model.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string IdClasses { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "jsonb")]
        public Stats[] Stats { get; set; }
    }
}
