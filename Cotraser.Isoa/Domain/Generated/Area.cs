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
	/// Strongly-typed collection for the Area class.
	/// </summary>
    [Serializable]
	public partial class AreaCollection : ActiveList<Area, AreaCollection>
	{	   
		public AreaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AreaCollection</returns>
		public AreaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Area o = this[i];
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
	/// This is an ActiveRecord class which wraps the Area table.
	/// </summary>
	[Serializable]
	public partial class Area : ActiveRecord<Area>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Area()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Area(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Area(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Area(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Area", TableType.Table, DataService.GetInstance("ISOAProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdArea = new TableSchema.TableColumn(schema);
				colvarIdArea.ColumnName = "IdArea";
				colvarIdArea.DataType = DbType.Int32;
				colvarIdArea.MaxLength = 0;
				colvarIdArea.AutoIncrement = true;
				colvarIdArea.IsNullable = false;
				colvarIdArea.IsPrimaryKey = true;
				colvarIdArea.IsForeignKey = false;
				colvarIdArea.IsReadOnly = false;
				colvarIdArea.DefaultSetting = @"";
				colvarIdArea.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdArea);
				
				TableSchema.TableColumn colvarAreaCode = new TableSchema.TableColumn(schema);
				colvarAreaCode.ColumnName = "AreaCode";
				colvarAreaCode.DataType = DbType.String;
				colvarAreaCode.MaxLength = 100;
				colvarAreaCode.AutoIncrement = false;
				colvarAreaCode.IsNullable = false;
				colvarAreaCode.IsPrimaryKey = false;
				colvarAreaCode.IsForeignKey = false;
				colvarAreaCode.IsReadOnly = false;
				colvarAreaCode.DefaultSetting = @"";
				colvarAreaCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAreaCode);
				
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
				DataService.Providers["ISOAProvider"].AddSchema("Area",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdArea")]
		[Bindable(true)]
		public int IdArea 
		{
			get { return GetColumnValue<int>(Columns.IdArea); }
			set { SetColumnValue(Columns.IdArea, value); }
		}
		  
		[XmlAttribute("AreaCode")]
		[Bindable(true)]
		public string AreaCode 
		{
			get { return GetColumnValue<string>(Columns.AreaCode); }
			set { SetColumnValue(Columns.AreaCode, value); }
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
        
		
		public Cotraser.Isoa.Domain.ProcessCollection ProcessRecords()
		{
			return new Cotraser.Isoa.Domain.ProcessCollection().Where(Process.Columns.IdArea, IdArea).Load();
		}
		public Cotraser.Isoa.Domain.UserByAreaCollection UserByAreaRecords()
		{
			return new Cotraser.Isoa.Domain.UserByAreaCollection().Where(UserByArea.Columns.IdArea, IdArea).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varAreaCode,string varDescription)
		{
			Area item = new Area();
			
			item.AreaCode = varAreaCode;
			
			item.Description = varDescription;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdArea,string varAreaCode,string varDescription)
		{
			Area item = new Area();
			
				item.IdArea = varIdArea;
			
				item.AreaCode = varAreaCode;
			
				item.Description = varDescription;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdAreaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn AreaCodeColumn
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
			 public static string IdArea = @"IdArea";
			 public static string AreaCode = @"AreaCode";
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
