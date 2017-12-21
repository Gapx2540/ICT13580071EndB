using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ICT13580071EndB.Models
{
    class Product
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string Typecar { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        [NotNull]
        [MaxLength(200)]
        public int Mile { get; set; }
        public string Color { get; set; }
        public string Delor { get; set; }
        public int Price { get; set; }
        public string Provice { get; set; }
        public int Phone { get; set; }
        public string description { get; set; }
        
    }
}