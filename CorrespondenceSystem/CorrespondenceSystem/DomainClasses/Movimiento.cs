using System;

namespace CorrespondenceSystem.DomainClasses
{
    public class Movimiento
    {
        public virtual int idMovimiento { get; set; }
        public virtual Documento documento { get; set; }
        public virtual Mensajero mensajero { get; set; }
        public virtual TipoMovimiento tipoMovimiento { get; set; }
        public virtual Departamento departamento { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual DateTime fecha { get; set; }
        public virtual DateTime fechaCreacion { get; set; }
        public virtual DateTime fechaModificacion { get; set; }
        public virtual int usuarioCreacion { get; set; }
        public virtual int usuarioModificacion { get; set; }

        public Movimiento()
        {
            usuario = new Usuario();
            documento = new Documento();
            mensajero = new Mensajero();
            tipoMovimiento = new TipoMovimiento();
            departamento = new Departamento();
        }
    }
}