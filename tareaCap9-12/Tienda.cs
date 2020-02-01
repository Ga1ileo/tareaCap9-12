using System;
using System.Collections.Generic;
using System.Text;

namespace tareaCap9_12
{
    public class Tienda
    {
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }

        public Tienda()
        {

            this.Articulo = Articulo;
            this.Descripcion = Descripcion;
            this.PrecioVenta = PrecioVenta;
            this.Cantidad = Cantidad;
            this.PrecioCompra = PrecioCompra;

        }
    }
}
 

