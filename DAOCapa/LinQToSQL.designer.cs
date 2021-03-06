﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOCapa
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="itir554")]
	public partial class LinQToSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public LinQToSQLDataContext() : 
				base(global::DAOCapa.Properties.Settings.Default.itir554ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinQToSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQToSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQToSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQToSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Persona> Persona
		{
			get
			{
				return this.GetTable<Persona>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListadoPersonas")]
		public ISingleResult<ListadoPersonasResult> ListadoPersonas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListadoPersonasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RegistrarPersona")]
		public int RegistrarPersona([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string lugarNac, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] ref string mensaje)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, lugarNac, mensaje);
			mensaje = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Persona")]
	public partial class Persona
	{
		
		private string _per_nombre;
		
		private string _per_lugarNacimiento;
		
		public Persona()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_nombre", DbType="NVarChar(50)")]
		public string per_nombre
		{
			get
			{
				return this._per_nombre;
			}
			set
			{
				if ((this._per_nombre != value))
				{
					this._per_nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_lugarNacimiento", DbType="NVarChar(50)")]
		public string per_lugarNacimiento
		{
			get
			{
				return this._per_lugarNacimiento;
			}
			set
			{
				if ((this._per_lugarNacimiento != value))
				{
					this._per_lugarNacimiento = value;
				}
			}
		}
	}
	
	public partial class ListadoPersonasResult
	{
		
		private string _per_nombre;
		
		private string _per_lugarNacimiento;
		
		public ListadoPersonasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_nombre", DbType="NVarChar(50)")]
		public string per_nombre
		{
			get
			{
				return this._per_nombre;
			}
			set
			{
				if ((this._per_nombre != value))
				{
					this._per_nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_lugarNacimiento", DbType="NVarChar(50)")]
		public string per_lugarNacimiento
		{
			get
			{
				return this._per_lugarNacimiento;
			}
			set
			{
				if ((this._per_lugarNacimiento != value))
				{
					this._per_lugarNacimiento = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
