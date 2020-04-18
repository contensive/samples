Option Explicit On
Option Strict On

Imports Contensive.BaseClasses

Namespace Controllers
    Public NotInheritable Class genericController
        Private Sub New()
        End Sub
        '
        '====================================================================================================
        ''' <summary>
        ''' if date is invalid, set to minValue
        ''' </summary>
        ''' <param name="srcDate"></param>
        ''' <returns></returns>
        Public Shared Function encodeMinDate(srcDate As DateTime) As DateTime
            Dim returnDate As DateTime = srcDate
            If srcDate < New DateTime(1900, 1, 1) Then
                returnDate = DateTime.MinValue
            End If
            Return returnDate
        End Function
        '
        '====================================================================================================
        ''' <summary>
        ''' if valid date, return the short date, else return blank string 
        ''' </summary>
        ''' <param name="srcDate"></param>
        ''' <returns></returns>
        Public Shared Function getShortDateString(srcDate As DateTime) As String
            Dim returnString As String = ""
            Dim workingDate As DateTime = encodeMinDate(srcDate)
            If Not isDateEmpty(srcDate) Then
                returnString = workingDate.ToShortDateString()
            End If
            Return returnString
        End Function
        '
        '====================================================================================================
        Public Shared Function isDateEmpty(srcDate As DateTime) As Boolean
            Return (srcDate < New DateTime(1900, 1, 1))
        End Function
        '
        '====================================================================================================
        Public Shared Function getSortOrderFromInteger(id As Integer) As String
            Return id.ToString().PadLeft(7, "0"c)
        End Function
        '
        '====================================================================================================
        Public Shared Function getDateForHtmlInput(source As DateTime) As String
            If isDateEmpty(source) Then
                Return ""
            Else
                Return source.Year.ToString() + "-" + source.Month.ToString().PadLeft(2, "0"c) + "-" + source.Day.ToString().PadLeft(2, "0"c)
            End If
        End Function
        '
        '====================================================================================================
        Public Shared Function convertToDosPath(sourcePath As String) As String
            Return sourcePath.Replace("/", "\")
        End Function
        '
        '====================================================================================================
        Public Shared Function convertToUnixPath(sourcePath As String) As String
            Return sourcePath.Replace("\", "/")
        End Function
        '
        ' ====================================================================================================
        ''' <summary>
        ''' execute an addon within a column
        ''' </summary>
        ''' <param name="cp"></param>
        ''' <param name="addonId"></param>
        ''' <param name="columnPtr"></param>
        ''' <param name="instanceId"></param>
        ''' <returns></returns>
        Public Shared Function executeColumnAddon(cp As CPBaseClass, addonId As Integer, columnPtr As Integer, instanceId As String) As String
            If (addonId <= 0) Then Return If(Not cp.User.IsEditingAnything, String.Empty, "<p style=""text-align:center;padding:10px;"">No Addon Selected</p>")
            cp.Doc.SetProperty("instanceId", instanceId & "-column:" & columnPtr)
            Return CType(cp.Addon.Execute(addonId.ToString), String)
        End Function
        '
        '====================================================================================================
        ''' <summary>
        ''' buffer an url to include protocol
        ''' </summary>
        ''' <param name="url">Url that needs to nbe normalized</param>
        ''' <returns>If blank is returned, </returns>
        Public Shared Function verifyProtocol(url As String) As String
            '
            ' -- allow empty
            If (String.IsNullOrWhiteSpace(url)) Then Return String.Empty
            '
            ' -- allow /myPage
            If (url.Substring(0, 1) = "/") Then Return url
            '
            ' -- allow if it includes ://
            If (Not url.IndexOf("://").Equals(-1)) Then Return url
            '
            ' -- add http://
            Return "http://" & url
        End Function
        '
        '====================================================================================================
        ''' <summary>
        ''' convert string into a style "height: {styleHeight};", if value is numeric it adds "px"
        ''' </summary>
        ''' <param name="styleheight"></param>
        ''' <returns></returns>
        Public Shared Function encodeStyleHeight(styleheight As String) As String
            Return If(String.IsNullOrWhiteSpace(styleheight), String.Empty, "overflow:hidden;height:" & styleheight & If(IsNumeric(styleheight), "px", String.Empty) & ";")
        End Function
        '
        '====================================================================================================
        ''' <summary>
        ''' convert string into a style "background-image: url(backgroundImage)
        ''' </summary>
        ''' <param name="backgroundImage"></param>
        ''' <returns></returns>
        Public Shared Function encodeStyleBackgroundImage(cp As CPBaseClass, backgroundImage As String) As String
            Return If(String.IsNullOrWhiteSpace(backgroundImage), String.Empty, "background-image: url(" & cp.Site.FilePath & backgroundImage & ");")
        End Function
    End Class
End Namespace

