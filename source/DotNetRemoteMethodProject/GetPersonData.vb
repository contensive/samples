Option Explicit On
Option Strict On

Imports Contensive.BaseClasses

Public Class GetPersonData
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
        //
        // -- MS serializer used here for simplicity, but NewtonSoft Nuget package Is prefered
        Dim jsonSerializer As New Web.Script.Serialization.JavaScriptSerializer
        Try
            '
            ' -- create the data object to be returned
            Dim personData As New PersonDataModel With {
                .id = 1,
                .name = "Bob"
            }
            '
            ' -- add the data object to a response wrapper object just to standardize responses for js simplicity
            Dim response As New ResponseModel() With {
                .data = personData,
                .errors = New List(Of ResponseErrorModel) From {}
            }
            result = jsonSerializer.Serialize(response)
        Catch ex As Exception
            cp.Site.ErrorReport(ex)
        End Try
        Return result
    End Function
    '
    Public Class PersonDataModel
        Public name As String
        Public id As Integer
    End Class
    '
    Public Class ResponseErrorModel
        Public number As Integer
        Public userMsg As String
        Public detail As String
    End Class
    '
    Private Class ResponseModel
        Public data As PersonDataModel
        Public errors As List(Of ResponseErrorModel)
    End Class
End Class


