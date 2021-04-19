﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("myFinanceDbFileModel", "TransactionContact", "Transaction", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PersonalFinanceApp.Transaction), "Contact", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(PersonalFinanceApp.Contact), true)]
[assembly: EdmRelationshipAttribute("myFinanceDbFileModel", "UserEvent", "User", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(PersonalFinanceApp.User), "Event", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PersonalFinanceApp.Event), true)]
[assembly: EdmRelationshipAttribute("myFinanceDbFileModel", "UserTransaction", "User", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(PersonalFinanceApp.User), "Transaction", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PersonalFinanceApp.Transaction), true)]

#endregion

namespace PersonalFinanceApp
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class myFinanceDbFileEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new myFinanceDbFileEntities object using the connection string found in the 'myFinanceDbFileEntities' section of the application configuration file.
        /// </summary>
        public myFinanceDbFileEntities() : base("name=myFinanceDbFileEntities", "myFinanceDbFileEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new myFinanceDbFileEntities object.
        /// </summary>
        public myFinanceDbFileEntities(string connectionString) : base(connectionString, "myFinanceDbFileEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new myFinanceDbFileEntities object.
        /// </summary>
        public myFinanceDbFileEntities(EntityConnection connection) : base(connection, "myFinanceDbFileEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Contact> Contacts
        {
            get
            {
                if ((_Contacts == null))
                {
                    _Contacts = base.CreateObjectSet<Contact>("Contacts");
                }
                return _Contacts;
            }
        }
        private ObjectSet<Contact> _Contacts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Transaction> Transactions
        {
            get
            {
                if ((_Transactions == null))
                {
                    _Transactions = base.CreateObjectSet<Transaction>("Transactions");
                }
                return _Transactions;
            }
        }
        private ObjectSet<Transaction> _Transactions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Event> Events
        {
            get
            {
                if ((_Events == null))
                {
                    _Events = base.CreateObjectSet<Event>("Events");
                }
                return _Events;
            }
        }
        private ObjectSet<Event> _Events;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contacts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContacts(Contact contact)
        {
            base.AddObject("Contacts", contact);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Transactions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTransactions(Transaction transaction)
        {
            base.AddObject("Transactions", transaction);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Events EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEvents(Event @event)
        {
            base.AddObject("Events", @event);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="myFinanceDbFileModel", Name="Contact")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contact : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contact object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="firstName">Initial value of the firstName property.</param>
        /// <param name="lastName">Initial value of the lastName property.</param>
        /// <param name="contactNo">Initial value of the contactNo property.</param>
        public static Contact CreateContact(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.String contactNo)
        {
            Contact contact = new Contact();
            contact.Id = id;
            contact.firstName = firstName;
            contact.lastName = lastName;
            contact.contactNo = contactNo;
            return contact;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                OnfirstNameChanging(value);
                ReportPropertyChanging("firstName");
                _firstName = StructuralObject.SetValidValue(value, false, "firstName");
                ReportPropertyChanged("firstName");
                OnfirstNameChanged();
            }
        }
        private global::System.String _firstName;
        partial void OnfirstNameChanging(global::System.String value);
        partial void OnfirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                OnlastNameChanging(value);
                ReportPropertyChanging("lastName");
                _lastName = StructuralObject.SetValidValue(value, false, "lastName");
                ReportPropertyChanged("lastName");
                OnlastNameChanged();
            }
        }
        private global::System.String _lastName;
        partial void OnlastNameChanging(global::System.String value);
        partial void OnlastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String contactNo
        {
            get
            {
                return _contactNo;
            }
            set
            {
                OncontactNoChanging(value);
                ReportPropertyChanging("contactNo");
                _contactNo = StructuralObject.SetValidValue(value, false, "contactNo");
                ReportPropertyChanged("contactNo");
                OncontactNoChanged();
            }
        }
        private global::System.String _contactNo;
        partial void OncontactNoChanging(global::System.String value);
        partial void OncontactNoChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("myFinanceDbFileModel", "TransactionContact", "Transaction")]
        public EntityCollection<Transaction> Transactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Transaction>("myFinanceDbFileModel.TransactionContact", "Transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Transaction>("myFinanceDbFileModel.TransactionContact", "Transaction", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="myFinanceDbFileModel", Name="Event")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Event : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Event object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the title property.</param>
        /// <param name="date">Initial value of the date property.</param>
        /// <param name="category">Initial value of the category property.</param>
        /// <param name="occurrence">Initial value of the occurrence property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        public static Event CreateEvent(global::System.Int32 id, global::System.String title, global::System.DateTime date, global::System.Int32 category, global::System.String occurrence, global::System.Int32 userId)
        {
            Event @event = new Event();
            @event.Id = id;
            @event.title = title;
            @event.date = date;
            @event.category = category;
            @event.occurrence = occurrence;
            @event.UserId = userId;
            return @event;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String title
        {
            get
            {
                return _title;
            }
            set
            {
                OntitleChanging(value);
                ReportPropertyChanging("title");
                _title = StructuralObject.SetValidValue(value, false, "title");
                ReportPropertyChanged("title");
                OntitleChanged();
            }
        }
        private global::System.String _title;
        partial void OntitleChanging(global::System.String value);
        partial void OntitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String location
        {
            get
            {
                return _location;
            }
            set
            {
                OnlocationChanging(value);
                ReportPropertyChanging("location");
                _location = StructuralObject.SetValidValue(value, true, "location");
                ReportPropertyChanged("location");
                OnlocationChanged();
            }
        }
        private global::System.String _location;
        partial void OnlocationChanging(global::System.String value);
        partial void OnlocationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value, "date");
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.DateTime _date;
        partial void OndateChanging(global::System.DateTime value);
        partial void OndateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 category
        {
            get
            {
                return _category;
            }
            set
            {
                OncategoryChanging(value);
                ReportPropertyChanging("category");
                _category = StructuralObject.SetValidValue(value, "category");
                ReportPropertyChanged("category");
                OncategoryChanged();
            }
        }
        private global::System.Int32 _category;
        partial void OncategoryChanging(global::System.Int32 value);
        partial void OncategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String occurrence
        {
            get
            {
                return _occurrence;
            }
            set
            {
                OnoccurrenceChanging(value);
                ReportPropertyChanging("occurrence");
                _occurrence = StructuralObject.SetValidValue(value, false, "occurrence");
                ReportPropertyChanged("occurrence");
                OnoccurrenceChanged();
            }
        }
        private global::System.String _occurrence;
        partial void OnoccurrenceChanging(global::System.String value);
        partial void OnoccurrenceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value, "UserId");
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("myFinanceDbFileModel", "UserEvent", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("myFinanceDbFileModel.UserEvent", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("myFinanceDbFileModel.UserEvent", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("myFinanceDbFileModel.UserEvent", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("myFinanceDbFileModel.UserEvent", "User", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="myFinanceDbFileModel", Name="Transaction")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Transaction : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Transaction object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="date">Initial value of the date property.</param>
        /// <param name="amount">Initial value of the amount property.</param>
        /// <param name="type">Initial value of the type property.</param>
        /// <param name="occurrence">Initial value of the occurrence property.</param>
        /// <param name="contactId">Initial value of the ContactId property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        public static Transaction CreateTransaction(global::System.Int32 id, global::System.DateTime date, global::System.Decimal amount, global::System.Int32 type, global::System.Int32 occurrence, global::System.Int32 contactId, global::System.Int32 userId)
        {
            Transaction transaction = new Transaction();
            transaction.Id = id;
            transaction.date = date;
            transaction.amount = amount;
            transaction.type = type;
            transaction.occurrence = occurrence;
            transaction.ContactId = contactId;
            transaction.UserId = userId;
            return transaction;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value, "date");
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.DateTime _date;
        partial void OndateChanging(global::System.DateTime value);
        partial void OndateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal amount
        {
            get
            {
                return _amount;
            }
            set
            {
                OnamountChanging(value);
                ReportPropertyChanging("amount");
                _amount = StructuralObject.SetValidValue(value, "amount");
                ReportPropertyChanged("amount");
                OnamountChanged();
            }
        }
        private global::System.Decimal _amount;
        partial void OnamountChanging(global::System.Decimal value);
        partial void OnamountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, true, "description");
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 type
        {
            get
            {
                return _type;
            }
            set
            {
                OntypeChanging(value);
                ReportPropertyChanging("type");
                _type = StructuralObject.SetValidValue(value, "type");
                ReportPropertyChanged("type");
                OntypeChanged();
            }
        }
        private global::System.Int32 _type;
        partial void OntypeChanging(global::System.Int32 value);
        partial void OntypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 occurrence
        {
            get
            {
                return _occurrence;
            }
            set
            {
                OnoccurrenceChanging(value);
                ReportPropertyChanging("occurrence");
                _occurrence = StructuralObject.SetValidValue(value, "occurrence");
                ReportPropertyChanged("occurrence");
                OnoccurrenceChanged();
            }
        }
        private global::System.Int32 _occurrence;
        partial void OnoccurrenceChanging(global::System.Int32 value);
        partial void OnoccurrenceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContactId
        {
            get
            {
                return _ContactId;
            }
            set
            {
                OnContactIdChanging(value);
                ReportPropertyChanging("ContactId");
                _ContactId = StructuralObject.SetValidValue(value, "ContactId");
                ReportPropertyChanged("ContactId");
                OnContactIdChanged();
            }
        }
        private global::System.Int32 _ContactId;
        partial void OnContactIdChanging(global::System.Int32 value);
        partial void OnContactIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value, "UserId");
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("myFinanceDbFileModel", "TransactionContact", "Contact")]
        public Contact Contact
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("myFinanceDbFileModel.TransactionContact", "Contact").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("myFinanceDbFileModel.TransactionContact", "Contact").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Contact> ContactReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("myFinanceDbFileModel.TransactionContact", "Contact");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Contact>("myFinanceDbFileModel.TransactionContact", "Contact", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("myFinanceDbFileModel", "UserTransaction", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("myFinanceDbFileModel.UserTransaction", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("myFinanceDbFileModel.UserTransaction", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("myFinanceDbFileModel.UserTransaction", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("myFinanceDbFileModel.UserTransaction", "User", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="myFinanceDbFileModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username">Initial value of the username property.</param>
        /// <param name="password">Initial value of the password property.</param>
        public static User CreateUser(global::System.Int32 id, global::System.String username, global::System.String password)
        {
            User user = new User();
            user.Id = id;
            user.username = username;
            user.password = password;
            return user;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String username
        {
            get
            {
                return _username;
            }
            set
            {
                OnusernameChanging(value);
                ReportPropertyChanging("username");
                _username = StructuralObject.SetValidValue(value, false, "username");
                ReportPropertyChanged("username");
                OnusernameChanged();
            }
        }
        private global::System.String _username;
        partial void OnusernameChanging(global::System.String value);
        partial void OnusernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                OnpasswordChanging(value);
                ReportPropertyChanging("password");
                _password = StructuralObject.SetValidValue(value, false, "password");
                ReportPropertyChanged("password");
                OnpasswordChanged();
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("myFinanceDbFileModel", "UserEvent", "Event")]
        public EntityCollection<Event> Events
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Event>("myFinanceDbFileModel.UserEvent", "Event");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Event>("myFinanceDbFileModel.UserEvent", "Event", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("myFinanceDbFileModel", "UserTransaction", "Transaction")]
        public EntityCollection<Transaction> Transactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Transaction>("myFinanceDbFileModel.UserTransaction", "Transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Transaction>("myFinanceDbFileModel.UserTransaction", "Transaction", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
