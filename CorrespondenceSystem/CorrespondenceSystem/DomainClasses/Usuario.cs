﻿using System;
using System.Collections.Generic;

namespace CorrespondenceSystem.DomainClasses
{
    public class Usuario
    {
        public virtual int idUsuario { get; set; }
        public virtual string nombre { get; set; }
        public virtual string correo { get; set; }
        public virtual TipoUsuario tipoUsuario { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }
        public virtual DateTime fechaRegistro { get; set; }
        public virtual DateTime fechaModificacion { get; set; }
        public virtual int usuarioCreacion { get; set; }
        public virtual int usuarioModificacion { get; set; }
        
        public Usuario()
        {
            tipoUsuario = new TipoUsuario();
        }
    }
}