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
    
        public virtual ObjectResult<SP_get_all_userTypes_Result> SP_get_all_userTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_get_all_userTypes_Result>("SP_get_all_userTypes");
        }
    
        public virtual ObjectResult<SP_Get_All_Clientes_Result> SP_Get_All_Clientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Clientes_Result>("SP_Get_All_Clientes");
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
    
        public virtual ObjectResult<SP_Get_All_Usuarios_Result> SP_Get_All_Usuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Usuarios_Result>("SP_Get_All_Usuarios");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Insert_Representative(string nombre, string apellido, string sexo, Nullable<System.DateTime> fechaNac)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacParameter = fechaNac.HasValue ?
                new ObjectParameter("FechaNac", fechaNac) :
                new ObjectParameter("FechaNac", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Insert_Representative", nombreParameter, apellidoParameter, sexoParameter, fechaNacParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Insert_Direccion(string prov, string localidad, string calle, Nullable<int> calleAltura)
        {
            var provParameter = prov != null ?
                new ObjectParameter("Prov", prov) :
                new ObjectParameter("Prov", typeof(string));
    
            var localidadParameter = localidad != null ?
                new ObjectParameter("Localidad", localidad) :
                new ObjectParameter("Localidad", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var calleAlturaParameter = calleAltura.HasValue ?
                new ObjectParameter("CalleAltura", calleAltura) :
                new ObjectParameter("CalleAltura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Insert_Direccion", provParameter, localidadParameter, calleParameter, calleAlturaParameter);
        }
    
        public virtual int SP_Insert_Direccion_Usuario(Nullable<int> userCode, Nullable<int> direccionCode)
        {
            var userCodeParameter = userCode.HasValue ?
                new ObjectParameter("UserCode", userCode) :
                new ObjectParameter("UserCode", typeof(int));
    
            var direccionCodeParameter = direccionCode.HasValue ?
                new ObjectParameter("DireccionCode", direccionCode) :
                new ObjectParameter("DireccionCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_Direccion_Usuario", userCodeParameter, direccionCodeParameter);
        }
    
        public virtual int SP_Insert_User(Nullable<int> repCode, Nullable<int> userTypeCode)
        {
            var repCodeParameter = repCode.HasValue ?
                new ObjectParameter("repCode", repCode) :
                new ObjectParameter("repCode", typeof(int));
    
            var userTypeCodeParameter = userTypeCode.HasValue ?
                new ObjectParameter("userTypeCode", userTypeCode) :
                new ObjectParameter("userTypeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_User", repCodeParameter, userTypeCodeParameter);
        }
    
        public virtual int SP_Delete_Direccion_Usuario(Nullable<int> userCode, Nullable<int> direccionCode)
        {
            var userCodeParameter = userCode.HasValue ?
                new ObjectParameter("UserCode", userCode) :
                new ObjectParameter("UserCode", typeof(int));
    
            var direccionCodeParameter = direccionCode.HasValue ?
                new ObjectParameter("DireccionCode", direccionCode) :
                new ObjectParameter("DireccionCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Direccion_Usuario", userCodeParameter, direccionCodeParameter);
        }
    
        public virtual int SP_Delete_Representative(Nullable<int> userCode)
        {
            var userCodeParameter = userCode.HasValue ?
                new ObjectParameter("userCode", userCode) :
                new ObjectParameter("userCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Representative", userCodeParameter);
        }
    
        public virtual int SP_Delete_User(Nullable<int> repCode)
        {
            var repCodeParameter = repCode.HasValue ?
                new ObjectParameter("repCode", repCode) :
                new ObjectParameter("repCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_User", repCodeParameter);
        }
    
        public virtual int SP_Update_Representative(Nullable<int> userCode, string nombre, string apellido, string sexo, Nullable<System.DateTime> fechaNac)
        {
            var userCodeParameter = userCode.HasValue ?
                new ObjectParameter("userCode", userCode) :
                new ObjectParameter("userCode", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacParameter = fechaNac.HasValue ?
                new ObjectParameter("FechaNac", fechaNac) :
                new ObjectParameter("FechaNac", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_Representative", userCodeParameter, nombreParameter, apellidoParameter, sexoParameter, fechaNacParameter);
        }
    
        public virtual int SP_Update_User(Nullable<int> repCode, Nullable<int> userTypeCode)
        {
            var repCodeParameter = repCode.HasValue ?
                new ObjectParameter("repCode", repCode) :
                new ObjectParameter("repCode", typeof(int));
    
            var userTypeCodeParameter = userTypeCode.HasValue ?
                new ObjectParameter("userTypeCode", userTypeCode) :
                new ObjectParameter("userTypeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_User", repCodeParameter, userTypeCodeParameter);
        }
    
        public virtual int SP_Delete_Direccion(Nullable<int> code)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Direccion", codeParameter);
        }
    
        public virtual int SP_Update_Direccion(Nullable<int> code, string prov, string localidad, string calle, Nullable<int> calleAltura)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(int));
    
            var provParameter = prov != null ?
                new ObjectParameter("Prov", prov) :
                new ObjectParameter("Prov", typeof(string));
    
            var localidadParameter = localidad != null ?
                new ObjectParameter("Localidad", localidad) :
                new ObjectParameter("Localidad", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var calleAlturaParameter = calleAltura.HasValue ?
                new ObjectParameter("CalleAltura", calleAltura) :
                new ObjectParameter("CalleAltura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_Direccion", codeParameter, provParameter, localidadParameter, calleParameter, calleAlturaParameter);
        }
    
        public virtual ObjectResult<SP_Get_Usuario_byID_Result> SP_Get_Usuario_byID(Nullable<int> userCode)
        {
            var userCodeParameter = userCode.HasValue ?
                new ObjectParameter("UserCode", userCode) :
                new ObjectParameter("UserCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Usuario_byID_Result>("SP_Get_Usuario_byID", userCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_All_Provincias_Result> SP_Get_All_Provincias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Provincias_Result>("SP_Get_All_Provincias");
        }
    
        public virtual int SP_Update_Direccion_Usuario(Nullable<int> userCode, Nullable<int> direccionCode)
        {
            var userCodeParameter = userCode.HasValue ?
                new ObjectParameter("UserCode", userCode) :
                new ObjectParameter("UserCode", typeof(int));
    
            var direccionCodeParameter = direccionCode.HasValue ?
                new ObjectParameter("DireccionCode", direccionCode) :
                new ObjectParameter("DireccionCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_Direccion_Usuario", userCodeParameter, direccionCodeParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<SP_Get_Calle_Result> SP_Get_Calle(Nullable<int> provCode)
        {
            var provCodeParameter = provCode.HasValue ?
                new ObjectParameter("ProvCode", provCode) :
                new ObjectParameter("ProvCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Calle_Result>("SP_Get_Calle", provCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_Localidad_Result> SP_Get_Localidad(Nullable<int> provCode)
        {
            var provCodeParameter = provCode.HasValue ?
                new ObjectParameter("ProvCode", provCode) :
                new ObjectParameter("ProvCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Localidad_Result>("SP_Get_Localidad", provCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_All_ProveedorTypes_Result> SP_Get_All_ProveedorTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_ProveedorTypes_Result>("SP_Get_All_ProveedorTypes");
        }
    
        public virtual int SP_Update_ProveedorType(Nullable<int> typeCode, string descripcion)
        {
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("typeCode", typeCode) :
                new ObjectParameter("typeCode", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_ProveedorType", typeCodeParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<SP_Get_ProveedorType_ByID_Result> SP_Get_ProveedorType_ByID(Nullable<int> typeCode)
        {
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("typeCode", typeCode) :
                new ObjectParameter("typeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_ProveedorType_ByID_Result>("SP_Get_ProveedorType_ByID", typeCodeParameter);
        }
    
        public virtual int SP_Delete_ProveedorType(Nullable<int> typeCode)
        {
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("typeCode", typeCode) :
                new ObjectParameter("typeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_ProveedorType", typeCodeParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Insert_ProveedorType(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Insert_ProveedorType", descripcionParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Insert_Proveedor(string nombre, string apellido, string sexo, Nullable<System.DateTime> fechaNac, string cuit)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacParameter = fechaNac.HasValue ?
                new ObjectParameter("FechaNac", fechaNac) :
                new ObjectParameter("FechaNac", typeof(System.DateTime));
    
            var cuitParameter = cuit != null ?
                new ObjectParameter("Cuit", cuit) :
                new ObjectParameter("Cuit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Insert_Proveedor", nombreParameter, apellidoParameter, sexoParameter, fechaNacParameter, cuitParameter);
        }
    
        public virtual int SP_Insert_TipoProveedor(Nullable<int> prvCode, Nullable<int> prvTypeCode)
        {
            var prvCodeParameter = prvCode.HasValue ?
                new ObjectParameter("prvCode", prvCode) :
                new ObjectParameter("prvCode", typeof(int));
    
            var prvTypeCodeParameter = prvTypeCode.HasValue ?
                new ObjectParameter("prvTypeCode", prvTypeCode) :
                new ObjectParameter("prvTypeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_TipoProveedor", prvCodeParameter, prvTypeCodeParameter);
        }
    
        public virtual int SP_Update_Proveedor(Nullable<int> proveedorCode, string nombre, string apellido, string sexo, Nullable<System.DateTime> fechaNac, string cuit)
        {
            var proveedorCodeParameter = proveedorCode.HasValue ?
                new ObjectParameter("proveedorCode", proveedorCode) :
                new ObjectParameter("proveedorCode", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacParameter = fechaNac.HasValue ?
                new ObjectParameter("FechaNac", fechaNac) :
                new ObjectParameter("FechaNac", typeof(System.DateTime));
    
            var cuitParameter = cuit != null ?
                new ObjectParameter("Cuit", cuit) :
                new ObjectParameter("Cuit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_Proveedor", proveedorCodeParameter, nombreParameter, apellidoParameter, sexoParameter, fechaNacParameter, cuitParameter);
        }
    
        public virtual int SP_Delete_Proveedor(Nullable<int> proveedorCode)
        {
            var proveedorCodeParameter = proveedorCode.HasValue ?
                new ObjectParameter("ProveedorCode", proveedorCode) :
                new ObjectParameter("ProveedorCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Proveedor", proveedorCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_Proveedor_ByID_Result> SP_Get_Proveedor_ByID(Nullable<int> proveedorCode)
        {
            var proveedorCodeParameter = proveedorCode.HasValue ?
                new ObjectParameter("ProveedorCode", proveedorCode) :
                new ObjectParameter("ProveedorCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Proveedor_ByID_Result>("SP_Get_Proveedor_ByID", proveedorCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_All_Proveedores_Result> SP_Get_All_Proveedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_Proveedores_Result>("SP_Get_All_Proveedores");
        }
    
        public virtual int SP_Update_TipoProveedor(Nullable<int> prvCode, Nullable<int> prvTypeCode)
        {
            var prvCodeParameter = prvCode.HasValue ?
                new ObjectParameter("prvCode", prvCode) :
                new ObjectParameter("prvCode", typeof(int));
    
            var prvTypeCodeParameter = prvTypeCode.HasValue ?
                new ObjectParameter("prvTypeCode", prvTypeCode) :
                new ObjectParameter("prvTypeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_TipoProveedor", prvCodeParameter, prvTypeCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_Catalogo_ByProveedor_Result> SP_Get_Catalogo_ByProveedor(Nullable<int> proveedorCode)
        {
            var proveedorCodeParameter = proveedorCode.HasValue ?
                new ObjectParameter("ProveedorCode", proveedorCode) :
                new ObjectParameter("ProveedorCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Catalogo_ByProveedor_Result>("SP_Get_Catalogo_ByProveedor", proveedorCodeParameter);
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
    
        public virtual int SP_Delete_ProductType(Nullable<int> typeCode)
        {
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("typeCode", typeCode) :
                new ObjectParameter("typeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_ProductType", typeCodeParameter);
        }
    
        public virtual ObjectResult<SP_Get_All_ProductsTypes_Result> SP_Get_All_ProductsTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_All_ProductsTypes_Result>("SP_Get_All_ProductsTypes");
        }
    
        public virtual ObjectResult<SP_Get_ProductType_Result> SP_Get_ProductType(Nullable<int> typeCode)
        {
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("typeCode", typeCode) :
                new ObjectParameter("typeCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_ProductType_Result>("SP_Get_ProductType", typeCodeParameter);
        }
    
        public virtual int SP_Insert_ProductType(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_ProductType", descripcionParameter);
        }
    
        public virtual int SP_Update_ProductType(Nullable<int> typeCode, string descripcion)
        {
            var typeCodeParameter = typeCode.HasValue ?
                new ObjectParameter("typeCode", typeCode) :
                new ObjectParameter("typeCode", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_ProductType", typeCodeParameter, descripcionParameter);
        }
    }
}
