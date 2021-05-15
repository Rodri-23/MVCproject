using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCproject.Data.Models
{
    public class Heladeria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CategoryType Category { get; set; }
    }
}
