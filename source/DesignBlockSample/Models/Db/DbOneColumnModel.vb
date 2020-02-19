
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class DbOneColumnModel
        Inherits DbBaseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "DB One Column"
        Public Const contentTableName As String = "dbOneColumn"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        ' -- instance properties
        ''' <summary>
        ''' legacy field - leave to support older legacy mode
        ''' </summary>
        ''' <returns></returns>
        Public Property addonforfirstcolumn As Integer
        '
        '====================================================================================================
        Public Overloads Shared Function createOrAddSettings(cp As CPBaseClass, settingsGuid As String) As DbOneColumnModel
            Dim result As DbOneColumnModel = create(Of DbOneColumnModel)(cp, settingsGuid)
            If (result Is Nothing) Then
                '
                ' -- create default content
                result = DbBaseModel.add(Of DbOneColumnModel)(cp)
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
                result.addonforfirstcolumn = 0
                '
                result.save(cp)
            End If
            Return result
        End Function
    End Class
End Namespace
