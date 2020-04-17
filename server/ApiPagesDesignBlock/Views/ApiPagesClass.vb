
Imports Contensive.Addons.apiPagesDesignBlock.Models.Db
Imports Contensive.Addons.apiPagesDesignBlock.Controllers
Imports Contensive.BaseClasses
Imports Contensive.Addons.apiPagesDesignBlock.Models.View

Namespace Views
    '
    '====================================================================================================
    ''' <summary>
    ''' Design block with a centered headline, image, paragraph text and a button.
    ''' </summary>
    Public Class ApiPagesClass
        Inherits AddonBaseClass
        '
        '====================================================================================================
        '
        Public Overrides Function Execute(ByVal CP As CPBaseClass) As Object
            Const designBlockName As String = "API Design Block"
            Try
                Dim result = String.Empty
                '
                '
                ' -- read instanceId, guid created uniquely for this instance of the addon on a page
                Dim settingsGuid = InstanceIdController.getSettingsGuid(CP, designBlockName, result)
                If (String.IsNullOrEmpty(settingsGuid)) Then Return result
                '
                ' -- locate or create a data record for this guid
                Dim settings = ApiPagesModel.createOrAddSettings(CP, settingsGuid)
                If (settings Is Nothing) Then Throw New ApplicationException("Could not create the design block settings record.")
                '
                ' -- Check if a version of the page already exists
                If Not CP.User.IsEditing(ApiPagesModel.contentName) And CP.CdnFiles.FileExists("SavedApiPage/SavedAPIPage.html") Then
                    result = CP.CdnFiles.Read("SavedApiPage/SavedAPIPage.html")
                Else
                    If CP.Doc.GetBoolean("publish") Then
                        CP.Visit.SetProperty("AllowDebugging", "False")
                        CP.Visit.SetProperty("AllowAdvancedEditor", "False")
                        CP.Visit.SetProperty("AllowEditing", "False")
                    End If
                    ' -- translate the Db model to a view model and mustache it into the layout
                    Dim viewModel = ApiPagesViewModel.create(CP, settings)
                    If (viewModel Is Nothing) Then Throw New ApplicationException("Could not create design block view model.")
                    result = Nustache.Core.Render.StringToString(My.Resources.ApiLayout, viewModel)
                    ' -- Write the file to be used until further changes
                    If CP.Doc.GetBoolean("publish") Then
                        If CP.CdnFiles.FileExists("SavedApiPage/SavedAPIPage.html") Then
                            CP.CdnFiles.DeleteFile("SavedApiPage/SavedAPIPage.html")
                        End If
                        CP.CdnFiles.Save("SavedApiPage/SavedAPIPage.html", result)
                    End If
                End If
                '
                ' -- if editing enabled, add the link and wrapper                  
                Return genericController.addEditWrapper(CP, result, settings.id, settings.name, ApiPagesModel.contentName)
                '
            Catch ex As Exception
                CP.Site.ErrorReport(ex)
                Return "<!-- " & designBlockName & ", Unexpected Exception -->"
            End Try
        End Function
    End Class
End Namespace