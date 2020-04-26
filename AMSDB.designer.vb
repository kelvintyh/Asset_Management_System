﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="AMSDB")>
Partial Public Class AMSDBDataContext
    Inherits System.Data.Linq.DataContext

    Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

#Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertAsset(instance As Asset)
    End Sub
    Partial Private Sub UpdateAsset(instance As Asset)
    End Sub
    Partial Private Sub DeleteAsset(instance As Asset)
    End Sub
    Partial Private Sub InsertAssetType(instance As AssetType)
    End Sub
    Partial Private Sub UpdateAssetType(instance As AssetType)
    End Sub
    Partial Private Sub DeleteAssetType(instance As AssetType)
    End Sub
    Partial Private Sub InsertInventoryLocation(instance As InventoryLocation)
    End Sub
    Partial Private Sub UpdateInventoryLocation(instance As InventoryLocation)
    End Sub
    Partial Private Sub DeleteInventoryLocation(instance As InventoryLocation)
    End Sub
    Partial Private Sub InsertManufacturer(instance As Manufacturer)
    End Sub
    Partial Private Sub UpdateManufacturer(instance As Manufacturer)
    End Sub
    Partial Private Sub DeleteManufacturer(instance As Manufacturer)
    End Sub
    Partial Private Sub InsertWarranty(instance As Warranty)
    End Sub
    Partial Private Sub UpdateWarranty(instance As Warranty)
    End Sub
    Partial Private Sub DeleteWarranty(instance As Warranty)
    End Sub
#End Region

    Public Sub New()
        MyBase.New(Global.Asset_Management_System.My.MySettings.Default.AMSDBConnectionString, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As String)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public ReadOnly Property Assets() As System.Data.Linq.Table(Of Asset)
        Get
            Return Me.GetTable(Of Asset)
        End Get
    End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Asset")>
Partial Public Class Asset
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _Id As String

    Private _Description As String

    Private _Manufacturer As String

    Private _Asset_type As String

    Private _Model As String

    Private _Serial_number As String

    Private _Condition As String

    Private _Status As String

    Private _Inventory_location As String

    Private _Image As System.Data.Linq.Binary

    Private _Date_of_acquisition As System.Nullable(Of Date)

    Private _Vendor As String

    Private _Value_At_Acquisition As System.Nullable(Of Decimal)

    Private _Invoice As String

    Private _WarrantyId As String

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As String)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnDescriptionChanged()
    End Sub
    Partial Private Sub OnManufacturerChanging(value As String)
    End Sub
    Partial Private Sub OnManufacturerChanged()
    End Sub
    Partial Private Sub OnAsset_typeChanging(value As String)
    End Sub
    Partial Private Sub OnAsset_typeChanged()
    End Sub
    Partial Private Sub OnModelChanging(value As String)
    End Sub
    Partial Private Sub OnModelChanged()
    End Sub
    Partial Private Sub OnSerial_numberChanging(value As String)
    End Sub
    Partial Private Sub OnSerial_numberChanged()
    End Sub
    Partial Private Sub OnConditionChanging(value As String)
    End Sub
    Partial Private Sub OnConditionChanged()
    End Sub
    Partial Private Sub OnStatusChanging(value As String)
    End Sub
    Partial Private Sub OnStatusChanged()
    End Sub
    Partial Private Sub OnInventory_locationChanging(value As String)
    End Sub
    Partial Private Sub OnInventory_locationChanged()
    End Sub
    Partial Private Sub OnImageChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnImageChanged()
    End Sub
    Partial Private Sub OnDate_of_acquisitionChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDate_of_acquisitionChanged()
    End Sub
    Partial Private Sub OnVendorChanging(value As String)
    End Sub
    Partial Private Sub OnVendorChanged()
    End Sub
    Partial Private Sub OnValue_At_AcquisitionChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnValue_At_AcquisitionChanged()
    End Sub
    Partial Private Sub OnInvoiceChanging(value As String)
    End Sub
    Partial Private Sub OnInvoiceChanged()
    End Sub
    Partial Private Sub OnWarrantyIdChanging(value As String)
    End Sub
    Partial Private Sub OnWarrantyIdChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="VarChar(10) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)>
    Public Property Id() As String
        Get
            Return Me._Id
        End Get
        Set
            If (String.Equals(Me._Id, Value) = False) Then
                Me.OnIdChanging(Value)
                Me.SendPropertyChanging()
                Me._Id = Value
                Me.SendPropertyChanged("Id")
                Me.OnIdChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="VarChar(50)")>
    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set
            If (String.Equals(Me._Description, Value) = False) Then
                Me.OnDescriptionChanging(Value)
                Me.SendPropertyChanging()
                Me._Description = Value
                Me.SendPropertyChanged("Description")
                Me.OnDescriptionChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Manufacturer", DbType:="VarChar(50)")>
    Public Property Manufacturer() As String
        Get
            Return Me._Manufacturer
        End Get
        Set
            If (String.Equals(Me._Manufacturer, Value) = False) Then
                Me.OnManufacturerChanging(Value)
                Me.SendPropertyChanging()
                Me._Manufacturer = Value
                Me.SendPropertyChanged("Manufacturer")
                Me.OnManufacturerChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Asset type]", Storage:="_Asset_type", DbType:="VarChar(50)")>
    Public Property Asset_type() As String
        Get
            Return Me._Asset_type
        End Get
        Set
            If (String.Equals(Me._Asset_type, Value) = False) Then
                Me.OnAsset_typeChanging(Value)
                Me.SendPropertyChanging()
                Me._Asset_type = Value
                Me.SendPropertyChanged("Asset_type")
                Me.OnAsset_typeChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Model", DbType:="VarChar(50)")>
    Public Property Model() As String
        Get
            Return Me._Model
        End Get
        Set
            If (String.Equals(Me._Model, Value) = False) Then
                Me.OnModelChanging(Value)
                Me.SendPropertyChanging()
                Me._Model = Value
                Me.SendPropertyChanged("Model")
                Me.OnModelChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Serial number]", Storage:="_Serial_number", DbType:="VarChar(50)")>
    Public Property Serial_number() As String
        Get
            Return Me._Serial_number
        End Get
        Set
            If (String.Equals(Me._Serial_number, Value) = False) Then
                Me.OnSerial_numberChanging(Value)
                Me.SendPropertyChanging()
                Me._Serial_number = Value
                Me.SendPropertyChanged("Serial_number")
                Me.OnSerial_numberChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Condition", DbType:="VarChar(50)")>
    Public Property Condition() As String
        Get
            Return Me._Condition
        End Get
        Set
            If (String.Equals(Me._Condition, Value) = False) Then
                Me.OnConditionChanging(Value)
                Me.SendPropertyChanging()
                Me._Condition = Value
                Me.SendPropertyChanged("Condition")
                Me.OnConditionChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Status", DbType:="VarChar(50)")>
    Public Property Status() As String
        Get
            Return Me._Status
        End Get
        Set
            If (String.Equals(Me._Status, Value) = False) Then
                Me.OnStatusChanging(Value)
                Me.SendPropertyChanging()
                Me._Status = Value
                Me.SendPropertyChanged("Status")
                Me.OnStatusChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Inventory location]", Storage:="_Inventory_location", DbType:="VarChar(50)")>
    Public Property Inventory_location() As String
        Get
            Return Me._Inventory_location
        End Get
        Set
            If (String.Equals(Me._Inventory_location, Value) = False) Then
                Me.OnInventory_locationChanging(Value)
                Me.SendPropertyChanging()
                Me._Inventory_location = Value
                Me.SendPropertyChanged("Inventory_location")
                Me.OnInventory_locationChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Image", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>
    Public Property Image() As System.Data.Linq.Binary
        Get
            Return Me._Image
        End Get
        Set
            If (Object.Equals(Me._Image, Value) = False) Then
                Me.OnImageChanging(Value)
                Me.SendPropertyChanging()
                Me._Image = Value
                Me.SendPropertyChanged("Image")
                Me.OnImageChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Date of acquisition]", Storage:="_Date_of_acquisition", DbType:="Date")>
    Public Property Date_of_acquisition() As System.Nullable(Of Date)
        Get
            Return Me._Date_of_acquisition
        End Get
        Set
            If (Me._Date_of_acquisition.Equals(Value) = False) Then
                Me.OnDate_of_acquisitionChanging(Value)
                Me.SendPropertyChanging()
                Me._Date_of_acquisition = Value
                Me.SendPropertyChanged("Date_of_acquisition")
                Me.OnDate_of_acquisitionChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Vendor", DbType:="VarChar(50)")>
    Public Property Vendor() As String
        Get
            Return Me._Vendor
        End Get
        Set
            If (String.Equals(Me._Vendor, Value) = False) Then
                Me.OnVendorChanging(Value)
                Me.SendPropertyChanging()
                Me._Vendor = Value
                Me.SendPropertyChanged("Vendor")
                Me.OnVendorChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Value At Acquisition]", Storage:="_Value_At_Acquisition", DbType:="Decimal(18,0)")>
    Public Property Value_At_Acquisition() As System.Nullable(Of Decimal)
        Get
            Return Me._Value_At_Acquisition
        End Get
        Set
            If (Me._Value_At_Acquisition.Equals(Value) = False) Then
                Me.OnValue_At_AcquisitionChanging(Value)
                Me.SendPropertyChanging()
                Me._Value_At_Acquisition = Value
                Me.SendPropertyChanged("Value_At_Acquisition")
                Me.OnValue_At_AcquisitionChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Invoice", DbType:="VarChar(50)")>
    Public Property Invoice() As String
        Get
            Return Me._Invoice
        End Get
        Set
            If (String.Equals(Me._Invoice, Value) = False) Then
                Me.OnInvoiceChanging(Value)
                Me.SendPropertyChanging()
                Me._Invoice = Value
                Me.SendPropertyChanged("Invoice")
                Me.OnInvoiceChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WarrantyId", DbType:="VarChar(10)")>
    Public Property WarrantyId() As String
        Get
            Return Me._WarrantyId
        End Get
        Set
            If (String.Equals(Me._WarrantyId, Value) = False) Then
                Me.OnWarrantyIdChanging(Value)
                Me.SendPropertyChanging()
                Me._WarrantyId = Value
                Me.SendPropertyChanged("WarrantyId")
                Me.OnWarrantyIdChanged()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AssetType")>
Partial Public Class AssetType
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _Id As String

    Private _Description As String

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As String)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnDescriptionChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="VarChar(10) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)>
    Public Property Id() As String
        Get
            Return Me._Id
        End Get
        Set
            If (String.Equals(Me._Id, Value) = False) Then
                Me.OnIdChanging(Value)
                Me.SendPropertyChanging()
                Me._Id = Value
                Me.SendPropertyChanged("Id")
                Me.OnIdChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="VarChar(50)")>
    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set
            If (String.Equals(Me._Description, Value) = False) Then
                Me.OnDescriptionChanging(Value)
                Me.SendPropertyChanging()
                Me._Description = Value
                Me.SendPropertyChanged("Description")
                Me.OnDescriptionChanged()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.InventoryLocation")>
Partial Public Class InventoryLocation
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _Id As String

    Private _Name_ As String

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As String)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnName_Changing(value As String)
    End Sub
    Partial Private Sub OnName_Changed()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="VarChar(10) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)>
    Public Property Id() As String
        Get
            Return Me._Id
        End Get
        Set
            If (String.Equals(Me._Id, Value) = False) Then
                Me.OnIdChanging(Value)
                Me.SendPropertyChanging()
                Me._Id = Value
                Me.SendPropertyChanged("Id")
                Me.OnIdChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Name ]", Storage:="_Name_", DbType:="VarChar(50)")>
    Public Property Name_() As String
        Get
            Return Me._Name_
        End Get
        Set
            If (String.Equals(Me._Name_, Value) = False) Then
                Me.OnName_Changing(Value)
                Me.SendPropertyChanging()
                Me._Name_ = Value
                Me.SendPropertyChanged("Name_")
                Me.OnName_Changed()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Manufacturer")>
Partial Public Class Manufacturer
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _Id As String

    Private _Name As String

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As String)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="VarChar(10) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)>
    Public Property Id() As String
        Get
            Return Me._Id
        End Get
        Set
            If (String.Equals(Me._Id, Value) = False) Then
                Me.OnIdChanging(Value)
                Me.SendPropertyChanging()
                Me._Id = Value
                Me.SendPropertyChanged("Id")
                Me.OnIdChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(50)")>
    Public Property Name() As String
        Get
            Return Me._Name
        End Get
        Set
            If (String.Equals(Me._Name, Value) = False) Then
                Me.OnNameChanging(Value)
                Me.SendPropertyChanging()
                Me._Name = Value
                Me.SendPropertyChanged("Name")
                Me.OnNameChanged()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Warranty")>
Partial Public Class Warranty
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _Warranty_Id As String

    Private _Warranty_Name As String

    Private _Warranty_Type As String

    Private _Warranty_Start As System.Nullable(Of Date)

    Private _Warranty_End As System.Nullable(Of Date)

    Private _Warranty_Status As String

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnWarranty_IdChanging(value As String)
    End Sub
    Partial Private Sub OnWarranty_IdChanged()
    End Sub
    Partial Private Sub OnWarranty_NameChanging(value As String)
    End Sub
    Partial Private Sub OnWarranty_NameChanged()
    End Sub
    Partial Private Sub OnWarranty_TypeChanging(value As String)
    End Sub
    Partial Private Sub OnWarranty_TypeChanged()
    End Sub
    Partial Private Sub OnWarranty_StartChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnWarranty_StartChanged()
    End Sub
    Partial Private Sub OnWarranty_EndChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnWarranty_EndChanged()
    End Sub
    Partial Private Sub OnWarranty_StatusChanging(value As String)
    End Sub
    Partial Private Sub OnWarranty_StatusChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Warranty Id]", Storage:="_Warranty_Id", DbType:="VarChar(10) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)>
    Public Property Warranty_Id() As String
        Get
            Return Me._Warranty_Id
        End Get
        Set
            If (String.Equals(Me._Warranty_Id, Value) = False) Then
                Me.OnWarranty_IdChanging(Value)
                Me.SendPropertyChanging()
                Me._Warranty_Id = Value
                Me.SendPropertyChanged("Warranty_Id")
                Me.OnWarranty_IdChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Warranty Name]", Storage:="_Warranty_Name", DbType:="VarChar(50)")>
    Public Property Warranty_Name() As String
        Get
            Return Me._Warranty_Name
        End Get
        Set
            If (String.Equals(Me._Warranty_Name, Value) = False) Then
                Me.OnWarranty_NameChanging(Value)
                Me.SendPropertyChanging()
                Me._Warranty_Name = Value
                Me.SendPropertyChanged("Warranty_Name")
                Me.OnWarranty_NameChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Warranty Type]", Storage:="_Warranty_Type", DbType:="VarChar(50)")>
    Public Property Warranty_Type() As String
        Get
            Return Me._Warranty_Type
        End Get
        Set
            If (String.Equals(Me._Warranty_Type, Value) = False) Then
                Me.OnWarranty_TypeChanging(Value)
                Me.SendPropertyChanging()
                Me._Warranty_Type = Value
                Me.SendPropertyChanged("Warranty_Type")
                Me.OnWarranty_TypeChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Warranty Start]", Storage:="_Warranty_Start", DbType:="Date")>
    Public Property Warranty_Start() As System.Nullable(Of Date)
        Get
            Return Me._Warranty_Start
        End Get
        Set
            If (Me._Warranty_Start.Equals(Value) = False) Then
                Me.OnWarranty_StartChanging(Value)
                Me.SendPropertyChanging()
                Me._Warranty_Start = Value
                Me.SendPropertyChanged("Warranty_Start")
                Me.OnWarranty_StartChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Warranty End]", Storage:="_Warranty_End", DbType:="Date")>
    Public Property Warranty_End() As System.Nullable(Of Date)
        Get
            Return Me._Warranty_End
        End Get
        Set
            If (Me._Warranty_End.Equals(Value) = False) Then
                Me.OnWarranty_EndChanging(Value)
                Me.SendPropertyChanging()
                Me._Warranty_End = Value
                Me.SendPropertyChanged("Warranty_End")
                Me.OnWarranty_EndChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Warranty Status]", Storage:="_Warranty_Status", DbType:="VarChar(10)")>
    Public Property Warranty_Status() As String
        Get
            Return Me._Warranty_Status
        End Get
        Set
            If (String.Equals(Me._Warranty_Status, Value) = False) Then
                Me.OnWarranty_StatusChanging(Value)
                Me.SendPropertyChanging()
                Me._Warranty_Status = Value
                Me.SendPropertyChanged("Warranty_Status")
                Me.OnWarranty_StatusChanged()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class
