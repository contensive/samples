
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectEnumsModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Page Object Enums"
        Public Const contentTableName As String = "apiPageObjectEnums"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        '
        ' -- instance properties
        Public Property description As String
        Public Property deprecated As Boolean
        '
    End Class
End Namespace
