using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class TipoMovimientoMap : ClassMap<TipoMovimiento>
    {
        public TipoMovimientoMap()
        {
            Id(a => a.idTipoMovimiento);
            Map(a => a.descripcion);
            
        }
    }
}