using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class TipoDepartamentoMap : ClassMap<DOMAIN_CLASS>
    {
        public TipoDepartamentoMap()
        {
            Id(a => a.Id_attribute);
            Map(a => a.Value_to_Map);
            
        }
    }
}