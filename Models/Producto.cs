using System;

namespace WebApiCRUD.Models {
    public class Producto {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAlta { get; set; }
        public Decimal Precio { get; set; }
        public bool Activo { get; set; }

    }
}