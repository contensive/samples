Option Explicit On
Option Strict On

Imports Contensive.BaseClasses

Public Class DemoDotNetRemoteMethod
    Inherits AddonBaseClass
    '
    '=====================================================================================
    ''' <summary>
    ''' Demo Dot net Addon
    ''' </summary>
    ''' <param name="cp"></param>
    ''' <returns></returns>
    Public Overrides Function Execute(ByVal cp As CPBaseClass) As Object
        Dim result As String = ""
        Dim jsonSerializer As New Web.Script.Serialization.JavaScriptSerializer
        Try
            Dim person As New PersonData With {
                .id = 1,
                .name = "Bob"
            }
            Dim response As New ResponseModel() With {
                .data = person,
                .errors = New List(Of ResponseError) From {}
            }
            result = jsonSerializer.Serialize(response)
        Catch ex As Exception
            cp.Site.ErrorReport(ex)
        End Try
        Return result
    End Function
    '
    Public Class PersonData
        Public name As String
        Public id As Integer
    End Class
    '
    Public Class ResponseError
        Public number As Integer
        Public userMsg As String
        Public detail As String
        Public id As Integer
    End Class
    '
    Private Class ResponseModel
        Public data As PersonData
        Public errors As List(Of ResponseError)
    End Class
End Class
