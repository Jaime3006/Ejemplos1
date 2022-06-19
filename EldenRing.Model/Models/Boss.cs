using System.ComponentModel.DataAnnotations.Schema;

namespace EldenRing.Model.Models
{
    public class Boss
    {
        public int Id { get; set; }
        public string IdBoss { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        [Column(TypeName = "jsonb")]
        public Items[] Drops { get; set; }
        public string HealthPoints { get; set; }
    }
}
