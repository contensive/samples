
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectMethodReturnValueModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Object Method Return Value"
        Public Const contentTableName As String = "apiObjectMethodReturnValue"
        Private Shadows Const contentDataSource As String = "default"
        '====================================================================================================
        '
        ' -- instance properties
        Public Property description As String
        Public Property returnValueTypeId As Integer
        '
    End Class
End Namespace
