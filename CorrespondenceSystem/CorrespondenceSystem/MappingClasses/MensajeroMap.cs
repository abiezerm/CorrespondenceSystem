using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class MensajeroMap : ClassMap<Mensajero>
    {
        public MensajeroMap()
        {
            Id(a => a.idMensajero);
            Map(a => a.descripcion);
        }
    }
}