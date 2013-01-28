namespace Microsoft.Data.OData
{
    using System;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.InteropServices;
    using System.Threading;

    internal sealed class TextRes
    {
        internal const string AsyncBufferedStream_WriterDisposedWithoutFlush = "AsyncBufferedStream_WriterDisposedWithoutFlush";
        internal const string AtomValueUtils_CannotConvertValueToAtomPrimitive = "AtomValueUtils_CannotConvertValueToAtomPrimitive";
        internal const string CollectionWithoutExpectedTypeValidator_IncompatibleItemTypeKind = "CollectionWithoutExpectedTypeValidator_IncompatibleItemTypeKind";
        internal const string CollectionWithoutExpectedTypeValidator_IncompatibleItemTypeName = "CollectionWithoutExpectedTypeValidator_IncompatibleItemTypeName";
        internal const string CollectionWithoutExpectedTypeValidator_InvalidItemTypeKind = "CollectionWithoutExpectedTypeValidator_InvalidItemTypeKind";
        internal const string DuplicatePropertyNamesChecker_DuplicatePropertyNamesNotAllowed = "DuplicatePropertyNamesChecker_DuplicatePropertyNamesNotAllowed";
        internal const string DuplicatePropertyNamesChecker_MultipleLinksForSingleton = "DuplicatePropertyNamesChecker_MultipleLinksForSingleton";
        internal const string EdmLibraryExtensions_CollectionItemCanBeOnlyPrimitiveOrComplex = "EdmLibraryExtensions_CollectionItemCanBeOnlyPrimitiveOrComplex";
        internal const string EntityPropertyMapping_EpmAttribute = "EntityPropertyMapping_EpmAttribute";
        internal const string EntityPropertyMapping_InvalidTargetPath = "EntityPropertyMapping_InvalidTargetPath";
        internal const string EntityPropertyMapping_TargetNamespaceUriNotValid = "EntityPropertyMapping_TargetNamespaceUriNotValid";
        internal const string EpmExtensionMethods_AttributeNotAllowedForAtomPubMappingOnProperty = "EpmExtensionMethods_AttributeNotAllowedForAtomPubMappingOnProperty";
        internal const string EpmExtensionMethods_AttributeNotAllowedForAtomPubMappingOnType = "EpmExtensionMethods_AttributeNotAllowedForAtomPubMappingOnType";
        internal const string EpmExtensionMethods_AttributeNotAllowedForCustomMappingOnProperty = "EpmExtensionMethods_AttributeNotAllowedForCustomMappingOnProperty";
        internal const string EpmExtensionMethods_AttributeNotAllowedForCustomMappingOnType = "EpmExtensionMethods_AttributeNotAllowedForCustomMappingOnType";
        internal const string EpmExtensionMethods_CannotConvertEdmAnnotationValue = "EpmExtensionMethods_CannotConvertEdmAnnotationValue";
        internal const string EpmExtensionMethods_InvalidKeepInContentOnProperty = "EpmExtensionMethods_InvalidKeepInContentOnProperty";
        internal const string EpmExtensionMethods_InvalidKeepInContentOnType = "EpmExtensionMethods_InvalidKeepInContentOnType";
        internal const string EpmExtensionMethods_InvalidTargetTextContentKindOnProperty = "EpmExtensionMethods_InvalidTargetTextContentKindOnProperty";
        internal const string EpmExtensionMethods_InvalidTargetTextContentKindOnType = "EpmExtensionMethods_InvalidTargetTextContentKindOnType";
        internal const string EpmExtensionMethods_MissingAttributeOnProperty = "EpmExtensionMethods_MissingAttributeOnProperty";
        internal const string EpmExtensionMethods_MissingAttributeOnType = "EpmExtensionMethods_MissingAttributeOnType";
        internal const string EpmReader_OpenComplexOrCollectionEpmProperty = "EpmReader_OpenComplexOrCollectionEpmProperty";
        internal const string EpmSourceTree_CollectionPropertyCannotBeMapped = "EpmSourceTree_CollectionPropertyCannotBeMapped";
        internal const string EpmSourceTree_DuplicateEpmAttributesWithSameSourceName = "EpmSourceTree_DuplicateEpmAttributesWithSameSourceName";
        internal const string EpmSourceTree_EndsWithNonPrimitiveType = "EpmSourceTree_EndsWithNonPrimitiveType";
        internal const string EpmSourceTree_InvalidSourcePath = "EpmSourceTree_InvalidSourcePath";
        internal const string EpmSourceTree_MissingPropertyOnInstance = "EpmSourceTree_MissingPropertyOnInstance";
        internal const string EpmSourceTree_MissingPropertyOnType = "EpmSourceTree_MissingPropertyOnType";
        internal const string EpmSourceTree_OpenComplexPropertyCannotBeMapped = "EpmSourceTree_OpenComplexPropertyCannotBeMapped";
        internal const string EpmSourceTree_OpenPropertySpatialTypeCannotBeMapped = "EpmSourceTree_OpenPropertySpatialTypeCannotBeMapped";
        internal const string EpmSourceTree_SpatialTypeCannotBeMapped = "EpmSourceTree_SpatialTypeCannotBeMapped";
        internal const string EpmSourceTree_StreamPropertyCannotBeMapped = "EpmSourceTree_StreamPropertyCannotBeMapped";
        internal const string EpmSourceTree_TraversalOfNonComplexType = "EpmSourceTree_TraversalOfNonComplexType";
        internal const string EpmSyndicationReader_MultipleValuesForNonCollectionProperty = "EpmSyndicationReader_MultipleValuesForNonCollectionProperty";
        internal const string EpmSyndicationWriter_DateTimePropertyCanNotBeConverted = "EpmSyndicationWriter_DateTimePropertyCanNotBeConverted";
        internal const string EpmSyndicationWriter_EmptyCollectionMappedToAuthor = "EpmSyndicationWriter_EmptyCollectionMappedToAuthor";
        internal const string EpmSyndicationWriter_InvalidLinkLengthValue = "EpmSyndicationWriter_InvalidLinkLengthValue";
        internal const string EpmSyndicationWriter_InvalidValueForCategorySchemeCriteriaAttribute = "EpmSyndicationWriter_InvalidValueForCategorySchemeCriteriaAttribute";
        internal const string EpmSyndicationWriter_InvalidValueForLinkRelCriteriaAttribute = "EpmSyndicationWriter_InvalidValueForLinkRelCriteriaAttribute";
        internal const string EpmSyndicationWriter_NullValueForAttributeTarget = "EpmSyndicationWriter_NullValueForAttributeTarget";
        internal const string EpmTargetTree_AttributeInMiddle = "EpmTargetTree_AttributeInMiddle";
        internal const string EpmTargetTree_DuplicateEpmAttributesWithSameTargetName = "EpmTargetTree_DuplicateEpmAttributesWithSameTargetName";
        internal const string EpmTargetTree_InvalidTargetPath_EmptySegment = "EpmTargetTree_InvalidTargetPath_EmptySegment";
        internal const string EpmTargetTree_InvalidTargetPath_MixedContent = "EpmTargetTree_InvalidTargetPath_MixedContent";
        internal const string ExceptionUtils_ArgumentStringNullOrEmpty = "ExceptionUtils_ArgumentStringNullOrEmpty";
        internal const string ExceptionUtils_CheckIntegerNotNegative = "ExceptionUtils_CheckIntegerNotNegative";
        internal const string ExceptionUtils_CheckIntegerPositive = "ExceptionUtils_CheckIntegerPositive";
        internal const string ExceptionUtils_CheckLongPositive = "ExceptionUtils_CheckLongPositive";
        internal const string ExpressionLexer_DigitExpected = "ExpressionLexer_DigitExpected";
        internal const string ExpressionLexer_ExpectedLiteralToken = "ExpressionLexer_ExpectedLiteralToken";
        internal const string ExpressionLexer_InvalidCharacter = "ExpressionLexer_InvalidCharacter";
        internal const string ExpressionLexer_SyntaxError = "ExpressionLexer_SyntaxError";
        internal const string ExpressionLexer_UnterminatedLiteral = "ExpressionLexer_UnterminatedLiteral";
        internal const string ExpressionLexer_UnterminatedStringLiteral = "ExpressionLexer_UnterminatedStringLiteral";
        internal const string ExpressionToken_IdentifierExpected = "ExpressionToken_IdentifierExpected";
        internal const string FeedWithoutExpectedTypeValidator_IncompatibleTypes = "FeedWithoutExpectedTypeValidator_IncompatibleTypes";
        internal const string General_InternalError = "General_InternalError";
        internal const string HttpUtils_CannotConvertCharToInt = "HttpUtils_CannotConvertCharToInt";
        internal const string HttpUtils_ClosingQuoteNotFound = "HttpUtils_ClosingQuoteNotFound";
        internal const string HttpUtils_ContentTypeMissing = "HttpUtils_ContentTypeMissing";
        internal const string HttpUtils_EscapeCharAtEnd = "HttpUtils_EscapeCharAtEnd";
        internal const string HttpUtils_EscapeCharWithoutQuotes = "HttpUtils_EscapeCharWithoutQuotes";
        internal const string HttpUtils_ExpectedLiteralNotFoundInString = "HttpUtils_ExpectedLiteralNotFoundInString";
        internal const string HttpUtils_InvalidCharacterInQuotedParameterValue = "HttpUtils_InvalidCharacterInQuotedParameterValue";
        internal const string HttpUtils_InvalidCharsetName = "HttpUtils_InvalidCharsetName";
        internal const string HttpUtils_InvalidHttpMethodString = "HttpUtils_InvalidHttpMethodString";
        internal const string HttpUtils_InvalidQualityValue = "HttpUtils_InvalidQualityValue";
        internal const string HttpUtils_InvalidQualityValueStartChar = "HttpUtils_InvalidQualityValueStartChar";
        internal const string HttpUtils_InvalidSeparatorBetweenCharsets = "HttpUtils_InvalidSeparatorBetweenCharsets";
        internal const string HttpUtils_MediaTypeMissingParameterName = "HttpUtils_MediaTypeMissingParameterName";
        internal const string HttpUtils_MediaTypeMissingParameterValue = "HttpUtils_MediaTypeMissingParameterValue";
        internal const string HttpUtils_MediaTypeRequiresSemicolonBeforeParameter = "HttpUtils_MediaTypeRequiresSemicolonBeforeParameter";
        internal const string HttpUtils_MediaTypeRequiresSlash = "HttpUtils_MediaTypeRequiresSlash";
        internal const string HttpUtils_MediaTypeRequiresSubType = "HttpUtils_MediaTypeRequiresSubType";
        internal const string HttpUtils_MediaTypeUnspecified = "HttpUtils_MediaTypeUnspecified";
        internal const string HttpUtils_MissingSeparatorBetweenCharsets = "HttpUtils_MissingSeparatorBetweenCharsets";
        internal const string HttpUtils_NoOrMoreThanOneContentTypeSpecified = "HttpUtils_NoOrMoreThanOneContentTypeSpecified";
        internal const string HttpUtils_UnexpectedEndOfQValue = "HttpUtils_UnexpectedEndOfQValue";
        internal const string JsonReader_EndOfInputWithOpenScope = "JsonReader_EndOfInputWithOpenScope";
        internal const string JsonReader_InvalidNumberFormat = "JsonReader_InvalidNumberFormat";
        internal const string JsonReader_InvalidPropertyNameOrUnexpectedComma = "JsonReader_InvalidPropertyNameOrUnexpectedComma";
        internal const string JsonReader_MissingColon = "JsonReader_MissingColon";
        internal const string JsonReader_MissingComma = "JsonReader_MissingComma";
        internal const string JsonReader_MultipleTopLevelValues = "JsonReader_MultipleTopLevelValues";
        internal const string JsonReader_UnexpectedComma = "JsonReader_UnexpectedComma";
        internal const string JsonReader_UnexpectedEndOfString = "JsonReader_UnexpectedEndOfString";
        internal const string JsonReader_UnexpectedToken = "JsonReader_UnexpectedToken";
        internal const string JsonReader_UnrecognizedEscapeSequence = "JsonReader_UnrecognizedEscapeSequence";
        internal const string JsonReader_UnrecognizedToken = "JsonReader_UnrecognizedToken";
        internal const string JsonReaderExtensions_CannotReadPropertyValueAsString = "JsonReaderExtensions_CannotReadPropertyValueAsString";
        internal const string JsonReaderExtensions_CannotReadValueAsDouble = "JsonReaderExtensions_CannotReadValueAsDouble";
        internal const string JsonReaderExtensions_CannotReadValueAsString = "JsonReaderExtensions_CannotReadValueAsString";
        internal const string JsonReaderExtensions_UnexpectedNodeDetected = "JsonReaderExtensions_UnexpectedNodeDetected";
        private static TextRes loader;
        internal const string MediaType_EncodingNotSupported = "MediaType_EncodingNotSupported";
        internal const string MediaTypeUtils_BoundaryMustBeSpecifiedForBatchPayloads = "MediaTypeUtils_BoundaryMustBeSpecifiedForBatchPayloads";
        internal const string MediaTypeUtils_CannotDetermineFormatFromContentType = "MediaTypeUtils_CannotDetermineFormatFromContentType";
        internal const string MediaTypeUtils_DidNotFindMatchingMediaType = "MediaTypeUtils_DidNotFindMatchingMediaType";
        internal const string MediaTypeUtils_NoOrMoreThanOneContentTypeSpecified = "MediaTypeUtils_NoOrMoreThanOneContentTypeSpecified";
        internal const string MessageStreamWrappingStream_ByteLimitExceeded = "MessageStreamWrappingStream_ByteLimitExceeded";
        internal const string MetadataUtils_ResolveTypeName = "MetadataUtils_ResolveTypeName";
        internal const string ODataAtomCollectionDeserializer_TopLevelCollectionElementWrongNamespace = "ODataAtomCollectionDeserializer_TopLevelCollectionElementWrongNamespace";
        internal const string ODataAtomCollectionDeserializer_TypeOrNullAttributeNotAllowed = "ODataAtomCollectionDeserializer_TypeOrNullAttributeNotAllowed";
        internal const string ODataAtomCollectionDeserializer_WrongCollectionItemElementName = "ODataAtomCollectionDeserializer_WrongCollectionItemElementName";
        internal const string ODataAtomCollectionWriter_CollectionNameMustNotBeNull = "ODataAtomCollectionWriter_CollectionNameMustNotBeNull";
        internal const string ODataAtomDeserializer_RelativeUriUsedWithoutBaseUriSpecified = "ODataAtomDeserializer_RelativeUriUsedWithoutBaseUriSpecified";
        internal const string ODataAtomEntityReferenceLinkDeserializer_InvalidEntityReferenceLinksStartElement = "ODataAtomEntityReferenceLinkDeserializer_InvalidEntityReferenceLinksStartElement";
        internal const string ODataAtomEntityReferenceLinkDeserializer_InvalidEntityReferenceLinkStartElement = "ODataAtomEntityReferenceLinkDeserializer_InvalidEntityReferenceLinkStartElement";
        internal const string ODataAtomEntityReferenceLinkDeserializer_MultipleEntityReferenceLinksElementsWithSameName = "ODataAtomEntityReferenceLinkDeserializer_MultipleEntityReferenceLinksElementsWithSameName";
        internal const string ODataAtomEntryAndFeedDeserializer_ContentWithInvalidNode = "ODataAtomEntryAndFeedDeserializer_ContentWithInvalidNode";
        internal const string ODataAtomEntryAndFeedDeserializer_ContentWithSourceLinkIsNotEmpty = "ODataAtomEntryAndFeedDeserializer_ContentWithSourceLinkIsNotEmpty";
        internal const string ODataAtomEntryAndFeedDeserializer_ContentWithWrongType = "ODataAtomEntryAndFeedDeserializer_ContentWithWrongType";
        internal const string ODataAtomEntryAndFeedDeserializer_DuplicateElements = "ODataAtomEntryAndFeedDeserializer_DuplicateElements";
        internal const string ODataAtomEntryAndFeedDeserializer_ElementExpected = "ODataAtomEntryAndFeedDeserializer_ElementExpected";
        internal const string ODataAtomEntryAndFeedDeserializer_EntryElementWrongName = "ODataAtomEntryAndFeedDeserializer_EntryElementWrongName";
        internal const string ODataAtomEntryAndFeedDeserializer_FeedElementWrongName = "ODataAtomEntryAndFeedDeserializer_FeedElementWrongName";
        internal const string ODataAtomEntryAndFeedDeserializer_InvalidTypeAttributeOnAssociationLink = "ODataAtomEntryAndFeedDeserializer_InvalidTypeAttributeOnAssociationLink";
        internal const string ODataAtomEntryAndFeedDeserializer_MultipleExpansionsInInline = "ODataAtomEntryAndFeedDeserializer_MultipleExpansionsInInline";
        internal const string ODataAtomEntryAndFeedDeserializer_MultipleInlineElementsInLink = "ODataAtomEntryAndFeedDeserializer_MultipleInlineElementsInLink";
        internal const string ODataAtomEntryAndFeedDeserializer_MultipleLinksInEntry = "ODataAtomEntryAndFeedDeserializer_MultipleLinksInEntry";
        internal const string ODataAtomEntryAndFeedDeserializer_MultipleLinksInFeed = "ODataAtomEntryAndFeedDeserializer_MultipleLinksInFeed";
        internal const string ODataAtomEntryAndFeedDeserializer_OperationMissingMetadataAttribute = "ODataAtomEntryAndFeedDeserializer_OperationMissingMetadataAttribute";
        internal const string ODataAtomEntryAndFeedDeserializer_OperationMissingTargetAttribute = "ODataAtomEntryAndFeedDeserializer_OperationMissingTargetAttribute";
        internal const string ODataAtomEntryAndFeedDeserializer_StreamPropertyDuplicatePropertyName = "ODataAtomEntryAndFeedDeserializer_StreamPropertyDuplicatePropertyName";
        internal const string ODataAtomEntryAndFeedDeserializer_StreamPropertyWithEmptyName = "ODataAtomEntryAndFeedDeserializer_StreamPropertyWithEmptyName";
        internal const string ODataAtomEntryAndFeedDeserializer_StreamPropertyWithMultipleContentTypes = "ODataAtomEntryAndFeedDeserializer_StreamPropertyWithMultipleContentTypes";
        internal const string ODataAtomEntryAndFeedDeserializer_StreamPropertyWithMultipleEditLinks = "ODataAtomEntryAndFeedDeserializer_StreamPropertyWithMultipleEditLinks";
        internal const string ODataAtomEntryAndFeedDeserializer_StreamPropertyWithMultipleReadLinks = "ODataAtomEntryAndFeedDeserializer_StreamPropertyWithMultipleReadLinks";
        internal const string ODataAtomEntryAndFeedDeserializer_UnknownElementInInline = "ODataAtomEntryAndFeedDeserializer_UnknownElementInInline";
        internal const string ODataAtomEntryMetadataDeserializer_InvalidTextConstructKind = "ODataAtomEntryMetadataDeserializer_InvalidTextConstructKind";
        internal const string ODataAtomErrorDeserializer_InvalidRootElement = "ODataAtomErrorDeserializer_InvalidRootElement";
        internal const string ODataAtomErrorDeserializer_MultipleErrorElementsWithSameName = "ODataAtomErrorDeserializer_MultipleErrorElementsWithSameName";
        internal const string ODataAtomErrorDeserializer_MultipleInnerErrorElementsWithSameName = "ODataAtomErrorDeserializer_MultipleInnerErrorElementsWithSameName";
        internal const string ODataAtomInputContext_NonEmptyElementWithNullAttribute = "ODataAtomInputContext_NonEmptyElementWithNullAttribute";
        internal const string ODataAtomMetadataDeserializer_MultipleSingletonMetadataElements = "ODataAtomMetadataDeserializer_MultipleSingletonMetadataElements";
        internal const string ODataAtomMetadataEpmMerge_TextKindConflict = "ODataAtomMetadataEpmMerge_TextKindConflict";
        internal const string ODataAtomMetadataEpmMerge_TextValueConflict = "ODataAtomMetadataEpmMerge_TextValueConflict";
        internal const string ODataAtomPropertyAndValueDeserializer_InvalidCollectionElement = "ODataAtomPropertyAndValueDeserializer_InvalidCollectionElement";
        internal const string ODataAtomPropertyAndValueDeserializer_NavigationPropertyInProperties = "ODataAtomPropertyAndValueDeserializer_NavigationPropertyInProperties";
        internal const string ODataAtomPropertyAndValueDeserializer_NonEmptyElementWithNullAttribute = "ODataAtomPropertyAndValueDeserializer_NonEmptyElementWithNullAttribute";
        internal const string ODataAtomPropertyAndValueDeserializer_TopLevelPropertyElementWrongNamespace = "ODataAtomPropertyAndValueDeserializer_TopLevelPropertyElementWrongNamespace";
        internal const string ODataAtomReader_DeferredEntryInFeedNavigationLink = "ODataAtomReader_DeferredEntryInFeedNavigationLink";
        internal const string ODataAtomReader_EntryXmlCustomizationCallbackReturnedSameInstance = "ODataAtomReader_EntryXmlCustomizationCallbackReturnedSameInstance";
        internal const string ODataAtomReader_ExpandedEntryInFeedNavigationLink = "ODataAtomReader_ExpandedEntryInFeedNavigationLink";
        internal const string ODataAtomReader_ExpandedFeedInEntryNavigationLink = "ODataAtomReader_ExpandedFeedInEntryNavigationLink";
        internal const string ODataAtomReader_FeedNavigationLinkForResourceReferenceProperty = "ODataAtomReader_FeedNavigationLinkForResourceReferenceProperty";
        internal const string ODataAtomReader_MediaLinkEntryMismatch = "ODataAtomReader_MediaLinkEntryMismatch";
        internal const string ODataAtomReaderUtils_InvalidTypeName = "ODataAtomReaderUtils_InvalidTypeName";
        internal const string ODataAtomServiceDocumentDeserializer_MissingWorkspaceElement = "ODataAtomServiceDocumentDeserializer_MissingWorkspaceElement";
        internal const string ODataAtomServiceDocumentDeserializer_MultipleWorkspaceElementsFound = "ODataAtomServiceDocumentDeserializer_MultipleWorkspaceElementsFound";
        internal const string ODataAtomServiceDocumentDeserializer_ServiceDocumentRootElementWrongNameOrNamespace = "ODataAtomServiceDocumentDeserializer_ServiceDocumentRootElementWrongNameOrNamespace";
        internal const string ODataAtomServiceDocumentDeserializer_UnexpectedElementInResourceCollection = "ODataAtomServiceDocumentDeserializer_UnexpectedElementInResourceCollection";
        internal const string ODataAtomServiceDocumentDeserializer_UnexpectedElementInServiceDocument = "ODataAtomServiceDocumentDeserializer_UnexpectedElementInServiceDocument";
        internal const string ODataAtomServiceDocumentDeserializer_UnexpectedElementInWorkspace = "ODataAtomServiceDocumentDeserializer_UnexpectedElementInWorkspace";
        internal const string ODataAtomServiceDocumentMetadataDeserializer_InvalidFixedAttributeValue = "ODataAtomServiceDocumentMetadataDeserializer_InvalidFixedAttributeValue";
        internal const string ODataAtomServiceDocumentMetadataDeserializer_MultipleAcceptElementsFoundInCollection = "ODataAtomServiceDocumentMetadataDeserializer_MultipleAcceptElementsFoundInCollection";
        internal const string ODataAtomServiceDocumentMetadataDeserializer_MultipleTitleElementsFound = "ODataAtomServiceDocumentMetadataDeserializer_MultipleTitleElementsFound";
        internal const string ODataAtomWriter_StartEntryXmlCustomizationCallbackReturnedSameInstance = "ODataAtomWriter_StartEntryXmlCustomizationCallbackReturnedSameInstance";
        internal const string ODataAtomWriterMetadataUtils_AuthorMetadataMustNotContainNull = "ODataAtomWriterMetadataUtils_AuthorMetadataMustNotContainNull";
        internal const string ODataAtomWriterMetadataUtils_CategoriesHrefWithOtherValues = "ODataAtomWriterMetadataUtils_CategoriesHrefWithOtherValues";
        internal const string ODataAtomWriterMetadataUtils_CategoryMetadataMustNotContainNull = "ODataAtomWriterMetadataUtils_CategoryMetadataMustNotContainNull";
        internal const string ODataAtomWriterMetadataUtils_CategoryMustSpecifyTerm = "ODataAtomWriterMetadataUtils_CategoryMustSpecifyTerm";
        internal const string ODataAtomWriterMetadataUtils_CategorySchemesMustMatch = "ODataAtomWriterMetadataUtils_CategorySchemesMustMatch";
        internal const string ODataAtomWriterMetadataUtils_CategoryTermsMustMatch = "ODataAtomWriterMetadataUtils_CategoryTermsMustMatch";
        internal const string ODataAtomWriterMetadataUtils_ContributorMetadataMustNotContainNull = "ODataAtomWriterMetadataUtils_ContributorMetadataMustNotContainNull";
        internal const string ODataAtomWriterMetadataUtils_InvalidAnnotationValue = "ODataAtomWriterMetadataUtils_InvalidAnnotationValue";
        internal const string ODataAtomWriterMetadataUtils_LinkHrefsMustMatch = "ODataAtomWriterMetadataUtils_LinkHrefsMustMatch";
        internal const string ODataAtomWriterMetadataUtils_LinkMediaTypesMustMatch = "ODataAtomWriterMetadataUtils_LinkMediaTypesMustMatch";
        internal const string ODataAtomWriterMetadataUtils_LinkMetadataMustNotContainNull = "ODataAtomWriterMetadataUtils_LinkMetadataMustNotContainNull";
        internal const string ODataAtomWriterMetadataUtils_LinkMustSpecifyHref = "ODataAtomWriterMetadataUtils_LinkMustSpecifyHref";
        internal const string ODataAtomWriterMetadataUtils_LinkRelationsMustMatch = "ODataAtomWriterMetadataUtils_LinkRelationsMustMatch";
        internal const string ODataAtomWriterMetadataUtils_LinkTitlesMustMatch = "ODataAtomWriterMetadataUtils_LinkTitlesMustMatch";
        internal const string ODataBatch_InvalidHttpMethodForChangeSetRequest = "ODataBatch_InvalidHttpMethodForChangeSetRequest";
        internal const string ODataBatch_InvalidHttpMethodForQueryOperation = "ODataBatch_InvalidHttpMethodForQueryOperation";
        internal const string ODataBatchOperationHeaderDictionary_DuplicateCaseInsensitiveKeys = "ODataBatchOperationHeaderDictionary_DuplicateCaseInsensitiveKeys";
        internal const string ODataBatchOperationHeaderDictionary_KeyNotFound = "ODataBatchOperationHeaderDictionary_KeyNotFound";
        internal const string ODataBatchOperationMessage_VerifyNotCompleted = "ODataBatchOperationMessage_VerifyNotCompleted";
        internal const string ODataBatchOperationStream_Disposed = "ODataBatchOperationStream_Disposed";
        internal const string ODataBatchReader_AsyncCallOnSyncReader = "ODataBatchReader_AsyncCallOnSyncReader";
        internal const string ODataBatchReader_CannotCreateRequestOperationWhenReadingResponse = "ODataBatchReader_CannotCreateRequestOperationWhenReadingResponse";
        internal const string ODataBatchReader_CannotCreateResponseOperationWhenReadingRequest = "ODataBatchReader_CannotCreateResponseOperationWhenReadingRequest";
        internal const string ODataBatchReader_CannotUseReaderWhileOperationStreamActive = "ODataBatchReader_CannotUseReaderWhileOperationStreamActive";
        internal const string ODataBatchReader_DuplicateContentIDsNotAllowed = "ODataBatchReader_DuplicateContentIDsNotAllowed";
        internal const string ODataBatchReader_InvalidStateForCreateOperationRequestMessage = "ODataBatchReader_InvalidStateForCreateOperationRequestMessage";
        internal const string ODataBatchReader_InvalidStateForCreateOperationResponseMessage = "ODataBatchReader_InvalidStateForCreateOperationResponseMessage";
        internal const string ODataBatchReader_MaxBatchSizeExceeded = "ODataBatchReader_MaxBatchSizeExceeded";
        internal const string ODataBatchReader_MaxChangeSetSizeExceeded = "ODataBatchReader_MaxChangeSetSizeExceeded";
        internal const string ODataBatchReader_NoMessageWasCreatedForOperation = "ODataBatchReader_NoMessageWasCreatedForOperation";
        internal const string ODataBatchReader_OperationRequestMessageAlreadyCreated = "ODataBatchReader_OperationRequestMessageAlreadyCreated";
        internal const string ODataBatchReader_OperationResponseMessageAlreadyCreated = "ODataBatchReader_OperationResponseMessageAlreadyCreated";
        internal const string ODataBatchReader_ReadOrReadAsyncCalledInInvalidState = "ODataBatchReader_ReadOrReadAsyncCalledInInvalidState";
        internal const string ODataBatchReader_SyncCallOnAsyncReader = "ODataBatchReader_SyncCallOnAsyncReader";
        internal const string ODataBatchReaderStream_DuplicateHeaderFound = "ODataBatchReaderStream_DuplicateHeaderFound";
        internal const string ODataBatchReaderStream_InvalidContentLengthSpecified = "ODataBatchReaderStream_InvalidContentLengthSpecified";
        internal const string ODataBatchReaderStream_InvalidContentTypeSpecified = "ODataBatchReaderStream_InvalidContentTypeSpecified";
        internal const string ODataBatchReaderStream_InvalidHeaderSpecified = "ODataBatchReaderStream_InvalidHeaderSpecified";
        internal const string ODataBatchReaderStream_InvalidHttpVersionSpecified = "ODataBatchReaderStream_InvalidHttpVersionSpecified";
        internal const string ODataBatchReaderStream_InvalidRequestLine = "ODataBatchReaderStream_InvalidRequestLine";
        internal const string ODataBatchReaderStream_InvalidResponseLine = "ODataBatchReaderStream_InvalidResponseLine";
        internal const string ODataBatchReaderStream_MissingContentTypeHeader = "ODataBatchReaderStream_MissingContentTypeHeader";
        internal const string ODataBatchReaderStream_MissingOrInvalidContentEncodingHeader = "ODataBatchReaderStream_MissingOrInvalidContentEncodingHeader";
        internal const string ODataBatchReaderStream_MultiByteEncodingsNotSupported = "ODataBatchReaderStream_MultiByteEncodingsNotSupported";
        internal const string ODataBatchReaderStream_NestedChangesetsAreNotSupported = "ODataBatchReaderStream_NestedChangesetsAreNotSupported";
        internal const string ODataBatchReaderStream_NonIntegerHttpStatusCode = "ODataBatchReaderStream_NonIntegerHttpStatusCode";
        internal const string ODataBatchReaderStreamBuffer_BoundaryLineSecurityLimitReached = "ODataBatchReaderStreamBuffer_BoundaryLineSecurityLimitReached";
        internal const string ODataBatchUtils_RelativeUriStartingWithDollarUsedWithoutBaseUriSpecified = "ODataBatchUtils_RelativeUriStartingWithDollarUsedWithoutBaseUriSpecified";
        internal const string ODataBatchUtils_RelativeUriUsedWithoutBaseUriSpecified = "ODataBatchUtils_RelativeUriUsedWithoutBaseUriSpecified";
        internal const string ODataBatchWriter_AsyncCallOnSyncWriter = "ODataBatchWriter_AsyncCallOnSyncWriter";
        internal const string ODataBatchWriter_CannotCompleteBatchWithActiveChangeSet = "ODataBatchWriter_CannotCompleteBatchWithActiveChangeSet";
        internal const string ODataBatchWriter_CannotCompleteChangeSetWithoutActiveChangeSet = "ODataBatchWriter_CannotCompleteChangeSetWithoutActiveChangeSet";
        internal const string ODataBatchWriter_CannotCreateRequestOperationWhenWritingResponse = "ODataBatchWriter_CannotCreateRequestOperationWhenWritingResponse";
        internal const string ODataBatchWriter_CannotCreateResponseOperationWhenWritingRequest = "ODataBatchWriter_CannotCreateResponseOperationWhenWritingRequest";
        internal const string ODataBatchWriter_CannotStartChangeSetWithActiveChangeSet = "ODataBatchWriter_CannotStartChangeSetWithActiveChangeSet";
        internal const string ODataBatchWriter_CannotWriteInStreamErrorForBatch = "ODataBatchWriter_CannotWriteInStreamErrorForBatch";
        internal const string ODataBatchWriter_DuplicateContentIDsNotAllowed = "ODataBatchWriter_DuplicateContentIDsNotAllowed";
        internal const string ODataBatchWriter_FlushOrFlushAsyncCalledInStreamRequestedState = "ODataBatchWriter_FlushOrFlushAsyncCalledInStreamRequestedState";
        internal const string ODataBatchWriter_InvalidTransitionFromBatchCompleted = "ODataBatchWriter_InvalidTransitionFromBatchCompleted";
        internal const string ODataBatchWriter_InvalidTransitionFromBatchStarted = "ODataBatchWriter_InvalidTransitionFromBatchStarted";
        internal const string ODataBatchWriter_InvalidTransitionFromChangeSetCompleted = "ODataBatchWriter_InvalidTransitionFromChangeSetCompleted";
        internal const string ODataBatchWriter_InvalidTransitionFromChangeSetStarted = "ODataBatchWriter_InvalidTransitionFromChangeSetStarted";
        internal const string ODataBatchWriter_InvalidTransitionFromOperationContentStreamDisposed = "ODataBatchWriter_InvalidTransitionFromOperationContentStreamDisposed";
        internal const string ODataBatchWriter_InvalidTransitionFromOperationContentStreamRequested = "ODataBatchWriter_InvalidTransitionFromOperationContentStreamRequested";
        internal const string ODataBatchWriter_InvalidTransitionFromOperationCreated = "ODataBatchWriter_InvalidTransitionFromOperationCreated";
        internal const string ODataBatchWriter_InvalidTransitionFromStart = "ODataBatchWriter_InvalidTransitionFromStart";
        internal const string ODataBatchWriter_MaxBatchSizeExceeded = "ODataBatchWriter_MaxBatchSizeExceeded";
        internal const string ODataBatchWriter_MaxChangeSetSizeExceeded = "ODataBatchWriter_MaxChangeSetSizeExceeded";
        internal const string ODataBatchWriter_SyncCallOnAsyncWriter = "ODataBatchWriter_SyncCallOnAsyncWriter";
        internal const string ODataCollectionReaderCore_AsyncCallOnSyncReader = "ODataCollectionReaderCore_AsyncCallOnSyncReader";
        internal const string ODataCollectionReaderCore_ReadOrReadAsyncCalledInInvalidState = "ODataCollectionReaderCore_ReadOrReadAsyncCalledInInvalidState";
        internal const string ODataCollectionReaderCore_SyncCallOnAsyncReader = "ODataCollectionReaderCore_SyncCallOnAsyncReader";
        internal const string ODataCollectionWriter_CannotCreateCollectionWriterForFormat = "ODataCollectionWriter_CannotCreateCollectionWriterForFormat";
        internal const string ODataCollectionWriterCore_AsyncCallOnSyncWriter = "ODataCollectionWriterCore_AsyncCallOnSyncWriter";
        internal const string ODataCollectionWriterCore_CollectionsMustNotHaveEmptyName = "ODataCollectionWriterCore_CollectionsMustNotHaveEmptyName";
        internal const string ODataCollectionWriterCore_InvalidTransitionFromCollection = "ODataCollectionWriterCore_InvalidTransitionFromCollection";
        internal const string ODataCollectionWriterCore_InvalidTransitionFromItem = "ODataCollectionWriterCore_InvalidTransitionFromItem";
        internal const string ODataCollectionWriterCore_InvalidTransitionFromStart = "ODataCollectionWriterCore_InvalidTransitionFromStart";
        internal const string ODataCollectionWriterCore_SyncCallOnAsyncWriter = "ODataCollectionWriterCore_SyncCallOnAsyncWriter";
        internal const string ODataCollectionWriterCore_WriteEndCalledInInvalidState = "ODataCollectionWriterCore_WriteEndCalledInInvalidState";
        internal const string ODataErrorException_GeneralError = "ODataErrorException_GeneralError";
        internal const string ODataException_GeneralError = "ODataException_GeneralError";
        internal const string ODataInputContext_UnsupportedPayloadKindForFormat = "ODataInputContext_UnsupportedPayloadKindForFormat";
        internal const string ODataJsonCollectionDeserializer_CannotReadCollectionContentStart = "ODataJsonCollectionDeserializer_CannotReadCollectionContentStart";
        internal const string ODataJsonCollectionDeserializer_MissingResultsPropertyForCollection = "ODataJsonCollectionDeserializer_MissingResultsPropertyForCollection";
        internal const string ODataJsonCollectionDeserializer_MultipleResultsPropertiesForCollection = "ODataJsonCollectionDeserializer_MultipleResultsPropertiesForCollection";
        internal const string ODataJsonCollectionReader_CannotReadCollectionStart = "ODataJsonCollectionReader_CannotReadCollectionStart";
        internal const string ODataJsonCollectionReader_CannotReadWrappedCollectionStart = "ODataJsonCollectionReader_CannotReadWrappedCollectionStart";
        internal const string ODataJsonCollectionReader_ParsingWithoutMetadata = "ODataJsonCollectionReader_ParsingWithoutMetadata";
        internal const string ODataJsonDeserializer_DataWrapperMultipleProperties = "ODataJsonDeserializer_DataWrapperMultipleProperties";
        internal const string ODataJsonDeserializer_DataWrapperPropertyNotFound = "ODataJsonDeserializer_DataWrapperPropertyNotFound";
        internal const string ODataJsonDeserializer_RelativeUriUsedWithoutBaseUriSpecified = "ODataJsonDeserializer_RelativeUriUsedWithoutBaseUriSpecified";
        internal const string ODataJsonEntityReferenceLinkDeserializer_EntityReferenceLinkMustBeObjectValue = "ODataJsonEntityReferenceLinkDeserializer_EntityReferenceLinkMustBeObjectValue";
        internal const string ODataJsonEntityReferenceLinkDeserializer_EntityReferenceLinkUriCannotBeNull = "ODataJsonEntityReferenceLinkDeserializer_EntityReferenceLinkUriCannotBeNull";
        internal const string ODataJsonEntityReferenceLinkDeserializer_ExpectedEntityReferenceLinksResultsPropertyNotFound = "ODataJsonEntityReferenceLinkDeserializer_ExpectedEntityReferenceLinksResultsPropertyNotFound";
        internal const string ODataJsonEntityReferenceLinkDeserializer_MultipleUriPropertiesInEntityReferenceLink = "ODataJsonEntityReferenceLinkDeserializer_MultipleUriPropertiesInEntityReferenceLink";
        internal const string ODataJsonEntryAndFeedDeserializer_CannotParseStreamReference = "ODataJsonEntryAndFeedDeserializer_CannotParseStreamReference";
        internal const string ODataJsonEntryAndFeedDeserializer_CannotReadCollectionNavigationPropertyValue = "ODataJsonEntryAndFeedDeserializer_CannotReadCollectionNavigationPropertyValue";
        internal const string ODataJsonEntryAndFeedDeserializer_CannotReadFeedContentStart = "ODataJsonEntryAndFeedDeserializer_CannotReadFeedContentStart";
        internal const string ODataJsonEntryAndFeedDeserializer_CannotReadNavigationPropertyValue = "ODataJsonEntryAndFeedDeserializer_CannotReadNavigationPropertyValue";
        internal const string ODataJsonEntryAndFeedDeserializer_CannotReadSingletonNavigationPropertyValue = "ODataJsonEntryAndFeedDeserializer_CannotReadSingletonNavigationPropertyValue";
        internal const string ODataJsonEntryAndFeedDeserializer_DeferredLinkMissingUri = "ODataJsonEntryAndFeedDeserializer_DeferredLinkMissingUri";
        internal const string ODataJsonEntryAndFeedDeserializer_DeferredLinkUriCannotBeNull = "ODataJsonEntryAndFeedDeserializer_DeferredLinkUriCannotBeNull";
        internal const string ODataJsonEntryAndFeedDeserializer_ExpectedFeedResultsPropertyNotFound = "ODataJsonEntryAndFeedDeserializer_ExpectedFeedResultsPropertyNotFound";
        internal const string ODataJsonEntryAndFeedDeserializer_MetadataMustHaveArrayValue = "ODataJsonEntryAndFeedDeserializer_MetadataMustHaveArrayValue";
        internal const string ODataJsonEntryAndFeedDeserializer_MultipleFeedResultsPropertiesFound = "ODataJsonEntryAndFeedDeserializer_MultipleFeedResultsPropertiesFound";
        internal const string ODataJsonEntryAndFeedDeserializer_MultipleMetadataPropertiesForStreamProperty = "ODataJsonEntryAndFeedDeserializer_MultipleMetadataPropertiesForStreamProperty";
        internal const string ODataJsonEntryAndFeedDeserializer_MultipleMetadataPropertiesInEntryValue = "ODataJsonEntryAndFeedDeserializer_MultipleMetadataPropertiesInEntryValue";
        internal const string ODataJsonEntryAndFeedDeserializer_MultipleOptionalPropertiesInOperation = "ODataJsonEntryAndFeedDeserializer_MultipleOptionalPropertiesInOperation";
        internal const string ODataJsonEntryAndFeedDeserializer_MultipleTargetPropertiesInOperation = "ODataJsonEntryAndFeedDeserializer_MultipleTargetPropertiesInOperation";
        internal const string ODataJsonEntryAndFeedDeserializer_MultipleUriPropertiesInDeferredLink = "ODataJsonEntryAndFeedDeserializer_MultipleUriPropertiesInDeferredLink";
        internal const string ODataJsonEntryAndFeedDeserializer_OperationMetadataArrayExpectedAnObject = "ODataJsonEntryAndFeedDeserializer_OperationMetadataArrayExpectedAnObject";
        internal const string ODataJsonEntryAndFeedDeserializer_OperationMissingTargetProperty = "ODataJsonEntryAndFeedDeserializer_OperationMissingTargetProperty";
        internal const string ODataJsonEntryAndFeedDeserializer_PropertyInEntryMustHaveObjectValue = "ODataJsonEntryAndFeedDeserializer_PropertyInEntryMustHaveObjectValue";
        internal const string ODataJsonEntryAndFeedDeserializer_RepeatMetadataValue = "ODataJsonEntryAndFeedDeserializer_RepeatMetadataValue";
        internal const string ODataJsonEntryAndFeedDeserializer_StreamPropertyInRequest = "ODataJsonEntryAndFeedDeserializer_StreamPropertyInRequest";
        internal const string ODataJsonErrorDeserializer_TopLevelErrorMessageValueWithInvalidProperty = "ODataJsonErrorDeserializer_TopLevelErrorMessageValueWithInvalidProperty";
        internal const string ODataJsonErrorDeserializer_TopLevelErrorValueWithInvalidProperty = "ODataJsonErrorDeserializer_TopLevelErrorValueWithInvalidProperty";
        internal const string ODataJsonErrorDeserializer_TopLevelErrorWithInvalidProperty = "ODataJsonErrorDeserializer_TopLevelErrorWithInvalidProperty";
        internal const string ODataJsonInputContext_FunctionImportCannotBeNullForCreateParameterReader = "ODataJsonInputContext_FunctionImportCannotBeNullForCreateParameterReader";
        internal const string ODataJsonParameterReader_NullCollectionExpected = "ODataJsonParameterReader_NullCollectionExpected";
        internal const string ODataJsonParameterReader_UnsupportedParameterTypeKind = "ODataJsonParameterReader_UnsupportedParameterTypeKind";
        internal const string ODataJsonParameterReader_UnsupportedPrimitiveParameterType = "ODataJsonParameterReader_UnsupportedPrimitiveParameterType";
        internal const string ODataJsonPropertyAndValueDeserializer_CannotReadPropertyValue = "ODataJsonPropertyAndValueDeserializer_CannotReadPropertyValue";
        internal const string ODataJsonPropertyAndValueDeserializer_CannotReadSpatialPropertyValue = "ODataJsonPropertyAndValueDeserializer_CannotReadSpatialPropertyValue";
        internal const string ODataJsonPropertyAndValueDeserializer_CollectionWithoutResults = "ODataJsonPropertyAndValueDeserializer_CollectionWithoutResults";
        internal const string ODataJsonPropertyAndValueDeserializer_InvalidPrimitiveTypeName = "ODataJsonPropertyAndValueDeserializer_InvalidPrimitiveTypeName";
        internal const string ODataJsonPropertyAndValueDeserializer_InvalidTopLevelPropertyPayload = "ODataJsonPropertyAndValueDeserializer_InvalidTopLevelPropertyPayload";
        internal const string ODataJsonPropertyAndValueDeserializer_InvalidTypeName = "ODataJsonPropertyAndValueDeserializer_InvalidTypeName";
        internal const string ODataJsonPropertyAndValueDeserializer_MetadataPropertyMustHaveObjectValue = "ODataJsonPropertyAndValueDeserializer_MetadataPropertyMustHaveObjectValue";
        internal const string ODataJsonPropertyAndValueDeserializer_MultipleMetadataPropertiesInComplexValue = "ODataJsonPropertyAndValueDeserializer_MultipleMetadataPropertiesInComplexValue";
        internal const string ODataJsonPropertyAndValueDeserializer_MultiplePropertiesInCollectionWrapper = "ODataJsonPropertyAndValueDeserializer_MultiplePropertiesInCollectionWrapper";
        internal const string ODataJsonPropertyAndValueDeserializer_TopLevelPropertyWithoutMetadata = "ODataJsonPropertyAndValueDeserializer_TopLevelPropertyWithoutMetadata";
        internal const string ODataJsonReader_CannotReadEntriesOfFeed = "ODataJsonReader_CannotReadEntriesOfFeed";
        internal const string ODataJsonReader_CannotReadEntryStart = "ODataJsonReader_CannotReadEntryStart";
        internal const string ODataJsonReader_CannotReadFeedStart = "ODataJsonReader_CannotReadFeedStart";
        internal const string ODataJsonReader_ParsingWithoutMetadata = "ODataJsonReader_ParsingWithoutMetadata";
        internal const string ODataJsonReaderUtils_CannotConvertBoolean = "ODataJsonReaderUtils_CannotConvertBoolean";
        internal const string ODataJsonReaderUtils_CannotConvertDateTime = "ODataJsonReaderUtils_CannotConvertDateTime";
        internal const string ODataJsonReaderUtils_CannotConvertDateTimeOffset = "ODataJsonReaderUtils_CannotConvertDateTimeOffset";
        internal const string ODataJsonReaderUtils_CannotConvertDouble = "ODataJsonReaderUtils_CannotConvertDouble";
        internal const string ODataJsonReaderUtils_CannotConvertInt32 = "ODataJsonReaderUtils_CannotConvertInt32";
        internal const string ODataJsonReaderUtils_CannotConvertInt64OrDecimal = "ODataJsonReaderUtils_CannotConvertInt64OrDecimal";
        internal const string ODataJsonReaderUtils_EntityReferenceLinksInlineCountWithNullValue = "ODataJsonReaderUtils_EntityReferenceLinksInlineCountWithNullValue";
        internal const string ODataJsonReaderUtils_EntityReferenceLinksPropertyWithNullValue = "ODataJsonReaderUtils_EntityReferenceLinksPropertyWithNullValue";
        internal const string ODataJsonReaderUtils_FeedPropertyWithNullValue = "ODataJsonReaderUtils_FeedPropertyWithNullValue";
        internal const string ODataJsonReaderUtils_MediaResourcePropertyWithNullValue = "ODataJsonReaderUtils_MediaResourcePropertyWithNullValue";
        internal const string ODataJsonReaderUtils_MetadataPropertyWithNullValue = "ODataJsonReaderUtils_MetadataPropertyWithNullValue";
        internal const string ODataJsonReaderUtils_MultipleEntityReferenceLinksWrapperPropertiesWithSameName = "ODataJsonReaderUtils_MultipleEntityReferenceLinksWrapperPropertiesWithSameName";
        internal const string ODataJsonReaderUtils_MultipleErrorPropertiesWithSameName = "ODataJsonReaderUtils_MultipleErrorPropertiesWithSameName";
        internal const string ODataJsonReaderUtils_MultipleMetadataPropertiesWithSameName = "ODataJsonReaderUtils_MultipleMetadataPropertiesWithSameName";
        internal const string ODataJsonReaderUtils_OperationPropertyCannotBeNull = "ODataJsonReaderUtils_OperationPropertyCannotBeNull";
        internal const string ODataJsonServiceDocumentDeserializer_MultipleEntitySetsPropertiesForServiceDocument = "ODataJsonServiceDocumentDeserializer_MultipleEntitySetsPropertiesForServiceDocument";
        internal const string ODataJsonServiceDocumentDeserializer_NoEntitySetsPropertyForServiceDocument = "ODataJsonServiceDocumentDeserializer_NoEntitySetsPropertyForServiceDocument";
        internal const string ODataJsonWriter_UnsupportedValueType = "ODataJsonWriter_UnsupportedValueType";
        internal const string ODataMediaTypeUtils_BoundaryMustBeSpecifiedForBatchPayloads = "ODataMediaTypeUtils_BoundaryMustBeSpecifiedForBatchPayloads";
        internal const string ODataMessage_MustNotModifyMessage = "ODataMessage_MustNotModifyMessage";
        internal const string ODataMessageReader_DetectPayloadKindMultipleTimes = "ODataMessageReader_DetectPayloadKindMultipleTimes";
        internal const string ODataMessageReader_EntityReferenceLinksInRequestNotAllowed = "ODataMessageReader_EntityReferenceLinksInRequestNotAllowed";
        internal const string ODataMessageReader_ErrorPayloadInRequest = "ODataMessageReader_ErrorPayloadInRequest";
        internal const string ODataMessageReader_ExpectedCollectionTypeWrongKind = "ODataMessageReader_ExpectedCollectionTypeWrongKind";
        internal const string ODataMessageReader_ExpectedPropertyTypeEntityKind = "ODataMessageReader_ExpectedPropertyTypeEntityKind";
        internal const string ODataMessageReader_ExpectedPropertyTypeStream = "ODataMessageReader_ExpectedPropertyTypeStream";
        internal const string ODataMessageReader_ExpectedTypeSpecifiedWithoutMetadata = "ODataMessageReader_ExpectedTypeSpecifiedWithoutMetadata";
        internal const string ODataMessageReader_ExpectedValueTypeWrongKind = "ODataMessageReader_ExpectedValueTypeWrongKind";
        internal const string ODataMessageReader_FunctionImportSpecifiedWithoutMetadata = "ODataMessageReader_FunctionImportSpecifiedWithoutMetadata";
        internal const string ODataMessageReader_GetFormatCalledBeforeReadingStarted = "ODataMessageReader_GetFormatCalledBeforeReadingStarted";
        internal const string ODataMessageReader_MetadataDocumentInRequest = "ODataMessageReader_MetadataDocumentInRequest";
        internal const string ODataMessageReader_NoneOrEmptyContentTypeHeader = "ODataMessageReader_NoneOrEmptyContentTypeHeader";
        internal const string ODataMessageReader_ParameterPayloadInResponse = "ODataMessageReader_ParameterPayloadInResponse";
        internal const string ODataMessageReader_PayloadKindDetectionInServerMode = "ODataMessageReader_PayloadKindDetectionInServerMode";
        internal const string ODataMessageReader_PayloadKindDetectionRunning = "ODataMessageReader_PayloadKindDetectionRunning";
        internal const string ODataMessageReader_ReaderAlreadyUsed = "ODataMessageReader_ReaderAlreadyUsed";
        internal const string ODataMessageReader_ServiceDocumentInRequest = "ODataMessageReader_ServiceDocumentInRequest";
        internal const string ODataMessageReader_WildcardInContentType = "ODataMessageReader_WildcardInContentType";
        internal const string ODataMessageWriter_CannotSetHeadersWithInvalidPayloadKind = "ODataMessageWriter_CannotSetHeadersWithInvalidPayloadKind";
        internal const string ODataMessageWriter_CannotSpecifyFunctionImportWithoutModel = "ODataMessageWriter_CannotSpecifyFunctionImportWithoutModel";
        internal const string ODataMessageWriter_CannotWriteInStreamErrorForRawValues = "ODataMessageWriter_CannotWriteInStreamErrorForRawValues";
        internal const string ODataMessageWriter_CannotWriteMetadataWithoutModel = "ODataMessageWriter_CannotWriteMetadataWithoutModel";
        internal const string ODataMessageWriter_CannotWriteNullInRawFormat = "ODataMessageWriter_CannotWriteNullInRawFormat";
        internal const string ODataMessageWriter_CannotWriteStreamPropertyAsTopLevelProperty = "ODataMessageWriter_CannotWriteStreamPropertyAsTopLevelProperty";
        internal const string ODataMessageWriter_EntityReferenceLinksInRequestNotAllowed = "ODataMessageWriter_EntityReferenceLinksInRequestNotAllowed";
        internal const string ODataMessageWriter_ErrorPayloadInRequest = "ODataMessageWriter_ErrorPayloadInRequest";
        internal const string ODataMessageWriter_IncompatiblePayloadKinds = "ODataMessageWriter_IncompatiblePayloadKinds";
        internal const string ODataMessageWriter_InvalidContentTypeForWritingRawValue = "ODataMessageWriter_InvalidContentTypeForWritingRawValue";
        internal const string ODataMessageWriter_MetadataDocumentInRequest = "ODataMessageWriter_MetadataDocumentInRequest";
        internal const string ODataMessageWriter_ServiceDocumentInRequest = "ODataMessageWriter_ServiceDocumentInRequest";
        internal const string ODataMessageWriter_WriteErrorAlreadyCalled = "ODataMessageWriter_WriteErrorAlreadyCalled";
        internal const string ODataMessageWriter_WriterAlreadyUsed = "ODataMessageWriter_WriterAlreadyUsed";
        internal const string ODataMessageWriterSettings_MessageWriterSettingsXmlCustomizationCallbacksMustBeSpecifiedBoth = "ODataMessageWriterSettings_MessageWriterSettingsXmlCustomizationCallbacksMustBeSpecifiedBoth";
        internal const string ODataMetadataInputContext_ErrorReadingMetadata = "ODataMetadataInputContext_ErrorReadingMetadata";
        internal const string ODataMetadataOutputContext_ErrorWritingMetadata = "ODataMetadataOutputContext_ErrorWritingMetadata";
        internal const string ODataOutputContext_UnsupportedPayloadKindForFormat = "ODataOutputContext_UnsupportedPayloadKindForFormat";
        internal const string ODataParameterReaderCore_AsyncCallOnSyncReader = "ODataParameterReaderCore_AsyncCallOnSyncReader";
        internal const string ODataParameterReaderCore_CreateReaderAlreadyCalled = "ODataParameterReaderCore_CreateReaderAlreadyCalled";
        internal const string ODataParameterReaderCore_DuplicateParametersInPayload = "ODataParameterReaderCore_DuplicateParametersInPayload";
        internal const string ODataParameterReaderCore_InvalidCreateReaderMethodCalledForState = "ODataParameterReaderCore_InvalidCreateReaderMethodCalledForState";
        internal const string ODataParameterReaderCore_ParameterNameNotInMetadata = "ODataParameterReaderCore_ParameterNameNotInMetadata";
        internal const string ODataParameterReaderCore_ParametersMissingInPayload = "ODataParameterReaderCore_ParametersMissingInPayload";
        internal const string ODataParameterReaderCore_ReadOrReadAsyncCalledInInvalidState = "ODataParameterReaderCore_ReadOrReadAsyncCalledInInvalidState";
        internal const string ODataParameterReaderCore_SubReaderMustBeCreatedAndReadToCompletionBeforeTheNextReadOrReadAsyncCall = "ODataParameterReaderCore_SubReaderMustBeCreatedAndReadToCompletionBeforeTheNextReadOrReadAsyncCall";
        internal const string ODataParameterReaderCore_SubReaderMustBeInCompletedStateBeforeTheNextReadOrReadAsyncCall = "ODataParameterReaderCore_SubReaderMustBeInCompletedStateBeforeTheNextReadOrReadAsyncCall";
        internal const string ODataParameterReaderCore_SyncCallOnAsyncReader = "ODataParameterReaderCore_SyncCallOnAsyncReader";
        internal const string ODataParameterWriter_CannotCreateParameterWriterOnResponseMessage = "ODataParameterWriter_CannotCreateParameterWriterOnResponseMessage";
        internal const string ODataParameterWriter_InStreamErrorNotSupported = "ODataParameterWriter_InStreamErrorNotSupported";
        internal const string ODataParameterWriterCore_AsyncCallOnSyncWriter = "ODataParameterWriterCore_AsyncCallOnSyncWriter";
        internal const string ODataParameterWriterCore_CannotCreateCollectionWriterOnNonCollectionTypeKind = "ODataParameterWriterCore_CannotCreateCollectionWriterOnNonCollectionTypeKind";
        internal const string ODataParameterWriterCore_CannotWriteEnd = "ODataParameterWriterCore_CannotWriteEnd";
        internal const string ODataParameterWriterCore_CannotWriteInErrorOrCompletedState = "ODataParameterWriterCore_CannotWriteInErrorOrCompletedState";
        internal const string ODataParameterWriterCore_CannotWriteParameter = "ODataParameterWriterCore_CannotWriteParameter";
        internal const string ODataParameterWriterCore_CannotWriteStart = "ODataParameterWriterCore_CannotWriteStart";
        internal const string ODataParameterWriterCore_CannotWriteValueOnNonSupportedValueType = "ODataParameterWriterCore_CannotWriteValueOnNonSupportedValueType";
        internal const string ODataParameterWriterCore_CannotWriteValueOnNonValueTypeKind = "ODataParameterWriterCore_CannotWriteValueOnNonValueTypeKind";
        internal const string ODataParameterWriterCore_DuplicatedParameterNameNotAllowed = "ODataParameterWriterCore_DuplicatedParameterNameNotAllowed";
        internal const string ODataParameterWriterCore_MissingParameterInParameterPayload = "ODataParameterWriterCore_MissingParameterInParameterPayload";
        internal const string ODataParameterWriterCore_ParameterNameNotFoundInFunctionImport = "ODataParameterWriterCore_ParameterNameNotFoundInFunctionImport";
        internal const string ODataParameterWriterCore_SyncCallOnAsyncWriter = "ODataParameterWriterCore_SyncCallOnAsyncWriter";
        internal const string ODataReaderCore_AsyncCallOnSyncReader = "ODataReaderCore_AsyncCallOnSyncReader";
        internal const string ODataReaderCore_NoReadCallsAllowed = "ODataReaderCore_NoReadCallsAllowed";
        internal const string ODataReaderCore_ReadOrReadAsyncCalledInInvalidState = "ODataReaderCore_ReadOrReadAsyncCalledInInvalidState";
        internal const string ODataReaderCore_SyncCallOnAsyncReader = "ODataReaderCore_SyncCallOnAsyncReader";
        internal const string ODataRequestMessage_AsyncNotAvailable = "ODataRequestMessage_AsyncNotAvailable";
        internal const string ODataRequestMessage_MessageStreamIsNull = "ODataRequestMessage_MessageStreamIsNull";
        internal const string ODataRequestMessage_StreamTaskIsNull = "ODataRequestMessage_StreamTaskIsNull";
        internal const string ODataResponseMessage_AsyncNotAvailable = "ODataResponseMessage_AsyncNotAvailable";
        internal const string ODataResponseMessage_MessageStreamIsNull = "ODataResponseMessage_MessageStreamIsNull";
        internal const string ODataResponseMessage_StreamTaskIsNull = "ODataResponseMessage_StreamTaskIsNull";
        internal const string ODataUriUtils_ConvertFromUriLiteralNullOnNonNullableType = "ODataUriUtils_ConvertFromUriLiteralNullOnNonNullableType";
        internal const string ODataUriUtils_ConvertFromUriLiteralNullTypeVerificationFailure = "ODataUriUtils_ConvertFromUriLiteralNullTypeVerificationFailure";
        internal const string ODataUriUtils_ConvertFromUriLiteralTypeRefWithoutModel = "ODataUriUtils_ConvertFromUriLiteralTypeRefWithoutModel";
        internal const string ODataUriUtils_ConvertFromUriLiteralTypeVerificationFailure = "ODataUriUtils_ConvertFromUriLiteralTypeVerificationFailure";
        internal const string ODataUriUtils_ConvertToUriLiteralUnsupportedType = "ODataUriUtils_ConvertToUriLiteralUnsupportedType";
        internal const string ODataUtils_CannotConvertValueToRawPrimitive = "ODataUtils_CannotConvertValueToRawPrimitive";
        internal const string ODataUtils_CannotSaveAnnotationsToBuiltInModel = "ODataUtils_CannotSaveAnnotationsToBuiltInModel";
        internal const string ODataUtils_DidNotFindDefaultMediaType = "ODataUtils_DidNotFindDefaultMediaType";
        internal const string ODataUtils_IsAlwaysBindableAnnotationSetForANonBindableFunctionImport = "ODataUtils_IsAlwaysBindableAnnotationSetForANonBindableFunctionImport";
        internal const string ODataUtils_NullValueForHttpMethodAnnotation = "ODataUtils_NullValueForHttpMethodAnnotation";
        internal const string ODataUtils_NullValueForMimeTypeAnnotation = "ODataUtils_NullValueForMimeTypeAnnotation";
        internal const string ODataUtils_UnexpectedIsAlwaysBindableAnnotationInANonBindableFunctionImport = "ODataUtils_UnexpectedIsAlwaysBindableAnnotationInANonBindableFunctionImport";
        internal const string ODataUtils_UnsupportedVersionHeader = "ODataUtils_UnsupportedVersionHeader";
        internal const string ODataUtils_UnsupportedVersionNumber = "ODataUtils_UnsupportedVersionNumber";
        internal const string ODataVersionChecker_AssociationLinksNotSupported = "ODataVersionChecker_AssociationLinksNotSupported";
        internal const string ODataVersionChecker_CollectionNotSupported = "ODataVersionChecker_CollectionNotSupported";
        internal const string ODataVersionChecker_CollectionPropertiesNotSupported = "ODataVersionChecker_CollectionPropertiesNotSupported";
        internal const string ODataVersionChecker_EpmVersionNotSupported = "ODataVersionChecker_EpmVersionNotSupported";
        internal const string ODataVersionChecker_GeographyAndGeometryNotSupported = "ODataVersionChecker_GeographyAndGeometryNotSupported";
        internal const string ODataVersionChecker_InlineCountNotSupported = "ODataVersionChecker_InlineCountNotSupported";
        internal const string ODataVersionChecker_MaxProtocolVersionExceeded = "ODataVersionChecker_MaxProtocolVersionExceeded";
        internal const string ODataVersionChecker_NextLinkNotSupported = "ODataVersionChecker_NextLinkNotSupported";
        internal const string ODataVersionChecker_ParameterPayloadNotSupported = "ODataVersionChecker_ParameterPayloadNotSupported";
        internal const string ODataVersionChecker_PropertyNotSupportedForODataVersionGreaterThanX = "ODataVersionChecker_PropertyNotSupportedForODataVersionGreaterThanX";
        internal const string ODataVersionChecker_ProtocolVersion3IsNotSupported = "ODataVersionChecker_ProtocolVersion3IsNotSupported";
        internal const string ODataVersionChecker_StreamPropertiesNotSupported = "ODataVersionChecker_StreamPropertiesNotSupported";
        internal const string ODataWriter_NavigationLinkMustSpecifyUrl = "ODataWriter_NavigationLinkMustSpecifyUrl";
        internal const string ODataWriter_RelativeUriUsedWithoutBaseUriSpecified = "ODataWriter_RelativeUriUsedWithoutBaseUriSpecified";
        internal const string ODataWriter_StreamPropertiesMustBePropertiesOfODataEntry = "ODataWriter_StreamPropertiesMustBePropertiesOfODataEntry";
        internal const string ODataWriterCore_AsyncCallOnSyncWriter = "ODataWriterCore_AsyncCallOnSyncWriter";
        internal const string ODataWriterCore_CannotWriteTopLevelEntryWithFeedWriter = "ODataWriterCore_CannotWriteTopLevelEntryWithFeedWriter";
        internal const string ODataWriterCore_CannotWriteTopLevelFeedWithEntryWriter = "ODataWriterCore_CannotWriteTopLevelFeedWithEntryWriter";
        internal const string ODataWriterCore_DeferredLinkInRequest = "ODataWriterCore_DeferredLinkInRequest";
        internal const string ODataWriterCore_EntityReferenceLinkInResponse = "ODataWriterCore_EntityReferenceLinkInResponse";
        internal const string ODataWriterCore_EntityReferenceLinkWithoutNavigationLink = "ODataWriterCore_EntityReferenceLinkWithoutNavigationLink";
        internal const string ODataWriterCore_InlineCountInRequest = "ODataWriterCore_InlineCountInRequest";
        internal const string ODataWriterCore_InvalidStateTransition = "ODataWriterCore_InvalidStateTransition";
        internal const string ODataWriterCore_InvalidTransitionFromCompleted = "ODataWriterCore_InvalidTransitionFromCompleted";
        internal const string ODataWriterCore_InvalidTransitionFromEntry = "ODataWriterCore_InvalidTransitionFromEntry";
        internal const string ODataWriterCore_InvalidTransitionFromError = "ODataWriterCore_InvalidTransitionFromError";
        internal const string ODataWriterCore_InvalidTransitionFromExpandedLink = "ODataWriterCore_InvalidTransitionFromExpandedLink";
        internal const string ODataWriterCore_InvalidTransitionFromFeed = "ODataWriterCore_InvalidTransitionFromFeed";
        internal const string ODataWriterCore_InvalidTransitionFromNullEntry = "ODataWriterCore_InvalidTransitionFromNullEntry";
        internal const string ODataWriterCore_InvalidTransitionFromStart = "ODataWriterCore_InvalidTransitionFromStart";
        internal const string ODataWriterCore_LinkMustSpecifyIsCollection = "ODataWriterCore_LinkMustSpecifyIsCollection";
        internal const string ODataWriterCore_MultipleItemsInNavigationLinkContent = "ODataWriterCore_MultipleItemsInNavigationLinkContent";
        internal const string ODataWriterCore_OnlyTopLevelFeedsSupportInlineCount = "ODataWriterCore_OnlyTopLevelFeedsSupportInlineCount";
        internal const string ODataWriterCore_SyncCallOnAsyncWriter = "ODataWriterCore_SyncCallOnAsyncWriter";
        internal const string ODataWriterCore_WriteEndCalledInInvalidState = "ODataWriterCore_WriteEndCalledInInvalidState";
        internal const string ReaderUtils_EnumerableModified = "ReaderUtils_EnumerableModified";
        internal const string ReaderValidationUtils_CannotConvertPrimitiveValue = "ReaderValidationUtils_CannotConvertPrimitiveValue";
        internal const string ReaderValidationUtils_DerivedComplexTypesAreNotAllowed = "ReaderValidationUtils_DerivedComplexTypesAreNotAllowed";
        internal const string ReaderValidationUtils_EntityReferenceLinkMissingUri = "ReaderValidationUtils_EntityReferenceLinkMissingUri";
        internal const string ReaderValidationUtils_EntryWithoutType = "ReaderValidationUtils_EntryWithoutType";
        internal const string ReaderValidationUtils_MessageReaderSettingsBaseUriMustBeNullOrAbsolute = "ReaderValidationUtils_MessageReaderSettingsBaseUriMustBeNullOrAbsolute";
        internal const string ReaderValidationUtils_NullValueForNonNullableType = "ReaderValidationUtils_NullValueForNonNullableType";
        internal const string ReaderValidationUtils_UndeclaredPropertyBehaviorKindSpecifiedForOpenType = "ReaderValidationUtils_UndeclaredPropertyBehaviorKindSpecifiedForOpenType";
        internal const string ReaderValidationUtils_UndeclaredPropertyBehaviorKindSpecifiedOnRequest = "ReaderValidationUtils_UndeclaredPropertyBehaviorKindSpecifiedOnRequest";
        internal const string ReaderValidationUtils_ValueWithoutType = "ReaderValidationUtils_ValueWithoutType";
        private ResourceManager resources;
        internal const string UriQueryExpressionParser_UnrecognizedLiteral = "UriQueryExpressionParser_UnrecognizedLiteral";
        internal const string UriUtils_InvalidRelativeUriForEscaping = "UriUtils_InvalidRelativeUriForEscaping";
        internal const string ValidationUtils_ActionsAndFunctionsMustSpecifyMetadata = "ValidationUtils_ActionsAndFunctionsMustSpecifyMetadata";
        internal const string ValidationUtils_ActionsAndFunctionsMustSpecifyTarget = "ValidationUtils_ActionsAndFunctionsMustSpecifyTarget";
        internal const string ValidationUtils_AssociationLinkMustSpecifyName = "ValidationUtils_AssociationLinkMustSpecifyName";
        internal const string ValidationUtils_AssociationLinkMustSpecifyUrl = "ValidationUtils_AssociationLinkMustSpecifyUrl";
        internal const string ValidationUtils_EntryTypeNotAssignableToExpectedType = "ValidationUtils_EntryTypeNotAssignableToExpectedType";
        internal const string ValidationUtils_EntryWithMediaResourceAndNonMLEType = "ValidationUtils_EntryWithMediaResourceAndNonMLEType";
        internal const string ValidationUtils_EntryWithoutMediaResourceAndMLEType = "ValidationUtils_EntryWithoutMediaResourceAndMLEType";
        internal const string ValidationUtils_EnumerableContainsANullItem = "ValidationUtils_EnumerableContainsANullItem";
        internal const string ValidationUtils_IncompatiblePrimitiveItemType = "ValidationUtils_IncompatiblePrimitiveItemType";
        internal const string ValidationUtils_IncompatibleType = "ValidationUtils_IncompatibleType";
        internal const string ValidationUtils_IncorrectTypeKind = "ValidationUtils_IncorrectTypeKind";
        internal const string ValidationUtils_IncorrectTypeKindNoTypeName = "ValidationUtils_IncorrectTypeKindNoTypeName";
        internal const string ValidationUtils_IncorrectValueTypeKind = "ValidationUtils_IncorrectValueTypeKind";
        internal const string ValidationUtils_InvalidBatchBoundaryDelimiterLength = "ValidationUtils_InvalidBatchBoundaryDelimiterLength";
        internal const string ValidationUtils_InvalidCollectionTypeName = "ValidationUtils_InvalidCollectionTypeName";
        internal const string ValidationUtils_InvalidCollectionTypeReference = "ValidationUtils_InvalidCollectionTypeReference";
        internal const string ValidationUtils_InvalidEtagValue = "ValidationUtils_InvalidEtagValue";
        internal const string ValidationUtils_LinkMustSpecifyName = "ValidationUtils_LinkMustSpecifyName";
        internal const string ValidationUtils_MaxDepthOfNestedEntriesExceeded = "ValidationUtils_MaxDepthOfNestedEntriesExceeded";
        internal const string ValidationUtils_MaxNumberOfEntityPropertyMappingsExceeded = "ValidationUtils_MaxNumberOfEntityPropertyMappingsExceeded";
        internal const string ValidationUtils_MismatchPropertyKindForStreamProperty = "ValidationUtils_MismatchPropertyKindForStreamProperty";
        internal const string ValidationUtils_NavigationPropertyExpected = "ValidationUtils_NavigationPropertyExpected";
        internal const string ValidationUtils_NestedCollectionsAreNotSupported = "ValidationUtils_NestedCollectionsAreNotSupported";
        internal const string ValidationUtils_NonPrimitiveTypeForPrimitiveValue = "ValidationUtils_NonPrimitiveTypeForPrimitiveValue";
        internal const string ValidationUtils_NonStreamingCollectionElementsMustNotBeNull = "ValidationUtils_NonStreamingCollectionElementsMustNotBeNull";
        internal const string ValidationUtils_NullCollectionItemForNonNullableType = "ValidationUtils_NullCollectionItemForNonNullableType";
        internal const string ValidationUtils_OpenCollectionProperty = "ValidationUtils_OpenCollectionProperty";
        internal const string ValidationUtils_OpenNavigationProperty = "ValidationUtils_OpenNavigationProperty";
        internal const string ValidationUtils_OpenStreamProperty = "ValidationUtils_OpenStreamProperty";
        internal const string ValidationUtils_PropertiesMustNotContainReservedChars = "ValidationUtils_PropertiesMustNotContainReservedChars";
        internal const string ValidationUtils_PropertyDoesNotExistOnType = "ValidationUtils_PropertyDoesNotExistOnType";
        internal const string ValidationUtils_RecursionDepthLimitReached = "ValidationUtils_RecursionDepthLimitReached";
        internal const string ValidationUtils_ResourceCollectionMustSpecifyUrl = "ValidationUtils_ResourceCollectionMustSpecifyUrl";
        internal const string ValidationUtils_ResourceCollectionUrlMustNotBeNull = "ValidationUtils_ResourceCollectionUrlMustNotBeNull";
        internal const string ValidationUtils_StreamReferenceValuesNotSupportedInCollections = "ValidationUtils_StreamReferenceValuesNotSupportedInCollections";
        internal const string ValidationUtils_TypeNameMustNotBeEmpty = "ValidationUtils_TypeNameMustNotBeEmpty";
        internal const string ValidationUtils_UnrecognizedTypeName = "ValidationUtils_UnrecognizedTypeName";
        internal const string ValidationUtils_UnsupportedPrimitiveType = "ValidationUtils_UnsupportedPrimitiveType";
        internal const string ValidationUtils_WorkspaceCollectionsMustNotContainNullItem = "ValidationUtils_WorkspaceCollectionsMustNotContainNullItem";
        internal const string WriterValidationUtils_AssociationLinkInRequest = "WriterValidationUtils_AssociationLinkInRequest";
        internal const string WriterValidationUtils_CollectionPropertiesMustNotHaveNullValue = "WriterValidationUtils_CollectionPropertiesMustNotHaveNullValue";
        internal const string WriterValidationUtils_DefaultStreamWithContentTypeWithoutReadLink = "WriterValidationUtils_DefaultStreamWithContentTypeWithoutReadLink";
        internal const string WriterValidationUtils_DefaultStreamWithReadLinkWithoutContentType = "WriterValidationUtils_DefaultStreamWithReadLinkWithoutContentType";
        internal const string WriterValidationUtils_EntityReferenceLinksLinkMustNotBeNull = "WriterValidationUtils_EntityReferenceLinksLinkMustNotBeNull";
        internal const string WriterValidationUtils_EntityReferenceLinkUrlMustNotBeNull = "WriterValidationUtils_EntityReferenceLinkUrlMustNotBeNull";
        internal const string WriterValidationUtils_EntriesMustHaveNonEmptyId = "WriterValidationUtils_EntriesMustHaveNonEmptyId";
        internal const string WriterValidationUtils_EntryTypeInExpandedLinkNotCompatibleWithNavigationPropertyType = "WriterValidationUtils_EntryTypeInExpandedLinkNotCompatibleWithNavigationPropertyType";
        internal const string WriterValidationUtils_ExpandedLinkIsCollectionFalseWithFeedContent = "WriterValidationUtils_ExpandedLinkIsCollectionFalseWithFeedContent";
        internal const string WriterValidationUtils_ExpandedLinkIsCollectionFalseWithFeedMetadata = "WriterValidationUtils_ExpandedLinkIsCollectionFalseWithFeedMetadata";
        internal const string WriterValidationUtils_ExpandedLinkIsCollectionTrueWithEntryContent = "WriterValidationUtils_ExpandedLinkIsCollectionTrueWithEntryContent";
        internal const string WriterValidationUtils_ExpandedLinkIsCollectionTrueWithEntryMetadata = "WriterValidationUtils_ExpandedLinkIsCollectionTrueWithEntryMetadata";
        internal const string WriterValidationUtils_ExpandedLinkWithEntryPayloadAndFeedMetadata = "WriterValidationUtils_ExpandedLinkWithEntryPayloadAndFeedMetadata";
        internal const string WriterValidationUtils_ExpandedLinkWithFeedPayloadAndEntryMetadata = "WriterValidationUtils_ExpandedLinkWithFeedPayloadAndEntryMetadata";
        internal const string WriterValidationUtils_FeedsMustHaveNonEmptyId = "WriterValidationUtils_FeedsMustHaveNonEmptyId";
        internal const string WriterValidationUtils_MessageWriterSettingsBaseUriMustBeNullOrAbsolute = "WriterValidationUtils_MessageWriterSettingsBaseUriMustBeNullOrAbsolute";
        internal const string WriterValidationUtils_MissingTypeNameWithMetadata = "WriterValidationUtils_MissingTypeNameWithMetadata";
        internal const string WriterValidationUtils_NextPageLinkInRequest = "WriterValidationUtils_NextPageLinkInRequest";
        internal const string WriterValidationUtils_NonNullablePropertiesMustNotHaveNullValue = "WriterValidationUtils_NonNullablePropertiesMustNotHaveNullValue";
        internal const string WriterValidationUtils_OperationInRequest = "WriterValidationUtils_OperationInRequest";
        internal const string WriterValidationUtils_PropertiesMustHaveNonEmptyName = "WriterValidationUtils_PropertiesMustHaveNonEmptyName";
        internal const string WriterValidationUtils_PropertyMustNotBeNull = "WriterValidationUtils_PropertyMustNotBeNull";
        internal const string WriterValidationUtils_ResourceCollectionMustHaveUniqueName = "WriterValidationUtils_ResourceCollectionMustHaveUniqueName";
        internal const string WriterValidationUtils_StreamPropertiesMustNotHaveNullValue = "WriterValidationUtils_StreamPropertiesMustNotHaveNullValue";
        internal const string WriterValidationUtils_StreamPropertyInRequest = "WriterValidationUtils_StreamPropertyInRequest";
        internal const string WriterValidationUtils_StreamReferenceValueEmptyContentType = "WriterValidationUtils_StreamReferenceValueEmptyContentType";
        internal const string WriterValidationUtils_StreamReferenceValueMustHaveEditLinkOrReadLink = "WriterValidationUtils_StreamReferenceValueMustHaveEditLinkOrReadLink";
        internal const string WriterValidationUtils_StreamReferenceValueMustHaveEditLinkToHaveETag = "WriterValidationUtils_StreamReferenceValueMustHaveEditLinkToHaveETag";
        internal const string XmlReaderExtension_InvalidNodeInStringValue = "XmlReaderExtension_InvalidNodeInStringValue";
        internal const string XmlReaderExtension_InvalidRootNode = "XmlReaderExtension_InvalidRootNode";

        internal TextRes()
        {
            this.resources = new ResourceManager("Microsoft.Data.OData", base.GetType().Assembly);
        }

        private static TextRes GetLoader()
        {
            if (loader == null)
            {
                TextRes res = new TextRes();
                Interlocked.CompareExchange<TextRes>(ref loader, res, null);
            }
            return loader;
        }

        public static object GetObject(string name)
        {
            TextRes loader = GetLoader();
            if (loader == null)
            {
                return null;
            }
            return loader.resources.GetObject(name, Culture);
        }

        public static string GetString(string name)
        {
            TextRes loader = GetLoader();
            if (loader == null)
            {
                return null;
            }
            return loader.resources.GetString(name, Culture);
        }

        public static string GetString(string name, out bool usedFallback)
        {
            usedFallback = false;
            return GetString(name);
        }

        public static string GetString(string name, params object[] args)
        {
            TextRes loader = GetLoader();
            if (loader == null)
            {
                return null;
            }
            string format = loader.resources.GetString(name, Culture);
            if ((args == null) || (args.Length <= 0))
            {
                return format;
            }
            for (int i = 0; i < args.Length; i++)
            {
                string str2 = args[i] as string;
                if ((str2 != null) && (str2.Length > 0x400))
                {
                    args[i] = str2.Substring(0, 0x3fd) + "...";
                }
            }
            return string.Format(CultureInfo.CurrentCulture, format, args);
        }

        private static CultureInfo Culture
        {
            get
            {
                return null;
            }
        }

        public static ResourceManager Resources
        {
            get
            {
                return GetLoader().resources;
            }
        }
    }
}

