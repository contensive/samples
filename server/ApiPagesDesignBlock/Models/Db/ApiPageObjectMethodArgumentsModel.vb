
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectMethodArgumentsModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Object Method Arguments"
        Public Const contentTableName As String = "apiObjectMethodArguments"
        Private Shadows Const contentDataSource As String = "default"
        '====================================================================================================
        '
        ' -- instance properties
        Public Property description As String
        Public Property argumentTypeId As Integer
        Public Property callByTypeId As Integer
        '
    End Class
End Namespace
