
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectEnumTypesModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Object Enum Types"
        Public Const contentTableName As String = "apiEnumTypes"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        '
        ' -- instance properties
        Public Property typeBlock As String
        Public Property deprecated As Boolean
        '
    End Class
End Namespace
