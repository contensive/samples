<script runat="server">
    '
    '==============================================================================
    ''' <summary>
    ''' run during page load
    ''' </summary>
    Sub Page_Load()
        Dim cp As New Contensive.Processor.CPClass
        Dim doc As String
        '
        doc = cpApiClass.getContensivePage(cp, False, Page)
        If cp.Response.isOpen() Then
            '
            ' page is open, modify it
            '
            doc = Replace(doc, "$myCustomTag$", "<div>cp.user.name = " & cp.User.Name & "</div>")
        End If
        Response.Write(doc)
        cp.Dispose()
    End Sub
</script>
