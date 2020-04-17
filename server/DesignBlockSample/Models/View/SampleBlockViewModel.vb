Imports Contensive.Addons.DesignBlockSample.Controllers
Imports Contensive.BaseClasses


Namespace Models.View
    Public Class SampleBlockViewModel
        Inherits ViewBaseModel
        '
        Public Property headline As String
        Public Property description As String
        '
        '====================================================================================================
        ''' <summary>
        ''' Populate the view model from the db model data. The view model matches the view's data. The data model matches the Db
        ''' </summary>
        ''' <param name="cp"></param>
        ''' <param name="settings"></param>
        ''' <returns></returns>
        Public Overloads Shared Function create(cp As CPBaseClass, settings As Models.Db.SampleBlockSettingsModel) As SampleBlockViewModel
            Try
                '
                ' -- base fields
                Dim result = ViewBaseModel.create(Of SampleBlockViewModel)(cp, settings)
                '
                result.headline = settings.headline
                result.description = settings.description
                '
                Return result
            Catch ex As Exception
                cp.Site.ErrorReport(ex)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace