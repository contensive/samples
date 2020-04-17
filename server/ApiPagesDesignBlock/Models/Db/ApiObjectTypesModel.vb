
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiObjectTypesModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Object Types"
        Public Const contentTableName As String = "apiObjectTypes"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        '
        ' -- instance properties
        Public Property description As String
        '
    End Class
End Namespace
