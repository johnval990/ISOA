using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace Cotraser.Isoa.Domain
{
	/// <summary>
	/// Strongly-typed collection for the AplicationRole class.
	/// </summary>
    [Serializable]
	public partial class AplicationRoleCollection : ActiveList<AplicationRole, AplicationRoleCollection>
	{	   
		public AplicationRoleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AplicationRoleCollection</returns>
		public AplicationRoleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AplicationRole o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the AplicationRole table.
	/// </summary>
	[Serializable]
	public partial class AplicationRole : ActiveRecord<AplicationRole>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AplicationRole()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AplicationRole(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AplicationRole(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AplicationRole(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("AplicationRole", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdAplicationRole = new TableSchema.TableColumn(schema);
				colvarIdAplicationRole.ColumnName = "IdAplicationRole";
				colvarIdAplicationRole.DataType = DbType.Int32;
				colvarIdAplicationRole.MaxLength = 0;
				colvarIdAplicationRole.AutoIncrement = true;
				colvarIdAplicationRole.IsNullable = false;
				colvarIdAplicationRole.IsPrimaryKey = true;
				colvarIdAplicationRole.IsForeignKey = false;
				colvarIdAplicationRole.IsReadOnly = false;
				colvarIdAplicationRole.DefaultSetting = @"";
				colvarIdAplicationRole.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAplicationRole);
				
				TableSchema.TableColumn colvarDescription = new TableSchema.TableColumn(schema);
				colvarDescription.ColumnName = "Description";
				colvarDescription.DataType = DbType.String;
				colvarDescription.MaxLength = 250;
				colvarDescription.AutoIncrement = false;
				colvarDescription.IsNullable = true;
				colvarDescription.IsPrimaryKey = false;
				colvarDescription.IsForeignKey = false;
				colvarDescription.IsReadOnly = false;
				colvarDescription.DefaultSetting = @"";
				colvarDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescription);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ISOAProvider"].AddSchema("AplicationRole",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdAplicationRole")]
		[Bindable(true)]
		public int IdAplicationRole 
		{
			get { return GetColumnValue<int>(Columns.IdAplicationRole); }
			set { SetColumnValue(Columns.IdAplicationRole, value); }
		}
		  
		[XmlAttribute("Description")]
		[Bindable(true)]
		public string Description 
		{
			get { return GetColumnValue<string>(Columns.Description); }
			set { SetColumnValue(Columns.Description, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public Cotraser.Isoa.Domain.UserByRoleCollection UserByRoleRecords()
		{
			return new Cotraser.Isoa.Domain.UserByRoleCollection().Where(UserByRole.Columns.IdAplicationRole, IdAplicationRole).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescription)
		{
			AplicationRole item = new AplicationRole();
			
			item.Description = varDescription;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdAplicationRole,string varDescription)
		{
			AplicationRole item = new AplicationRole();
			
				item.IdAplicationRole = varIdAplicationRole;
			
				item.Description = varDescription;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdAplicationRoleColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdAplicationRole = @"IdAplicationRole";
			 public static string Description = @"Description";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
