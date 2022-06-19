﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EldenRing.Model.Models
{
    public class Armors
    {
        public int Id { get; set; }
        public string IdArmors { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Weight { get; set; }
        [Column(TypeName = "jsonb")]
        public dmgNegation[] DmgNegation { get; set; }
        [Column(TypeName = "jsonb")]
        public Resistance[] Resistance { get; set; }
    }
}
