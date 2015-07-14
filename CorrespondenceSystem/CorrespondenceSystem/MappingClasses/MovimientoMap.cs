using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class MovimientoMap : ClassMap<Movimiento>
    {
        public MovimientoMap()
        {
            Id(a => a.idMovimiento);
            Map(a => a.fecha).Not.Nullable();
            Map(a => a.fechaCreacion).Not.Nullable();
            Map(a => a.fechaModificacion).Not.Nullable();
            References(a => a.documento).Column("idDocumento");
            References(a => a.mensjaero).Column("idMensajero");
            References(a => a.tipoMovimiento).Column("idTipoMovimiento");
            References(a => a.departamento).Column("idDepartamento");
            References(a => a.usuario, "usuarioCreacion").Column("idUsuario").Not.Nullable();
            References(a => a.usuario, "usuarioModificacion").Column("idUsuario");
        }
    }
}