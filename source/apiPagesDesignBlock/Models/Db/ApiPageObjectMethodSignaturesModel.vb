
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectMethodSignaturesModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Object Method Signatures"
        Public Const contentTableName As String = "apiObjectMethodSignatures"
        Private Shadows Const contentDataSource As String = "default"
        '
        Public Property deprecated As Boolean
        '
    End Class
End Namespace
