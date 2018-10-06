﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DESA : DbContext
    {
        public DESA()
            : base("name=DESA")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<string> SP_validateUser(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_validateUser", usernameParameter, passwordParameter);
        }
    
        public virtual int SP_Delete_Producto(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Producto", idProductoParameter);
        }
    
        public virtual int SP_update_Descripcion_Producto(string descripcion, Nullable<int> idProducto)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_update_Descripcion_Producto", descripcionParameter, idProductoParameter);
        }
    
        public virtual int SP_Insert_Producto(string descripcion, Nullable<int> categoriaCode, Nullable<int> typeCode)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var categoriaCodeParameter = categoriaCode.HasValue ?
                new ObjectParameter("CategoriaCode", categoriaCode) :
                new ObjectParameter("CategoriaCode", typeof(int));
    
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("TypeCode", typeCode) :
                new ObjectParameter("TypeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_Producto", descripcionParameter, categoriaCodeParameter, typeCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_All_Productos_Result> SP_Get_All_Productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Productos_Result>("SP_Get_All_Productos");
        }
    
        public virtual ObjectResult<SP_Get_Producto_byID_Result> SP_Get_Producto_byID(Nullable<int> iDPRODUCTO)
        {
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Producto_byID_Result>("SP_Get_Producto_byID", iDPRODUCTOParameter);
        }
    
        public virtual ObjectResult<SP_get_all_userTypes_Result> SP_get_all_userTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_get_all_userTypes_Result>("SP_get_all_userTypes");
        }
    
        public virtual ObjectResult<SP_Get_All_Clientes_Result> SP_Get_All_Clientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Clientes_Result>("SP_Get_All_Clientes");
        }
    
        public virtual ObjectResult<SP_Get_All_Proveedores_Result> SP_Get_All_Proveedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Proveedores_Result>("SP_Get_All_Proveedores");
        }
    
        public virtual ObjectResult<SP_Get_All_CategoriasProducts_Result> SP_Get_All_CategoriasProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_CategoriasProducts_Result>("SP_Get_All_CategoriasProducts");
        }
    
        public virtual ObjectResult<SP_Get_Cliente_ByID_Result> SP_Get_Cliente_ByID(Nullable<int> clientCode)
        {
            var clientCodeParameter = clientCode.HasValue ?
                new ObjectParameter("ClientCode", clientCode) :
                new ObjectParameter("ClientCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Cliente_ByID_Result>("SP_Get_Cliente_ByID", clientCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_Proveedor_ByID_Result> SP_Get_Proveedor_ByID(Nullable<int> proveedorCode)
        {
            var proveedorCodeParameter = proveedorCode.HasValue ?
                new ObjectParameter("ProveedorCode", proveedorCode) :
                new ObjectParameter("ProveedorCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Proveedor_ByID_Result>("SP_Get_Proveedor_ByID", proveedorCodeParameter);
        }
    }
}
