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
	/// Strongly-typed collection for the UserByArea class.
	/// </summary>
    [Serializable]
	public partial class UserByAreaCollection : ActiveList<UserByArea, UserByAreaCollection>
	{	   
		public UserByAreaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>UserByAreaCollection</returns>
		public UserByAreaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                UserByArea o = this[i];
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
	/// This is an ActiveRecord class which wraps the UserByArea table.
	/// </summary>
	[Serializable]
	public partial class UserByArea : ActiveRecord<UserByArea>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public UserByArea()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public UserByArea(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public UserByArea(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public UserByArea(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("UserByArea", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdUserByArea = new TableSchema.TableColumn(schema);
				colvarIdUserByArea.ColumnName = "IdUserByArea";
				colvarIdUserByArea.DataType = DbType.Int32;
				colvarIdUserByArea.MaxLength = 0;
				colvarIdUserByArea.AutoIncrement = true;
				colvarIdUserByArea.IsNullable = false;
				colvarIdUserByArea.IsPrimaryKey = true;
				colvarIdUserByArea.IsForeignKey = false;
				colvarIdUserByArea.IsReadOnly = false;
				colvarIdUserByArea.DefaultSetting = @"";
				colvarIdUserByArea.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUserByArea);
				
				TableSchema.TableColumn colvarIdUser = new TableSchema.TableColumn(schema);
				colvarIdUser.ColumnName = "IdUser";
				colvarIdUser.DataType = DbType.Int32;
				colvarIdUser.MaxLength = 0;
				colvarIdUser.AutoIncrement = false;
				colvarIdUser.IsNullable = false;
				colvarIdUser.IsPrimaryKey = false;
				colvarIdUser.IsForeignKey = true;
				colvarIdUser.IsReadOnly = false;
				colvarIdUser.DefaultSetting = @"";
				
					colvarIdUser.ForeignKeyTableName = "User";
				schema.Columns.Add(colvarIdUser);
				
				TableSchema.TableColumn colvarIdArea = new TableSchema.TableColumn(schema);
				colvarIdArea.ColumnName = "IdArea";
				colvarIdArea.DataType = DbType.Int32;
				colvarIdArea.MaxLength = 0;
				colvarIdArea.AutoIncrement = false;
				colvarIdArea.IsNullable = false;
				colvarIdArea.IsPrimaryKey = false;
				colvarIdArea.IsForeignKey = true;
				colvarIdArea.IsReadOnly = false;
				colvarIdArea.DefaultSetting = @"";
				
					colvarIdArea.ForeignKeyTableName = "Area";
				schema.Columns.Add(colvarIdArea);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ISOAProvider"].AddSchema("UserByArea",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdUserByArea")]
		[Bindable(true)]
		public int IdUserByArea 
		{
			get { return GetColumnValue<int>(Columns.IdUserByArea); }
			set { SetColumnValue(Columns.IdUserByArea, value); }
		}
		  
		[XmlAttribute("IdUser")]
		[Bindable(true)]
		public int IdUser 
		{
			get { return GetColumnValue<int>(Columns.IdUser); }
			set { SetColumnValue(Columns.IdUser, value); }
		}
		  
		[XmlAttribute("IdArea")]
		[Bindable(true)]
		public int IdArea 
		{
			get { return GetColumnValue<int>(Columns.IdArea); }
			set { SetColumnValue(Columns.IdArea, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Area ActiveRecord object related to this UserByArea
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.Area Area
		{
			get { return Cotraser.Isoa.Domain.Area.FetchByID(this.IdArea); }
			set { SetColumnValue("IdArea", value.IdArea); }
		}
		
		
		/// <summary>
		/// Returns a User ActiveRecord object related to this UserByArea
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.User User
		{
			get { return Cotraser.Isoa.Domain.User.FetchByID(this.IdUser); }
			set { SetColumnValue("IdUser", value.IdUser); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdUser,int varIdArea)
		{
			UserByArea item = new UserByArea();
			
			item.IdUser = varIdUser;
			
			item.IdArea = varIdArea;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdUserByArea,int varIdUser,int varIdArea)
		{
			UserByArea item = new UserByArea();
			
				item.IdUserByArea = varIdUserByArea;
			
				item.IdUser = varIdUser;
			
				item.IdArea = varIdArea;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdUserByAreaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUserColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAreaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdUserByArea = @"IdUserByArea";
			 public static string IdUser = @"IdUser";
			 public static string IdArea = @"IdArea";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
