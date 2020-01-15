﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP2DB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Etudiants")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCompte(Compte instance);
    partial void UpdateCompte(Compte instance);
    partial void DeleteCompte(Compte instance);
    partial void Insertetudiant(etudiant instance);
    partial void Updateetudiant(etudiant instance);
    partial void Deleteetudiant(etudiant instance);
    partial void InsertFiliere(Filiere instance);
    partial void UpdateFiliere(Filiere instance);
    partial void DeleteFiliere(Filiere instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::TP2DB.Properties.Settings.Default.EtudiantsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Compte> Comptes
		{
			get
			{
				return this.GetTable<Compte>();
			}
		}
		
		public System.Data.Linq.Table<etudiant> etudiants
		{
			get
			{
				return this.GetTable<etudiant>();
			}
		}
		
		public System.Data.Linq.Table<Filiere> Filieres
		{
			get
			{
				return this.GetTable<Filiere>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Compte")]
	public partial class Compte : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Num;
		
		private string _Nom;
		
		private string _Prenom;
		
		private System.Nullable<int> _solde;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumChanging(int value);
    partial void OnNumChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnsoldeChanging(System.Nullable<int> value);
    partial void OnsoldeChanged();
    #endregion
		
		public Compte()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this.OnNumChanging(value);
					this.SendPropertyChanging();
					this._Num = value;
					this.SendPropertyChanged("Num");
					this.OnNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(100)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="VarChar(100)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_solde", DbType="Int")]
		public System.Nullable<int> solde
		{
			get
			{
				return this._solde;
			}
			set
			{
				if ((this._solde != value))
				{
					this.OnsoldeChanging(value);
					this.SendPropertyChanging();
					this._solde = value;
					this.SendPropertyChanged("solde");
					this.OnsoldeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.etudiant")]
	public partial class etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cne;
		
		private string _nom;
		
		private string _prenom;
		
		private System.Nullable<char> _sexe;
		
		private System.Nullable<System.DateTime> _date_naiss;
		
		private System.Nullable<int> _id_fil;
		
		private EntityRef<Filiere> _Filiere;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncneChanging(int value);
    partial void OncneChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OnsexeChanging(System.Nullable<char> value);
    partial void OnsexeChanged();
    partial void Ondate_naissChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_naissChanged();
    partial void Onid_filChanging(System.Nullable<int> value);
    partial void Onid_filChanged();
    #endregion
		
		public etudiant()
		{
			this._Filiere = default(EntityRef<Filiere>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cne", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cne
		{
			get
			{
				return this._cne;
			}
			set
			{
				if ((this._cne != value))
				{
					this.OncneChanging(value);
					this.SendPropertyChanging();
					this._cne = value;
					this.SendPropertyChanged("cne");
					this.OncneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(100)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(100)")]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexe", DbType="Char(1)")]
		public System.Nullable<char> sexe
		{
			get
			{
				return this._sexe;
			}
			set
			{
				if ((this._sexe != value))
				{
					this.OnsexeChanging(value);
					this.SendPropertyChanging();
					this._sexe = value;
					this.SendPropertyChanged("sexe");
					this.OnsexeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_naiss", DbType="Date")]
		public System.Nullable<System.DateTime> date_naiss
		{
			get
			{
				return this._date_naiss;
			}
			set
			{
				if ((this._date_naiss != value))
				{
					this.Ondate_naissChanging(value);
					this.SendPropertyChanging();
					this._date_naiss = value;
					this.SendPropertyChanged("date_naiss");
					this.Ondate_naissChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_fil", DbType="Int")]
		public System.Nullable<int> id_fil
		{
			get
			{
				return this._id_fil;
			}
			set
			{
				if ((this._id_fil != value))
				{
					if (this._Filiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_filChanging(value);
					this.SendPropertyChanging();
					this._id_fil = value;
					this.SendPropertyChanged("id_fil");
					this.Onid_filChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Filiere_etudiant", Storage="_Filiere", ThisKey="id_fil", OtherKey="Id_filiere", IsForeignKey=true, DeleteRule="CASCADE")]
		public Filiere Filiere
		{
			get
			{
				return this._Filiere.Entity;
			}
			set
			{
				Filiere previousValue = this._Filiere.Entity;
				if (((previousValue != value) 
							|| (this._Filiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Filiere.Entity = null;
						previousValue.etudiants.Remove(this);
					}
					this._Filiere.Entity = value;
					if ((value != null))
					{
						value.etudiants.Add(this);
						this._id_fil = value.Id_filiere;
					}
					else
					{
						this._id_fil = default(Nullable<int>);
					}
					this.SendPropertyChanged("Filiere");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Filiere")]
	public partial class Filiere : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_filiere;
		
		private string _Nom_filiere;
		
		private EntitySet<etudiant> _etudiants;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_filiereChanging(int value);
    partial void OnId_filiereChanged();
    partial void OnNom_filiereChanging(string value);
    partial void OnNom_filiereChanged();
    #endregion
		
		public Filiere()
		{
			this._etudiants = new EntitySet<etudiant>(new Action<etudiant>(this.attach_etudiants), new Action<etudiant>(this.detach_etudiants));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_filiere", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_filiere
		{
			get
			{
				return this._Id_filiere;
			}
			set
			{
				if ((this._Id_filiere != value))
				{
					this.OnId_filiereChanging(value);
					this.SendPropertyChanging();
					this._Id_filiere = value;
					this.SendPropertyChanged("Id_filiere");
					this.OnId_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom_filiere", DbType="VarChar(100)")]
		public string Nom_filiere
		{
			get
			{
				return this._Nom_filiere;
			}
			set
			{
				if ((this._Nom_filiere != value))
				{
					this.OnNom_filiereChanging(value);
					this.SendPropertyChanging();
					this._Nom_filiere = value;
					this.SendPropertyChanged("Nom_filiere");
					this.OnNom_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Filiere_etudiant", Storage="_etudiants", ThisKey="Id_filiere", OtherKey="id_fil")]
		public EntitySet<etudiant> etudiants
		{
			get
			{
				return this._etudiants;
			}
			set
			{
				this._etudiants.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_etudiants(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.Filiere = this;
		}
		
		private void detach_etudiants(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.Filiere = null;
		}
	}
}
#pragma warning restore 1591
