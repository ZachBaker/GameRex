using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameRex.Data.Access.Entities
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        public string GB_GUID { get; set; }

        public string Abbreviation { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }
    }
}
