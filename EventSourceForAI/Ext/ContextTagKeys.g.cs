
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 3.02
//   File : ContextTagKeys_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Collections.Generic;

    
    
    [System.CodeDom.Compiler.GeneratedCode("gbc", "3.02")]
    internal partial class ContextTagKeys
    {
        
        public string ApplicationVersion { get; set; }

        
        public string ApplicationBuild { get; set; }

        
        public string ApplicationTypeId { get; set; }

        
        public string ApplicationId { get; set; }

        
        public string DeviceId { get; set; }

        
        public string DeviceIp { get; set; }

        
        public string DeviceLanguage { get; set; }

        
        public string DeviceLocale { get; set; }

        
        public string DeviceModel { get; set; }

        
        public string DeviceNetwork { get; set; }

        
        public string DeviceNetworkName { get; set; }

        
        public string DeviceOEMName { get; set; }

        
        public string DeviceOS { get; set; }

        
        public string DeviceOSVersion { get; set; }

        
        public string DeviceRoleInstance { get; set; }

        
        public string DeviceRoleName { get; set; }

        
        public string DeviceScreenResolution { get; set; }

        
        public string DeviceType { get; set; }

        
        public string DeviceMachineName { get; set; }

        
        public string DeviceVMName { get; set; }

        
        public string LocationIp { get; set; }

        
        public string OperationId { get; set; }

        
        public string OperationName { get; set; }

        
        public string OperationParentId { get; set; }

        
        public string OperationRootId { get; set; }

        
        public string OperationSyntheticSource { get; set; }

        
        public string OperationIsSynthetic { get; set; }

        
        public string OperationCorrelationVector { get; set; }

        
        public string SessionId { get; set; }

        
        public string SessionIsFirst { get; set; }

        
        public string SessionIsNew { get; set; }

        
        public string UserAccountAcquisitionDate { get; set; }

        
        public string UserAccountId { get; set; }

        
        public string UserAgent { get; set; }

        
        public string UserId { get; set; }

        
        public string UserStoreRegion { get; set; }

        
        public string UserAuthUserId { get; set; }

        
        public string UserAnonymousUserAcquisitionDate { get; set; }

        
        public string UserAuthenticatedUserAcquisitionDate { get; set; }

        
        
        public string SampleRate { get; set; }

        
        public string CloudName { get; set; }

        
        public string CloudRoleVer { get; set; }

        
        public string CloudEnvironment { get; set; }

        
        public string CloudLocation { get; set; }

        
        public string CloudDeploymentUnit { get; set; }

        
        public string ServerDeviceOS { get; set; }

        
        public string ServerDeviceOSVer { get; set; }

        
        public string InternalSdkVersion { get; set; }

        
        public string InternalAgentVersion { get; set; }

        
        public ContextTagKeys()
            : this("AI.ContextTagKeys", "ContextTagKeys")
        {}

        protected ContextTagKeys(string fullName, string name)
        {
            ApplicationVersion = "ai.application.ver";
            ApplicationBuild = "ai.application.build";
            ApplicationTypeId = "ai.application.typeId";
            ApplicationId = "ai.application.applicationId";
            DeviceId = "ai.device.id";
            DeviceIp = "ai.device.ip";
            DeviceLanguage = "ai.device.language";
            DeviceLocale = "ai.device.locale";
            DeviceModel = "ai.device.model";
            DeviceNetwork = "ai.device.network";
            DeviceNetworkName = "ai.device.networkName";
            DeviceOEMName = "ai.device.oemName";
            DeviceOS = "ai.device.os";
            DeviceOSVersion = "ai.device.osVersion";
            DeviceRoleInstance = "ai.device.roleInstance";
            DeviceRoleName = "ai.device.roleName";
            DeviceScreenResolution = "ai.device.screenResolution";
            DeviceType = "ai.device.type";
            DeviceMachineName = "ai.device.machineName";
            DeviceVMName = "ai.device.vmName";
            LocationIp = "ai.location.ip";
            OperationId = "ai.operation.id";
            OperationName = "ai.operation.name";
            OperationParentId = "ai.operation.parentId";
            OperationRootId = "ai.operation.rootId";
            OperationSyntheticSource = "ai.operation.syntheticSource";
            OperationIsSynthetic = "ai.operation.isSynthetic";
            OperationCorrelationVector = "ai.operation.correlationVector";
            SessionId = "ai.session.id";
            SessionIsFirst = "ai.session.isFirst";
            SessionIsNew = "ai.session.isNew";
            UserAccountAcquisitionDate = "ai.user.accountAcquisitionDate";
            UserAccountId = "ai.user.accountId";
            UserAgent = "ai.user.userAgent";
            UserId = "ai.user.id";
            UserStoreRegion = "ai.user.storeRegion";
            UserAuthUserId = "ai.user.authUserId";
            UserAnonymousUserAcquisitionDate = "ai.user.anonUserAcquisitionDate";
            UserAuthenticatedUserAcquisitionDate = "ai.user.authUserAcquisitionDate";
            SampleRate = "ai.sample.sampleRate";
            CloudName = "ai.cloud.name";
            CloudRoleVer = "ai.cloud.roleVer";
            CloudEnvironment = "ai.cloud.environment";
            CloudLocation = "ai.cloud.location";
            CloudDeploymentUnit = "ai.cloud.deploymentUnit";
            ServerDeviceOS = "ai.serverDevice.os";
            ServerDeviceOSVer = "ai.serverDevice.osVer";
            InternalSdkVersion = "ai.internal.sdkVersion";
            InternalAgentVersion = "ai.internal.agentVersion";
        }
    }
} // AI










