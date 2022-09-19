using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Producto___Categoría
{
    internal class categoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int cantidad { get; set; }

        public List<producto> ProductosList = new List<producto>();


    }
}
