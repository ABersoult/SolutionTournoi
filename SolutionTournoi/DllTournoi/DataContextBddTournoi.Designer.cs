﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 20/09/2024 13:50:10
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace BddtournoiContext
{

    [DatabaseAttribute(Name = "bddtournoi")]
    [ProviderAttribute(typeof(Devart.Data.MySql.Linq.Provider.MySqlDataProvider))]
    public partial class BddtournoiDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(BddtournoiDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertParticipant(Participant instance);
        partial void UpdateParticipant(Participant instance);
        partial void DeleteParticipant(Participant instance);
        partial void InsertSport(Sport instance);
        partial void UpdateSport(Sport instance);
        partial void DeleteSport(Sport instance);
        partial void InsertTournoi(Tournoi instance);
        partial void UpdateTournoi(Tournoi instance);
        partial void DeleteTournoi(Tournoi instance);

        #endregion

        public BddtournoiDataContext() :
        base(GetConnectionString("BddtournoiDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        public BddtournoiDataContext(MappingSource mappingSource) :
        base(GetConnectionString("BddtournoiDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public BddtournoiDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public BddtournoiDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public BddtournoiDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public BddtournoiDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Participant> Participants
        {
            get
            {
                return this.GetTable<Participant>();
            }
        }

        public Devart.Data.Linq.Table<Sport> Sports
        {
            get
            {
                return this.GetTable<Sport>();
            }
        }

        public Devart.Data.Linq.Table<Tournoi> Tournois
        {
            get
            {
                return this.GetTable<Tournoi>();
            }
        }
    }
}

namespace BddtournoiContext
{

    /// <summary>
    /// There are no comments for BddtournoiContext.Participant in the schema.
    /// </summary>
    [Table(Name = @"bddtournoi.participant")]
    public partial class Participant : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private System.DateTime _DateNaissance;

        private int _Id;

        private int _IdSport;

        private int _IdTournoi;

        private string _Nom;

        private byte[] _Photo;

        private string _Prenom;

        private string _Sexe;
        #pragma warning restore 0649

        private EntityRef<Tournoi> _Tournoi;

        private EntityRef<Sport> _Sport;

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnDateNaissanceChanging(System.DateTime value);
        partial void OnDateNaissanceChanged();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnIdSportChanging(int value);
        partial void OnIdSportChanged();
        partial void OnIdTournoiChanging(int value);
        partial void OnIdTournoiChanged();
        partial void OnNomChanging(string value);
        partial void OnNomChanged();
        partial void OnPhotoChanging(byte[] value);
        partial void OnPhotoChanged();
        partial void OnPrenomChanging(string value);
        partial void OnPrenomChanged();
        partial void OnSexeChanging(string value);
        partial void OnSexeChanged();
        #endregion

        public Participant()
        {
            this._Tournoi  = default(EntityRef<Tournoi>);
            this._Sport  = default(EntityRef<Sport>);
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DateNaissance in the schema.
        /// </summary>
        [Column(Name = @"dateNaissance", Storage = "_DateNaissance", CanBeNull = false, DbType = "DATE NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.DateTime DateNaissance
        {
            get
            {
                return this._DateNaissance;
            }
            set
            {
                if (this._DateNaissance != value)
                {
                    this.OnDateNaissanceChanging(value);
                    this.SendPropertyChanging("DateNaissance");
                    this._DateNaissance = value;
                    this.SendPropertyChanged("DateNaissance");
                    this.OnDateNaissanceChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [Column(Name = @"id", Storage = "_Id", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging("Id");
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for IdSport in the schema.
        /// </summary>
        [Column(Name = @"idSport", Storage = "_IdSport", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int IdSport
        {
            get
            {
                return this._IdSport;
            }
            set
            {
                if (this._IdSport != value)
                {
                    if (this._Sport.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnIdSportChanging(value);
                    this.SendPropertyChanging("IdSport");
                    this._IdSport = value;
                    this.SendPropertyChanged("IdSport");
                    this.OnIdSportChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for IdTournoi in the schema.
        /// </summary>
        [Column(Name = @"idTournoi", Storage = "_IdTournoi", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int IdTournoi
        {
            get
            {
                return this._IdTournoi;
            }
            set
            {
                if (this._IdTournoi != value)
                {
                    if (this._Tournoi.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnIdTournoiChanging(value);
                    this.SendPropertyChanging("IdTournoi");
                    this._IdTournoi = value;
                    this.SendPropertyChanged("IdTournoi");
                    this.OnIdTournoiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Nom in the schema.
        /// </summary>
        [Column(Name = @"nom", Storage = "_Nom", CanBeNull = false, DbType = "CHAR(20) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Nom
        {
            get
            {
                return this._Nom;
            }
            set
            {
                if (this._Nom != value)
                {
                    this.OnNomChanging(value);
                    this.SendPropertyChanging("Nom");
                    this._Nom = value;
                    this.SendPropertyChanged("Nom");
                    this.OnNomChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Photo in the schema.
        /// </summary>
        [Column(Name = @"photo", Storage = "_Photo", DbType = "LONGBLOB NULL", UpdateCheck = UpdateCheck.Never)]
        public byte[] Photo
        {
            get
            {
                return this._Photo;
            }
            set
            {
                if (this._Photo != value)
                {
                    this.OnPhotoChanging(value);
                    this.SendPropertyChanging("Photo");
                    this._Photo = value;
                    this.SendPropertyChanged("Photo");
                    this.OnPhotoChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Prenom in the schema.
        /// </summary>
        [Column(Name = @"prenom", Storage = "_Prenom", CanBeNull = false, DbType = "CHAR(20) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Prenom
        {
            get
            {
                return this._Prenom;
            }
            set
            {
                if (this._Prenom != value)
                {
                    this.OnPrenomChanging(value);
                    this.SendPropertyChanging("Prenom");
                    this._Prenom = value;
                    this.SendPropertyChanged("Prenom");
                    this.OnPrenomChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Sexe in the schema.
        /// </summary>
        [Column(Name = @"sexe", Storage = "_Sexe", DbType = "VARCHAR(10) NULL", UpdateCheck = UpdateCheck.Never)]
        public string Sexe
        {
            get
            {
                return this._Sexe;
            }
            set
            {
                if (this._Sexe != value)
                {
                    this.OnSexeChanging(value);
                    this.SendPropertyChanging("Sexe");
                    this._Sexe = value;
                    this.SendPropertyChanged("Sexe");
                    this.OnSexeChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Tournoi in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Tournoi_Participant", Storage="_Tournoi", ThisKey="IdTournoi", OtherKey="IdTournoi", IsForeignKey=true)]
        public Tournoi Tournoi
        {
            get
            {
                return this._Tournoi.Entity;
            }
            set
            {
                Tournoi previousValue = this._Tournoi.Entity;
                if ((previousValue != value) || (this._Tournoi.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging("Tournoi");
                    if (previousValue != null)
                    {
                        this._Tournoi.Entity = null;
                        previousValue.Participants.Remove(this);
                    }
                    this._Tournoi.Entity = value;
                    if (value != null)
                    {
                        this._IdTournoi = value.IdTournoi;
                        value.Participants.Add(this);
                    }
                    else
                    {
                        this._IdTournoi = default(int);
                    }
                    this.SendPropertyChanged("Tournoi");
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Sport in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Sport_Participant", Storage="_Sport", ThisKey="IdSport", OtherKey="IdSport", IsForeignKey=true)]
        public Sport Sport
        {
            get
            {
                return this._Sport.Entity;
            }
            set
            {
                Sport previousValue = this._Sport.Entity;
                if ((previousValue != value) || (this._Sport.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging("Sport");
                    if (previousValue != null)
                    {
                        this._Sport.Entity = null;
                        previousValue.Participants.Remove(this);
                    }
                    this._Sport.Entity = value;
                    if (value != null)
                    {
                        this._IdSport = value.IdSport;
                        value.Participants.Add(this);
                    }
                    else
                    {
                        this._IdSport = default(int);
                    }
                    this.SendPropertyChanged("Sport");
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for BddtournoiContext.Sport in the schema.
    /// </summary>
    [Table(Name = @"bddtournoi.sport")]
    public partial class Sport : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _IdSport;

        private string _Intitule;
        #pragma warning restore 0649

        private EntitySet<Participant> _Participants;

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdSportChanging(int value);
        partial void OnIdSportChanged();
        partial void OnIntituleChanging(string value);
        partial void OnIntituleChanged();
        #endregion

        public Sport()
        {
            this._Participants = new EntitySet<Participant>(new Action<Participant>(this.attach_Participants), new Action<Participant>(this.detach_Participants));
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for IdSport in the schema.
        /// </summary>
        [Column(Name = @"idSport", Storage = "_IdSport", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int IdSport
        {
            get
            {
                return this._IdSport;
            }
            set
            {
                if (this._IdSport != value)
                {
                    this.OnIdSportChanging(value);
                    this.SendPropertyChanging("IdSport");
                    this._IdSport = value;
                    this.SendPropertyChanged("IdSport");
                    this.OnIdSportChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Intitule in the schema.
        /// </summary>
        [Column(Name = @"intitule", Storage = "_Intitule", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Intitule
        {
            get
            {
                return this._Intitule;
            }
            set
            {
                if (this._Intitule != value)
                {
                    this.OnIntituleChanging(value);
                    this.SendPropertyChanging("Intitule");
                    this._Intitule = value;
                    this.SendPropertyChanged("Intitule");
                    this.OnIntituleChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Participants in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Sport_Participant", Storage="_Participants", ThisKey="IdSport", OtherKey="IdSport", DeleteRule="NO ACTION")]
        public EntitySet<Participant> Participants
        {
            get
            {
                return this._Participants;
            }
            set
            {
                this._Participants.Assign(value);
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void attach_Participants(Participant entity)
        {
            this.SendPropertyChanging("Participants");
            entity.Sport = this;
        }
    
        private void detach_Participants(Participant entity)
        {
            this.SendPropertyChanging("Participants");
            entity.Sport = null;
        }
    }

    /// <summary>
    /// There are no comments for BddtournoiContext.Tournoi in the schema.
    /// </summary>
    [Table(Name = @"bddtournoi.tournoi")]
    public partial class Tournoi : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private System.DateTime _DateTournoi;

        private int _IdTournoi;

        private string _Intitule;
        #pragma warning restore 0649

        private EntitySet<Participant> _Participants;

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnDateTournoiChanging(System.DateTime value);
        partial void OnDateTournoiChanged();
        partial void OnIdTournoiChanging(int value);
        partial void OnIdTournoiChanged();
        partial void OnIntituleChanging(string value);
        partial void OnIntituleChanged();
        #endregion

        public Tournoi()
        {
            this._Participants = new EntitySet<Participant>(new Action<Participant>(this.attach_Participants), new Action<Participant>(this.detach_Participants));
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for DateTournoi in the schema.
        /// </summary>
        [Column(Name = @"dateTournoi", Storage = "_DateTournoi", CanBeNull = false, DbType = "DATE NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.DateTime DateTournoi
        {
            get
            {
                return this._DateTournoi;
            }
            set
            {
                if (this._DateTournoi != value)
                {
                    this.OnDateTournoiChanging(value);
                    this.SendPropertyChanging("DateTournoi");
                    this._DateTournoi = value;
                    this.SendPropertyChanged("DateTournoi");
                    this.OnDateTournoiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for IdTournoi in the schema.
        /// </summary>
        [Column(Name = @"idTournoi", Storage = "_IdTournoi", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int IdTournoi
        {
            get
            {
                return this._IdTournoi;
            }
            set
            {
                if (this._IdTournoi != value)
                {
                    this.OnIdTournoiChanging(value);
                    this.SendPropertyChanging("IdTournoi");
                    this._IdTournoi = value;
                    this.SendPropertyChanged("IdTournoi");
                    this.OnIdTournoiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Intitule in the schema.
        /// </summary>
        [Column(Name = @"intitule", Storage = "_Intitule", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Intitule
        {
            get
            {
                return this._Intitule;
            }
            set
            {
                if (this._Intitule != value)
                {
                    this.OnIntituleChanging(value);
                    this.SendPropertyChanging("Intitule");
                    this._Intitule = value;
                    this.SendPropertyChanged("Intitule");
                    this.OnIntituleChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Participants in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Tournoi_Participant", Storage="_Participants", ThisKey="IdTournoi", OtherKey="IdTournoi", DeleteRule="NO ACTION")]
        public EntitySet<Participant> Participants
        {
            get
            {
                return this._Participants;
            }
            set
            {
                this._Participants.Assign(value);
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void attach_Participants(Participant entity)
        {
            this.SendPropertyChanging("Participants");
            entity.Tournoi = this;
        }
    
        private void detach_Participants(Participant entity)
        {
            this.SendPropertyChanging("Participants");
            entity.Tournoi = null;
        }
    }

}