
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectPropertiesModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Page Object Properties"
        Public Const contentTableName As String = "apiPageObjectProperties"
        Private Shadows Const contentDataSource As String = "default"
        '
        '====================================================================================================
        '
        ' -- instance properties
        Public Property description As String
        Public Property propertyTypeId As Integer
        Public Property deprecated As Boolean
        Public Property getAndSet As Boolean
        Public Property notAbstract As Boolean
        Public Property declarationOnly As Boolean
        Public Property propertyEqualsValue As Boolean
        Public Property equalsValue As String
        '
    End Class
End Namespace
