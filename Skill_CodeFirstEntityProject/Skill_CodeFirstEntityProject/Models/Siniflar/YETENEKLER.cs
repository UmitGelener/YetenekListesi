using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntityProject.Models.Siniflar
{
    public class YETENEKLER
    {
        [Key]
        public int ID { get; set; }
        public string YetenekAciklama { get; set; }
        public byte YetenekYüzdeDeger { get; set; }
    }
}