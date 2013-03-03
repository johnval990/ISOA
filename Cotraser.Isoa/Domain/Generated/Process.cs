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
	/// Strongly-typed collection for the Process class.
	/// </summary>
    [Serializable]
	public partial class ProcessCollection : ActiveList<Process, ProcessCollection>
	{	   
		public ProcessCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProcessCollection</returns>
		public ProcessCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Process o = this[i];
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
	/// This is an ActiveRecord class which wraps the Process table.
	/// </summary>
	[Serializable]
	public partial class Process : ActiveRecord<Process>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Process()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Process(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Process(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Process(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Process", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdProcess = new TableSchema.TableColumn(schema);
				colvarIdProcess.ColumnName = "IdProcess";
				colvarIdProcess.DataType = DbType.Int32;
				colvarIdProcess.MaxLength = 0;
				colvarIdProcess.AutoIncrement = true;
				colvarIdProcess.IsNullable = false;
				colvarIdProcess.IsPrimaryKey = true;
				colvarIdProcess.IsForeignKey = false;
				colvarIdProcess.IsReadOnly = false;
				colvarIdProcess.DefaultSetting = @"";
				colvarIdProcess.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProcess);
				
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
				
				TableSchema.TableColumn colvarDescription = new TableSchema.TableColumn(schema);
				colvarDescription.ColumnName = "Description";
				colvarDescription.DataType = DbType.String;
				colvarDescription.MaxLength = 100;
				colvarDescription.AutoIncrement = false;
				colvarDescription.IsNullable = false;
				colvarDescription.IsPrimaryKey = false;
				colvarDescription.IsForeignKey = false;
				colvarDescription.IsReadOnly = false;
				colvarDescription.DefaultSetting = @"";
				colvarDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescription);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ISOAProvider"].AddSchema("Process",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdProcess")]
		[Bindable(true)]
		public int IdProcess 
		{
			get { return GetColumnValue<int>(Columns.IdProcess); }
			set { SetColumnValue(Columns.IdProcess, value); }
		}
		  
		[XmlAttribute("IdArea")]
		[Bindable(true)]
		public int IdArea 
		{
			get { return GetColumnValue<int>(Columns.IdArea); }
			set { SetColumnValue(Columns.IdArea, value); }
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
        
		
		public Cotraser.Isoa.Domain.FileCollection FileRecords()
		{
			return new Cotraser.Isoa.Domain.FileCollection().Where(File.Columns.IdProcess, IdProcess).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Area ActiveRecord object related to this Process
		/// 
		/// </summary>
		public Cotraser.Isoa.Domain.Area Area
		{
			get { return Cotraser.Isoa.Domain.Area.FetchByID(this.IdArea); }
			set { SetColumnValue("IdArea", value.IdArea); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdArea,string varDescription)
		{
			Process item = new Process();
			
			item.IdArea = varIdArea;
			
			item.Description = varDescription;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdProcess,int varIdArea,string varDescription)
		{
			Process item = new Process();
			
				item.IdProcess = varIdProcess;
			
				item.IdArea = varIdArea;
			
				item.Description = varDescription;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdProcessColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAreaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdProcess = @"IdProcess";
			 public static string IdArea = @"IdArea";
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
