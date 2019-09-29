using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2_test.Models
{
    public class Player
    {
        [Key]
        public int IdPlayer { get; set; }

        [Required, MaxLength(150)]
        [Display(Name = "Imie")]
        public String FirstName { get; set; }

        [Required, MaxLength(150)]
        [Display(Name = "Nazwisko")]
        public String LastName { get; set; }

        [Display(Name = "Data Urodzenia")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Zespol")]
        public int IdTeam { get; set; }

        [ForeignKey("IdTeam")]
        public Team Team { get; set; }
    }
}
