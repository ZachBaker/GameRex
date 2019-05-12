using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameRex.GiantBomb.Data.Access.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public string ExternalId { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        ICollection<Company> Developers { get; set; }

        ICollection<Platform> Platforms { get; set; }
    }
}