
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class SampleBlockSettingsModel
        Inherits DbBaseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "Sample Block Settings"
        Public Const contentTableName As String = "dbSampleBlockSettings"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        ' -- instance properties
        Public Property headline As String
        Public Property description As String
        '
        '====================================================================================================
        Public Overloads Shared Function createOrAddSettings(cp As CPBaseClass, settingsGuid As String) As SampleBlockSettingsModel
            Dim result As SampleBlockSettingsModel = create(Of SampleBlockSettingsModel)(cp, settingsGuid)
            If (result Is Nothing) Then
                '
                ' -- create default content
                result = DbBaseModel.add(Of SampleBlockSettingsModel)(cp)
                result.name = contentName & " Instance " & result.id & ", created " & Now.ToString()
                result.ccguid = settingsGuid
                result.fontStyleId = 0
                result.themeStyleId = 0
                result.padTop = False
                result.padBottom = False
                result.padRight = False
                result.padLeft = False
                '
                ' -- create custom content
                result.headline = "Lorem Ipsum Dolor"
                result.description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>"
                '
                result.save(cp)
            End If
            Return result
        End Function
    End Class
End Namespace
