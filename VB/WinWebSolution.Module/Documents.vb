Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	<DefaultClassOptions, System.ComponentModel.DisplayName("Documents"), DefaultProperty("Name")> _
	Public MustInherit Class DocumentBase
		Inherits Note
		Protected Const AssignedToContactCriteriaBase As String = "Active=True"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private nameCore As String
		Public Property Name() As String
			Get
				Return nameCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", nameCore, value)
			End Set
		End Property
		Private createdByCore As ContactBase
		<DataSourceCriteria(AssignedToContactCriteriaBase)> _
		Public Property CreatedBy() As ContactBase
			Get
				Return createdByCore
			End Get
			Set(ByVal value As ContactBase)
				SetPropertyValue("CreatedBy", createdByCore, value)
			End Set
		End Property
		Private modifiedByCore As ContactBase
		<DataSourceProperty("ModifiedByCustomLookupDataSource")> _
		Public Property ModifiedBy() As ContactBase
			Get
				Return modifiedByCore
			End Get
			Set(ByVal value As ContactBase)
				SetPropertyValue("ModifiedBy", modifiedByCore, value)
			End Set
		End Property
		Private modifiedByCustomLookupDataSourceCore As XPCollection(Of ContactBase)
		Protected ReadOnly Property ModifiedByCustomLookupDataSource() As XPCollection(Of ContactBase)
			Get
				If modifiedByCustomLookupDataSourceCore Is Nothing Then
					modifiedByCustomLookupDataSourceCore = New XPCollection(Of ContactBase)(Session)
				End If
				RefreshModifiedByCustomLookupDataSource()
				Return modifiedByCustomLookupDataSourceCore
			End Get
		End Property
		Protected Overridable Sub RefreshModifiedByCustomLookupDataSource()
			modifiedByCustomLookupDataSourceCore.Criteria = ModifiedByContactCriteria
		End Sub
		Protected MustOverride ReadOnly Property ModifiedByContactCriteria() As CriteriaOperator
	End Class
	Public Class DocumentType1
		Inherits DocumentBase
		Protected Const AssignedToContactCriteria1 As String = "ObjectType.TypeName='WinWebSolution.Module.ContactType1'"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private documentType1PropertyCore As String
		Public Property DocumentType1Property() As String
			Get
				Return documentType1PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("DocumentType1Property", documentType1PropertyCore, value)
			End Set
		End Property
		<DataSourceCriteria(AssignedToContactCriteriaBase & " AND " & AssignedToContactCriteria1)> _
		Public Shadows Property CreatedBy() As ContactBase
			Get
				Return MyBase.CreatedBy
			End Get
			Set(ByVal value As ContactBase)
				MyBase.CreatedBy = value
			End Set
		End Property
		Protected Overrides ReadOnly Property ModifiedByContactCriteria() As CriteriaOperator
			Get
				Return CriteriaOperator.Parse(String.Format("{0} AND {1}", AssignedToContactCriteriaBase, AssignedToContactCriteria1))
			End Get
		End Property
	End Class
	Public Class DocumentType2
		Inherits DocumentBase
		Protected Const AssignedToContactCriteria2 As String = "ObjectType.TypeName='WinWebSolution.Module.ContactType2'"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private documentType2PropertyCore As String
		Public Property DocumentType2Property() As String
			Get
				Return documentType2PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("DocumentType2Property", documentType2PropertyCore, value)
			End Set
		End Property
		<DataSourceCriteria(AssignedToContactCriteriaBase & " AND " & AssignedToContactCriteria2)> _
		Public Shadows Property CreatedBy() As ContactBase
			Get
				Return MyBase.CreatedBy
			End Get
			Set(ByVal value As ContactBase)
				MyBase.CreatedBy = value
			End Set
		End Property
		Protected Overrides ReadOnly Property ModifiedByContactCriteria() As CriteriaOperator
			Get
				Return CriteriaOperator.Parse(String.Format("{0} AND {1}", AssignedToContactCriteriaBase, AssignedToContactCriteria2))
			End Get
		End Property
	End Class
End Namespace