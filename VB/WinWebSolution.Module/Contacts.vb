Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	<DefaultClassOptions, System.ComponentModel.DisplayName("Contacts")> _
	Public MustInherit Class ContactBase
		Inherits Person
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private activeCore As Boolean
		Public Property Active() As Boolean
			Get
				Return activeCore
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue("Active", activeCore, value)
			End Set
		End Property
	End Class
	Public Class ContactType1
		Inherits ContactBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private contactType1PropertyCore As String
		Public Property ContactType1Property() As String
			Get
				Return contactType1PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactType1Property", contactType1PropertyCore, value)
			End Set
		End Property
	End Class
	Public Class ContactType2
		Inherits ContactBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private contactType2PropertyCore As String
		Public Property ContactType2Property() As String
			Get
				Return contactType2PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactType2Property", contactType2PropertyCore, value)
			End Set
		End Property
	End Class
End Namespace