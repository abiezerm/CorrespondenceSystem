using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class DocumentoMap : ClassMap<Documento>
    {
        public DocumentoMap()
        {
            Id(a => a.idDocumento);
            Map(a => a.codigo).Not.Nullable();
            Map(a => a.fechaCreacion).Not.Nullable();
            Map(a => a.fechaRegistroUsuario).Not.Nullable();
            Map(a => a.asunto).Not.Nullable();
            References(a => a.departamento).Column("idDepartamento").Not.Nullable();
            References(a => a.usuario, "usuarioCreacion").Column("idUsuario").Not.Nullable();
            References(a => a.usuario, "usuarioModificacion").Column("idUsuario");

        }
    }
}