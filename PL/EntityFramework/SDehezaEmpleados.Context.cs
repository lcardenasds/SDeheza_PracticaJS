﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmpleadosEntities1 : DbContext
    {
        public EmpleadosEntities1()
            : base("name=EmpleadosEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
    
        public virtual int EmpleadoAdd(string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<int> idEstado, string telefono, Nullable<int> idRol)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, idEstadoParameter, telefonoParameter, idRolParameter);
        }
    
        public virtual int EmpleadoDelete(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoDelete", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetAll_Result1> EmpleadoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetAll_Result1>("EmpleadoGetAll");
        }
    
        public virtual int EmpleadoUpdate(Nullable<int> idEmpleado, string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<int> idEstado, string telefono, Nullable<int> idRol)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoUpdate", idEmpleadoParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, idEstadoParameter, telefonoParameter, idRolParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetById_Result> EmpleadoGetById(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetById_Result>("EmpleadoGetById", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<RolGetAll_Result> RolGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetAll_Result>("RolGetAll");
        }
    
        public virtual ObjectResult<EstadoGetAll_Result> EstadoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EstadoGetAll_Result>("EstadoGetAll");
        }
    }
}