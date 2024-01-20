namespace Pie.Spirv.Cross.Native;

public enum SpvBuiltIn_
{
    SpvBuiltInPosition = 0,
    SpvBuiltInPointSize = 1,
    SpvBuiltInClipDistance = 3,
    SpvBuiltInCullDistance = 4,
    SpvBuiltInVertexId = 5,
    SpvBuiltInInstanceId = 6,
    SpvBuiltInPrimitiveId = 7,
    SpvBuiltInInvocationId = 8,
    SpvBuiltInLayer = 9,
    SpvBuiltInViewportIndex = 10,
    SpvBuiltInTessLevelOuter = 11,
    SpvBuiltInTessLevelInner = 12,
    SpvBuiltInTessCoord = 13,
    SpvBuiltInPatchVertices = 14,
    SpvBuiltInFragCoord = 15,
    SpvBuiltInPointCoord = 16,
    SpvBuiltInFrontFacing = 17,
    SpvBuiltInSampleId = 18,
    SpvBuiltInSamplePosition = 19,
    SpvBuiltInSampleMask = 20,
    SpvBuiltInFragDepth = 22,
    SpvBuiltInHelperInvocation = 23,
    SpvBuiltInNumWorkgroups = 24,
    SpvBuiltInWorkgroupSize = 25,
    SpvBuiltInWorkgroupId = 26,
    SpvBuiltInLocalInvocationId = 27,
    SpvBuiltInGlobalInvocationId = 28,
    SpvBuiltInLocalInvocationIndex = 29,
    SpvBuiltInWorkDim = 30,
    SpvBuiltInGlobalSize = 31,
    SpvBuiltInEnqueuedWorkgroupSize = 32,
    SpvBuiltInGlobalOffset = 33,
    SpvBuiltInGlobalLinearId = 34,
    SpvBuiltInSubgroupSize = 36,
    SpvBuiltInSubgroupMaxSize = 37,
    SpvBuiltInNumSubgroups = 38,
    SpvBuiltInNumEnqueuedSubgroups = 39,
    SpvBuiltInSubgroupId = 40,
    SpvBuiltInSubgroupLocalInvocationId = 41,
    SpvBuiltInVertexIndex = 42,
    SpvBuiltInInstanceIndex = 43,
    SpvBuiltInSubgroupEqMask = 4416,
    SpvBuiltInSubgroupEqMaskKHR = 4416,
    SpvBuiltInSubgroupGeMask = 4417,
    SpvBuiltInSubgroupGeMaskKHR = 4417,
    SpvBuiltInSubgroupGtMask = 4418,
    SpvBuiltInSubgroupGtMaskKHR = 4418,
    SpvBuiltInSubgroupLeMask = 4419,
    SpvBuiltInSubgroupLeMaskKHR = 4419,
    SpvBuiltInSubgroupLtMask = 4420,
    SpvBuiltInSubgroupLtMaskKHR = 4420,
    SpvBuiltInBaseVertex = 4424,
    SpvBuiltInBaseInstance = 4425,
    SpvBuiltInDrawIndex = 4426,
    SpvBuiltInPrimitiveShadingRateKHR = 4432,
    SpvBuiltInDeviceIndex = 4438,
    SpvBuiltInViewIndex = 4440,
    SpvBuiltInShadingRateKHR = 4444,
    SpvBuiltInBaryCoordNoPerspAMD = 4992,
    SpvBuiltInBaryCoordNoPerspCentroidAMD = 4993,
    SpvBuiltInBaryCoordNoPerspSampleAMD = 4994,
    SpvBuiltInBaryCoordSmoothAMD = 4995,
    SpvBuiltInBaryCoordSmoothCentroidAMD = 4996,
    SpvBuiltInBaryCoordSmoothSampleAMD = 4997,
    SpvBuiltInBaryCoordPullModelAMD = 4998,
    SpvBuiltInFragStencilRefEXT = 5014,
    SpvBuiltInViewportMaskNV = 5253,
    SpvBuiltInSecondaryPositionNV = 5257,
    SpvBuiltInSecondaryViewportMaskNV = 5258,
    SpvBuiltInPositionPerViewNV = 5261,
    SpvBuiltInViewportMaskPerViewNV = 5262,
    SpvBuiltInFullyCoveredEXT = 5264,
    SpvBuiltInTaskCountNV = 5274,
    SpvBuiltInPrimitiveCountNV = 5275,
    SpvBuiltInPrimitiveIndicesNV = 5276,
    SpvBuiltInClipDistancePerViewNV = 5277,
    SpvBuiltInCullDistancePerViewNV = 5278,
    SpvBuiltInLayerPerViewNV = 5279,
    SpvBuiltInMeshViewCountNV = 5280,
    SpvBuiltInMeshViewIndicesNV = 5281,
    SpvBuiltInBaryCoordKHR = 5286,
    SpvBuiltInBaryCoordNV = 5286,
    SpvBuiltInBaryCoordNoPerspKHR = 5287,
    SpvBuiltInBaryCoordNoPerspNV = 5287,
    SpvBuiltInFragSizeEXT = 5292,
    SpvBuiltInFragmentSizeNV = 5292,
    SpvBuiltInFragInvocationCountEXT = 5293,
    SpvBuiltInInvocationsPerPixelNV = 5293,
    SpvBuiltInPrimitivePointIndicesEXT = 5294,
    SpvBuiltInPrimitiveLineIndicesEXT = 5295,
    SpvBuiltInPrimitiveTriangleIndicesEXT = 5296,
    SpvBuiltInCullPrimitiveEXT = 5299,
    SpvBuiltInLaunchIdKHR = 5319,
    SpvBuiltInLaunchIdNV = 5319,
    SpvBuiltInLaunchSizeKHR = 5320,
    SpvBuiltInLaunchSizeNV = 5320,
    SpvBuiltInWorldRayOriginKHR = 5321,
    SpvBuiltInWorldRayOriginNV = 5321,
    SpvBuiltInWorldRayDirectionKHR = 5322,
    SpvBuiltInWorldRayDirectionNV = 5322,
    SpvBuiltInObjectRayOriginKHR = 5323,
    SpvBuiltInObjectRayOriginNV = 5323,
    SpvBuiltInObjectRayDirectionKHR = 5324,
    SpvBuiltInObjectRayDirectionNV = 5324,
    SpvBuiltInRayTminKHR = 5325,
    SpvBuiltInRayTminNV = 5325,
    SpvBuiltInRayTmaxKHR = 5326,
    SpvBuiltInRayTmaxNV = 5326,
    SpvBuiltInInstanceCustomIndexKHR = 5327,
    SpvBuiltInInstanceCustomIndexNV = 5327,
    SpvBuiltInObjectToWorldKHR = 5330,
    SpvBuiltInObjectToWorldNV = 5330,
    SpvBuiltInWorldToObjectKHR = 5331,
    SpvBuiltInWorldToObjectNV = 5331,
    SpvBuiltInHitTNV = 5332,
    SpvBuiltInHitKindKHR = 5333,
    SpvBuiltInHitKindNV = 5333,
    SpvBuiltInCurrentRayTimeNV = 5334,
    SpvBuiltInIncomingRayFlagsKHR = 5351,
    SpvBuiltInIncomingRayFlagsNV = 5351,
    SpvBuiltInRayGeometryIndexKHR = 5352,
    SpvBuiltInWarpsPerSMNV = 5374,
    SpvBuiltInSMCountNV = 5375,
    SpvBuiltInWarpIDNV = 5376,
    SpvBuiltInSMIDNV = 5377,
    SpvBuiltInCullMaskKHR = 6021,
    SpvBuiltInMax = 0x7fffffff,
}
