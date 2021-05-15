using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCproject.Data.Models;

namespace MVCproject.Data.Services
{
    public class InMemoryHeladeriaData : IHeladeriaData
    {
        readonly List<Heladeria> _heladerias;
        public InMemoryHeladeriaData()
        {
            _heladerias = new List<Heladeria>()
            {
                new Heladeria{Id=1, Nombre ="Limon", Category = CategoryType.Ligth},
                new Heladeria{Id=2, Nombre ="Chocolate", Category = CategoryType.handcrafted},
            };

        }
        public IEnumerable<Heladeria> GetAll()
        {
            return _heladerias.OrderBy(r => r.Nombre);
        }
    }
}
