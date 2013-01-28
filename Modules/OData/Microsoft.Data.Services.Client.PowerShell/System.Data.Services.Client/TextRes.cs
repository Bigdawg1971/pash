namespace System.Data.Services.Client
{
    using System;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.InteropServices;
    using System.Threading;

    internal sealed class TextRes
    {
        internal const string ALinq_AnyAllNotSupportedInOrderBy = "ALinq_AnyAllNotSupportedInOrderBy";
        internal const string ALinq_BinaryNotSupported = "ALinq_BinaryNotSupported";
        internal const string ALinq_CannotAddCountOption = "ALinq_CannotAddCountOption";
        internal const string ALinq_CannotAddCountOptionConflict = "ALinq_CannotAddCountOptionConflict";
        internal const string ALinq_CannotConstructKnownEntityTypes = "ALinq_CannotConstructKnownEntityTypes";
        internal const string ALinq_CannotCreateConstantEntity = "ALinq_CannotCreateConstantEntity";
        internal const string ALinq_CannotProjectWithExplicitExpansion = "ALinq_CannotProjectWithExplicitExpansion";
        internal const string ALinq_CannotUseTypeFiltersMultipleTimes = "ALinq_CannotUseTypeFiltersMultipleTimes";
        internal const string ALinq_CanOnlyApplyOneKeyPredicate = "ALinq_CanOnlyApplyOneKeyPredicate";
        internal const string ALinq_CanOnlyProjectTheLeaf = "ALinq_CanOnlyProjectTheLeaf";
        internal const string ALinq_CantAddAstoriaQueryOption = "ALinq_CantAddAstoriaQueryOption";
        internal const string ALinq_CantAddDuplicateQueryOption = "ALinq_CantAddDuplicateQueryOption";
        internal const string ALinq_CantAddQueryOption = "ALinq_CantAddQueryOption";
        internal const string ALinq_CantAddQueryOptionStartingWithDollarSign = "ALinq_CantAddQueryOptionStartingWithDollarSign";
        internal const string ALinq_CantCastToUnsupportedPrimitive = "ALinq_CantCastToUnsupportedPrimitive";
        internal const string ALinq_CantExpand = "ALinq_CantExpand";
        internal const string ALinq_CantNavigateWithoutKeyPredicate = "ALinq_CantNavigateWithoutKeyPredicate";
        internal const string ALinq_CantReferToPublicField = "ALinq_CantReferToPublicField";
        internal const string ALinq_CantTranslateExpression = "ALinq_CantTranslateExpression";
        internal const string ALinq_CollectionMemberAccessNotSupportedInNavigation = "ALinq_CollectionMemberAccessNotSupportedInNavigation";
        internal const string ALinq_CollectionPropertyNotSupportedInOrderBy = "ALinq_CollectionPropertyNotSupportedInOrderBy";
        internal const string ALinq_CollectionPropertyNotSupportedInWhere = "ALinq_CollectionPropertyNotSupportedInWhere";
        internal const string ALinq_ConditionalNotSupported = "ALinq_ConditionalNotSupported";
        internal const string ALinq_ConstantNotSupported = "ALinq_ConstantNotSupported";
        internal const string ALinq_CouldNotConvert = "ALinq_CouldNotConvert";
        internal const string ALinq_ExpressionCannotEndWithTypeAs = "ALinq_ExpressionCannotEndWithTypeAs";
        internal const string ALinq_ExpressionNotSupportedInProjection = "ALinq_ExpressionNotSupportedInProjection";
        internal const string ALinq_ExpressionNotSupportedInProjectionToEntity = "ALinq_ExpressionNotSupportedInProjectionToEntity";
        internal const string ALinq_InvalidExpressionInNavigationPath = "ALinq_InvalidExpressionInNavigationPath";
        internal const string ALinq_InvalidSourceForAnyAll = "ALinq_InvalidSourceForAnyAll";
        internal const string ALinq_InvocationNotSupported = "ALinq_InvocationNotSupported";
        internal const string ALinq_LambdaNotSupported = "ALinq_LambdaNotSupported";
        internal const string ALinq_LinkPropertyNotSupportedInExpression = "ALinq_LinkPropertyNotSupportedInExpression";
        internal const string ALinq_ListInitNotSupported = "ALinq_ListInitNotSupported";
        internal const string ALinq_MemberAccessNotSupported = "ALinq_MemberAccessNotSupported";
        internal const string ALinq_MemberInitNotSupported = "ALinq_MemberInitNotSupported";
        internal const string ALinq_MethodNotSupported = "ALinq_MethodNotSupported";
        internal const string ALinq_MethodNotSupportedForMaxDataServiceVersionLessThanX = "ALinq_MethodNotSupportedForMaxDataServiceVersionLessThanX";
        internal const string ALinq_NewArrayNotSupported = "ALinq_NewArrayNotSupported";
        internal const string ALinq_NewNotSupported = "ALinq_NewNotSupported";
        internal const string ALinq_OfTypeArgumentNotAvailable = "ALinq_OfTypeArgumentNotAvailable";
        internal const string ALinq_ParameterNotSupported = "ALinq_ParameterNotSupported";
        internal const string ALinq_ProjectionCanOnlyHaveOneProjection = "ALinq_ProjectionCanOnlyHaveOneProjection";
        internal const string ALinq_ProjectionMemberAssignmentMismatch = "ALinq_ProjectionMemberAssignmentMismatch";
        internal const string ALinq_ProjectionOnlyAllowedOnLeafNodes = "ALinq_ProjectionOnlyAllowedOnLeafNodes";
        internal const string ALinq_PropertyNamesMustMatchInProjections = "ALinq_PropertyNamesMustMatchInProjections";
        internal const string ALinq_QueryOptionOutOfOrder = "ALinq_QueryOptionOutOfOrder";
        internal const string ALinq_QueryOptionsOnlyAllowedOnLeafNodes = "ALinq_QueryOptionsOnlyAllowedOnLeafNodes";
        internal const string ALinq_QueryOptionsOnlyAllowedOnSingletons = "ALinq_QueryOptionsOnlyAllowedOnSingletons";
        internal const string ALinq_TranslationError = "ALinq_TranslationError";
        internal const string ALinq_TypeAsArgumentNotEntityType = "ALinq_TypeAsArgumentNotEntityType";
        internal const string ALinq_TypeAsNotSupportedForMaxDataServiceVersionLessThan3 = "ALinq_TypeAsNotSupportedForMaxDataServiceVersionLessThan3";
        internal const string ALinq_TypeBinaryNotSupported = "ALinq_TypeBinaryNotSupported";
        internal const string ALinq_UnaryNotSupported = "ALinq_UnaryNotSupported";
        internal const string ALinq_UnsupportedExpression = "ALinq_UnsupportedExpression";
        internal const string AtomMaterializer_CannotAssignNull = "AtomMaterializer_CannotAssignNull";
        internal const string AtomMaterializer_CollectionExpectedCollection = "AtomMaterializer_CollectionExpectedCollection";
        internal const string AtomMaterializer_DataServiceCollectionNotSupportedForNonEntities = "AtomMaterializer_DataServiceCollectionNotSupportedForNonEntities";
        internal const string AtomMaterializer_EntryIntoCollectionMismatch = "AtomMaterializer_EntryIntoCollectionMismatch";
        internal const string AtomMaterializer_EntryToAccessIsNull = "AtomMaterializer_EntryToAccessIsNull";
        internal const string AtomMaterializer_EntryToInitializeIsNull = "AtomMaterializer_EntryToInitializeIsNull";
        internal const string AtomMaterializer_InvalidCollectionItem = "AtomMaterializer_InvalidCollectionItem";
        internal const string AtomMaterializer_InvalidContentTypeEncountered = "AtomMaterializer_InvalidContentTypeEncountered";
        internal const string AtomMaterializer_InvalidEntityType = "AtomMaterializer_InvalidEntityType";
        internal const string AtomMaterializer_InvalidNonEntityType = "AtomMaterializer_InvalidNonEntityType";
        internal const string AtomMaterializer_InvalidResponsePayload = "AtomMaterializer_InvalidResponsePayload";
        internal const string AtomMaterializer_NoParameterlessCtorForCollectionProperty = "AtomMaterializer_NoParameterlessCtorForCollectionProperty";
        internal const string AtomMaterializer_ProjectEntityTypeMismatch = "AtomMaterializer_ProjectEntityTypeMismatch";
        internal const string AtomMaterializer_PropertyMissing = "AtomMaterializer_PropertyMissing";
        internal const string AtomMaterializer_PropertyNotExpectedEntry = "AtomMaterializer_PropertyNotExpectedEntry";
        internal const string AtomParser_SingleEntry_ExpectedFeedOrEntry = "AtomParser_SingleEntry_ExpectedFeedOrEntry";
        internal const string AtomParser_SingleEntry_MultipleFound = "AtomParser_SingleEntry_MultipleFound";
        internal const string AtomParser_SingleEntry_NoneFound = "AtomParser_SingleEntry_NoneFound";
        internal const string Batch_ExpectedContentType = "Batch_ExpectedContentType";
        internal const string Batch_ExpectedResponse = "Batch_ExpectedResponse";
        internal const string Batch_IncompleteResponseCount = "Batch_IncompleteResponseCount";
        internal const string Batch_UnexpectedContent = "Batch_UnexpectedContent";
        internal const string ClientType_Ambiguous = "ClientType_Ambiguous";
        internal const string ClientType_CollectionOfCollectionNotSupported = "ClientType_CollectionOfCollectionNotSupported";
        internal const string ClientType_CollectionPropertyNotSupportedInV2AndBelow = "ClientType_CollectionPropertyNotSupportedInV2AndBelow";
        internal const string ClientType_KeysMustBeSimpleTypes = "ClientType_KeysMustBeSimpleTypes";
        internal const string ClientType_KeysOnDifferentDeclaredType = "ClientType_KeysOnDifferentDeclaredType";
        internal const string ClientType_MissingMediaEntryProperty = "ClientType_MissingMediaEntryProperty";
        internal const string ClientType_MissingMimeTypeDataProperty = "ClientType_MissingMimeTypeDataProperty";
        internal const string ClientType_MissingMimeTypeProperty = "ClientType_MissingMimeTypeProperty";
        internal const string ClientType_MissingOpenProperty = "ClientType_MissingOpenProperty";
        internal const string ClientType_MissingProperty = "ClientType_MissingProperty";
        internal const string ClientType_MultipleImplementationNotSupported = "ClientType_MultipleImplementationNotSupported";
        internal const string Clienttype_MultipleOpenProperty = "Clienttype_MultipleOpenProperty";
        internal const string ClientType_MultipleTypesWithSameName = "ClientType_MultipleTypesWithSameName";
        internal const string ClientType_NoSettableFields = "ClientType_NoSettableFields";
        internal const string ClientType_NullOpenProperties = "ClientType_NullOpenProperties";
        internal const string ClientType_UnsupportedType = "ClientType_UnsupportedType";
        internal const string ClientTypeCache_NonEntityTypeCannotContainEntityProperties = "ClientTypeCache_NonEntityTypeCannotContainEntityProperties";
        internal const string Collection_ComplexTypesInCollectionOfPrimitiveTypesNotAllowed = "Collection_ComplexTypesInCollectionOfPrimitiveTypesNotAllowed";
        internal const string Collection_NullCollectionItemsNotSupported = "Collection_NullCollectionItemsNotSupported";
        internal const string Collection_NullCollectionNotSupported = "Collection_NullCollectionNotSupported";
        internal const string Collection_NullCollectionReference = "Collection_NullCollectionReference";
        internal const string Collection_NullNonPropertyCollectionNotSupported = "Collection_NullNonPropertyCollectionNotSupported";
        internal const string Collection_PrimitiveTypesInCollectionOfComplexTypesNotAllowed = "Collection_PrimitiveTypesInCollectionOfComplexTypesNotAllowed";
        internal const string Content_EntityIsNotEntityType = "Content_EntityIsNotEntityType";
        internal const string Content_EntityWithoutKey = "Content_EntityWithoutKey";
        internal const string Context_AddLinkCollectionOnly = "Context_AddLinkCollectionOnly";
        internal const string Context_AddRelatedObjectCollectionOnly = "Context_AddRelatedObjectCollectionOnly";
        internal const string Context_AddRelatedObjectSourceDeleted = "Context_AddRelatedObjectSourceDeleted";
        internal const string Context_AsyncAlreadyDone = "Context_AsyncAlreadyDone";
        internal const string Context_BaseUri = "Context_BaseUri";
        internal const string Context_BaseUriRequired = "Context_BaseUriRequired";
        internal const string Context_BatchExecuteError = "Context_BatchExecuteError";
        internal const string Context_BatchNotSupportedForMediaLink = "Context_BatchNotSupportedForMediaLink";
        internal const string Context_BatchNotSupportedForNamedStreams = "Context_BatchNotSupportedForNamedStreams";
        internal const string Context_BodyOperationParametersNotAllowedWithGet = "Context_BodyOperationParametersNotAllowedWithGet";
        internal const string Context_BothLocationAndIdMustBeSpecified = "Context_BothLocationAndIdMustBeSpecified";
        internal const string Context_CannotConvertKey = "Context_CannotConvertKey";
        internal const string Context_ChildResourceExists = "Context_ChildResourceExists";
        internal const string Context_ContentTypeRequiredForNamedStream = "Context_ContentTypeRequiredForNamedStream";
        internal const string Context_DidNotOriginateAsync = "Context_DidNotOriginateAsync";
        internal const string Context_DifferentEntityAlreadyContained = "Context_DifferentEntityAlreadyContained";
        internal const string Context_DuplicateBodyOperationParameterName = "Context_DuplicateBodyOperationParameterName";
        internal const string Context_DuplicateUriOperationParameterName = "Context_DuplicateUriOperationParameterName";
        internal const string Context_EndExecuteExpectedVoidResponse = "Context_EndExecuteExpectedVoidResponse";
        internal const string Context_EntityAlreadyContained = "Context_EntityAlreadyContained";
        internal const string Context_EntityDoesNotContainNamedStream = "Context_EntityDoesNotContainNamedStream";
        internal const string Context_EntityNotContained = "Context_EntityNotContained";
        internal const string Context_EntityNotMediaLinkEntry = "Context_EntityNotMediaLinkEntry";
        internal const string Context_EntitySetName = "Context_EntitySetName";
        internal const string Context_ExecuteExpectedVoidResponse = "Context_ExecuteExpectedVoidResponse";
        internal const string Context_ExecuteExpectsGetOrPost = "Context_ExecuteExpectsGetOrPost";
        internal const string Context_InternalError = "Context_InternalError";
        internal const string Context_LinkResourceInsertFailure = "Context_LinkResourceInsertFailure";
        internal const string Context_LocationHeaderExpectsAbsoluteUri = "Context_LocationHeaderExpectsAbsoluteUri";
        internal const string Context_MissingOperationParameterName = "Context_MissingOperationParameterName";
        internal const string Context_MissingSelfAndEditLinkForNamedStream = "Context_MissingSelfAndEditLinkForNamedStream";
        internal const string Context_MLEWithoutSaveStream = "Context_MLEWithoutSaveStream";
        internal const string Context_NoContentTypeForMediaLink = "Context_NoContentTypeForMediaLink";
        internal const string Context_NoLoadWithInsertEnd = "Context_NoLoadWithInsertEnd";
        internal const string Context_NoRelationWithDeleteEnd = "Context_NoRelationWithDeleteEnd";
        internal const string Context_NoRelationWithInsertEnd = "Context_NoRelationWithInsertEnd";
        internal const string Context_NullElementInOperationParameterArray = "Context_NullElementInOperationParameterArray";
        internal const string Context_NullKeysAreNotSupported = "Context_NullKeysAreNotSupported";
        internal const string Context_OperationCanceled = "Context_OperationCanceled";
        internal const string Context_PropertyNotSupportedForMaxDataServiceVersionGreaterThanX = "Context_PropertyNotSupportedForMaxDataServiceVersionGreaterThanX";
        internal const string Context_RelationAlreadyContained = "Context_RelationAlreadyContained";
        internal const string Context_RelationNotRefOrCollection = "Context_RelationNotRefOrCollection";
        internal const string Context_RequestUriIsRelativeBaseUriRequired = "Context_RequestUriIsRelativeBaseUriRequired";
        internal const string Context_RequestVersionIsBiggerThanProtocolVersion = "Context_RequestVersionIsBiggerThanProtocolVersion";
        internal const string Context_ResolveEntitySetOrBaseUriRequired = "Context_ResolveEntitySetOrBaseUriRequired";
        internal const string Context_ResolveReturnedInvalidUri = "Context_ResolveReturnedInvalidUri";
        internal const string Context_ResponseVersionIsBiggerThanProtocolVersion = "Context_ResponseVersionIsBiggerThanProtocolVersion";
        internal const string Context_SendingRequestEventArgsNotHttp = "Context_SendingRequestEventArgsNotHttp";
        internal const string Context_SetLinkReferenceOnly = "Context_SetLinkReferenceOnly";
        internal const string Context_SetSaveStreamOnInvalidEntityState = "Context_SetSaveStreamOnInvalidEntityState";
        internal const string Context_SetSaveStreamOnMediaEntryProperty = "Context_SetSaveStreamOnMediaEntryProperty";
        internal const string Context_SetSaveStreamWithoutEditMediaLink = "Context_SetSaveStreamWithoutEditMediaLink";
        internal const string Context_SetSaveStreamWithoutNamedStreamEditLink = "Context_SetSaveStreamWithoutNamedStreamEditLink";
        internal const string Context_TrackingExpectsAbsoluteUri = "Context_TrackingExpectsAbsoluteUri";
        internal const string Context_UnexpectedZeroRawRead = "Context_UnexpectedZeroRawRead";
        internal const string Context_VersionNotSupported = "Context_VersionNotSupported";
        internal const string DataBinding_BindingOperation_ArrayItemNotEntity = "DataBinding_BindingOperation_ArrayItemNotEntity";
        internal const string DataBinding_BindingOperation_ArrayItemNull = "DataBinding_BindingOperation_ArrayItemNull";
        internal const string DataBinding_BindingOperation_DetachedSource = "DataBinding_BindingOperation_DetachedSource";
        internal const string DataBinding_CollectionAssociatedWithMultipleEntities = "DataBinding_CollectionAssociatedWithMultipleEntities";
        internal const string DataBinding_CollectionChangedUnknownActionCollection = "DataBinding_CollectionChangedUnknownActionCollection";
        internal const string DataBinding_CollectionPropertySetterValueHasObserver = "DataBinding_CollectionPropertySetterValueHasObserver";
        internal const string DataBinding_ComplexObjectAssociatedWithMultipleEntities = "DataBinding_ComplexObjectAssociatedWithMultipleEntities";
        internal const string DataBinding_DataServiceCollectionArgumentMustHaveEntityType = "DataBinding_DataServiceCollectionArgumentMustHaveEntityType";
        internal const string DataBinding_DataServiceCollectionChangedUnknownActionCollection = "DataBinding_DataServiceCollectionChangedUnknownActionCollection";
        internal const string DataBinding_EntityAlreadyInCollection = "DataBinding_EntityAlreadyInCollection";
        internal const string DataBinding_NotifyCollectionChangedNotImpl = "DataBinding_NotifyCollectionChangedNotImpl";
        internal const string DataBinding_NotifyPropertyChangedNotImpl = "DataBinding_NotifyPropertyChangedNotImpl";
        internal const string DataBinding_Util_UnknownEntitySetName = "DataBinding_Util_UnknownEntitySetName";
        internal const string DataServiceCollection_CannotDetermineContextFromItems = "DataServiceCollection_CannotDetermineContextFromItems";
        internal const string DataServiceCollection_CannotStopTrackingChildCollection = "DataServiceCollection_CannotStopTrackingChildCollection";
        internal const string DataServiceCollection_InsertIntoTrackedButNotLoadedCollection = "DataServiceCollection_InsertIntoTrackedButNotLoadedCollection";
        internal const string DataServiceCollection_LoadRequiresTargetCollectionObserved = "DataServiceCollection_LoadRequiresTargetCollectionObserved";
        internal const string DataServiceCollection_OperationForTrackedOnly = "DataServiceCollection_OperationForTrackedOnly";
        internal const string DataServiceException_GeneralError = "DataServiceException_GeneralError";
        internal const string DataServiceRequest_FailGetCount = "DataServiceRequest_FailGetCount";
        internal const string Deserialize_Current = "Deserialize_Current";
        internal const string Deserialize_ExpectingSimpleValue = "Deserialize_ExpectingSimpleValue";
        internal const string Deserialize_GetEnumerator = "Deserialize_GetEnumerator";
        internal const string Deserialize_MismatchAtomLinkEntryPropertyIsCollection = "Deserialize_MismatchAtomLinkEntryPropertyIsCollection";
        internal const string Deserialize_MismatchAtomLinkFeedPropertyNotCollection = "Deserialize_MismatchAtomLinkFeedPropertyNotCollection";
        internal const string Deserialize_MismatchAtomLinkLocalSimple = "Deserialize_MismatchAtomLinkLocalSimple";
        internal const string Deserialize_MissingIdElement = "Deserialize_MissingIdElement";
        internal const string Deserialize_MixedTextWithComment = "Deserialize_MixedTextWithComment";
        internal const string Deserialize_NoLocationHeader = "Deserialize_NoLocationHeader";
        internal const string Deserialize_ServerException = "Deserialize_ServerException";
        internal const string DSKAttribute_MustSpecifyAtleastOnePropertyName = "DSKAttribute_MustSpecifyAtleastOnePropertyName";
        internal const string EntityDescriptor_MissingSelfEditLink = "EntityDescriptor_MissingSelfEditLink";
        internal const string EpmSourceTree_CollectionPropertyCannotBeMapped = "EpmSourceTree_CollectionPropertyCannotBeMapped";
        internal const string EpmSourceTree_DuplicateEpmAttrsWithSameSourceName = "EpmSourceTree_DuplicateEpmAttrsWithSameSourceName";
        internal const string EpmSourceTree_EndsWithNonPrimitiveType = "EpmSourceTree_EndsWithNonPrimitiveType";
        internal const string EpmSourceTree_InaccessiblePropertyOnType = "EpmSourceTree_InaccessiblePropertyOnType";
        internal const string EpmSourceTree_InvalidSourcePath = "EpmSourceTree_InvalidSourcePath";
        internal const string EpmSourceTree_NamedStreamCannotBeMapped = "EpmSourceTree_NamedStreamCannotBeMapped";
        internal const string EpmSourceTree_SpatialTypeCannotBeMapped = "EpmSourceTree_SpatialTypeCannotBeMapped";
        internal const string EpmTargetTree_AttributeInMiddle = "EpmTargetTree_AttributeInMiddle";
        internal const string EpmTargetTree_DuplicateEpmAttrsWithSameTargetName = "EpmTargetTree_DuplicateEpmAttrsWithSameTargetName";
        internal const string EpmTargetTree_InvalidTargetPath = "EpmTargetTree_InvalidTargetPath";
        internal const string HttpProcessUtility_ClosingQuoteNotFound = "HttpProcessUtility_ClosingQuoteNotFound";
        internal const string HttpProcessUtility_ContentTypeMissing = "HttpProcessUtility_ContentTypeMissing";
        internal const string HttpProcessUtility_EncodingNotSupported = "HttpProcessUtility_EncodingNotSupported";
        internal const string HttpProcessUtility_EscapeCharAtEnd = "HttpProcessUtility_EscapeCharAtEnd";
        internal const string HttpProcessUtility_EscapeCharWithoutQuotes = "HttpProcessUtility_EscapeCharWithoutQuotes";
        internal const string HttpProcessUtility_MediaTypeMissingValue = "HttpProcessUtility_MediaTypeMissingValue";
        internal const string HttpProcessUtility_MediaTypeRequiresSemicolonBeforeParameter = "HttpProcessUtility_MediaTypeRequiresSemicolonBeforeParameter";
        internal const string HttpProcessUtility_MediaTypeRequiresSlash = "HttpProcessUtility_MediaTypeRequiresSlash";
        internal const string HttpProcessUtility_MediaTypeRequiresSubType = "HttpProcessUtility_MediaTypeRequiresSubType";
        internal const string HttpProcessUtility_MediaTypeUnspecified = "HttpProcessUtility_MediaTypeUnspecified";
        private static TextRes loader;
        internal const string MaterializeFromAtom_CollectionKeyNotPresentInLinkTable = "MaterializeFromAtom_CollectionKeyNotPresentInLinkTable";
        internal const string MaterializeFromAtom_CountNotPresent = "MaterializeFromAtom_CountNotPresent";
        internal const string MaterializeFromAtom_GetNestLinkForFlatCollection = "MaterializeFromAtom_GetNestLinkForFlatCollection";
        internal const string MaterializeFromAtom_TopLevelLinkNotAvailable = "MaterializeFromAtom_TopLevelLinkNotAvailable";
        internal const string ODataRequestMessage_GetStreamMethodNotSupported = "ODataRequestMessage_GetStreamMethodNotSupported";
        private ResourceManager resources;
        internal const string Serializer_InvalidCollectionParamterItemType = "Serializer_InvalidCollectionParamterItemType";
        internal const string Serializer_InvalidParameterType = "Serializer_InvalidParameterType";
        internal const string Serializer_LoopsNotAllowedInComplexTypes = "Serializer_LoopsNotAllowedInComplexTypes";
        internal const string Serializer_LoopsNotAllowedInNonPropertyComplexTypes = "Serializer_LoopsNotAllowedInNonPropertyComplexTypes";
        internal const string Serializer_NullCollectionParamterItemValue = "Serializer_NullCollectionParamterItemValue";
        internal const string Serializer_UriDoesNotContainParameterAlias = "Serializer_UriDoesNotContainParameterAlias";
        internal const string Util_EmptyArray = "Util_EmptyArray";
        internal const string Util_EmptyString = "Util_EmptyString";
        internal const string Util_NullArrayElement = "Util_NullArrayElement";
        internal const string WebUtil_CollectionTypeNotSupportedInV2OrBelow = "WebUtil_CollectionTypeNotSupportedInV2OrBelow";
        internal const string WebUtil_TypeMismatchInCollection = "WebUtil_TypeMismatchInCollection";
        internal const string WebUtil_TypeMismatchInNonPropertyCollection = "WebUtil_TypeMismatchInNonPropertyCollection";

        internal TextRes()
        {
            this.resources = new ResourceManager("System.Data.Services.Client", base.GetType().Assembly);
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

