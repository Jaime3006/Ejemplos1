using System.ComponentModel.DataAnnotations.Schema;

namespace EldenRing.Model.Models
{
    public class Shields
    {
        public int Id { get; set; }
        public string IdShields { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Weight { get; set; }
        [Column(TypeName = "jsonb")]
        public Attack[] Attack { get; set; }
        [Column(TypeName = "jsonb")]
        public Defence[] Defence { get; set; }
        [Column(TypeName = "jsonb")]
        public RequiredAttributes[] RequiredAttributes { get; set; }
        [Column(TypeName = "jsonb")]
        public ScalesWith[] ScalesWith { get; set; }



    }
}
