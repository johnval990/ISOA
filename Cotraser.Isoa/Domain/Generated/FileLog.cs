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
	/// Strongly-typed collection for the FileLog class.
	/// </summary>
    [Serializable]
	public partial class FileLogCollection : ActiveList<FileLog, FileLogCollection>
	{	   
		public FileLogCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileLogCollection</returns>
		public FileLogCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FileLog o = this[i];
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
	/// This is an ActiveRecord class which wraps the FileLog table.
	/// </summary>
	[Serializable]
	public partial class FileLog : ActiveRecord<FileLog>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FileLog()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FileLog(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FileLog(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FileLog(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FileLog", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdFileLog = new TableSchema.TableColumn(schema);
				colvarIdFileLog.ColumnName = "IdFileLog";
				colvarIdFileLog.DataType = DbType.Int32;
				colvarIdFileLog.MaxLength = 0;
				colvarIdFileLog.AutoIncrement = true;
				colvarIdFileLog.IsNullable = false;
				colvarIdFileLog.IsPrimaryKey = true;
				colvarIdFileLog.IsForeignKey = false;
				colvarIdFileLog.IsReadOnly = false;
				colvarIdFileLog.DefaultSetting = @"";
				colvarIdFileLog.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdFileLog);
				
				TableSchema.TableColumn colvarIdFileLogType = new TableSchema.TableColumn(schema);
				colvarIdFileLogType.ColumnName = "IdFileLogType";
				colvarIdFileLogType.DataType = DbType.Int32;
				colvarIdFileLogType.MaxLength = 0;
				colvarIdFileLogType.AutoIncrement = false;
				colvarIdFileLogType.IsNullable = false;
				colvarIdFileLogType.IsPrimaryKey = false;
				colvarIdFileLogType.IsForeignKey = true;
				colvarIdFileLogType.IsReadOnly = false;
				colvarIdFileLogType.DefaultSetting = @"";
				
					colvarIdFileLogType.ForeignKeyTableName = "FileLogType";
				schema.Columns.Add(colvarIdFileLogType);
				
				TableSchema.TableColumn colvarIdFile = new TableSchema.TableColumn(schema);
				colvarIdFile.ColumnName = "IdFile";
				colvarIdFile.DataType = DbType.Int32;
				colvarIdFile.MaxLength = 0;
				colvarIdFile.AutoIncrement = false;
				colvarIdFile.IsNullable = false;
				colvarIdFile.IsPrimaryKey = false;
				colvarIdFile.IsForeignKey = true;
				colvarIdFile.IsReadOnly = false;
				colvarIdFile.DefaultSetting = @"";
				
					colvarIdFile.ForeignKeyTableName = "File";
				schema.Columns.Add(colvarIdFile);
				
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
				
				TableSchema.TableColumn colvarIp = new TableSchema.TableColumn(schema);
				colvarIp.ColumnName = "IP";
				colvarIp.DataType = DbType.String;
				colvarIp.MaxLength = 500;
				colvarIp.AutoIncrement = false;
				colvarIp.IsNullable = true;
				colvarIp.IsPrimaryKey = false;
				colvarIp.IsForeignKey = false;
				colvarIp.IsReadOnly = false;
				colvarIp.DefaultSetting = @"";
				colvarIp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIp);
				
				TableSchema.TableColumn colvarMchineName = new TableSchema.TableColumn(schema);
				colvarMchineName.ColumnName = "MchineName";
				colvarMchineName.DataType = DbType.String;
				colvarMchineName.MaxLength = 500;
				colvarMchineName.AutoIncrement = false;
				colvarMchineName.IsNullable = true;
				colvarMchineName.IsPrimaryKey = false;
				colvarMchineName.IsForeignKey = false;
				colvarMchineName.IsReadOnly = false;
				colvarMchineName.DefaultSetting = @"";
				colvarMchineName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMchineName);
				
				TableSchema.TableColumn colvarBorwser = new TableSchema.TableColumn(schema);
				colvarBorwser.ColumnName = "Borwser";
				colvarBorwser.DataType = DbType.String;
				colvarBorwser.MaxLength = 500;
				colvarBorwser.AutoIncrement = false;
				colvarBorwser.IsNullable = true;
				colvarBorwser.IsPrimaryKey = false;
				colvarBorwser.IsForeignKey = false;
				colvarBorwser.IsReadOnly = false;
				colvarBorwser.DefaultSetting = @"";
				colvarBorwser.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBorwser);
				
				TableSchema.TableColumn colvarDateX = new TableSchema.TableColumn(schema);
				colvarDateX.ColumnName = "Date";
				colvarDateX.DataType = DbType.DateTime;
				colvarDateX.MaxLength = 0;
				colvarDateX.AutoIncrement = false;
				colvarDateX.IsNullable = false;
				colvarDateX.IsPrimaryKey = false;
				colvarDateX.IsForeignKey = false;
				colvarDateX.IsReadOnly = false;
				colvarDateX.DefaultSetting = @"";
				colvarDateX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDateX);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ISOAProvider"].AddSchema("FileLog",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdFileLog")]
		[Bindable(true)]
		public int IdFileLog 
		{
			get { return GetColumnValue<int>(Columns.IdFileLog); }
			set { SetColumnValue(Columns.IdFileLog, value); }
		}
		  
		[XmlAttribute("IdFileLogType")]
		[Bindable(true)]
		public int IdFileLogType 
		{
			get { return GetColumnValue<int>(Columns.IdFileLogType); }
			set { SetColumnValue(Columns.IdFileLogType, value); }
		}
		  
		[XmlAttribute("IdFile")]
		[Bindable(true)]
		public int IdFile 
		{
			get { return GetColumnValue<int>(Columns.IdFile); }
			set { SetColumnValue(Columns.IdFile, value); }
		}
		  
		[XmlAttribute("IdUser")]
		[Bindable(true)]
		public int IdUser 
		{
			get { return GetColumnValue<int>(Columns.IdUser); }
			set { SetColumnValue(Columns.IdUser, value); }
		}
		  
		[XmlAttribute("Ip")]
		[Bindable(true)]
		public string Ip 
		{
			get { return GetColumnValue<string>(Columns.Ip); }
			set { SetColumnValue(Columns.Ip, value); }
		}
		  
		[XmlAttribute("MchineName")]
		[Bindable(true)]
		public string MchineName 
		{
			get { return GetColumnValue<string>(Columns.MchineName); }
			set { SetColumnValue(Columns.MchineName, value); }
		}
		  
		[XmlAttribute("Borwser")]
		[Bindable(true)]
		public string Borwser 
		{
			get { return GetColumnValue<string>(Columns.Borwser); }
			set { SetColumnValue(Columns.Borwser, value); }
		}
		  
		[XmlAttribute("DateX")]
		[Bindable(true)]
		public DateTime DateX 
		{
			get { return GetColumnValue<DateTime>(Columns.DateX); }
			set { SetColumnValue(Columns.DateX, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a File ActiveRecord object related to this FileLog
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.File File
		{
			get { return Cotraser.Isoa.Domain.File.FetchByID(this.IdFile); }
			set { SetColumnValue("IdFile", value.IdFile); }
		}
		
		
		/// <summary>
		/// Returns a FileLogType ActiveRecord object related to this FileLog
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.FileLogType FileLogType
		{
			get { return Cotraser.Isoa.Domain.FileLogType.FetchByID(this.IdFileLogType); }
			set { SetColumnValue("IdFileLogType", value.IdFileLogType); }
		}
		
		
		/// <summary>
		/// Returns a User ActiveRecord object related to this FileLog
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
		public static void Insert(int varIdFileLogType,int varIdFile,int varIdUser,string varIp,string varMchineName,string varBorwser,DateTime varDateX)
		{
			FileLog item = new FileLog();
			
			item.IdFileLogType = varIdFileLogType;
			
			item.IdFile = varIdFile;
			
			item.IdUser = varIdUser;
			
			item.Ip = varIp;
			
			item.MchineName = varMchineName;
			
			item.Borwser = varBorwser;
			
			item.DateX = varDateX;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdFileLog,int varIdFileLogType,int varIdFile,int varIdUser,string varIp,string varMchineName,string varBorwser,DateTime varDateX)
		{
			FileLog item = new FileLog();
			
				item.IdFileLog = varIdFileLog;
			
				item.IdFileLogType = varIdFileLogType;
			
				item.IdFile = varIdFile;
			
				item.IdUser = varIdUser;
			
				item.Ip = varIp;
			
				item.MchineName = varMchineName;
			
				item.Borwser = varBorwser;
			
				item.DateX = varDateX;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdFileLogColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdFileLogTypeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdFileColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUserColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IpColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MchineNameColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn BorwserColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn DateXColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdFileLog = @"IdFileLog";
			 public static string IdFileLogType = @"IdFileLogType";
			 public static string IdFile = @"IdFile";
			 public static string IdUser = @"IdUser";
			 public static string Ip = @"IP";
			 public static string MchineName = @"MchineName";
			 public static string Borwser = @"Borwser";
			 public static string DateX = @"Date";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
