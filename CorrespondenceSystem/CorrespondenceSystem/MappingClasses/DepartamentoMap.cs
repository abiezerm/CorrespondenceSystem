using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class DepartamentoMap : ClassMap<Departamento>
    {
        public DepartamentoMap()
        {
            Id(a => a.idDepartamento);
            Map(a => a.descripcion);
            References(a => a.tipoDepartamento).Column("idTipoDepartamento");
        }
    }
}