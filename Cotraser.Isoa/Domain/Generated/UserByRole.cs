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
	/// Strongly-typed collection for the UserByRole class.
	/// </summary>
    [Serializable]
	public partial class UserByRoleCollection : ActiveList<UserByRole, UserByRoleCollection>
	{	   
		public UserByRoleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>UserByRoleCollection</returns>
		public UserByRoleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                UserByRole o = this[i];
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
	/// This is an ActiveRecord class which wraps the UserByRole table.
	/// </summary>
	[Serializable]
	public partial class UserByRole : ActiveRecord<UserByRole>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public UserByRole()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public UserByRole(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public UserByRole(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public UserByRole(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("UserByRole", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdUserByRole = new TableSchema.TableColumn(schema);
				colvarIdUserByRole.ColumnName = "IdUserByRole";
				colvarIdUserByRole.DataType = DbType.Int32;
				colvarIdUserByRole.MaxLength = 0;
				colvarIdUserByRole.AutoIncrement = true;
				colvarIdUserByRole.IsNullable = false;
				colvarIdUserByRole.IsPrimaryKey = true;
				colvarIdUserByRole.IsForeignKey = false;
				colvarIdUserByRole.IsReadOnly = false;
				colvarIdUserByRole.DefaultSetting = @"";
				colvarIdUserByRole.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUserByRole);
				
				TableSchema.TableColumn colvarIdUser = new TableSchema.TableColumn(schema);
				colvarIdUser.ColumnName = "IdUser";
				colvarIdUser.DataType = DbType.Int32;
				colvarIdUser.MaxLength = 0;
				colvarIdUser.AutoIncrement = false;
				colvarIdUser.IsNullable = true;
				colvarIdUser.IsPrimaryKey = false;
				colvarIdUser.IsForeignKey = true;
				colvarIdUser.IsReadOnly = false;
				colvarIdUser.DefaultSetting = @"";
				
					colvarIdUser.ForeignKeyTableName = "User";
				schema.Columns.Add(colvarIdUser);
				
				TableSchema.TableColumn colvarIdAplicationRole = new TableSchema.TableColumn(schema);
				colvarIdAplicationRole.ColumnName = "IdAplicationRole";
				colvarIdAplicationRole.DataType = DbType.Int32;
				colvarIdAplicationRole.MaxLength = 0;
				colvarIdAplicationRole.AutoIncrement = false;
				colvarIdAplicationRole.IsNullable = false;
				colvarIdAplicationRole.IsPrimaryKey = false;
				colvarIdAplicationRole.IsForeignKey = true;
				colvarIdAplicationRole.IsReadOnly = false;
				colvarIdAplicationRole.DefaultSetting = @"";
				
					colvarIdAplicationRole.ForeignKeyTableName = "AplicationRole";
				schema.Columns.Add(colvarIdAplicationRole);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ISOAProvider"].AddSchema("UserByRole",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdUserByRole")]
		[Bindable(true)]
		public int IdUserByRole 
		{
			get { return GetColumnValue<int>(Columns.IdUserByRole); }
			set { SetColumnValue(Columns.IdUserByRole, value); }
		}
		  
		[XmlAttribute("IdUser")]
		[Bindable(true)]
		public int? IdUser 
		{
			get { return GetColumnValue<int?>(Columns.IdUser); }
			set { SetColumnValue(Columns.IdUser, value); }
		}
		  
		[XmlAttribute("IdAplicationRole")]
		[Bindable(true)]
		public int IdAplicationRole 
		{
			get { return GetColumnValue<int>(Columns.IdAplicationRole); }
			set { SetColumnValue(Columns.IdAplicationRole, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a AplicationRole ActiveRecord object related to this UserByRole
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.AplicationRole AplicationRole
		{
			get { return Cotraser.Isoa.Domain.AplicationRole.FetchByID(this.IdAplicationRole); }
			set { SetColumnValue("IdAplicationRole", value.IdAplicationRole); }
		}
		
		
		/// <summary>
		/// Returns a User ActiveRecord object related to this UserByRole
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
		public static void Insert(int? varIdUser,int varIdAplicationRole)
		{
			UserByRole item = new UserByRole();
			
			item.IdUser = varIdUser;
			
			item.IdAplicationRole = varIdAplicationRole;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdUserByRole,int? varIdUser,int varIdAplicationRole)
		{
			UserByRole item = new UserByRole();
			
				item.IdUserByRole = varIdUserByRole;
			
				item.IdUser = varIdUser;
			
				item.IdAplicationRole = varIdAplicationRole;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdUserByRoleColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUserColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAplicationRoleColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdUserByRole = @"IdUserByRole";
			 public static string IdUser = @"IdUser";
			 public static string IdAplicationRole = @"IdAplicationRole";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
