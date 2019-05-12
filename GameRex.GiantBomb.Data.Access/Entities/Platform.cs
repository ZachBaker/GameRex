using System;
using System.ComponentModel.DataAnnotations;

namespace GameRex.GiantBomb.Data.Access.Entities
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        //Since data comes from different sources, we need a way to map an ID
        //back to that source
        public string ExternalId { get; set; }

        public string Abbreviation { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        public string SiteDetailIUrl { get; set; }

        public int InstallBase { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Company Company { get; set; }
    }
}