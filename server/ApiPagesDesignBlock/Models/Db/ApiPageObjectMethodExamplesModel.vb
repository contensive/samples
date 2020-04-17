
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Contensive.BaseClasses

Namespace Models.Db
    Public Class ApiPageObjectMethodExamplesModel
        Inherits baseModel
        '
        '====================================================================================================
        '-- const
        Public Const contentName As String = "API Page Object Examples"
        Public Const contentTableName As String = "apipageObjectExamples"
        Private Shadows Const contentDataSource As String = "default"
        '====================================================================================================
        '
        ' -- instance properties
        Public Property codeExample As String
        Public Property hideRunButton As Boolean
        '
    End Class
End Namespace
