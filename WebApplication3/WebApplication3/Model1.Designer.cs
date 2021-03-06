﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("BD_EntityFrameworkModel", "FK_Producto_Cliente", "Cliente", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WebApplication3.Cliente), "Producto", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebApplication3.Producto), true)]
[assembly: EdmRelationshipAttribute("BD_EntityFrameworkModel", "FK_Direccion_Empleado", "Empleado", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WebApplication3.Empleado), "Direccion", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WebApplication3.Direccion), true)]

#endregion

namespace WebApplication3
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class BD_EntityFrameworkEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto BD_EntityFrameworkEntities usando la cadena de conexión encontrada en la sección 'BD_EntityFrameworkEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public BD_EntityFrameworkEntities() : base("name=BD_EntityFrameworkEntities", "BD_EntityFrameworkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto BD_EntityFrameworkEntities.
        /// </summary>
        public BD_EntityFrameworkEntities(string connectionString) : base(connectionString, "BD_EntityFrameworkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto BD_EntityFrameworkEntities.
        /// </summary>
        public BD_EntityFrameworkEntities(EntityConnection connection) : base(connection, "BD_EntityFrameworkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Cliente> Cliente
        {
            get
            {
                if ((_Cliente == null))
                {
                    _Cliente = base.CreateObjectSet<Cliente>("Cliente");
                }
                return _Cliente;
            }
        }
        private ObjectSet<Cliente> _Cliente;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Direccion> Direccion
        {
            get
            {
                if ((_Direccion == null))
                {
                    _Direccion = base.CreateObjectSet<Direccion>("Direccion");
                }
                return _Direccion;
            }
        }
        private ObjectSet<Direccion> _Direccion;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Empleado> Empleado
        {
            get
            {
                if ((_Empleado == null))
                {
                    _Empleado = base.CreateObjectSet<Empleado>("Empleado");
                }
                return _Empleado;
            }
        }
        private ObjectSet<Empleado> _Empleado;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Producto> Producto
        {
            get
            {
                if ((_Producto == null))
                {
                    _Producto = base.CreateObjectSet<Producto>("Producto");
                }
                return _Producto;
            }
        }
        private ObjectSet<Producto> _Producto;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Cliente. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToCliente(Cliente cliente)
        {
            base.AddObject("Cliente", cliente);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Direccion. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToDireccion(Direccion direccion)
        {
            base.AddObject("Direccion", direccion);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Empleado. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToEmpleado(Empleado empleado)
        {
            base.AddObject("Empleado", empleado);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Producto. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToProducto(Producto producto)
        {
            base.AddObject("Producto", producto);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BD_EntityFrameworkModel", Name="Cliente")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cliente : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Cliente.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad ID.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        public static Cliente CreateCliente(global::System.Int32 id, global::System.String nombre)
        {
            Cliente cliente = new Cliente();
            cliente.ID = id;
            cliente.nombre = nombre;
            return cliente;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BD_EntityFrameworkModel", "FK_Producto_Cliente", "Producto")]
        public EntityCollection<Producto> Producto
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Producto>("BD_EntityFrameworkModel.FK_Producto_Cliente", "Producto");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Producto>("BD_EntityFrameworkModel.FK_Producto_Cliente", "Producto", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BD_EntityFrameworkModel", Name="Direccion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Direccion : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Direccion.
        /// </summary>
        /// <param name="iDEmpleado">Valor inicial de la propiedad IDEmpleado.</param>
        public static Direccion CreateDireccion(global::System.Int32 iDEmpleado)
        {
            Direccion direccion = new Direccion();
            direccion.IDEmpleado = iDEmpleado;
            return direccion;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }
            set
            {
                if (_IDEmpleado != value)
                {
                    OnIDEmpleadoChanging(value);
                    ReportPropertyChanging("IDEmpleado");
                    _IDEmpleado = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IDEmpleado");
                    OnIDEmpleadoChanged();
                }
            }
        }
        private global::System.Int32 _IDEmpleado;
        partial void OnIDEmpleadoChanging(global::System.Int32 value);
        partial void OnIDEmpleadoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Calle
        {
            get
            {
                return _Calle;
            }
            set
            {
                OnCalleChanging(value);
                ReportPropertyChanging("Calle");
                _Calle = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Calle");
                OnCalleChanged();
            }
        }
        private global::System.String _Calle;
        partial void OnCalleChanging(global::System.String value);
        partial void OnCalleChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Nro
        {
            get
            {
                return _Nro;
            }
            set
            {
                OnNroChanging(value);
                ReportPropertyChanging("Nro");
                _Nro = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Nro");
                OnNroChanged();
            }
        }
        private Nullable<global::System.Int32> _Nro;
        partial void OnNroChanging(Nullable<global::System.Int32> value);
        partial void OnNroChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BD_EntityFrameworkModel", "FK_Direccion_Empleado", "Empleado")]
        public Empleado Empleado
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Empleado>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Empleado").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Empleado>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Empleado").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Empleado> EmpleadoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Empleado>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Empleado");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Empleado>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Empleado", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BD_EntityFrameworkModel", Name="Empleado")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Empleado : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Empleado.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad ID.</param>
        public static Empleado CreateEmpleado(global::System.Int32 id)
        {
            Empleado empleado = new Empleado();
            empleado.ID = id;
            return empleado;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BD_EntityFrameworkModel", "FK_Direccion_Empleado", "Direccion")]
        public Direccion Direccion
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Direccion>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Direccion").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Direccion>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Direccion").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Direccion> DireccionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Direccion>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Direccion");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Direccion>("BD_EntityFrameworkModel.FK_Direccion_Empleado", "Direccion", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BD_EntityFrameworkModel", Name="Producto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Producto : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Producto.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad ID.</param>
        public static Producto CreateProducto(global::System.Int32 id)
        {
            Producto producto = new Producto();
            producto.ID = id;
            return producto;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IDCliente
        {
            get
            {
                return _IDCliente;
            }
            set
            {
                OnIDClienteChanging(value);
                ReportPropertyChanging("IDCliente");
                _IDCliente = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IDCliente");
                OnIDClienteChanged();
            }
        }
        private Nullable<global::System.Int32> _IDCliente;
        partial void OnIDClienteChanging(Nullable<global::System.Int32> value);
        partial void OnIDClienteChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BD_EntityFrameworkModel", "FK_Producto_Cliente", "Cliente")]
        public Cliente Cliente
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cliente>("BD_EntityFrameworkModel.FK_Producto_Cliente", "Cliente").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cliente>("BD_EntityFrameworkModel.FK_Producto_Cliente", "Cliente").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Cliente> ClienteReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cliente>("BD_EntityFrameworkModel.FK_Producto_Cliente", "Cliente");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Cliente>("BD_EntityFrameworkModel.FK_Producto_Cliente", "Cliente", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
