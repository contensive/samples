
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Contensive.Addons.xxxxxCollectionNameSpaceGoesHerexxxxx.Models.Complex     '<------ set namespace
    Public Class xxxxxmodelNameGoesHerexxxxx        '<------ set set model Name and everywhere that matches this string
        Inherits baseComplexModel
        Implements ICloneable
        '
        '====================================================================================================
        '-- const
        Private Shadows Const contentDataSource As String = "default"             '<------ set to datasource if not default
        '
        '====================================================================================================
        ' -- instance properties
        Public Property samplePropertyFromQuery As String
        '
        '====================================================================================================
        Public Overloads Shared Function createList(cp As CPBaseClass, organizationId As Integer, Optional pageSize As Integer = 999999, Optional pageNumber As Integer = 1) As List(Of accreditationExportRawModel)
            Dim sql As String = My.Resources.ExportAccreditationSql.Replace("{0}", organizationId.ToString())
            Return createListFromSql(Of accreditationExportRawModel)(cp, sql, pageSize, pageNumber)
        End Function

    End Class
End Namespace
