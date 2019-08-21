Imports apiPagesDesignBlock.Models.Db
Imports apiPagesDesignBlock.Models.View
Imports Contensive.BaseClasses


Namespace Models.View
    Public Class ApiPagesViewModel
        Inherits ViewBaseModel
        '
        '
        Public Property objectTypeList As New List(Of ApiObjectTypeViewModel)
        Public Property showPublish As New Boolean
        Public Property refreshQueryString As String
        '====================================================================================================
        ''' <summary>
        ''' Populate the view model from the entity model
        ''' </summary>
        ''' <param name="cp"></param>
        ''' <param name="settings"></param>
        ''' <returns></returns>
        Public Overloads Shared Function create(cp As CPBaseClass, settings As Models.Db.ApiPagesModel) As ApiPagesViewModel
            Try
                '
                ' -- base fields
                Dim result = ViewBaseModel.create(Of ApiPagesViewModel)(cp, settings)
                '
                ' -- custom
                For Each ApiObjectType In baseModel.createList(Of ApiObjectTypesModel)(cp, "(ApiPageId=" & settings.id & ")", "name")

                    ' -- Compose list of properties before the list of object types
                    Dim propertiesList As New List(Of ApiPageObjectPropertiesViewModel)
                    '
                    For Each propertyType In baseModel.createList(Of ApiPageObjectPropertiesModel)(cp,
                        "(ApiParentObjectTypeId=" & ApiObjectType.id & ")", "id")
                        '
                        propertiesList.Add(New ApiPageObjectPropertiesViewModel With {
                                                        .name = propertyType.name,
                                                        .description = propertyType.description,
                                                        .propertyTypeId = baseModel.create(Of ApiObjectTypesModel)(cp, propertyType.propertyTypeId).name,
                                                        .deprecated = propertyType.deprecated,
                                                        .isFirstProperty = False,
                                                        .areProperties = True,
                                                        .notAbstract = propertyType.notAbstract,
                                                        .declarationOnly = propertyType.declarationOnly,
                                                        .hasEqualsValue = propertyType.propertyEqualsValue,
                                                        .theEqualsValue = propertyType.equalsValue,
                                                        .getAndSet = propertyType.getAndSet,
                                                        .editTag = cp.Content.GetEditLink(ApiPageObjectPropertiesModel.contentName,
                                                                                          propertyType.id.ToString,
                                                                                          False, propertyType.name,
                                                                                          cp.User.IsEditing(ApiPageObjectPropertiesModel.contentName))
                                                        })
                    Next
                    ' -- Compose list of methods before the list of object types
                    '
                    Dim methodsList As New List(Of ApiPageObjectMethodsViewModel)
                    '
                    For Each methodType In baseModel.createList(Of ApiPageObjectMethodsModel)(cp,
                        "(ApiParentObjectTypeId=" & ApiObjectType.id & ")", "id")
                        '
                        ' -- Compose list of signatures
                        Dim signatureList As New List(Of ApiPageObjectMethodSignatureViewModel)
                        '
                        For Each signature In baseModel.createList(Of ApiPageObjectMethodSignaturesModel)(cp,
                        "(ApiParentMethodTypeId=" & methodType.id & ")", "name")
                            signatureList.Add(New ApiPageObjectMethodSignatureViewModel With {
                                               .name = signature.name,
                                               .deprecated = signature.deprecated,
                                               .editTag = cp.Content.GetEditLink(ApiPageObjectMethodSignaturesModel.contentName,
                                                                                          signature.id.ToString,
                                                                                          False, signature.name,
                                                                                          cp.User.IsEditing(ApiPageObjectMethodSignaturesModel.contentName))
                                              })
                        Next
                        '
                        ' -- compose list of arguments
                        Dim argumentList As New List(Of ApiPageObjectMethodArgumentViewModel)
                        '
                        For Each argument In baseModel.createList(Of ApiPageObjectMethodArgumentsModel)(cp,
                        "(ApiParentMethodTypeId=" & methodType.id & ")", "name")
                            '
                            argumentList.Add(New ApiPageObjectMethodArgumentViewModel With {
                                            .name = argument.name,
                                            .description = argument.description,
                                            .argumentTypeId = baseModel.create(Of ApiObjectTypesModel)(cp, argument.argumentTypeId).name,
                                            .callByTypeId = baseModel.create(Of ApiObjectTypesModel)(cp, argument.callByTypeId).name,
                                            .editTag = cp.Content.GetEditLink(ApiPageObjectMethodArgumentsModel.contentName,
                                                                                          argument.id.ToString,
                                                                                          False, argument.name,
                                                                                          cp.User.IsEditing(ApiPageObjectMethodArgumentsModel.contentName))
                                            })

                        Next
                        '
                        ' -- Get return value
                        '
                        Dim returnVal As New ApiPageObjectMethodReturnValueViewModel
                        For Each retVal In baseModel.createList(Of ApiPageObjectMethodReturnValueModel)(cp,
                        "(ApiParentMethodTypeId=" & methodType.id & ")", "name")
                            returnVal = New ApiPageObjectMethodReturnValueViewModel With {
                                         .description = retVal.description,
                                         .isFirstReturn = True,
                                         .returnValueTypeId = baseModel.create(Of ApiObjectTypesModel)(cp, retVal.returnValueTypeId).name,
                                         .editTag = cp.Content.GetEditLink(ApiPageObjectMethodReturnValueModel.contentName,
                                                                                          retVal.id.ToString,
                                                                                          False, retVal.name,
                                                                                          cp.User.IsEditing(ApiPageObjectMethodReturnValueModel.contentName))
                                         }
                        Next
                        '
                        '
                        If returnVal Is Nothing Or returnVal.description Is Nothing Then
                            returnVal.addReturnTag = cp.Content.GetAddLink(ApiPageObjectMethodReturnValueModel.contentName,
                                                                           "", False,
                                                                           cp.User.IsEditing(ApiPageObjectMethodReturnValueModel.contentName))
                            returnVal.description = ""
                            returnVal.returnValueTypeId = ""
                            returnVal.editTag = ""
                            returnVal.isFirstReturn = False
                        End If
                        '
                        ' -- Compose list of examples
                        Dim examplesList As New List(Of ApiPageObjectMethodExamplesViewModel)
                        '
                        For Each example In baseModel.createList(Of ApiPageObjectMethodExamplesModel)(cp,
                        "(ApiParentMethodTypeId=" & methodType.id & ")", "name")
                            examplesList.Add(New ApiPageObjectMethodExamplesViewModel With {
                                             .codeExample = example.codeExample,
                                             .name = example.name,
                                             .id = example.id,
                                             .isFirstExample = False,
                                             .hideRunButton = example.hideRunButton,
                                             .editTag = cp.Content.GetEditLink(ApiPageObjectMethodExamplesModel.contentName,
                                                                                          example.id.ToString,
                                                                                          False, example.name,
                                                                                          cp.User.IsEditing(ApiPageObjectMethodExamplesModel.contentName))
                                            })
                            '
                        Next
                        ' -- Add all elements to the method list
                        methodsList.Add(New ApiPageObjectMethodsViewModel With {
                                            .name = methodType.name,
                                            .description = methodType.description,
                                            .deprecated = methodType.deprecated,
                                            .signatureList = signatureList,
                                            .argumentList = argumentList,
                                            .isFirstMethod = False,
                                            .areMethods = True,
                                            .returnValue = returnVal,
                                            .exampleList = examplesList,
                                            .editTag = cp.Content.GetEditLink(ApiPageObjectMethodsModel.contentName,
                                                                            methodType.id.ToString,
                                                                            False, methodType.name,
                                                                            cp.User.IsEditing(ApiPageObjectMethodsModel.contentName))
                                            })
                        '
                        ' -- Insert add tags to the end of each method's signature list
                        If signatureList.Count > 0 Then
                            signatureList.ElementAt(signatureList.Count - 1).addSignatureTag = cp.Content.GetAddLink(ApiPageObjectMethodSignaturesModel.contentName,
                                                                                                                    "", False,
                                                                                                                    cp.User.IsEditing(ApiPageObjectMethodSignaturesModel.contentName))
                            signatureList.ElementAt(0).isFirstSignature = True
                            ' -- Inserts a blank place-holder signature if none have been added yet
                        Else
                            signatureList.Add(New ApiPageObjectMethodSignatureViewModel With {
                                                            .name = "",
                                                            .deprecated = False,
                                                            .editTag = "",
                                                            .isFirstSignature = False,
                                                            .addSignatureTag = cp.Content.GetAddLink(ApiPageObjectMethodSignaturesModel.contentName,
                                                                                                    "", False,
                                                                                                    cp.User.IsEditing(ApiPageObjectMethodSignaturesModel.contentName))
                                                            })
                        End If
                        '
                        ' -- Insert add tags to the end of each method's argument list
                        If argumentList.Count > 0 Then
                            argumentList.ElementAt(argumentList.Count - 1).addArgumentTag = cp.Content.GetAddLink(ApiPageObjectMethodArgumentsModel.contentName,
                                                                                                                    "", False,
                                                                                                                    cp.User.IsEditing(ApiPageObjectMethodArgumentsModel.contentName))
                            argumentList.ElementAt(0).isFirstArgument = True
                            ' -- Inserts a blank place-holder argument if none have been added yet
                        Else
                            argumentList.Add(New ApiPageObjectMethodArgumentViewModel With {
                                                            .name = "",
                                                            .deprecated = False,
                                                            .editTag = "",
                                                            .argumentTypeId = "",
                                                            .callByTypeId = "",
                                                            .isFirstArgument = False,
                                                            .description = "",
                                                            .addArgumentTag = cp.Content.GetAddLink(ApiPageObjectMethodArgumentsModel.contentName,
                                                                                                    "", False,
                                                                                                    cp.User.IsEditing(ApiPageObjectMethodArgumentsModel.contentName))
                                                            })
                        End If
                        '
                        ' -- Insert add tags to the end of each object's examples list
                        If examplesList.Count > 0 Then
                            examplesList.ElementAt(examplesList.Count - 1).addExampleTag = cp.Content.GetAddLink(ApiPageObjectMethodExamplesModel.contentName,
                                                                                                                "", False,
                                                                                                                cp.User.IsEditing(ApiPageObjectMethodExamplesModel.contentName))
                            examplesList.ElementAt(0).isFirstExample = True
                            ' -- Inserts a blank place-holder example with add tag if none have been added yet
                        Else
                            examplesList.Add(New ApiPageObjectMethodExamplesViewModel With {
                                        .editTag = "",
                                        .name = "",
                                        .id = 0,
                                        .codeExample = "",
                                        .isFirstExample = False,
                                        .hideRunButton = True,
                                        .addExampleTag = cp.Content.GetAddLink(ApiPageObjectMethodExamplesModel.contentName,
                                                                                                "", False,
                                                                                                cp.User.IsEditing(ApiPageObjectMethodExamplesModel.contentName))
                                        })
                        End If
                        '
                    Next
                    '
                    ' -- Compose list of enums
                    '
                    Dim enumsList As New List(Of ApiPageObjectEnumsViewModel)
                    '
                    For Each enumObject In baseModel.createList(Of ApiPageObjectEnumsModel)(cp,
                        "(ApiParentObjectTypeId=" & ApiObjectType.id & ")", "name")

                        Dim enumTypesList As New List(Of ApiPageObjectEnumTypesViewModel)
                        '
                        For Each enumType In baseModel.createList(Of ApiPageObjectEnumTypesModel)(cp,
                        "(ApiParentEnumId=" & enumObject.id & ")", "id")
                            Dim temp = Text.RegularExpressions.Regex.Split(ApiObjectType.name, "(?<!^)(?=[A-Z])")

                            enumTypesList.Add(New ApiPageObjectEnumTypesViewModel With {
                                              .deprecated = enumType.deprecated,
                                              .name = enumType.name,
                                              .typeBlock = enumType.typeBlock,
                                              .parentEnumType = enumObject.name,
                                              .objectDotType = temp.ElementAt(2),
                                              .editTag = cp.Content.GetEditLink(ApiPageObjectEnumTypesModel.contentName,
                                                                            enumType.id.ToString,
                                                                            False, enumType.name,
                                                                            cp.User.IsEditing(ApiPageObjectEnumTypesModel.contentName))
                                              })

                        Next
                        '
                        enumsList.Add(New ApiPageObjectEnumsViewModel With {
                                          .name = enumObject.name,
                                          .description = enumObject.description,
                                          .deprecated = enumObject.deprecated,
                                          .isFirstEnum = False,
                                          .areEnums = True,
                                          .enumTypesList = enumTypesList,
                                          .editTag = cp.Content.GetEditLink(ApiPageObjectEnumsModel.contentName,
                                                                                enumObject.id.ToString,
                                                                                False, enumObject.name,
                                                                                cp.User.IsEditing(ApiPageObjectEnumsModel.contentName))})
                        '
                        ' -- Insert add tags to the end of each enum's type list
                        If enumTypesList.Count > 0 Then
                            enumTypesList.ElementAt(enumTypesList.Count - 1).addEnumTypeTag = cp.Content.GetAddLink(ApiPageObjectEnumTypesModel.contentName,
                                                                                                                    "", False,
                                                                                                                    cp.User.IsEditing(ApiPageObjectEnumTypesModel.contentName))
                            enumTypesList.ElementAt(0).isFirstEnumType = True
                            ' -- Inserts a blank place-holder enum type if none have been added yet
                        Else
                            enumTypesList.Add(New ApiPageObjectEnumTypesViewModel With {
                                                            .name = "",
                                                            .deprecated = False,
                                                            .editTag = "",
                                                            .isFirstEnumType = False,
                                                            .typeBlock = "",
                                                            .parentEnumType = "",
                                                            .addEnumTypeTag = cp.Content.GetAddLink(ApiPageObjectEnumTypesModel.contentName,
                                                                                                    "", False,
                                                                                                    cp.User.IsEditing(ApiPageObjectEnumTypesModel.contentName))
                                                            })
                        End If
                        '
                    Next
                    '
                    ' -- Insert add tags to the end of each object's enums list
                    '
                    If enumsList.Count > 0 Then
                        enumsList.ElementAt(enumsList.Count - 1).addEnumTag = cp.Content.GetAddLink(ApiPageObjectEnumsModel.contentName,
                                                                                                                "", False,
                                                                                                                cp.User.IsEditing(ApiPageObjectEnumsModel.contentName))
                        enumsList.ElementAt(0).isFirstEnum = True
                        ' -- Inserts a blank place-holder enum with add tag if none have been added yet
                    Else
                        enumsList.Add(New ApiPageObjectEnumsViewModel With {
                                            .name = "",
                                            .description = "",
                                            .deprecated = False,
                                            .editTag = "",
                                            .isFirstEnum = False,
                                            .areEnums = False,
                                            .enumTypesList = New List(Of ApiPageObjectEnumTypesViewModel),
                                            .addEnumTag = cp.Content.GetAddLink(ApiPageObjectEnumsModel.contentName,
                                                                                                    "", False,
                                                                                                    cp.User.IsEditing(ApiPageObjectEnumsModel.contentName))
                                            })
                    End If
                    ' -- Insert add tags to the end of each object's properties list
                    If propertiesList.Count > 0 Then
                        propertiesList.ElementAt(propertiesList.Count - 1).addPropertyTag = cp.Content.GetAddLink(ApiPageObjectPropertiesModel.contentName,
                                                                                                                "", False,
                                                                                                                cp.User.IsEditing(ApiPageObjectPropertiesModel.contentName))
                        propertiesList.ElementAt(0).isFirstProperty = True
                        ' -- Inserts a blank place-holder property with add tag if none have been added yet
                    Else
                        propertiesList.Add(New ApiPageObjectPropertiesViewModel With {
                                            .name = "",
                                            .description = "",
                                            .propertyTypeId = "",
                                            .deprecated = False,
                                            .isFirstProperty = False,
                                            .areProperties = False,
                                            .getAndSet = False,
                                            .declarationOnly = False,
                                            .notAbstract = False,
                                            .hasEqualsValue = False,
                                            .theEqualsValue = "",
                                            .editTag = "",
                                            .addPropertyTag = cp.Content.GetAddLink(ApiPageObjectPropertiesModel.contentName,
                                                                                                    "", False,
                                                                                                    cp.User.IsEditing(ApiPageObjectPropertiesModel.contentName))
                                            })
                    End If
                    '
                    ' -- Insert add tags to the end of each object's methods list
                    If methodsList.Count > 0 Then
                        methodsList.ElementAt(methodsList.Count - 1).addMethodTag = cp.Content.GetAddLink(ApiPageObjectMethodsModel.contentName,
                                                                                                                "", False,
                                                                                                                cp.User.IsEditing(ApiPageObjectMethodsModel.contentName))
                        methodsList.ElementAt(0).isFirstMethod = True
                        ' -- Inserts a blank place-holder method with add tag if none have been added yet
                    Else
                        methodsList.Add(New ApiPageObjectMethodsViewModel With {
                                        .name = "",
                                        .description = "",
                                        .deprecated = False,
                                        .isFirstMethod = False,
                                        .editTag = "",
                                        .areMethods = False,
                                        .argumentList = New List(Of ApiPageObjectMethodArgumentViewModel),
                                        .signatureList = New List(Of ApiPageObjectMethodSignatureViewModel),
                                        .exampleList = New List(Of ApiPageObjectMethodExamplesViewModel),
                                        .returnValue = New ApiPageObjectMethodReturnValueViewModel,
                                        .addMethodTag = cp.Content.GetAddLink(ApiPageObjectMethodsModel.contentName,
                                                                                                "", False,
                                                                                                cp.User.IsEditing(ApiPageObjectMethodsModel.contentName))
                                        })
                    End If
                    '
                    ' -- Add everything to the object type list
                    result.objectTypeList.Add(New ApiObjectTypeViewModel With {
                                                .name = ApiObjectType.name,
                                                .description = ApiObjectType.description,
                                                .ApiPageObjectPropertiesList = propertiesList,
                                                .ApiPageObjectMethodsList = methodsList,
                                                .ApiPageObjectEnumsList = enumsList,
                                                .editTag = cp.Content.GetEditLink(ApiObjectTypesModel.contentName,
                                                                                ApiObjectType.id.ToString, False,
                                                                                ApiObjectType.name, cp.User.IsEditing(ApiPagesModel.contentName)),
                                                .addObjectTag = ""
                                                })
                Next
                '
                ' -- Insert add tag at the end of the whole object list
                If result.objectTypeList.Count > 0 Then
                    result.objectTypeList.ElementAt(result.objectTypeList.Count - 1).addObjectTag = cp.Content.GetAddLink(ApiObjectTypesModel.contentName,
                                                                                                                "", False,
                                                                                                                cp.User.IsEditing(ApiObjectTypesModel.contentName))
                End If
                '
                ' -- Check if publish button should be shown
                If cp.User.IsEditing(ApiObjectTypesModel.contentName) Then
                    result.showPublish = True
                    ' -- Get the refresh query string that sets publish to true
                    result.refreshQueryString = cp.Doc.RefreshQueryString + "&publish=1"
                Else
                    result.showPublish = False
                    result.refreshQueryString = ""
                End If
                '
                Return result
            Catch ex As Exception
                cp.Site.ErrorReport(ex)
                Return Nothing
            End Try
        End Function

        Public Function getDotType(name As String) As String
            Dim temp = Split(name, "[A-Z][a-z]+")
            Return temp.ElementAt(1)
        End Function
    End Class

    Public Class ApiObjectTypeViewModel
        Public Property name As String
        Public Property description As String
        Public Property ApiPageObjectPropertiesList As New List(Of ApiPageObjectPropertiesViewModel)
        Public Property ApiPageObjectMethodsList As New List(Of ApiPageObjectMethodsViewModel)
        Public Property ApiPageObjectEnumsList As New List(Of ApiPageObjectEnumsViewModel)
        Public Property editTag As String
        Public Property addObjectTag As String
        Public Property dotType As String
    End Class

    Public Class ApiPageObjectPropertiesViewModel
        Public Property name As String
        Public Property editTag As String
        Public Property description As String
        Public Property propertyTypeId As String
        Public Property deprecated As Boolean
        Public Property getAndSet As Boolean
        Public Property notAbstract As Boolean
        Public Property declarationOnly As Boolean
        Public Property isFirstProperty As Boolean
        Public Property areProperties As Boolean
        Public Property addPropertyTag As String
        Public Property hasEqualsValue As Boolean
        Public Property theEqualsValue As String
    End Class

    Public Class ApiPageObjectMethodsViewModel
        Public Property name As String
        Public Property description As String
        Public Property editTag As String
        Public Property addMethodTag As String
        Public Property deprecated As Boolean
        Public Property isFirstMethod As Boolean
        Public Property areMethods As Boolean
        Public Property signatureList As New List(Of ApiPageObjectMethodSignatureViewModel)
        Public Property argumentList As New List(Of ApiPageObjectMethodArgumentViewModel)
        Public Property returnValue As New ApiPageObjectMethodReturnValueViewModel
        Public Property exampleList As New List(Of ApiPageObjectMethodExamplesViewModel)
    End Class

    Public Class ApiPageObjectEnumsViewModel
        Public Property name As String
        Public Property description As String
        Public Property deprecated As Boolean
        Public Property isFirstEnum As Boolean
        Public Property areEnums As Boolean
        Public Property editTag As String
        Public Property addEnumTag As String
        Public Property enumTypesList As New List(Of ApiPageObjectEnumTypesViewModel)
    End Class

    Public Class ApiPageObjectEnumTypesViewModel
        Public Property name As String
        Public Property typeBlock As String
        Public Property deprecated As Boolean
        Public Property isFirstEnumType As Boolean
        Public Property editTag As String
        Public Property parentEnumType As String
        Public Property objectDotType As String
        Public Property addEnumTypeTag As String
    End Class

    Public Class ApiPageObjectMethodSignatureViewModel
        Public Property name As String
        Public Property editTag As String
        Public Property addSignatureTag As String
        Public Property deprecated As Boolean
        Public Property isFirstSignature As Boolean
    End Class

    Public Class ApiPageObjectMethodArgumentViewModel
        Public Property name As String
        Public Property editTag As String
        Public Property addArgumentTag As String
        Public Property deprecated As Boolean
        Public Property argumentTypeId As String
        Public Property callByTypeId As String
        Public Property description As String
        Public Property isFirstArgument As Boolean
    End Class

    Public Class ApiPageObjectMethodReturnValueViewModel
        Public Property returnValueTypeId As String
        Public Property addReturnTag As String
        Public Property editTag As String
        Public Property description As String
        Public Property isFirstReturn As Boolean
    End Class

    Public Class ApiPageObjectMethodExamplesViewModel
        Public Property name As String
        Public Property id As Integer
        Public Property codeExample As String
        Public Property addExampleTag As String
        Public Property editTag As String
        Public Property isFirstExample As Boolean
        Public Property hideRunButton As Boolean
    End Class
End Namespace