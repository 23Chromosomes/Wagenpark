#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ROCit_P31
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ROCitP31")]
	public partial class DataLinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertauto(auto instance);
    partial void Updateauto(auto instance);
    partial void Deleteauto(auto instance);
    partial void Insertdealer(dealer instance);
    partial void Updatedealer(dealer instance);
    partial void Deletedealer(dealer instance);
    partial void Insertgebruiker(gebruiker instance);
    partial void Updategebruiker(gebruiker instance);
    partial void Deletegebruiker(gebruiker instance);
    partial void Insertonderhoud(onderhoud instance);
    partial void Updateonderhoud(onderhoud instance);
    partial void Deleteonderhoud(onderhoud instance);
    partial void Insertpersoneel(personeel instance);
    partial void Updatepersoneel(personeel instance);
    partial void Deletepersoneel(personeel instance);
    partial void Insertwerkplaat(werkplaat instance);
    partial void Updatewerkplaat(werkplaat instance);
    partial void Deletewerkplaat(werkplaat instance);
    #endregion
		
		public DataLinQDataContext() : 
				base(global::ROCit_P31.Properties.Settings.Default.ROCitP31ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<auto> autos
		{
			get
			{
				return this.GetTable<auto>();
			}
		}
		
		public System.Data.Linq.Table<dealer> dealers
		{
			get
			{
				return this.GetTable<dealer>();
			}
		}
		
		public System.Data.Linq.Table<gebruiker> gebruikers
		{
			get
			{
				return this.GetTable<gebruiker>();
			}
		}
		
		public System.Data.Linq.Table<onderhoud> onderhouds
		{
			get
			{
				return this.GetTable<onderhoud>();
			}
		}
		
		public System.Data.Linq.Table<personeel> personeels
		{
			get
			{
				return this.GetTable<personeel>();
			}
		}
		
		public System.Data.Linq.Table<werkplaat> werkplaats
		{
			get
			{
				return this.GetTable<werkplaat>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.auto")]
	public partial class auto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _autoId;
		
		private string _merk;
		
		private string _kenteken;
		
		private string _kleur;
		
		private int _personeelId;
		
		private int _dealerId;
		
		private EntitySet<onderhoud> _onderhouds;
		
		private EntityRef<dealer> _dealer;
		
		private EntityRef<personeel> _personeel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnautoIdChanging(int value);
    partial void OnautoIdChanged();
    partial void OnmerkChanging(string value);
    partial void OnmerkChanged();
    partial void OnkentekenChanging(string value);
    partial void OnkentekenChanged();
    partial void OnkleurChanging(string value);
    partial void OnkleurChanged();
    partial void OnpersoneelIdChanging(int value);
    partial void OnpersoneelIdChanged();
    partial void OndealerIdChanging(int value);
    partial void OndealerIdChanged();
    #endregion
		
		public auto()
		{
			this._onderhouds = new EntitySet<onderhoud>(new Action<onderhoud>(this.attach_onderhouds), new Action<onderhoud>(this.detach_onderhouds));
			this._dealer = default(EntityRef<dealer>);
			this._personeel = default(EntityRef<personeel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autoId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int autoId
		{
			get
			{
				return this._autoId;
			}
			set
			{
				if ((this._autoId != value))
				{
					this.OnautoIdChanging(value);
					this.SendPropertyChanging();
					this._autoId = value;
					this.SendPropertyChanged("autoId");
					this.OnautoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_merk", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string merk
		{
			get
			{
				return this._merk;
			}
			set
			{
				if ((this._merk != value))
				{
					this.OnmerkChanging(value);
					this.SendPropertyChanging();
					this._merk = value;
					this.SendPropertyChanged("merk");
					this.OnmerkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kenteken", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string kenteken
		{
			get
			{
				return this._kenteken;
			}
			set
			{
				if ((this._kenteken != value))
				{
					this.OnkentekenChanging(value);
					this.SendPropertyChanging();
					this._kenteken = value;
					this.SendPropertyChanged("kenteken");
					this.OnkentekenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kleur", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string kleur
		{
			get
			{
				return this._kleur;
			}
			set
			{
				if ((this._kleur != value))
				{
					this.OnkleurChanging(value);
					this.SendPropertyChanging();
					this._kleur = value;
					this.SendPropertyChanged("kleur");
					this.OnkleurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personeelId", DbType="Int NOT NULL")]
		public int personeelId
		{
			get
			{
				return this._personeelId;
			}
			set
			{
				if ((this._personeelId != value))
				{
					if (this._personeel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpersoneelIdChanging(value);
					this.SendPropertyChanging();
					this._personeelId = value;
					this.SendPropertyChanged("personeelId");
					this.OnpersoneelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dealerId", DbType="Int NOT NULL")]
		public int dealerId
		{
			get
			{
				return this._dealerId;
			}
			set
			{
				if ((this._dealerId != value))
				{
					if (this._dealer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndealerIdChanging(value);
					this.SendPropertyChanging();
					this._dealerId = value;
					this.SendPropertyChanged("dealerId");
					this.OndealerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="auto_onderhoud", Storage="_onderhouds", ThisKey="autoId", OtherKey="autoId")]
		public EntitySet<onderhoud> onderhouds
		{
			get
			{
				return this._onderhouds;
			}
			set
			{
				this._onderhouds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dealer_auto", Storage="_dealer", ThisKey="dealerId", OtherKey="dealerId", IsForeignKey=true)]
		public dealer dealer
		{
			get
			{
				return this._dealer.Entity;
			}
			set
			{
				dealer previousValue = this._dealer.Entity;
				if (((previousValue != value) 
							|| (this._dealer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._dealer.Entity = null;
						previousValue.autos.Remove(this);
					}
					this._dealer.Entity = value;
					if ((value != null))
					{
						value.autos.Add(this);
						this._dealerId = value.dealerId;
					}
					else
					{
						this._dealerId = default(int);
					}
					this.SendPropertyChanged("dealer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="personeel_auto", Storage="_personeel", ThisKey="personeelId", OtherKey="personeelId", IsForeignKey=true)]
		public personeel personeel
		{
			get
			{
				return this._personeel.Entity;
			}
			set
			{
				personeel previousValue = this._personeel.Entity;
				if (((previousValue != value) 
							|| (this._personeel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._personeel.Entity = null;
						previousValue.autos.Remove(this);
					}
					this._personeel.Entity = value;
					if ((value != null))
					{
						value.autos.Add(this);
						this._personeelId = value.personeelId;
					}
					else
					{
						this._personeelId = default(int);
					}
					this.SendPropertyChanged("personeel");
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
		
		private void attach_onderhouds(onderhoud entity)
		{
			this.SendPropertyChanging();
			entity.auto = this;
		}
		
		private void detach_onderhouds(onderhoud entity)
		{
			this.SendPropertyChanging();
			entity.auto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dealer")]
	public partial class dealer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _dealerId;
		
		private string _dealerNaam;
		
		private EntitySet<auto> _autos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndealerIdChanging(int value);
    partial void OndealerIdChanged();
    partial void OndealerNaamChanging(string value);
    partial void OndealerNaamChanged();
    #endregion
		
		public dealer()
		{
			this._autos = new EntitySet<auto>(new Action<auto>(this.attach_autos), new Action<auto>(this.detach_autos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dealerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int dealerId
		{
			get
			{
				return this._dealerId;
			}
			set
			{
				if ((this._dealerId != value))
				{
					this.OndealerIdChanging(value);
					this.SendPropertyChanging();
					this._dealerId = value;
					this.SendPropertyChanged("dealerId");
					this.OndealerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dealerNaam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string dealerNaam
		{
			get
			{
				return this._dealerNaam;
			}
			set
			{
				if ((this._dealerNaam != value))
				{
					this.OndealerNaamChanging(value);
					this.SendPropertyChanging();
					this._dealerNaam = value;
					this.SendPropertyChanged("dealerNaam");
					this.OndealerNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dealer_auto", Storage="_autos", ThisKey="dealerId", OtherKey="dealerId")]
		public EntitySet<auto> autos
		{
			get
			{
				return this._autos;
			}
			set
			{
				this._autos.Assign(value);
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
		
		private void attach_autos(auto entity)
		{
			this.SendPropertyChanging();
			entity.dealer = this;
		}
		
		private void detach_autos(auto entity)
		{
			this.SendPropertyChanging();
			entity.dealer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.gebruiker")]
	public partial class gebruiker : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userId;
		
		private string _naam;
		
		private string _wachtwoord;
		
		private int _key;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnnaamChanging(string value);
    partial void OnnaamChanged();
    partial void OnwachtwoordChanging(string value);
    partial void OnwachtwoordChanged();
    partial void OnkeyChanging(int value);
    partial void OnkeyChanged();
    #endregion
		
		public gebruiker()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naam", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string naam
		{
			get
			{
				return this._naam;
			}
			set
			{
				if ((this._naam != value))
				{
					this.OnnaamChanging(value);
					this.SendPropertyChanging();
					this._naam = value;
					this.SendPropertyChanged("naam");
					this.OnnaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wachtwoord", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string wachtwoord
		{
			get
			{
				return this._wachtwoord;
			}
			set
			{
				if ((this._wachtwoord != value))
				{
					this.OnwachtwoordChanging(value);
					this.SendPropertyChanging();
					this._wachtwoord = value;
					this.SendPropertyChanged("wachtwoord");
					this.OnwachtwoordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[key]", Storage="_key", DbType="Int NOT NULL")]
		public int key
		{
			get
			{
				return this._key;
			}
			set
			{
				if ((this._key != value))
				{
					this.OnkeyChanging(value);
					this.SendPropertyChanging();
					this._key = value;
					this.SendPropertyChanged("key");
					this.OnkeyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.onderhoud")]
	public partial class onderhoud : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _onderhoudId;
		
		private string _beurtnaam;
		
		private decimal _kosten;
		
		private string _omschrijving;
		
		private int _autoId;
		
		private System.DateTime _uitvoerdatum;
		
		private int _werkplaatsId;
		
		private EntityRef<auto> _auto;
		
		private EntityRef<werkplaat> _werkplaat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnonderhoudIdChanging(int value);
    partial void OnonderhoudIdChanged();
    partial void OnbeurtnaamChanging(string value);
    partial void OnbeurtnaamChanged();
    partial void OnkostenChanging(decimal value);
    partial void OnkostenChanged();
    partial void OnomschrijvingChanging(string value);
    partial void OnomschrijvingChanged();
    partial void OnautoIdChanging(int value);
    partial void OnautoIdChanged();
    partial void OnuitvoerdatumChanging(System.DateTime value);
    partial void OnuitvoerdatumChanged();
    partial void OnwerkplaatsIdChanging(int value);
    partial void OnwerkplaatsIdChanged();
    #endregion
		
		public onderhoud()
		{
			this._auto = default(EntityRef<auto>);
			this._werkplaat = default(EntityRef<werkplaat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_onderhoudId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int onderhoudId
		{
			get
			{
				return this._onderhoudId;
			}
			set
			{
				if ((this._onderhoudId != value))
				{
					this.OnonderhoudIdChanging(value);
					this.SendPropertyChanging();
					this._onderhoudId = value;
					this.SendPropertyChanged("onderhoudId");
					this.OnonderhoudIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_beurtnaam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string beurtnaam
		{
			get
			{
				return this._beurtnaam;
			}
			set
			{
				if ((this._beurtnaam != value))
				{
					this.OnbeurtnaamChanging(value);
					this.SendPropertyChanging();
					this._beurtnaam = value;
					this.SendPropertyChanged("beurtnaam");
					this.OnbeurtnaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kosten", DbType="Decimal(18,2) NOT NULL")]
		public decimal kosten
		{
			get
			{
				return this._kosten;
			}
			set
			{
				if ((this._kosten != value))
				{
					this.OnkostenChanging(value);
					this.SendPropertyChanging();
					this._kosten = value;
					this.SendPropertyChanged("kosten");
					this.OnkostenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_omschrijving", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string omschrijving
		{
			get
			{
				return this._omschrijving;
			}
			set
			{
				if ((this._omschrijving != value))
				{
					this.OnomschrijvingChanging(value);
					this.SendPropertyChanging();
					this._omschrijving = value;
					this.SendPropertyChanged("omschrijving");
					this.OnomschrijvingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autoId", DbType="Int NOT NULL")]
		public int autoId
		{
			get
			{
				return this._autoId;
			}
			set
			{
				if ((this._autoId != value))
				{
					if (this._auto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnautoIdChanging(value);
					this.SendPropertyChanging();
					this._autoId = value;
					this.SendPropertyChanged("autoId");
					this.OnautoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uitvoerdatum", DbType="Date NOT NULL")]
		public System.DateTime uitvoerdatum
		{
			get
			{
				return this._uitvoerdatum;
			}
			set
			{
				if ((this._uitvoerdatum != value))
				{
					this.OnuitvoerdatumChanging(value);
					this.SendPropertyChanging();
					this._uitvoerdatum = value;
					this.SendPropertyChanged("uitvoerdatum");
					this.OnuitvoerdatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_werkplaatsId", DbType="Int NOT NULL")]
		public int werkplaatsId
		{
			get
			{
				return this._werkplaatsId;
			}
			set
			{
				if ((this._werkplaatsId != value))
				{
					if (this._werkplaat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnwerkplaatsIdChanging(value);
					this.SendPropertyChanging();
					this._werkplaatsId = value;
					this.SendPropertyChanged("werkplaatsId");
					this.OnwerkplaatsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="auto_onderhoud", Storage="_auto", ThisKey="autoId", OtherKey="autoId", IsForeignKey=true)]
		public auto auto
		{
			get
			{
				return this._auto.Entity;
			}
			set
			{
				auto previousValue = this._auto.Entity;
				if (((previousValue != value) 
							|| (this._auto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._auto.Entity = null;
						previousValue.onderhouds.Remove(this);
					}
					this._auto.Entity = value;
					if ((value != null))
					{
						value.onderhouds.Add(this);
						this._autoId = value.autoId;
					}
					else
					{
						this._autoId = default(int);
					}
					this.SendPropertyChanged("auto");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="werkplaat_onderhoud", Storage="_werkplaat", ThisKey="werkplaatsId", OtherKey="werkplaatsId", IsForeignKey=true)]
		public werkplaat werkplaat
		{
			get
			{
				return this._werkplaat.Entity;
			}
			set
			{
				werkplaat previousValue = this._werkplaat.Entity;
				if (((previousValue != value) 
							|| (this._werkplaat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._werkplaat.Entity = null;
						previousValue.onderhouds.Remove(this);
					}
					this._werkplaat.Entity = value;
					if ((value != null))
					{
						value.onderhouds.Add(this);
						this._werkplaatsId = value.werkplaatsId;
					}
					else
					{
						this._werkplaatsId = default(int);
					}
					this.SendPropertyChanged("werkplaat");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.personeel")]
	public partial class personeel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _personeelId;
		
		private string _naam;
		
		private string _personeelsnumer;
		
		private EntitySet<auto> _autos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpersoneelIdChanging(int value);
    partial void OnpersoneelIdChanged();
    partial void OnnaamChanging(string value);
    partial void OnnaamChanged();
    partial void OnpersoneelsnummerChanging(string value);
    partial void OnpersoneelsnummerChanged();
    #endregion
		
		public personeel()
		{
			this._autos = new EntitySet<auto>(new Action<auto>(this.attach_autos), new Action<auto>(this.detach_autos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personeelId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int personeelId
		{
			get
			{
				return this._personeelId;
			}
			set
			{
				if ((this._personeelId != value))
				{
					this.OnpersoneelIdChanging(value);
					this.SendPropertyChanging();
					this._personeelId = value;
					this.SendPropertyChanged("personeelId");
					this.OnpersoneelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naam", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string naam
		{
			get
			{
				return this._naam;
			}
			set
			{
				if ((this._naam != value))
				{
					this.OnnaamChanging(value);
					this.SendPropertyChanging();
					this._naam = value;
					this.SendPropertyChanged("naam");
					this.OnnaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personeelsnumer", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string personeelsnummer
		{
			get
			{
				return this._personeelsnumer;
			}
			set
			{
				if ((this._personeelsnumer != value))
				{
					this.OnpersoneelsnummerChanging(value);
					this.SendPropertyChanging();
					this._personeelsnumer = value;
					this.SendPropertyChanged("personeelsnummer");
					this.OnpersoneelsnummerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="personeel_auto", Storage="_autos", ThisKey="personeelId", OtherKey="personeelId")]
		public EntitySet<auto> autos
		{
			get
			{
				return this._autos;
			}
			set
			{
				this._autos.Assign(value);
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
		
		private void attach_autos(auto entity)
		{
			this.SendPropertyChanging();
			entity.personeel = this;
		}
		
		private void detach_autos(auto entity)
		{
			this.SendPropertyChanging();
			entity.personeel = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.werkplaats")]
	public partial class werkplaat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _werkplaatsId;
		
		private string _bedrijfsnaam;
		
		private string _werkplaatsnaam;
		
		private EntitySet<onderhoud> _onderhouds;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnwerkplaatsIdChanging(int value);
    partial void OnwerkplaatsIdChanged();
    partial void OnbedrijfsnaamChanging(string value);
    partial void OnbedrijfsnaamChanged();
    partial void OnwerkplaatsnaamChanging(string value);
    partial void OnwerkplaatsnaamChanged();
    #endregion
		
		public werkplaat()
		{
			this._onderhouds = new EntitySet<onderhoud>(new Action<onderhoud>(this.attach_onderhouds), new Action<onderhoud>(this.detach_onderhouds));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_werkplaatsId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int werkplaatsId
		{
			get
			{
				return this._werkplaatsId;
			}
			set
			{
				if ((this._werkplaatsId != value))
				{
					this.OnwerkplaatsIdChanging(value);
					this.SendPropertyChanging();
					this._werkplaatsId = value;
					this.SendPropertyChanged("werkplaatsId");
					this.OnwerkplaatsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bedrijfsnaam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string bedrijfsnaam
		{
			get
			{
				return this._bedrijfsnaam;
			}
			set
			{
				if ((this._bedrijfsnaam != value))
				{
					this.OnbedrijfsnaamChanging(value);
					this.SendPropertyChanging();
					this._bedrijfsnaam = value;
					this.SendPropertyChanged("bedrijfsnaam");
					this.OnbedrijfsnaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_werkplaatsnaam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string werkplaatsnaam
		{
			get
			{
				return this._werkplaatsnaam;
			}
			set
			{
				if ((this._werkplaatsnaam != value))
				{
					this.OnwerkplaatsnaamChanging(value);
					this.SendPropertyChanging();
					this._werkplaatsnaam = value;
					this.SendPropertyChanged("werkplaatsnaam");
					this.OnwerkplaatsnaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="werkplaat_onderhoud", Storage="_onderhouds", ThisKey="werkplaatsId", OtherKey="werkplaatsId")]
		public EntitySet<onderhoud> onderhouds
		{
			get
			{
				return this._onderhouds;
			}
			set
			{
				this._onderhouds.Assign(value);
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
		
		private void attach_onderhouds(onderhoud entity)
		{
			this.SendPropertyChanging();
			entity.werkplaat = this;
		}
		
		private void detach_onderhouds(onderhoud entity)
		{
			this.SendPropertyChanging();
			entity.werkplaat = null;
		}
	}
}
#pragma warning restore 1591
