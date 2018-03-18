using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameRex.Data.Access.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string GB_GUID { get; set; }

        public string Name { get; set; }

        public string SiteDetailUrl { get; set; }

        public string Website { get; set; }

        public ICollection<Platform> Platforms { get; set; }
    }
}
