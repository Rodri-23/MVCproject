using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCproject.Data.Models;

namespace MVCproject.Data.Services
{
    public interface IHeladeriaData
    {
        IEnumerable<Heladeria> GetAll();
    }
}
