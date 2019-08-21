
Option Explicit On
Option Strict On

Public Module constants
    '
    Public Const Version As Integer = 1
    '
    ' -- groups
    Public guidSiteManagersGroup As String = "{0685bd36-fe24-4542-be42-27337af50da8}"
    '
    '
    Public Const guidTwoColumnLayoutType As String = "{af8bbbfa-6e0e-4427-822e-15cae00e2b04}"
    Public Const guidTwoColumnLeftLayoutType As String = "{2471D0DC-61A6-4102-B549-D33ABA9736E3}"
    Public Const guidTwoColumnRightLayoutType As String = "{5474D793-F0B8-4B20-8FC0-8D97FE104F71}"
    Public Const guidThreeColumnLayoutType As String = "{7e8f85e5-7c2b-4f7a-b80a-890114fd5310}"
    Public Const guidFourColumnLayoutType As String = "{295ad573-631a-4928-8a38-107969ec0918}"
    Public Const guidDbContactUsNotificationEmail As String = "{69E6689D-8F96-49AF-B317-048A5F541759}"
    '
    Public Const guidDesignBlockTile As String = "{63EC50BE-4052-4594-B2AB-5F9739564DFA}"
    '
    Public Const guidTestBlock As String = "{0699bb30-4833-4527-aa36-a2ca7531bdfe}"
    '
    Public Const guidLoginFormAddon As String = "{E23C5941-19C2-4164-BCFD-83D6DD42F651}"
    Public Const guidLoginPageAddon As String = "{288a7ee1-9d93-4058-bcd9-c9cd29d25ec8}"
    '
    ' -- sample
    Public Const rnInputValue As String = "inputValue"
    '
    Public Const buttonValueResubmit = "Resubmit"
    '
    Public Const heroImageCdnPathFilenameDefault As String = "designblocks\img\seattledusk1920.png"
    Public Const carouselImageCdnPathFilenameDefault As String = "designblocks\img\CarouselSample.png"
    Public Const textAndImageCdnPathFilenameDefault As String = "designblocks\img\SampleTextAndImage.png"
    Public Const sliderImageCdnPathFilenameDefault As String = "designblocks\img\SliderSample.png"
    '
    'Public Const textBackgroundImagePathFilenameDefault As String = "designblocks\img\seattledusk1920.png"
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
