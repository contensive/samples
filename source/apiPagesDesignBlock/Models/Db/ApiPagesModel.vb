

Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPagesModel
        Inherits DbBaseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Pages"
        Public Const contentTableName As String = "apiPages"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        ' -- instance properties
        'instancePropertiesGoHere
        ' sample instance property -- Public Property DataSourceID As Integer
        '
        '====================================================================================================
        Public Overloads Shared Function add(cp As CPBaseClass) As ApiPagesModel
            Return add(Of ApiPagesModel)(cp)
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function create(cp As CPBaseClass, recordId As Integer) As ApiPagesModel
            Return create(Of ApiPagesModel)(cp, recordId)
        End Function

        Public Overloads Shared Function createOrAddSettings(cp As CPBaseClass, settingsGuid As String) As ApiPagesModel
            Dim result As ApiPagesModel = create(Of ApiPagesModel)(cp, settingsGuid)
            If (result Is Nothing) Then
                '
                ' -- create default content
                result = DbBaseModel.add(Of ApiPagesModel)(cp)
                result.name = contentName & " Instance " & result.id & ", created " & Now.ToString()
                result.ccguid = settingsGuid
                result.fontStyleId = 0
                result.themeStyleId = 0
                result.padTop = False
                result.padBottom = False
                result.padRight = False
                result.padLeft = False
                '
                '
                result.save(cp)
            End If
            Return result
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function create(cp As CPBaseClass, recordGuid As String) As ApiPagesModel
            Return create(Of ApiPagesModel)(cp, recordGuid)
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function createByName(cp As CPBaseClass, recordName As String) As ApiPagesModel
            Return createByName(Of ApiPagesModel)(cp, recordName)
        End Function
        '
        '====================================================================================================
        Public Overloads Sub save(cp As CPBaseClass)
            MyBase.save(cp)
        End Sub
        '
        '====================================================================================================
        Public Overloads Shared Sub delete(cp As CPBaseClass, recordId As Integer)
            delete(Of ApiPagesModel)(cp, recordId)
        End Sub
        '
        '====================================================================================================
        Public Overloads Shared Sub delete(cp As CPBaseClass, ccGuid As String)
            delete(Of ApiPagesModel)(cp, ccGuid)
        End Sub
        '
        '====================================================================================================
        Public Overloads Shared Function createList(cp As CPBaseClass, sqlCriteria As String, Optional sqlOrderBy As String = "id") As List(Of ApiPagesModel)
            Return createList(Of ApiPagesModel)(cp, sqlCriteria, sqlOrderBy)
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function getRecordName(cp As CPBaseClass, recordId As Integer) As String
            Return baseModel.getRecordName(Of ApiPagesModel)(cp, recordId)
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function getRecordName(cp As CPBaseClass, ccGuid As String) As String
            Return baseModel.getRecordName(Of ApiPagesModel)(cp, ccGuid)
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function getRecordId(cp As CPBaseClass, ccGuid As String) As Integer
            Return baseModel.getRecordId(Of ApiPagesModel)(cp, ccGuid)
        End Function
        '
        '====================================================================================================
        Public Overloads Shared Function getCount(cp As CPBaseClass, sqlCriteria As String) As Integer
            Return baseModel.getCount(Of ApiPagesModel)(cp, sqlCriteria)
        End Function
        '
        '====================================================================================================
        Public Overloads Function getUploadPath(fieldName As String) As String
            Return MyBase.getUploadPath(Of ApiPagesModel)(fieldName)
        End Function

    End Class
End Namespace
