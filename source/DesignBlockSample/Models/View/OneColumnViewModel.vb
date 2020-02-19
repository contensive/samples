Imports Contensive.Addons.DesignBlockSample.Controllers
Imports Contensive.BaseClasses

Namespace Models.View

    Public Class OneColumnViewModel
        Inherits ViewBaseModel
        '
        Public addonCol1 As String
        '
        '====================================================================================================
        ''' <summary>
        ''' Populate the view model from the entity model
        ''' </summary>
        ''' <param name="cp"></param>
        ''' <param name="settings"></param>
        ''' <returns></returns>
        Public Overloads Shared Function create(cp As CPBaseClass, settings As Db.DbOneColumnModel) As OneColumnViewModel
            Try
                '
                ' -- base fields
                Dim result = ViewBaseModel.create(Of OneColumnViewModel)(cp, settings)
                '
                ' -- custom
                result.addonCol1 = genericController.executeColumnAddon(cp, settings.addonforfirstcolumn, 1, settings.ccguid)
                Return result
            Catch ex As Exception
                cp.Site.ErrorReport(ex)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace