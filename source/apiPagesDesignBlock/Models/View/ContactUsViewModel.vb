Imports Contensive.Addons.aoDesignBlocks.Controllers
Imports Contensive.BaseClasses

Namespace Models.View

    Public Class ContactUsViewModel
        Inherits ViewBaseModel
        '       
        Public Property id As Integer
        Public Property text As String
        Public Property formDescription As String
        Public Property formButtonText As String
        Public Property inputValueFirstName As String
        Public Property inputValueLastName As String
        Public Property inputValueEmail As String
        Public Property inputValueCompany As String
        Public Property inputValueGroupID As Integer
        Public Property inputValueGroupCaption As String
        Public Property inputValueGroupTypeName As String
        Public Property inputValueMessage As String
        Public Property thankYouTitle As String
        Public Property thankYouDescription As String
        Public Property formSubmitted As Boolean
        Public Property formInstanceId As String
        Public Property contactUsgroupList As New List(Of ContactUsGroupClass)
        Public Property contactUsgroupListShow As Boolean
        Public Property groupCnt As Integer
        Public Property groupListTitle As String
        Public Property allowFirstName As Boolean
        Public Property allowLastName As Boolean
        Public Property allowCompany As Boolean
        Public Property allowMessage As Boolean
        '
        ' 
        Public Class ContactUsGroupClass
            Public Property groupID As Integer
            Public Property ptr As Integer
            Public Property groupCaption As String
        End Class
        '
        '====================================================================================================
        ''' <summary>
        ''' Populate the view model from the entity model
        ''' </summary>
        ''' <param name="cp"></param>
        ''' <param name="settings"></param>
        ''' <returns></returns>
        Public Overloads Shared Function create(cp As CPBaseClass, settings As Models.Db.DbContactUsModel) As ContactUsViewModel
            Try
                '
                ' -- base fields
                Dim result = ViewBaseModel.create(Of ContactUsViewModel)(cp, settings)
                '
                ' -- custom
                result.id = settings.id
                result.formDescription = settings.formDescription
                result.formButtonText = settings.formButtonText
                result.inputValueFirstName = ""
                result.inputValueLastName = ""
                result.inputValueEmail = ""
                result.inputValueCompany = ""
                result.inputValueGroupID = 0
                result.inputValueGroupCaption = ""
                result.groupListTitle = settings.groupListTitle
                '
                result.thankYouTitle = settings.thankYouTitle
                result.thankYouDescription = settings.thankYouDescription
                '
                result.formSubmitted = cp.Visit.GetBoolean("Contact Form Submitted " & settings.ccguid)
                result.formInstanceId = settings.ccguid
                '
                '
                Dim groupList = Db.GroupModel.getContactUsGroupList(cp, settings.id)
                Dim ptr As Integer = 1
                For Each group In groupList
                    result.contactUsgroupList.Add(New ContactUsGroupClass With {
                        .groupID = group.id,
                        .groupCaption = group.Caption,
                        .ptr = ptr
                    })
                    ptr += 1
                Next
                result.contactUsgroupListShow = (result.contactUsgroupList.Count > 0)
                result.groupCnt = ptr - 1
                '
                '
                If (Not cp.User.IsAuthenticated) Then
                    If (Not cp.User.IsRecognized) Then
                        '
                        ' -- guest
                    Else
                        '
                        ' -- recognized, do not prepopulate the edit the form
                    End If
                Else
                    '
                    ' -- authenticated
                    Dim user As Models.Db.PeopleModel = Models.Db.PeopleModel.create(cp, cp.User.Id)
                    If (user IsNot Nothing) Then
                        result.inputValueFirstName = user.FirstName
                        result.inputValueLastName = user.LastName
                        result.inputValueEmail = user.Email
                        result.inputValueCompany = user.Company
                    End If
                End If
                '
                result.allowFirstName = settings.allowfirstname
                result.allowLastName = settings.allowlastname
                result.allowCompany = settings.allowcompany
                result.allowMessage = settings.allowMessage
                '
                Return result
            Catch ex As Exception
                cp.Site.ErrorReport(ex)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace