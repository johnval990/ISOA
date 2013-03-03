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
	#region Tables Struct
	public partial struct Tables
	{
		
		public static readonly string AplicationRole = @"AplicationRole";
        
		public static readonly string Area = @"Area";
        
		public static readonly string File = @"File";
        
		public static readonly string FileLog = @"FileLog";
        
		public static readonly string FileLogType = @"FileLogType";
        
		public static readonly string Process = @"Process";
        
		public static readonly string User = @"User";
        
		public static readonly string UserByArea = @"UserByArea";
        
		public static readonly string UserByRole = @"UserByRole";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table AplicationRole
		{
            get { return DataService.GetSchema("AplicationRole", "ISOAProvider"); }
		}
        
		public static TableSchema.Table Area
		{
            get { return DataService.GetSchema("Area", "ISOAProvider"); }
		}
        
		public static TableSchema.Table File
		{
            get { return DataService.GetSchema("File", "ISOAProvider"); }
		}
        
		public static TableSchema.Table FileLog
		{
            get { return DataService.GetSchema("FileLog", "ISOAProvider"); }
		}
        
		public static TableSchema.Table FileLogType
		{
            get { return DataService.GetSchema("FileLogType", "ISOAProvider"); }
		}
        
		public static TableSchema.Table Process
		{
            get { return DataService.GetSchema("Process", "ISOAProvider"); }
		}
        
		public static TableSchema.Table User
		{
            get { return DataService.GetSchema("User", "ISOAProvider"); }
		}
        
		public static TableSchema.Table UserByArea
		{
            get { return DataService.GetSchema("UserByArea", "ISOAProvider"); }
		}
        
		public static TableSchema.Table UserByRole
		{
            get { return DataService.GetSchema("UserByRole", "ISOAProvider"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["ISOAProvider"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository 
        {
            get 
            {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository; 
            }
            set { _repository = value; }
        }
        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
	    {
            return Repository.SelectAllColumnsFrom<T>();
	    }
	    public static Select Select()
	    {
            return Repository.Select();
	    }
	    
		public static Select Select(params string[] columns)
		{
            return Repository.Select(columns);
        }
	    
		public static Select Select(params Aggregate[] aggregates)
		{
            return Repository.Select(aggregates);
        }
   
	    public static Update Update<T>() where T : RecordBase<T>, new()
	    {
            return Repository.Update<T>();
	    }
	    
	    public static Insert Insert()
	    {
            return Repository.Insert();
	    }
	    
	    public static Delete Delete()
	    {
            return Repository.Delete();
	    }
	    
	    public static InlineQuery Query()
	    {
            return Repository.Query();
	    }
	    	    
	    
	}
    #endregion
    
}
#region Databases
public partial struct Databases 
{
	
	public static readonly string ISOAProvider = @"ISOAProvider";
    
}
#endregion