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

namespace OrderToAloha
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AlohaGallery")]
	public partial class OrdersDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrderItem(OrderItem instance);
    partial void UpdateOrderItem(OrderItem instance);
    partial void DeleteOrderItem(OrderItem instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public OrdersDbDataContext() : 
				base(global::OrderToAloha.Properties.Settings.Default.AlohaGalleryConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrdersDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<OrderItem> OrderItems
		{
			get
			{
				return this.GetTable<OrderItem>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderItems")]
	public partial class OrderItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _OrderId;
		
		private System.Nullable<int> _Barcode;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<bool> _Deleted;
		
		private System.Nullable<int> _EntryId;
		
		private System.Nullable<decimal> _OriginalPrice;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOrderIdChanging(System.Nullable<int> value);
    partial void OnOrderIdChanged();
    partial void OnBarcodeChanging(System.Nullable<int> value);
    partial void OnBarcodeChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnDeletedChanging(System.Nullable<bool> value);
    partial void OnDeletedChanged();
    partial void OnEntryIdChanging(System.Nullable<int> value);
    partial void OnEntryIdChanged();
    partial void OnOriginalPriceChanging(System.Nullable<decimal> value);
    partial void OnOriginalPriceChanged();
    #endregion
		
		public OrderItem()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int")]
		public System.Nullable<int> OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Barcode", DbType="Int")]
		public System.Nullable<int> Barcode
		{
			get
			{
				return this._Barcode;
			}
			set
			{
				if ((this._Barcode != value))
				{
					this.OnBarcodeChanging(value);
					this.SendPropertyChanging();
					this._Barcode = value;
					this.SendPropertyChanged("Barcode");
					this.OnBarcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deleted", DbType="Bit")]
		public System.Nullable<bool> Deleted
		{
			get
			{
				return this._Deleted;
			}
			set
			{
				if ((this._Deleted != value))
				{
					this.OnDeletedChanging(value);
					this.SendPropertyChanging();
					this._Deleted = value;
					this.SendPropertyChanged("Deleted");
					this.OnDeletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntryId", DbType="Int")]
		public System.Nullable<int> EntryId
		{
			get
			{
				return this._EntryId;
			}
			set
			{
				if ((this._EntryId != value))
				{
					this.OnEntryIdChanging(value);
					this.SendPropertyChanging();
					this._EntryId = value;
					this.SendPropertyChanged("EntryId");
					this.OnEntryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OriginalPrice", DbType="Money")]
		public System.Nullable<decimal> OriginalPrice
		{
			get
			{
				return this._OriginalPrice;
			}
			set
			{
				if ((this._OriginalPrice != value))
				{
					this.OnOriginalPriceChanging(value);
					this.SendPropertyChanging();
					this._OriginalPrice = value;
					this.SendPropertyChanged("OriginalPrice");
					this.OnOriginalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_Order", ThisKey="OrderId", OtherKey="Id", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderItems.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderItems.Add(this);
						this._OrderId = value.Id;
					}
					else
					{
						this._OrderId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _StNum;
		
		private System.Nullable<int> _AlohaNumber;
		
		private System.Nullable<int> _CompanyId;
		
		private string _CompanyName;
		
		private string _BortName;
		
		private System.Nullable<decimal> _Summ;
		
		private string _AlohaTable;
		
		private System.Nullable<decimal> _ComplexDisc;
		
		private System.Nullable<int> _StDiscId;
		
		private System.Nullable<System.DateTime> _OpenTime;
		
		private System.Nullable<System.DateTime> _TimeofShipping;
		
		private System.Nullable<int> _OrderDiscId;
		
		private int _Id;
		
		private System.Nullable<bool> _Closed;
		
		private System.Nullable<System.DateTime> _TimeOfClose;
		
		private System.Nullable<int> _Margin;
		
		private EntitySet<OrderItem> _OrderItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStNumChanging(System.Nullable<int> value);
    partial void OnStNumChanged();
    partial void OnAlohaNumberChanging(System.Nullable<int> value);
    partial void OnAlohaNumberChanged();
    partial void OnCompanyIdChanging(System.Nullable<int> value);
    partial void OnCompanyIdChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnBortNameChanging(string value);
    partial void OnBortNameChanged();
    partial void OnSummChanging(System.Nullable<decimal> value);
    partial void OnSummChanged();
    partial void OnAlohaTableChanging(string value);
    partial void OnAlohaTableChanged();
    partial void OnComplexDiscChanging(System.Nullable<decimal> value);
    partial void OnComplexDiscChanged();
    partial void OnStDiscIdChanging(System.Nullable<int> value);
    partial void OnStDiscIdChanged();
    partial void OnOpenTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnOpenTimeChanged();
    partial void OnTimeofShippingChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeofShippingChanged();
    partial void OnOrderDiscIdChanging(System.Nullable<int> value);
    partial void OnOrderDiscIdChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnClosedChanging(System.Nullable<bool> value);
    partial void OnClosedChanged();
    partial void OnTimeOfCloseChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeOfCloseChanged();
    partial void OnMarginChanging(System.Nullable<int> value);
    partial void OnMarginChanged();
    #endregion
		
		public Order()
		{
			this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StNum", DbType="Int")]
		public System.Nullable<int> StNum
		{
			get
			{
				return this._StNum;
			}
			set
			{
				if ((this._StNum != value))
				{
					this.OnStNumChanging(value);
					this.SendPropertyChanging();
					this._StNum = value;
					this.SendPropertyChanged("StNum");
					this.OnStNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlohaNumber", DbType="Int")]
		public System.Nullable<int> AlohaNumber
		{
			get
			{
				return this._AlohaNumber;
			}
			set
			{
				if ((this._AlohaNumber != value))
				{
					this.OnAlohaNumberChanging(value);
					this.SendPropertyChanging();
					this._AlohaNumber = value;
					this.SendPropertyChanged("AlohaNumber");
					this.OnAlohaNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyId", DbType="Int")]
		public System.Nullable<int> CompanyId
		{
			get
			{
				return this._CompanyId;
			}
			set
			{
				if ((this._CompanyId != value))
				{
					this.OnCompanyIdChanging(value);
					this.SendPropertyChanging();
					this._CompanyId = value;
					this.SendPropertyChanged("CompanyId");
					this.OnCompanyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(50)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BortName", DbType="NVarChar(50)")]
		public string BortName
		{
			get
			{
				return this._BortName;
			}
			set
			{
				if ((this._BortName != value))
				{
					this.OnBortNameChanging(value);
					this.SendPropertyChanging();
					this._BortName = value;
					this.SendPropertyChanged("BortName");
					this.OnBortNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Summ", DbType="Money")]
		public System.Nullable<decimal> Summ
		{
			get
			{
				return this._Summ;
			}
			set
			{
				if ((this._Summ != value))
				{
					this.OnSummChanging(value);
					this.SendPropertyChanging();
					this._Summ = value;
					this.SendPropertyChanged("Summ");
					this.OnSummChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlohaTable", DbType="NVarChar(50)")]
		public string AlohaTable
		{
			get
			{
				return this._AlohaTable;
			}
			set
			{
				if ((this._AlohaTable != value))
				{
					this.OnAlohaTableChanging(value);
					this.SendPropertyChanging();
					this._AlohaTable = value;
					this.SendPropertyChanged("AlohaTable");
					this.OnAlohaTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComplexDisc", DbType="Money")]
		public System.Nullable<decimal> ComplexDisc
		{
			get
			{
				return this._ComplexDisc;
			}
			set
			{
				if ((this._ComplexDisc != value))
				{
					this.OnComplexDiscChanging(value);
					this.SendPropertyChanging();
					this._ComplexDisc = value;
					this.SendPropertyChanged("ComplexDisc");
					this.OnComplexDiscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StDiscId", DbType="Int")]
		public System.Nullable<int> StDiscId
		{
			get
			{
				return this._StDiscId;
			}
			set
			{
				if ((this._StDiscId != value))
				{
					this.OnStDiscIdChanging(value);
					this.SendPropertyChanging();
					this._StDiscId = value;
					this.SendPropertyChanged("StDiscId");
					this.OnStDiscIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpenTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> OpenTime
		{
			get
			{
				return this._OpenTime;
			}
			set
			{
				if ((this._OpenTime != value))
				{
					this.OnOpenTimeChanging(value);
					this.SendPropertyChanging();
					this._OpenTime = value;
					this.SendPropertyChanged("OpenTime");
					this.OnOpenTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeofShipping", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeofShipping
		{
			get
			{
				return this._TimeofShipping;
			}
			set
			{
				if ((this._TimeofShipping != value))
				{
					this.OnTimeofShippingChanging(value);
					this.SendPropertyChanging();
					this._TimeofShipping = value;
					this.SendPropertyChanged("TimeofShipping");
					this.OnTimeofShippingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDiscId", DbType="Int")]
		public System.Nullable<int> OrderDiscId
		{
			get
			{
				return this._OrderDiscId;
			}
			set
			{
				if ((this._OrderDiscId != value))
				{
					this.OnOrderDiscIdChanging(value);
					this.SendPropertyChanging();
					this._OrderDiscId = value;
					this.SendPropertyChanged("OrderDiscId");
					this.OnOrderDiscIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Closed", DbType="Bit")]
		public System.Nullable<bool> Closed
		{
			get
			{
				return this._Closed;
			}
			set
			{
				if ((this._Closed != value))
				{
					this.OnClosedChanging(value);
					this.SendPropertyChanging();
					this._Closed = value;
					this.SendPropertyChanged("Closed");
					this.OnClosedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeOfClose", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeOfClose
		{
			get
			{
				return this._TimeOfClose;
			}
			set
			{
				if ((this._TimeOfClose != value))
				{
					this.OnTimeOfCloseChanging(value);
					this.SendPropertyChanging();
					this._TimeOfClose = value;
					this.SendPropertyChanged("TimeOfClose");
					this.OnTimeOfCloseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Margin", DbType="Int")]
		public System.Nullable<int> Margin
		{
			get
			{
				return this._Margin;
			}
			set
			{
				if ((this._Margin != value))
				{
					this.OnMarginChanging(value);
					this.SendPropertyChanging();
					this._Margin = value;
					this.SendPropertyChanged("Margin");
					this.OnMarginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_OrderItems", ThisKey="Id", OtherKey="OrderId")]
		public EntitySet<OrderItem> OrderItems
		{
			get
			{
				return this._OrderItems;
			}
			set
			{
				this._OrderItems.Assign(value);
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
		
		private void attach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
}
#pragma warning restore 1591