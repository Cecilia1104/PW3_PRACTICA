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

[assembly: EdmRelationshipAttribute("PruebaModel1", "FK__Jugador__idselec__0CBAE877", "Seleccion", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(entity1610.Seleccion), "Jugador", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(entity1610.Jugador), true)]
[assembly: EdmRelationshipAttribute("PruebaModel1", "FK__Tecnico__idselec__0F975522", "Seleccion", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(entity1610.Seleccion), "Tecnico", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(entity1610.Tecnico), true)]

#endregion

namespace entity1610
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class PruebaEntities1 : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto PruebaEntities1 usando la cadena de conexión encontrada en la sección 'PruebaEntities1' del archivo de configuración de la aplicación.
        /// </summary>
        public PruebaEntities1() : base("name=PruebaEntities1", "PruebaEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto PruebaEntities1.
        /// </summary>
        public PruebaEntities1(string connectionString) : base(connectionString, "PruebaEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto PruebaEntities1.
        /// </summary>
        public PruebaEntities1(EntityConnection connection) : base(connection, "PruebaEntities1")
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
        public ObjectSet<Jugador> Jugador
        {
            get
            {
                if ((_Jugador == null))
                {
                    _Jugador = base.CreateObjectSet<Jugador>("Jugador");
                }
                return _Jugador;
            }
        }
        private ObjectSet<Jugador> _Jugador;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Seleccion> Seleccion
        {
            get
            {
                if ((_Seleccion == null))
                {
                    _Seleccion = base.CreateObjectSet<Seleccion>("Seleccion");
                }
                return _Seleccion;
            }
        }
        private ObjectSet<Seleccion> _Seleccion;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Tecnico> Tecnico
        {
            get
            {
                if ((_Tecnico == null))
                {
                    _Tecnico = base.CreateObjectSet<Tecnico>("Tecnico");
                }
                return _Tecnico;
            }
        }
        private ObjectSet<Tecnico> _Tecnico;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Jugador. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToJugador(Jugador jugador)
        {
            base.AddObject("Jugador", jugador);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Seleccion. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToSeleccion(Seleccion seleccion)
        {
            base.AddObject("Seleccion", seleccion);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Tecnico. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToTecnico(Tecnico tecnico)
        {
            base.AddObject("Tecnico", tecnico);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PruebaModel1", Name="Jugador")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Jugador : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Jugador.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="idseleccion">Valor inicial de la propiedad idseleccion.</param>
        public static Jugador CreateJugador(global::System.Int32 id, global::System.Int32 idseleccion)
        {
            Jugador jugador = new Jugador();
            jugador.id = id;
            jugador.idseleccion = idseleccion;
            return jugador;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                OnapellidoChanging(value);
                ReportPropertyChanging("apellido");
                _apellido = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("apellido");
                OnapellidoChanged();
            }
        }
        private global::System.String _apellido;
        partial void OnapellidoChanging(global::System.String value);
        partial void OnapellidoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idseleccion
        {
            get
            {
                return _idseleccion;
            }
            set
            {
                OnidseleccionChanging(value);
                ReportPropertyChanging("idseleccion");
                _idseleccion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("idseleccion");
                OnidseleccionChanged();
            }
        }
        private global::System.Int32 _idseleccion;
        partial void OnidseleccionChanging(global::System.Int32 value);
        partial void OnidseleccionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> edad
        {
            get
            {
                return _edad;
            }
            set
            {
                OnedadChanging(value);
                ReportPropertyChanging("edad");
                _edad = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("edad");
                OnedadChanged();
            }
        }
        private Nullable<global::System.Int32> _edad;
        partial void OnedadChanging(Nullable<global::System.Int32> value);
        partial void OnedadChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PruebaModel1", "FK__Jugador__idselec__0CBAE877", "Seleccion")]
        public Seleccion Seleccion
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Seleccion>("PruebaModel1.FK__Jugador__idselec__0CBAE877", "Seleccion").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Seleccion>("PruebaModel1.FK__Jugador__idselec__0CBAE877", "Seleccion").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Seleccion> SeleccionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Seleccion>("PruebaModel1.FK__Jugador__idselec__0CBAE877", "Seleccion");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Seleccion>("PruebaModel1.FK__Jugador__idselec__0CBAE877", "Seleccion", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PruebaModel1", Name="Seleccion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Seleccion : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Seleccion.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        public static Seleccion CreateSeleccion(global::System.Int32 id)
        {
            Seleccion seleccion = new Seleccion();
            seleccion.id = id;
            return seleccion;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _nombre = StructuralObject.SetValidValue(value, true);
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
        [EdmRelationshipNavigationPropertyAttribute("PruebaModel1", "FK__Jugador__idselec__0CBAE877", "Jugador")]
        public EntityCollection<Jugador> Jugador
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Jugador>("PruebaModel1.FK__Jugador__idselec__0CBAE877", "Jugador");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Jugador>("PruebaModel1.FK__Jugador__idselec__0CBAE877", "Jugador", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PruebaModel1", "FK__Tecnico__idselec__0F975522", "Tecnico")]
        public EntityCollection<Tecnico> Tecnico
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Tecnico>("PruebaModel1.FK__Tecnico__idselec__0F975522", "Tecnico");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Tecnico>("PruebaModel1.FK__Tecnico__idselec__0F975522", "Tecnico", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PruebaModel1", Name="Tecnico")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tecnico : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Tecnico.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        /// <param name="idseleccion">Valor inicial de la propiedad idseleccion.</param>
        public static Tecnico CreateTecnico(global::System.Int32 id, global::System.String nombre, global::System.Int32 idseleccion)
        {
            Tecnico tecnico = new Tecnico();
            tecnico.id = id;
            tecnico.nombre = nombre;
            tecnico.idseleccion = idseleccion;
            return tecnico;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
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
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                OnapellidoChanging(value);
                ReportPropertyChanging("apellido");
                _apellido = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("apellido");
                OnapellidoChanged();
            }
        }
        private global::System.String _apellido;
        partial void OnapellidoChanging(global::System.String value);
        partial void OnapellidoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idseleccion
        {
            get
            {
                return _idseleccion;
            }
            set
            {
                OnidseleccionChanging(value);
                ReportPropertyChanging("idseleccion");
                _idseleccion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("idseleccion");
                OnidseleccionChanged();
            }
        }
        private global::System.Int32 _idseleccion;
        partial void OnidseleccionChanging(global::System.Int32 value);
        partial void OnidseleccionChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PruebaModel1", "FK__Tecnico__idselec__0F975522", "Seleccion")]
        public Seleccion Seleccion
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Seleccion>("PruebaModel1.FK__Tecnico__idselec__0F975522", "Seleccion").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Seleccion>("PruebaModel1.FK__Tecnico__idselec__0F975522", "Seleccion").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Seleccion> SeleccionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Seleccion>("PruebaModel1.FK__Tecnico__idselec__0F975522", "Seleccion");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Seleccion>("PruebaModel1.FK__Tecnico__idselec__0F975522", "Seleccion", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}