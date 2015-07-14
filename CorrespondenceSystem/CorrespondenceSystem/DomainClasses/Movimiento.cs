using System;

namespace CorrespondenceSystem.DomainClasses
{
    public class Movimiento
    {
        public virtual int idMovimiento { get; set; }
        public virtual Documento documento { get; set; }
        public virtual Mensajero mensjaero { get; set; }
        public virtual TipoMovimiento tipoMovimiento { get; set; }
        public virtual Departamento departamento { get; set; }
        public virtual DateTime fecha { get; set; }
        public virtual DateTime fechaCreacion { get; set; }
        public virtual DateTime fechaModificacion { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}