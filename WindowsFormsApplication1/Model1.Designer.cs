﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 11/10/2012 4:43:03 PM
namespace WindowsFormsApplication1
{
    
    /// <summary>
    /// There are no comments for sanEntities in the schema.
    /// </summary>
    public partial class sanEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new sanEntities object using the connection string found in the 'sanEntities' section of the application configuration file.
        /// </summary>
        public sanEntities() : 
                base("name=sanEntities", "sanEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new sanEntities object.
        /// </summary>
        public sanEntities(string connectionString) : 
                base(connectionString, "sanEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new sanEntities object.
        /// </summary>
        public sanEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "sanEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for master in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<master> master
        {
            get
            {
                if ((this._master == null))
                {
                    this._master = base.CreateQuery<master>("[master]");
                }
                return this._master;
            }
        }
        private global::System.Data.Objects.ObjectQuery<master> _master;
        /// <summary>
        /// There are no comments for master in the schema.
        /// </summary>
        public void AddTomaster(master master)
        {
            base.AddObject("master", master);
        }
    }
    /// <summary>
    /// There are no comments for sanModel.master in the schema.
    /// </summary>
    /// <KeyProperties>
    /// idmaster
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="sanModel", Name="master")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class master : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new master object.
        /// </summary>
        /// <param name="idmaster">Initial value of idmaster.</param>
        public static master Createmaster(int idmaster)
        {
            master master = new master();
            master.idmaster = idmaster;
            return master;
        }
        /// <summary>
        /// There are no comments for Property idmaster in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int idmaster
        {
            get
            {
                return this._idmaster;
            }
            set
            {
                this.OnidmasterChanging(value);
                this.ReportPropertyChanging("idmaster");
                this._idmaster = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("idmaster");
                this.OnidmasterChanged();
            }
        }
        private int _idmaster;
        partial void OnidmasterChanging(int value);
        partial void OnidmasterChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this.ReportPropertyChanging("name");
                this._name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("name");
                this.OnnameChanged();
            }
        }
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
    }
}