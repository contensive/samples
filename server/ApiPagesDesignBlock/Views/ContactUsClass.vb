
Imports Contensive.Addons.apiPagesDesignBlock.Controllers
Imports Contensive.Addons.apiPagesDesignBlock.Models.Db
Imports Contensive.Addons.apiPagesDesignBlock.Models.View
Imports Contensive.BaseClasses

Namespace Views
    Public Class ContactUsClass
        Inherits AddonBaseClass
        '
        '====================================================================================================
        '
        Public Overrides Function Execute(ByVal CP As CPBaseClass) As Object
            Const designBlockName As String = "Contact Us Design Block"
            Try
                '
                ' -- read instanceId, guid created uniquely for this instance of the addon on a page
                Dim result = String.Empty
                Dim settingsGuid = InstanceIdController.getSettingsGuid(CP, designBlockName, result)
                If (String.IsNullOrEmpty(settingsGuid)) Then Return result
                '
                ' -- locate or create a data record for this guid
                Dim settings = DbContactUsModel.createOrAddSettings(CP, settingsGuid)
                If (settings Is Nothing) Then Throw New ApplicationException("Could not create the design block settings record.")
                '
                ' -- translate the Db model to a view model and mustache it into the layout
                Dim viewModel = ContactUsViewModel.create(CP, settings)
                If (viewModel Is Nothing) Then Throw New ApplicationException("Could not create design block view model.")
                '
                ' -- process form request
                Dim ptr As Integer = 0
                Dim request As New Request() With {
                    .blockContactFormButton = CP.Doc.GetText("blockContactFormButton" & settings.id),
                    .contactFirstName = CP.Doc.GetText("contactFirstName"),
                    .contactLastName = CP.Doc.GetText("contactLastName"),
                    .contactEmail = CP.Doc.GetText("contactEmail"),
                    .contactCountry = CP.Doc.GetText("contactCountry"),
                    .contactMessage = CP.Doc.GetText("contactMessage"),
                    .contactGroupList = New List(Of groupListItem)
                }
                For ptr = 1 To CP.Doc.GetInteger("groupcnt")
                    request.contactGroupList.Add(New groupListItem With {
                        .checked = CP.Doc.GetBoolean("group" & ptr),
                        .groupId = CP.Doc.GetInteger("groupId" & ptr)
                    })
                Next
                viewModel.formSubmitted = Controllers.ContactUsController.processRequest(CP, settings, request)
                '
                ' -- translate view model into html
                result = CP.Html.Form(Nustache.Core.Render.StringToString(My.Resources.ContactUsLayout, viewModel))
                '
                ' -- if editing enabled, add the link and wrapperwrapper
                Return CP.Content.GetEditWrapper(result, DbContactUsModel.contentName, settings.id)
            Catch ex As Exception
                CP.Site.ErrorReport(ex)
                Return "<!-- " & designBlockName & ", Unexpected Exception -->"
            End Try
        End Function
        '
        Public Class Request
            Public blockContactFormButton As String
            Public contactFirstName As String
            Public contactLastName As String
            Public contactEmail As String
            Public contactCountry As String
            Public contactMessage As String
            Public contactGroupList As List(Of groupListItem)
        End Class
        '
        Public Class groupListItem
            Public checked As Boolean
            Public groupId As Integer
            Public groupTitle As String
        End Class
    End Class
End Namespace