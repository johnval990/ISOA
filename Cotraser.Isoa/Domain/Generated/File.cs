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
	/// Strongly-typed collection for the File class.
	/// </summary>
    [Serializable]
	public partial class FileCollection : ActiveList<File, FileCollection>
	{	   
		public FileCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileCollection</returns>
		public FileCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                File o = this[i];
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
	/// This is an ActiveRecord class which wraps the File table.
	/// </summary>
	[Serializable]
	public partial class File : ActiveRecord<File>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public File()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public File(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public File(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public File(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("File", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdFile = new TableSchema.TableColumn(schema);
				colvarIdFile.ColumnName = "IdFile";
				colvarIdFile.DataType = DbType.Int32;
				colvarIdFile.MaxLength = 0;
				colvarIdFile.AutoIncrement = true;
				colvarIdFile.IsNullable = false;
				colvarIdFile.IsPrimaryKey = true;
				colvarIdFile.IsForeignKey = false;
				colvarIdFile.IsReadOnly = false;
				colvarIdFile.DefaultSetting = @"";
				colvarIdFile.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdFile);
				
				TableSchema.TableColumn colvarFileCode = new TableSchema.TableColumn(schema);
				colvarFileCode.ColumnName = "FileCode";
				colvarFileCode.DataType = DbType.String;
				colvarFileCode.MaxLength = 100;
				colvarFileCode.AutoIncrement = false;
				colvarFileCode.IsNullable = false;
				colvarFileCode.IsPrimaryKey = false;
				colvarFileCode.IsForeignKey = false;
				colvarFileCode.IsReadOnly = false;
				colvarFileCode.DefaultSetting = @"";
				colvarFileCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileCode);
				
				TableSchema.TableColumn colvarIdProcess = new TableSchema.TableColumn(schema);
				colvarIdProcess.ColumnName = "IdProcess";
				colvarIdProcess.DataType = DbType.Int32;
				colvarIdProcess.MaxLength = 0;
				colvarIdProcess.AutoIncrement = false;
				colvarIdProcess.IsNullable = false;
				colvarIdProcess.IsPrimaryKey = false;
				colvarIdProcess.IsForeignKey = true;
				colvarIdProcess.IsReadOnly = false;
				colvarIdProcess.DefaultSetting = @"";
				
					colvarIdProcess.ForeignKeyTableName = "Process";
				schema.Columns.Add(colvarIdProcess);
				
				TableSchema.TableColumn colvarFileName = new TableSchema.TableColumn(schema);
				colvarFileName.ColumnName = "FileName";
				colvarFileName.DataType = DbType.String;
				colvarFileName.MaxLength = 250;
				colvarFileName.AutoIncrement = false;
				colvarFileName.IsNullable = false;
				colvarFileName.IsPrimaryKey = false;
				colvarFileName.IsForeignKey = false;
				colvarFileName.IsReadOnly = false;
				colvarFileName.DefaultSetting = @"";
				colvarFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileName);
				
				TableSchema.TableColumn colvarDescription = new TableSchema.TableColumn(schema);
				colvarDescription.ColumnName = "Description";
				colvarDescription.DataType = DbType.String;
				colvarDescription.MaxLength = 500;
				colvarDescription.AutoIncrement = false;
				colvarDescription.IsNullable = true;
				colvarDescription.IsPrimaryKey = false;
				colvarDescription.IsForeignKey = false;
				colvarDescription.IsReadOnly = false;
				colvarDescription.DefaultSetting = @"";
				colvarDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescription);
				
				TableSchema.TableColumn colvarUrlSource = new TableSchema.TableColumn(schema);
				colvarUrlSource.ColumnName = "Url_Source";
				colvarUrlSource.DataType = DbType.String;
				colvarUrlSource.MaxLength = 500;
				colvarUrlSource.AutoIncrement = false;
				colvarUrlSource.IsNullable = false;
				colvarUrlSource.IsPrimaryKey = false;
				colvarUrlSource.IsForeignKey = false;
				colvarUrlSource.IsReadOnly = false;
				colvarUrlSource.DefaultSetting = @"";
				colvarUrlSource.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUrlSource);
				
				TableSchema.TableColumn colvarIsActive = new TableSchema.TableColumn(schema);
				colvarIsActive.ColumnName = "IsActive";
				colvarIsActive.DataType = DbType.Boolean;
				colvarIsActive.MaxLength = 0;
				colvarIsActive.AutoIncrement = false;
				colvarIsActive.IsNullable = false;
				colvarIsActive.IsPrimaryKey = false;
				colvarIsActive.IsForeignKey = false;
				colvarIsActive.IsReadOnly = false;
				colvarIsActive.DefaultSetting = @"";
				colvarIsActive.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsActive);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ISOAProvider"].AddSchema("File",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdFile")]
		[Bindable(true)]
		public int IdFile 
		{
			get { return GetColumnValue<int>(Columns.IdFile); }
			set { SetColumnValue(Columns.IdFile, value); }
		}
		  
		[XmlAttribute("FileCode")]
		[Bindable(true)]
		public string FileCode 
		{
			get { return GetColumnValue<string>(Columns.FileCode); }
			set { SetColumnValue(Columns.FileCode, value); }
		}
		  
		[XmlAttribute("IdProcess")]
		[Bindable(true)]
		public int IdProcess 
		{
			get { return GetColumnValue<int>(Columns.IdProcess); }
			set { SetColumnValue(Columns.IdProcess, value); }
		}
		  
		[XmlAttribute("FileName")]
		[Bindable(true)]
		public string FileName 
		{
			get { return GetColumnValue<string>(Columns.FileName); }
			set { SetColumnValue(Columns.FileName, value); }
		}
		  
		[XmlAttribute("Description")]
		[Bindable(true)]
		public string Description 
		{
			get { return GetColumnValue<string>(Columns.Description); }
			set { SetColumnValue(Columns.Description, value); }
		}
		  
		[XmlAttribute("UrlSource")]
		[Bindable(true)]
		public string UrlSource 
		{
			get { return GetColumnValue<string>(Columns.UrlSource); }
			set { SetColumnValue(Columns.UrlSource, value); }
		}
		  
		[XmlAttribute("IsActive")]
		[Bindable(true)]
		public bool IsActive 
		{
			get { return GetColumnValue<bool>(Columns.IsActive); }
			set { SetColumnValue(Columns.IsActive, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public Cotraser.Isoa.Domain.FileLogCollection FileLogRecords()
		{
			return new Cotraser.Isoa.Domain.FileLogCollection().Where(FileLog.Columns.IdFile, IdFile).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Process ActiveRecord object related to this File
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.Process Process
		{
			get { return Cotraser.Isoa.Domain.Process.FetchByID(this.IdProcess); }
			set { SetColumnValue("IdProcess", value.IdProcess); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFileCode,int varIdProcess,string varFileName,string varDescription,string varUrlSource,bool varIsActive)
		{
			File item = new File();
			
			item.FileCode = varFileCode;
			
			item.IdProcess = varIdProcess;
			
			item.FileName = varFileName;
			
			item.Description = varDescription;
			
			item.UrlSource = varUrlSource;
			
			item.IsActive = varIsActive;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdFile,string varFileCode,int varIdProcess,string varFileName,string varDescription,string varUrlSource,bool varIsActive)
		{
			File item = new File();
			
				item.IdFile = varIdFile;
			
				item.FileCode = varFileCode;
			
				item.IdProcess = varIdProcess;
			
				item.FileName = varFileName;
			
				item.Description = varDescription;
			
				item.UrlSource = varUrlSource;
			
				item.IsActive = varIsActive;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdFileColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FileCodeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProcessColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FileNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn UrlSourceColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IsActiveColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdFile = @"IdFile";
			 public static string FileCode = @"FileCode";
			 public static string IdProcess = @"IdProcess";
			 public static string FileName = @"FileName";
			 public static string Description = @"Description";
			 public static string UrlSource = @"Url_Source";
			 public static string IsActive = @"IsActive";
						
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
