
Option Explicit On
Option Strict On

Namespace Contensive.Addons.xxxxxCollectionNameSpaceGoesHerexxxxx
    Public Module constants
        '
        ' -- sample
        Public Const Version As Integer = 1
        '
        ' -- sample
        Public Const rnInputValue As String = "inputValue"
        '
        ' -- errors for resultErrList
        Public Enum resultErrorEnum
            errPermission = 50
            errDuplicate = 100
            errVerification = 110
            errRestriction = 120
            errInput = 200
            errAuthentication = 300
            errAdd = 400
            errSave = 500
            errDelete = 600
            errLookup = 700
            errLoad = 710
            errContent = 800
            errMiscellaneous = 900
        End Enum
        '
        ' -- http errors
        Public Enum httpErrorEnum
            badRequest = 400
            unauthorized = 401
            paymentRequired = 402
            forbidden = 403
            notFound = 404
            methodNotAllowed = 405
            notAcceptable = 406
            proxyAuthenticationRequired = 407
            requestTimeout = 408
            conflict = 409
            gone = 410
            lengthRequired = 411
            preconditionFailed = 412
            payloadTooLarge = 413
            urlTooLong = 414
            unsupportedMediaType = 415
            rangeNotSatisfiable = 416
            expectationFailed = 417
            teapot = 418
            methodFailure = 420
            enhanceYourCalm = 420
            misdirectedRequest = 421
            unprocessableEntity = 422
            locked = 423
            failedDependency = 424
            upgradeRequired = 426
            preconditionRequired = 428
            tooManyRequests = 429
            requestHeaderFieldsTooLarge = 431
            loginTimeout = 440
            noResponse = 444
            retryWith = 449
            redirect = 451
            unavailableForLegalReasons = 451
            sslCertificateError = 495
            sslCertificateRequired = 496
            httpRequestSentToSecurePort = 497
            invalidToken = 498
            clientClosedRequest = 499
            tokenRequired = 499
            internalServerError = 500
        End Enum
    End Module

    '
    ' During VB6 code upgrade, these are typical find-replace strings
    ' -- VB6 typical Replace List
    '                   Find                                            Replace                                             Manual
    '                   -----------------------------------------       --------------------------------------------------  ------------------------------
    '                   a-s long                                        as integer
    '                   a-s variant                                     as object
    '                   k-maIndent(                                     nop(                                                -
    '                   k-maEncodeInteger(Main.GetSiteProperty(         cp.site.getInteger(                                 - leaves double ending "))"
    '                   M-ain.GetFormInputText(                         cp.html.inputText(
    '                   M-ain.GetStreamText(                            cp.doc.getText(
    '                   M-ain.GetStreamNumber(                          cp.doc.getNumber(
    '                   M-ain.GetStreamBoolean(                         cp.doc.getBoolean(
    '                   M-ain.GetStreamDate(                            cp.doc.getDate(
    '                   D-OMDocument60                                  xml.xmlDocument
    '                   M-ain.GetFormButton(                            cp.html.button("button",
    '                   kmaEncodeBoolean                                cp.utils.encodeBoolean
    '                   kmaEncodeInteger                                cp.utils.encodeInteger
    '                   kmaEncodeNumber                                 cp.utils.encodeNumber
    '                   kmaEncodeDate                                   cp.utils.encodeDate
    '                   Main.IsAdmin                                    cp.user.isAdmin
    '                   Main.GetAdminHintWrapper                        cp.html.adminHint(
    '                                                                   
    '
    '                   Manual issues
    '                   ------------------------------------------------------------------------
    '                   optionString = optionString & "&name=value"     cp.doc.setProperty( name, value )
    '                   Main.GetFormStart() ... Main.GetFormEnd()       cp.html.form( ... )
    '                   Err. -> convert to try+catch

End Namespace
