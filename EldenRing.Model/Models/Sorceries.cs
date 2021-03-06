using System.ComponentModel.DataAnnotations.Schema;

namespace EldenRing.Model.Models
{
    public class Sorceries
    {
        public int Id { get; set; }
        public string IdSorceries { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public int Slots { get; set; }
        public string Effects { get; set; }
        [Column(TypeName = "jsonb")]
        public RequiredAttributes[] RequiredAttributes { get; set; }
    }
}
