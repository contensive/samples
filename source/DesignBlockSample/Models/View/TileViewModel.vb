Imports Contensive.Addons.DesignBlockSample.Controllers
Imports Contensive.BaseClasses


Namespace Models.View
    Public Class TileViewModel
        Inherits ViewBaseModel
        '
        Public Property imageUrl As String
        Public Property headlineTopPadClass As String
        Public Property headline As String
        Public Property descriptionTopPadClass As String
        Public Property embed As String
        Public Property embedTopPadClass As String
        Public Property description As String
        Public Property buttonTopPadClass As String
        Public Property buttonText As String
        Public Property buttonUrl As String
        Public Property manageAspectRatio As Boolean
        Public Property styleAspectRatio As String
        '
        '====================================================================================================
        ''' <summary>
        ''' Populate the view model from the entity model
        ''' </summary>
        ''' <param name="cp"></param>
        ''' <param name="settings"></param>
        ''' <returns></returns>
        Public Overloads Shared Function create(cp As CPBaseClass, settings As Models.Db.DbSampleModel) As TileViewModel
            Try
                '
                ' -- base fields
                Dim result = ViewBaseModel.create(Of TileViewModel)(cp, settings)
                '
                ' -- custom
                result.imageUrl = If(String.IsNullOrEmpty(settings.imageFilename), "", (cp.Site.FilePath & settings.imageFilename).Replace(" ", "+"))
                result.manageAspectRatio = True
                Select Case settings.imageAspectRatioId
                    Case 2
                        '
                        ' -- 1:1
                        result.styleAspectRatio = "blockTileImageAspect-1-1"
                    Case 3
                        '
                        ' -- 3:2
                        result.styleAspectRatio = "blockTileImageAspect-3-2"
                    Case 4
                        '
                        ' -- 4:3
                        result.styleAspectRatio = "blockTileImageAspect-4-3"
                    Case 5
                        '
                        ' -- 16:9
                        result.styleAspectRatio = "blockTileImageAspect-16-9"
                    Case Else
                        '
                        ' -- (1 and null) non-managed
                        result.manageAspectRatio = False
                        cp.Db.ExecuteNonQuery("update " & Db.DbSampleModel.contentTableName + " set imageAspectRatioId=1 where (imageAspectRatioId is null)or(imageAspectRatioId<1)or(imageAspectRatioId>5)")
                End Select
                '
                Dim isTopElement As Boolean = String.IsNullOrWhiteSpace(result.imageUrl)
                result.headline = settings.headline
                result.headlineTopPadClass = If(isTopElement And (Not String.IsNullOrEmpty(result.headline)), "", "pt-3")
                '
                isTopElement = isTopElement And String.IsNullOrWhiteSpace(result.headline)
                result.embed = settings.embed
                result.headlineTopPadClass = If(isTopElement, "", "pt-3")
                '
                isTopElement = isTopElement And String.IsNullOrWhiteSpace(result.embed)
                result.description = settings.description
                result.descriptionTopPadClass = If(isTopElement, "", "pt-3")
                '
                isTopElement = isTopElement And String.IsNullOrWhiteSpace(result.description)
                result.buttonUrl = genericController.verifyProtocol(settings.buttonUrl)
                result.buttonText = If(String.IsNullOrWhiteSpace(settings.buttonText), String.Empty, settings.buttonText)
                If (String.IsNullOrEmpty(result.buttonText) Or String.IsNullOrEmpty(result.buttonUrl)) Then
                    result.buttonText = ""
                    result.buttonUrl = ""
                End If
                result.buttonTopPadClass = If(isTopElement, "", "pt-3")
                '
                Return result
            Catch ex As Exception
                cp.Site.ErrorReport(ex)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace