﻿Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Xpo

Namespace E274.Module
	' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
	Public NotInheritable Partial Class E274Module
		Inherits ModuleBase

		Public Sub New()
			InitializeComponent()
			BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction
		End Sub
		Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
			Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
			Return New ModuleUpdater() { updater }
		End Function
		Public Overrides Sub Setup(ByVal application As XafApplication)
			MyBase.Setup(application)
			' Manage various aspects of the application UI and behavior at the module level.
		End Sub
		Public Overrides Sub CustomizeTypesInfo(ByVal typesInfo As ITypesInfo)
			MyBase.CustomizeTypesInfo(typesInfo)
			CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo)
		End Sub
	End Class
End Namespace
