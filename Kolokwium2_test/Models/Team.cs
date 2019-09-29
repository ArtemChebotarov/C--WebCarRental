using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2_test.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }

        public String Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
