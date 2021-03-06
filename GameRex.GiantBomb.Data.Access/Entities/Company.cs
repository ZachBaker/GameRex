﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameRex.GiantBomb.Data.Access.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string ExternalId { get; set; }

        public string Name { get; set; }

        public string SiteDetailUrl { get; set; }

        public string Website { get; set; }

        public ICollection<Platform> Platforms { get; set; }
    }
}