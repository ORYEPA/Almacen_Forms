using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Almacen
{
    public class P_articulos
    {
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
        public string MARCA { get; set; }
        public int ID_UNIDAD { get; set; }
        public int ID_CATEGORIA { get; set; }
        public decimal STOCK { get; set; }
        public string FECHA_REGISTRO { get; set; }
        public string FECHA_MODIFICACION { get; set; }
    }
}
