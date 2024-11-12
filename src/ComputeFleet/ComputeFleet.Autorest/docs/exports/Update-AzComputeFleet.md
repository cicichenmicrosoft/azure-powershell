---
external help file:
Module Name: Az.ComputeFleet
online version: https://learn.microsoft.com/powershell/module/computefleet/update-azcomputefleet
schema: 2.0.0
---

# Update-AzComputeFleet

## SYNOPSIS
update a ComputeFleet

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzComputeFleet -FleetName <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-AdditionalLocationProfileLocationProfiles <ILocationProfile[]>]
 [-AdditionalVirtualMachineCapabilityHibernationEnabled] [-AdditionalVirtualMachineCapabilityUltraSsdEnabled]
 [-ComputeProfileBaseVirtualMachineProfile <IBaseVirtualMachineProfile>]
 [-ComputeProfileComputeApiVersion <String>] [-ComputeProfilePlatformFaultDomainCount <Int32>]
 [-IdentityType <String>] [-IdentityUserAssignedIdentities <Hashtable>] [-PlanName <String>]
 [-PlanProduct <String>] [-PlanPromotionCode <String>] [-PlanPublisher <String>] [-PlanVersion <String>]
 [-RegularPriorityProfileAllocationStrategy <String>] [-RegularPriorityProfileCapacity <Int32>]
 [-RegularPriorityProfileMinCapacity <Int32>] [-SpotPriorityProfileAllocationStrategy <String>]
 [-SpotPriorityProfileCapacity <Int32>] [-SpotPriorityProfileEvictionPolicy <String>]
 [-SpotPriorityProfileMaintain] [-SpotPriorityProfileMaxPricePerVM <Single>]
 [-SpotPriorityProfileMinCapacity <Int32>] [-Tags <Hashtable>] [-VMAttributes <IVMAttributes>]
 [-VMSizesProfile <IVMSizeProfile[]>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-AzComputeFleet -FleetName <String> -ResourceGroupName <String> -SubscriptionId <String>
 -Properties <IFleetUpdate> [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-AzComputeFleet -InputObject <IFleetIdentity> -Properties <IFleetUpdate> [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzComputeFleet -InputObject <IFleetIdentity>
 [-AdditionalLocationProfileLocationProfiles <ILocationProfile[]>]
 [-AdditionalVirtualMachineCapabilityHibernationEnabled] [-AdditionalVirtualMachineCapabilityUltraSsdEnabled]
 [-ComputeProfileBaseVirtualMachineProfile <IBaseVirtualMachineProfile>]
 [-ComputeProfileComputeApiVersion <String>] [-ComputeProfilePlatformFaultDomainCount <Int32>]
 [-IdentityType <String>] [-IdentityUserAssignedIdentities <Hashtable>] [-PlanName <String>]
 [-PlanProduct <String>] [-PlanPromotionCode <String>] [-PlanPublisher <String>] [-PlanVersion <String>]
 [-RegularPriorityProfileAllocationStrategy <String>] [-RegularPriorityProfileCapacity <Int32>]
 [-RegularPriorityProfileMinCapacity <Int32>] [-SpotPriorityProfileAllocationStrategy <String>]
 [-SpotPriorityProfileCapacity <Int32>] [-SpotPriorityProfileEvictionPolicy <String>]
 [-SpotPriorityProfileMaintain] [-SpotPriorityProfileMaxPricePerVM <Single>]
 [-SpotPriorityProfileMinCapacity <Int32>] [-Tags <Hashtable>] [-VMAttributes <IVMAttributes>]
 [-VMSizesProfile <IVMSizeProfile[]>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
update a ComputeFleet

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalLocationProfileLocationProfiles
The list of location profiles.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.ILocationProfile[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalVirtualMachineCapabilityHibernationEnabled
The flag that enables or disables hibernation capability on the VM.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalVirtualMachineCapabilityUltraSsdEnabled
The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS.Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComputeProfileBaseVirtualMachineProfile
Base Virtual Machine Profile Properties to be specified according to "specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile"

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IBaseVirtualMachineProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComputeProfileComputeApiVersion
Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.The default value will be the latest supported computeApiVersion by Compute ComputeFleet.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComputeProfilePlatformFaultDomainCount
Specifies the number of fault domains to use when creating the underlying VMSS.A fault domain is a logical group of hardware within an Azure datacenter.VMs in the same fault domain share a common power source and network switch.If not specified, defaults to 1, which represents "Max Spreading" (using as many fault domains as possible).This property cannot be updated.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FleetName
The name of the Compute ComputeFleet

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityType
The type of managed identity assigned to this resource.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityUserAssignedIdentities
The identities assigned to this resource by the user.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleetIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanName
A user defined name of the 3rd Party Artifact that is being procured.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanProduct
The 3rd Party artifact that is being procured.
E.g.
NewRelic.
Product maps to the OfferID specified for the artifact at the time of Data Market onboarding.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanPromotionCode
A publisher provided promotion code as provisioned in Data Market for the said product/artifact.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanPublisher
The publisher of the 3rd Party Artifact that is being bought.
E.g.
NewRelic

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanVersion
The version of the desired product/artifact.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Properties
ComputeFleet Update Model

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleetUpdate
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -RegularPriorityProfileAllocationStrategy
Allocation strategy to follow when determining the VM sizes distribution for Regular VMs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegularPriorityProfileCapacity
Total capacity to achieve.
It is currently in terms of number of VMs.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegularPriorityProfileMinCapacity
Minimum capacity to achieve which cannot be updated.
If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileAllocationStrategy
Allocation strategy to follow when determining the VM sizes distribution for Spot VMs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileCapacity
Total capacity to achieve.
It is currently in terms of number of VMs.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileEvictionPolicy
Eviction Policy to follow when evicting Spot VMs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileMaintain
Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint) in order to achieve the desired capacity.Maintain is enabled by default.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileMaxPricePerVM
Price per hour of each Spot VM will never exceed this.

```yaml
Type: System.Single
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileMinCapacity
Minimum capacity to achieve which cannot be updated.
If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMAttributes
Attribute based ComputeFleet.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IVMAttributes
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMSizesProfile
List of VM sizes supported for Compute ComputeFleet

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IVMSizeProfile[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleetIdentity

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleetUpdate

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleet

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDITIONALLOCATIONPROFILELOCATIONPROFILES <ILocationProfile[]>`: The list of location profiles.
  - `Location <String>`: The ARM location name of the additional region. If LocationProfile is specified, then location is required.
  - `[VirtualMachineProfileOverride <IBaseVirtualMachineProfile>]`: An override for computeProfile.baseVirtualMachineProfile specific to this region.         This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources deployed in this location.
    - `[ApplicationProfileGalleryApplications <List<IVMGalleryApplication>>]`: Specifies the gallery applications that should be made available to the VM/VMSS
      - `PackageReferenceId <String>`: Specifies the GalleryApplicationVersion resource id on the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
      - `[ConfigurationReference <String>]`: Optional, Specifies the uri to an azure blob that will replace the default         configuration for the package if provided
      - `[EnableAutomaticUpgrade <Boolean?>]`: If set to true, when a new Gallery Application version is available in PIR/SIG,         it will be automatically updated for the VM/VMSS
      - `[Order <Int32?>]`: Optional, Specifies the order in which the packages have to be installed
      - `[Tags <String>]`: Optional, Specifies a passthrough value for more generic context.
      - `[TreatFailureAsDeploymentFailure <Boolean?>]`: Optional, If true, any failure for any operation in the VmApplication will fail         the deployment
    - `[BootDiagnosticEnabled <Boolean?>]`: Whether boot diagnostics should be enabled on the Virtual Machine.
    - `[BootDiagnosticStorageUri <String>]`: Uri of the storage account to use for placing the console output and         screenshot. If storageUri is not specified while enabling boot diagnostics,         managed storage will be used.
    - `[CapacityReservationGroupId <String>]`: Resource Id
    - `[EncryptionIdentityUserAssignedIdentityResourceId <String>]`: Specifies ARM Resource ID of one of the user identities associated with the VM.
    - `[ExtensionProfileExtensions <List<IVirtualMachineScaleSetExtension>>]`: The virtual machine scale set child extension resources.
      - `[AutoUpgradeMinorVersion <Boolean?>]`: Indicates whether the extension should use a newer minor version if one is         available at deployment time. Once deployed, however, the extension will not         upgrade minor versions unless redeployed, even with this property set to true.
      - `[EnableAutomaticUpgrade <Boolean?>]`: Indicates whether the extension should be automatically upgraded by the         platform if there is a newer version of the extension available.
      - `[ForceUpdateTag <String>]`: If a value is provided and is different from the previous value, the extension         handler will be forced to update even if the extension configuration has not         changed.
      - `[Name <String>]`: The name of the extension.
      - `[PropertiesType <String>]`: Specifies the type of the extension; an example is "CustomScriptExtension".
      - `[ProtectedSettingFromKeyVaultSecretUrl <String>]`: The URL referencing a secret in a Key Vault.
      - `[ProtectedSettings <IVirtualMachineScaleSetExtensionPropertiesProtectedSettings>]`: The extension can contain either protectedSettings or         protectedSettingsFromKeyVault or no protected settings at all.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ProvisionAfterExtensions <List<String>>]`: Collection of extension names after which this extension needs to be         provisioned.
      - `[Publisher <String>]`: The name of the extension handler publisher.
      - `[Settings <IVirtualMachineScaleSetExtensionPropertiesSettings>]`: Json formatted public settings for the extension.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SourceVaultId <String>]`: Resource Id
      - `[SuppressFailures <Boolean?>]`: Indicates whether failures stemming from the extension will be suppressed         (Operational failures such as not connecting to the VM will not be suppressed         regardless of this value). The default is false.
      - `[TypeHandlerVersion <String>]`: Specifies the version of the script handler.
    - `[ExtensionProfileExtensionsTimeBudget <String>]`: Specifies the time alloted for all extensions to start. The time duration         should be between 15 minutes and 120 minutes (inclusive) and should be         specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).         Minimum api-version: 2020-06-01.
    - `[HealthProbeId <String>]`: The ARM resource id in the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
    - `[LicenseType <String>]`: Specifies that the image or disk that is being used was licensed on-premises.            Possible values for Windows Server operating system are:            Windows_Client    Windows_Server    Possible values for Linux         Server operating system are:    RHEL_BYOS (for RHEL)    SLES_BYOS         (for SUSE)    For more information, see [Azure Hybrid Use Benefit for         Windows         Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)            [Azure Hybrid Use Benefit for Linux         Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)            Minimum api-version: 2015-06-15
    - `[NetworkProfileNetworkApiVersion <String>]`: specifies the Microsoft.Network API version used when creating networking         resources in the Network Interface Configurations for Virtual Machine Scale Set         with orchestration mode 'Flexible'
    - `[NetworkProfileNetworkInterfaceConfigurations <List<IVirtualMachineScaleSetNetworkConfiguration>>]`: The list of network configurations.
      - `Name <String>`: The network configuration name.
      - `[AuxiliaryMode <String>]`: Specifies whether the Auxiliary mode is enabled for the Network Interface         resource.
      - `[AuxiliarySku <String>]`: Specifies whether the Auxiliary sku is enabled for the Network Interface         resource.
      - `[DeleteOption <String>]`: Specify what happens to the network interface when the VM is deleted
      - `[DisableTcpStateTracking <Boolean?>]`: Specifies whether the network interface is disabled for tcp state tracking.
      - `[DnsSettingDnsServers <List<String>>]`: List of DNS servers IP addresses
      - `[EnableAcceleratedNetworking <Boolean?>]`: Specifies whether the network interface is accelerated networking-enabled.
      - `[EnableFpga <Boolean?>]`: Specifies whether the network interface is FPGA networking-enabled.
      - `[EnableIPForwarding <Boolean?>]`: Whether IP forwarding enabled on this NIC.
      - `[IPConfigurations <List<IVirtualMachineScaleSetIPConfiguration>>]`: Specifies the IP configurations of the network interface.
        - `Name <String>`: The IP configuration name.
        - `[ApplicationGatewayBackendAddressPools <List<ISubResource>>]`: Specifies an array of references to backend address pools of application         gateways. A scale set can reference backend address pools of multiple         application gateways. Multiple scale sets cannot use the same application         gateway.
          - `[Id <String>]`: Resource Id
        - `[ApplicationSecurityGroups <List<ISubResource>>]`: Specifies an array of references to application security group.
        - `[DeleteOption <String>]`: Specify what happens to the public IP when the VM is deleted
        - `[DnsSettingDomainNameLabel <String>]`: The Domain name label.The concatenation of the domain name label and vm index         will be the domain name labels of the PublicIPAddress resources that will be         created
        - `[DnsSettingDomainNameLabelScope <String>]`: The Domain name label scope.The concatenation of the hashed domain name label         that generated according to the policy from domain name label scope and vm         index will be the domain name labels of the PublicIPAddress resources that will         be created
        - `[IPTags <List<IVirtualMachineScaleSetIPTag>>]`: The list of IP tags associated with the public IP address.
          - `[IPTagType <String>]`: IP tag type. Example: FirstPartyUsage.
          - `[Tag <String>]`: IP tag associated with the public IP. Example: SQL, Storage etc.
        - `[IdleTimeoutInMinutes <Int32?>]`: The idle timeout of the public IP address.
        - `[LoadBalancerBackendAddressPools <List<ISubResource>>]`: Specifies an array of references to backend address pools of load balancers. A         scale set can reference backend address pools of one public and one internal         load balancer. Multiple scale sets cannot use the same basic sku load balancer.
        - `[LoadBalancerInboundNatPools <List<ISubResource>>]`: Specifies an array of references to inbound Nat pools of the load balancers. A         scale set can reference inbound nat pools of one public and one internal load         balancer. Multiple scale sets cannot use the same basic sku load balancer.
        - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more         than 1 network interface.
        - `[PrivateIPAddressVersion <String>]`: Available from Api-Version 2017-03-30 onwards, it represents whether the         specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible         values are: 'IPv4' and 'IPv6'.
        - `[PublicIPAddressConfigurationName <String>]`: The publicIP address configuration name.
        - `[PublicIPAddressVersion <String>]`: Available from Api-Version 2019-07-01 onwards, it represents whether the         specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible         values are: 'IPv4' and 'IPv6'.
        - `[PublicIPPrefixId <String>]`: Resource Id
        - `[SkuName <String>]`: Specify public IP sku name
        - `[SkuTier <String>]`: Specify public IP sku tier
        - `[SubnetId <String>]`: The ARM resource id in the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
      - `[NetworkSecurityGroupId <String>]`: Resource Id
      - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more         than 1 network interface.
    - `[OSImageNotificationProfileEnable <Boolean?>]`: Specifies whether the OS Image Scheduled event is enabled or disabled.
    - `[OSImageNotificationProfileNotBeforeTimeout <String>]`: Length of time a Virtual Machine being reimaged or having its OS upgraded will         have to potentially approve the OS Image Scheduled Event before the event is         auto approved (timed out). The configuration is specified in ISO 8601 format,         and the value must not exceed 15 minutes (PT15M)
    - `[OSProfile <IVirtualMachineScaleSetOSProfile>]`: Specifies the operating system settings for the virtual machines in the scale         set.
      - `[AdminPassword <SecureString>]`: Specifies the password of the administrator account.    **Minimum-length         (Windows):** 8 characters    **Minimum-length (Linux):** 6 characters            **Max-length (Windows):** 123 characters    **Max-length         (Linux):** 72 characters    **Complexity requirements:** 3 out of 4         conditions below need to be fulfilled   Has lower characters  Has upper         characters   Has a digit   Has a special character (Regex match [\W_])            **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd",         "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1",         "Password22", "iloveyou!"    For resetting the password, see [How to         reset the Remote Desktop service or its login password in a Windows         VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)            For resetting root password, see [Manage users, SSH, and check or         repair disks on Azure Linux VMs using the VMAccess         Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
      - `[AdminUsername <String>]`: Specifies the name of the administrator account.    **Windows-only         restriction:** Cannot end in "."    **Disallowed values:**         "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3",         "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup",         "console", "david", "guest", "john", "owner", "root", "server", "sql",         "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".            **Minimum-length (Linux):** 1  character    **Max-length         (Linux):** 64 characters    **Max-length (Windows):** 20 characters
      - `[AllowExtensionOperations <Boolean?>]`: Specifies whether extension operations should be allowed on the virtual machine         scale set. This may only be set to False when no extensions are present on the         virtual machine scale set.
      - `[ComputerNamePrefix <String>]`: Specifies the computer name prefix for all of the virtual machines in the scale         set. Computer name prefixes must be 1 to 15 characters long.
      - `[CustomData <SecureString>]`: Specifies a base-64 encoded string of custom data. The base-64 encoded string         is decoded to a binary array that is saved as a file on the Virtual Machine.         The maximum length of the binary array is 65535 bytes. For using cloud-init for         your VM, see [Using cloud-init to customize a Linux VM during         creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
      - `[LinuxConfigurationDisablePasswordAuthentication <Boolean?>]`: Specifies whether password authentication should be disabled.
      - `[LinuxConfigurationEnableVMAgentPlatformUpdates <Boolean?>]`: Indicates whether VMAgent Platform Updates is enabled for the Linux virtual         machine. Default value is false.
      - `[LinuxConfigurationPatchSettingsAssessmentMode <String>]`: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual         machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You         control the timing of patch assessments on a virtual machine. <br /><br />         **AutomaticByPlatform** - The platform will trigger periodic patch assessments.         The property provisionVMAgent must be true.
      - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule <Boolean?>]`: Enables customer to schedule patching without accidental upgrades
      - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <String>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation         operations.
      - `[LinuxConfigurationPatchSettingsPatchMode <String>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual         machines associated to virtual machine scale set with OrchestrationMode as         Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The         virtual machine's default patching configuration is used. <br /><br />         **AutomaticByPlatform** - The virtual machine will be automatically updated by         the platform. The property provisionVMAgent must be true
      - `[LinuxConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual         machine. When this property is not specified in the request body, default         behavior is to set it to true. This will ensure that VM Agent is installed on         the VM so that extensions can be added to the VM later.
      - `[PatchSettingEnableHotpatching <Boolean?>]`: Enables customers to patch their Azure VMs without requiring a reboot. For         enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'         must be set to 'AutomaticByPlatform'.
      - `[RequireGuestProvisionSignal <Boolean?>]`: Optional property which must either be set to True or omitted.
      - `[Secrets <List<IVaultSecretGroup>>]`: Specifies set of certificates that should be installed onto the virtual         machines in the scale set. To install certificates on a virtual machine it is         recommended to use the [Azure Key Vault virtual machine extension for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        - `[SourceVaultId <String>]`: Resource Id
        - `[VaultCertificates <List<IVaultCertificate>>]`: The list of key vault references in SourceVault which contain certificates.
          - `[CertificateStore <String>]`: For Windows VMs, specifies the certificate store on the Virtual Machine to         which the certificate should be added. The specified certificate store is         implicitly in the LocalMachine account. For Linux VMs, the certificate file is         placed under the /var/lib/waagent directory, with the file name         &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and         &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem         formatted.
          - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a         secret. For adding a secret to the Key Vault, see [Add a key or secret to the         key         vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).         In this case, your certificate needs to be It is the Base64 encoding of the         following JSON Object which is encoded in UTF-8:    {          "data":"<Base64-encoded-certificate>",   "dataType":"pfx",          "password":"<pfx-file-password>" }   To install certificates on a virtual         machine it is recommended to use the [Azure Key Vault virtual machine extension         for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
      - `[SshPublicKeys <List<ISshPublicKey>>]`: The list of SSH public keys used to authenticate with linux based VMs.
        - `[KeyData <String>]`: SSH public key certificate used to authenticate with the VM through ssh. The         key needs to be at least 2048-bit and in ssh-rsa format. For creating ssh keys,         see [Create SSH keys on Linux and Mac for Linux VMs in         Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
        - `[Path <String>]`: Specifies the full path on the created VM where ssh public key is stored. If         the file already exists, the specified key is appended to the file. Example:         /home/user/.ssh/authorized_keys
      - `[WinRmListeners <List<IWinRmListener>>]`: The list of Windows Remote Management listeners
        - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a         secret. For adding a secret to the Key Vault, see [Add a key or secret to the         key         vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).         In this case, your certificate needs to be the Base64 encoding of the following         JSON Object which is encoded in UTF-8:    {          "data":"<Base64-encoded-certificate>",   "dataType":"pfx",          "password":"<pfx-file-password>" }   To install certificates on a virtual         machine it is recommended to use the [Azure Key Vault virtual machine extension         for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        - `[Protocol <String>]`: Specifies the protocol of WinRM listener. Possible values are: **http,**         **https.**
      - `[WindowConfigurationAdditionalUnattendContent <List<IAdditionalUnattendContent>>]`: Specifies additional base-64 encoded XML formatted information that can be         included in the Unattend.xml file, which is used by Windows Setup.
        - `[ComponentName <String>]`: The component name. Currently, the only allowable value is         Microsoft-Windows-Shell-Setup.
        - `[Content <SecureString>]`: Specifies the XML formatted content that is added to the unattend.xml file for         the specified path and component. The XML must be less than 4KB and must         include the root element for the setting or feature that is being inserted.
        - `[PassName <String>]`: The pass name. Currently, the only allowable value is OobeSystem.
        - `[SettingName <String>]`: Specifies the name of the setting to which the content applies. Possible values         are: FirstLogonCommands and AutoLogon.
      - `[WindowConfigurationEnableAutomaticUpdates <Boolean?>]`: Indicates whether Automatic Updates is enabled for the Windows virtual machine.         Default value is true. For virtual machine scale sets, this property can be         updated and updates will take effect on OS reprovisioning.
      - `[WindowConfigurationEnableVMAgentPlatformUpdates <Boolean?>]`: Indicates whether VMAgent Platform Updates is enabled for the Windows virtual         machine. Default value is false.
      - `[WindowConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual         machine. When this property is not specified in the request body, it is set to         true by default. This will ensure that VM Agent is installed on the VM so that         extensions can be added to the VM later.
      - `[WindowConfigurationTimeZone <String>]`: Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".         Possible values can be         [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)         value from time zones returned by         [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
      - `[WindowsConfigurationPatchSettingsAssessmentMode <String>]`: Specifies the mode of VM Guest patch assessment for the IaaS virtual         machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You         control the timing of patch assessments on a virtual machine.<br /><br />         **AutomaticByPlatform** - The platform will trigger periodic patch assessments.         The property provisionVMAgent must be true.
      - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule <Boolean?>]`: Enables customer to schedule patching without accidental upgrades
      - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <String>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation         operations.
      - `[WindowsConfigurationPatchSettingsPatchMode <String>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual         machines associated to virtual machine scale set with OrchestrationMode as         Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You         control the application of patches to a virtual machine. You do this by         applying patches manually inside the VM. In this mode, automatic updates are         disabled; the property WindowsConfiguration.enableAutomaticUpdates must be         false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be         updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates         must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will         automatically updated by the platform. The properties provisionVMAgent and         WindowsConfiguration.enableAutomaticUpdates must be true
    - `[ProxyAgentSettingEnabled <Boolean?>]`: Specifies whether ProxyAgent feature should be enabled on the virtual machine         or virtual machine scale set.
    - `[ProxyAgentSettingKeyIncarnationId <Int32?>]`: Increase the value of this property allows user to reset the key used for         securing communication channel between guest and host.
    - `[ProxyAgentSettingMode <String>]`: Specifies the mode that ProxyAgent will execute on if the feature is enabled.         ProxyAgent will start to audit or monitor but not enforce access control over         requests to host endpoints in Audit mode, while in Enforce mode it will enforce         access control. The default value is Enforce mode.
    - `[SecurityPostureReferenceExcludeExtensions <List<String>>]`: List of virtual machine extension names to exclude when applying the security         posture.
    - `[SecurityPostureReferenceId <String>]`: The security posture reference id in the form of         /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest
    - `[SecurityPostureReferenceIsOverridable <Boolean?>]`: Whether the security posture can be overridden by the user.
    - `[SecurityProfileEncryptionAtHost <Boolean?>]`: This property can be used by user in the request to enable or disable the Host         Encryption for the virtual machine or virtual machine scale set. This will         enable the encryption for all the disks including Resource/Temp disk at host         itself. The default behavior is: The Encryption at host will be disabled unless         this property is set to true for the resource.
    - `[SecurityProfileSecurityType <String>]`: Specifies the SecurityType of the virtual machine. It has to be set to any         specified value to enable UefiSettings. The default behavior is: UefiSettings         will not be enabled unless this property is set.
    - `[ServiceArtifactReferenceId <String>]`: The service artifact reference id in the form of         /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}
    - `[StorageProfile <IVirtualMachineScaleSetStorageProfile>]`: Specifies the storage settings for the virtual machine disks.
      - `[DataDisks <List<IVirtualMachineScaleSetDataDisk>>]`: Specifies the parameters that are used to add data disks to the virtual         machines in the scale set. For more information about disks, see [About disks         and VHDs for Azure virtual         machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
        - `CreateOption <String>`: The create option.
        - `Lun <Int32>`: Specifies the logical unit number of the data disk. This value is used to         identify data disks within the VM and therefore must be unique for each data         disk attached to a VM.
        - `[Caching <String>]`: Specifies the caching requirements. Possible values are: **None,**         **ReadOnly,** **ReadWrite.** The default values are: **None for Standard         storage. ReadOnly for Premium storage.**
        - `[DeleteOption <String>]`: Specifies whether data disk should be deleted or detached upon VMSS Flex         deletion (This feature is available for VMSS with Flexible OrchestrationMode         only).   Possible values:    **Delete** If this value is used, the         data disk is deleted when the VMSS Flex VM is deleted.   **Detach** If         this value is used, the data disk is retained after VMSS Flex VM is         deleted.   The default value is set to **Delete**.
        - `[DiskIopsReadWrite <Int64?>]`: Specifies the Read-Write IOPS for the managed disk. Should be used only when         StorageAccountType is UltraSSD_LRS. If not specified, a default value would be         assigned based on diskSizeGB.
        - `[DiskMBpsReadWrite <Int64?>]`: Specifies the bandwidth in MB per second for the managed disk. Should be used         only when StorageAccountType is UltraSSD_LRS. If not specified, a default value         would be assigned based on diskSizeGB.
        - `[DiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used         to overwrite the size of the disk in a virtual machine image. The property         diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be         larger than 1023.
        - `[Id <String>]`: Resource Id
        - `[ManagedDiskStorageAccountType <String>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can         only be used with data disks, it cannot be used with OS Disk.
        - `[Name <String>]`: The disk name.
        - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
        - `[SecurityProfileSecurityEncryptionType <String>]`: Specifies the EncryptionType of the managed disk. It is set to         DiskWithVMGuestState for encryption of the managed disk along with VMGuestState         blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and         NonPersistedTPM for not persisting firmware state in the VMGuestState blob..         **Note:** It can be set for only Confidential VMs.
        - `[WriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.
      - `[DiffDiskSettingOption <String>]`: Specifies the ephemeral disk settings for operating system disk.
      - `[DiffDiskSettingPlacement <String>]`: Specifies the ephemeral disk placement for operating system disk. Possible         values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:         **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**         is used. Refer to the VM size documentation for Windows VM at         https://docs.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at         https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM         sizes exposes a cache disk.
      - `[DiskControllerType <String>]`: Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01
      - `[Id <String>]`: Resource Id
      - `[ImageReferenceCommunityGalleryImageId <String>]`: Specified the community gallery image unique id for vm deployment. This can be         fetched from community gallery image GET call.
      - `[ImageReferenceId <String>]`: Resource Id
      - `[ImageReferenceOffer <String>]`: Specifies the offer of the platform image or marketplace image used to create         the virtual machine.
      - `[ImageReferencePublisher <String>]`: The image publisher.
      - `[ImageReferenceSharedGalleryImageId <String>]`: Specified the shared gallery image unique id for vm deployment. This can be         fetched from shared gallery image GET call.
      - `[ImageReferenceSku <String>]`: The image SKU.
      - `[ImageReferenceVersion <String>]`: Specifies the version of the platform image or marketplace image used to create         the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.         Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest         version of an image available at deploy time. Even if you use 'latest', the VM         image will not automatically update after deploy time even if a new version         becomes available. Please do not use field 'version' for gallery image         deployment, gallery image should always use 'id' field for deployment, to use 'latest'         version of gallery image, just set         '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'         in the 'id' field without version input.
      - `[ImageUri <String>]`: Specifies the virtual hard disk's uri.
      - `[ManagedDiskStorageAccountType <String>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can         only be used with data disks, it cannot be used with OS Disk.
      - `[OSDiskCaching <String>]`: Specifies the caching requirements. Possible values are: **None,**         **ReadOnly,** **ReadWrite.** The default values are: **None for Standard         storage. ReadOnly for Premium storage.**
      - `[OSDiskCreateOption <String>]`: Specifies how the virtual machines in the scale set should be created. The only         allowed value is: **FromImage.** This value is used when you are using an image         to create the virtual machine. If you are using a platform image, you also use         the imageReference element described above. If you are using a marketplace         image, you  also use the plan element previously described.
      - `[OSDiskDeleteOption <String>]`: Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion         (This feature is available for VMSS with Flexible OrchestrationMode only).            Possible values:    **Delete** If this value is used, the OS         disk is deleted when VMSS Flex VM is deleted.   **Detach** If this value         is used, the OS disk is retained after VMSS Flex VM is deleted.    The         default value is set to **Delete**. For an Ephemeral OS Disk, the default value         is set to **Delete**. User cannot change the delete option for Ephemeral OS         Disk.
      - `[OSDiskName <String>]`: The disk name.
      - `[OSDiskOstype <String>]`: This property allows you to specify the type of the OS that is included in the         disk if creating a VM from user-image or a specialized VHD. Possible values         are: **Windows,** **Linux.**
      - `[OSDiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used         to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'         is the number of bytes x 1024^3 for the disk and the value cannot         be larger than 1023.
      - `[OSDiskVhdContainers <List<String>>]`: Specifies the container urls that are used to store operating system disks for         the scale set.
      - `[OSDiskWriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.
      - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
      - `[SecurityProfileSecurityEncryptionType <String>]`: Specifies the EncryptionType of the managed disk. It is set to         DiskWithVMGuestState for encryption of the managed disk along with VMGuestState         blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and         NonPersistedTPM for not persisting firmware state in the VMGuestState blob..         **Note:** It can be set for only Confidential VMs.
    - `[TerminateNotificationProfileEnable <Boolean?>]`: Specifies whether the Terminate Scheduled event is enabled or disabled.
    - `[TerminateNotificationProfileNotBeforeTimeout <String>]`: Configurable length of time a Virtual Machine being deleted will have to         potentially approve the Terminate Scheduled Event before the event is auto         approved (timed out). The configuration must be specified in ISO 8601 format,         the default value is 5 minutes (PT5M)
    - `[UefiSettingSecureBootEnabled <Boolean?>]`: Specifies whether secure boot should be enabled on the virtual machine. Minimum         api-version: 2020-12-01.
    - `[UefiSettingVTpmEnabled <Boolean?>]`: Specifies whether vTPM should be enabled on the virtual machine. Minimum         api-version: 2020-12-01.
    - `[UserData <String>]`: UserData for the virtual machines in the scale set, which must be base-64         encoded. Customer should not pass any secrets in here. Minimum api-version:         2021-03-01.
    - `[VMSizePropertyVcpUsAvailable <Int32?>]`: Specifies the number of vCPUs available for the VM. When this property is not         specified in the request body the default behavior is to set it to the value of         vCPUs available for that VM size exposed in api response of [List all available         virtual machine sizes in a         region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list).
    - `[VMSizePropertyVcpUsPerCore <Int32?>]`: Specifies the vCPU to physical core ratio. When this property is not specified         in the request body the default behavior is set to the value of vCPUsPerCore         for the VM Size exposed in api response of [List all available virtual machine         sizes in a         region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list).         **Setting this property to 1 also means that hyper-threading is disabled.**

`COMPUTEPROFILEBASEVIRTUALMACHINEPROFILE <IBaseVirtualMachineProfile>`: Base Virtual Machine Profile Properties to be specified according to "specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile"
  - `[ApplicationProfileGalleryApplications <List<IVMGalleryApplication>>]`: Specifies the gallery applications that should be made available to the VM/VMSS
    - `PackageReferenceId <String>`: Specifies the GalleryApplicationVersion resource id on the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
    - `[ConfigurationReference <String>]`: Optional, Specifies the uri to an azure blob that will replace the default         configuration for the package if provided
    - `[EnableAutomaticUpgrade <Boolean?>]`: If set to true, when a new Gallery Application version is available in PIR/SIG,         it will be automatically updated for the VM/VMSS
    - `[Order <Int32?>]`: Optional, Specifies the order in which the packages have to be installed
    - `[Tags <String>]`: Optional, Specifies a passthrough value for more generic context.
    - `[TreatFailureAsDeploymentFailure <Boolean?>]`: Optional, If true, any failure for any operation in the VmApplication will fail         the deployment
  - `[BootDiagnosticEnabled <Boolean?>]`: Whether boot diagnostics should be enabled on the Virtual Machine.
  - `[BootDiagnosticStorageUri <String>]`: Uri of the storage account to use for placing the console output and         screenshot. If storageUri is not specified while enabling boot diagnostics,         managed storage will be used.
  - `[CapacityReservationGroupId <String>]`: Resource Id
  - `[EncryptionIdentityUserAssignedIdentityResourceId <String>]`: Specifies ARM Resource ID of one of the user identities associated with the VM.
  - `[ExtensionProfileExtensions <List<IVirtualMachineScaleSetExtension>>]`: The virtual machine scale set child extension resources.
    - `[AutoUpgradeMinorVersion <Boolean?>]`: Indicates whether the extension should use a newer minor version if one is         available at deployment time. Once deployed, however, the extension will not         upgrade minor versions unless redeployed, even with this property set to true.
    - `[EnableAutomaticUpgrade <Boolean?>]`: Indicates whether the extension should be automatically upgraded by the         platform if there is a newer version of the extension available.
    - `[ForceUpdateTag <String>]`: If a value is provided and is different from the previous value, the extension         handler will be forced to update even if the extension configuration has not         changed.
    - `[Name <String>]`: The name of the extension.
    - `[PropertiesType <String>]`: Specifies the type of the extension; an example is "CustomScriptExtension".
    - `[ProtectedSettingFromKeyVaultSecretUrl <String>]`: The URL referencing a secret in a Key Vault.
    - `[ProtectedSettings <IVirtualMachineScaleSetExtensionPropertiesProtectedSettings>]`: The extension can contain either protectedSettings or         protectedSettingsFromKeyVault or no protected settings at all.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ProvisionAfterExtensions <List<String>>]`: Collection of extension names after which this extension needs to be         provisioned.
    - `[Publisher <String>]`: The name of the extension handler publisher.
    - `[Settings <IVirtualMachineScaleSetExtensionPropertiesSettings>]`: Json formatted public settings for the extension.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SourceVaultId <String>]`: Resource Id
    - `[SuppressFailures <Boolean?>]`: Indicates whether failures stemming from the extension will be suppressed         (Operational failures such as not connecting to the VM will not be suppressed         regardless of this value). The default is false.
    - `[TypeHandlerVersion <String>]`: Specifies the version of the script handler.
  - `[ExtensionProfileExtensionsTimeBudget <String>]`: Specifies the time alloted for all extensions to start. The time duration         should be between 15 minutes and 120 minutes (inclusive) and should be         specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).         Minimum api-version: 2020-06-01.
  - `[HealthProbeId <String>]`: The ARM resource id in the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
  - `[LicenseType <String>]`: Specifies that the image or disk that is being used was licensed on-premises.            Possible values for Windows Server operating system are:            Windows_Client    Windows_Server    Possible values for Linux         Server operating system are:    RHEL_BYOS (for RHEL)    SLES_BYOS         (for SUSE)    For more information, see [Azure Hybrid Use Benefit for         Windows         Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)            [Azure Hybrid Use Benefit for Linux         Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)            Minimum api-version: 2015-06-15
  - `[NetworkProfileNetworkApiVersion <String>]`: specifies the Microsoft.Network API version used when creating networking         resources in the Network Interface Configurations for Virtual Machine Scale Set         with orchestration mode 'Flexible'
  - `[NetworkProfileNetworkInterfaceConfigurations <List<IVirtualMachineScaleSetNetworkConfiguration>>]`: The list of network configurations.
    - `Name <String>`: The network configuration name.
    - `[AuxiliaryMode <String>]`: Specifies whether the Auxiliary mode is enabled for the Network Interface         resource.
    - `[AuxiliarySku <String>]`: Specifies whether the Auxiliary sku is enabled for the Network Interface         resource.
    - `[DeleteOption <String>]`: Specify what happens to the network interface when the VM is deleted
    - `[DisableTcpStateTracking <Boolean?>]`: Specifies whether the network interface is disabled for tcp state tracking.
    - `[DnsSettingDnsServers <List<String>>]`: List of DNS servers IP addresses
    - `[EnableAcceleratedNetworking <Boolean?>]`: Specifies whether the network interface is accelerated networking-enabled.
    - `[EnableFpga <Boolean?>]`: Specifies whether the network interface is FPGA networking-enabled.
    - `[EnableIPForwarding <Boolean?>]`: Whether IP forwarding enabled on this NIC.
    - `[IPConfigurations <List<IVirtualMachineScaleSetIPConfiguration>>]`: Specifies the IP configurations of the network interface.
      - `Name <String>`: The IP configuration name.
      - `[ApplicationGatewayBackendAddressPools <List<ISubResource>>]`: Specifies an array of references to backend address pools of application         gateways. A scale set can reference backend address pools of multiple         application gateways. Multiple scale sets cannot use the same application         gateway.
        - `[Id <String>]`: Resource Id
      - `[ApplicationSecurityGroups <List<ISubResource>>]`: Specifies an array of references to application security group.
      - `[DeleteOption <String>]`: Specify what happens to the public IP when the VM is deleted
      - `[DnsSettingDomainNameLabel <String>]`: The Domain name label.The concatenation of the domain name label and vm index         will be the domain name labels of the PublicIPAddress resources that will be         created
      - `[DnsSettingDomainNameLabelScope <String>]`: The Domain name label scope.The concatenation of the hashed domain name label         that generated according to the policy from domain name label scope and vm         index will be the domain name labels of the PublicIPAddress resources that will         be created
      - `[IPTags <List<IVirtualMachineScaleSetIPTag>>]`: The list of IP tags associated with the public IP address.
        - `[IPTagType <String>]`: IP tag type. Example: FirstPartyUsage.
        - `[Tag <String>]`: IP tag associated with the public IP. Example: SQL, Storage etc.
      - `[IdleTimeoutInMinutes <Int32?>]`: The idle timeout of the public IP address.
      - `[LoadBalancerBackendAddressPools <List<ISubResource>>]`: Specifies an array of references to backend address pools of load balancers. A         scale set can reference backend address pools of one public and one internal         load balancer. Multiple scale sets cannot use the same basic sku load balancer.
      - `[LoadBalancerInboundNatPools <List<ISubResource>>]`: Specifies an array of references to inbound Nat pools of the load balancers. A         scale set can reference inbound nat pools of one public and one internal load         balancer. Multiple scale sets cannot use the same basic sku load balancer.
      - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more         than 1 network interface.
      - `[PrivateIPAddressVersion <String>]`: Available from Api-Version 2017-03-30 onwards, it represents whether the         specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible         values are: 'IPv4' and 'IPv6'.
      - `[PublicIPAddressConfigurationName <String>]`: The publicIP address configuration name.
      - `[PublicIPAddressVersion <String>]`: Available from Api-Version 2019-07-01 onwards, it represents whether the         specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible         values are: 'IPv4' and 'IPv6'.
      - `[PublicIPPrefixId <String>]`: Resource Id
      - `[SkuName <String>]`: Specify public IP sku name
      - `[SkuTier <String>]`: Specify public IP sku tier
      - `[SubnetId <String>]`: The ARM resource id in the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
    - `[NetworkSecurityGroupId <String>]`: Resource Id
    - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more         than 1 network interface.
  - `[OSImageNotificationProfileEnable <Boolean?>]`: Specifies whether the OS Image Scheduled event is enabled or disabled.
  - `[OSImageNotificationProfileNotBeforeTimeout <String>]`: Length of time a Virtual Machine being reimaged or having its OS upgraded will         have to potentially approve the OS Image Scheduled Event before the event is         auto approved (timed out). The configuration is specified in ISO 8601 format,         and the value must not exceed 15 minutes (PT15M)
  - `[OSProfile <IVirtualMachineScaleSetOSProfile>]`: Specifies the operating system settings for the virtual machines in the scale         set.
    - `[AdminPassword <SecureString>]`: Specifies the password of the administrator account.    **Minimum-length         (Windows):** 8 characters    **Minimum-length (Linux):** 6 characters            **Max-length (Windows):** 123 characters    **Max-length         (Linux):** 72 characters    **Complexity requirements:** 3 out of 4         conditions below need to be fulfilled   Has lower characters  Has upper         characters   Has a digit   Has a special character (Regex match [\W_])            **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd",         "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1",         "Password22", "iloveyou!"    For resetting the password, see [How to         reset the Remote Desktop service or its login password in a Windows         VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)            For resetting root password, see [Manage users, SSH, and check or         repair disks on Azure Linux VMs using the VMAccess         Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
    - `[AdminUsername <String>]`: Specifies the name of the administrator account.    **Windows-only         restriction:** Cannot end in "."    **Disallowed values:**         "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3",         "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup",         "console", "david", "guest", "john", "owner", "root", "server", "sql",         "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".            **Minimum-length (Linux):** 1  character    **Max-length         (Linux):** 64 characters    **Max-length (Windows):** 20 characters
    - `[AllowExtensionOperations <Boolean?>]`: Specifies whether extension operations should be allowed on the virtual machine         scale set. This may only be set to False when no extensions are present on the         virtual machine scale set.
    - `[ComputerNamePrefix <String>]`: Specifies the computer name prefix for all of the virtual machines in the scale         set. Computer name prefixes must be 1 to 15 characters long.
    - `[CustomData <SecureString>]`: Specifies a base-64 encoded string of custom data. The base-64 encoded string         is decoded to a binary array that is saved as a file on the Virtual Machine.         The maximum length of the binary array is 65535 bytes. For using cloud-init for         your VM, see [Using cloud-init to customize a Linux VM during         creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
    - `[LinuxConfigurationDisablePasswordAuthentication <Boolean?>]`: Specifies whether password authentication should be disabled.
    - `[LinuxConfigurationEnableVMAgentPlatformUpdates <Boolean?>]`: Indicates whether VMAgent Platform Updates is enabled for the Linux virtual         machine. Default value is false.
    - `[LinuxConfigurationPatchSettingsAssessmentMode <String>]`: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual         machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You         control the timing of patch assessments on a virtual machine. <br /><br />         **AutomaticByPlatform** - The platform will trigger periodic patch assessments.         The property provisionVMAgent must be true.
    - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule <Boolean?>]`: Enables customer to schedule patching without accidental upgrades
    - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <String>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation         operations.
    - `[LinuxConfigurationPatchSettingsPatchMode <String>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual         machines associated to virtual machine scale set with OrchestrationMode as         Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The         virtual machine's default patching configuration is used. <br /><br />         **AutomaticByPlatform** - The virtual machine will be automatically updated by         the platform. The property provisionVMAgent must be true
    - `[LinuxConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual         machine. When this property is not specified in the request body, default         behavior is to set it to true. This will ensure that VM Agent is installed on         the VM so that extensions can be added to the VM later.
    - `[PatchSettingEnableHotpatching <Boolean?>]`: Enables customers to patch their Azure VMs without requiring a reboot. For         enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'         must be set to 'AutomaticByPlatform'.
    - `[RequireGuestProvisionSignal <Boolean?>]`: Optional property which must either be set to True or omitted.
    - `[Secrets <List<IVaultSecretGroup>>]`: Specifies set of certificates that should be installed onto the virtual         machines in the scale set. To install certificates on a virtual machine it is         recommended to use the [Azure Key Vault virtual machine extension for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
      - `[SourceVaultId <String>]`: Resource Id
      - `[VaultCertificates <List<IVaultCertificate>>]`: The list of key vault references in SourceVault which contain certificates.
        - `[CertificateStore <String>]`: For Windows VMs, specifies the certificate store on the Virtual Machine to         which the certificate should be added. The specified certificate store is         implicitly in the LocalMachine account. For Linux VMs, the certificate file is         placed under the /var/lib/waagent directory, with the file name         &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and         &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem         formatted.
        - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a         secret. For adding a secret to the Key Vault, see [Add a key or secret to the         key         vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).         In this case, your certificate needs to be It is the Base64 encoding of the         following JSON Object which is encoded in UTF-8:    {          "data":"<Base64-encoded-certificate>",   "dataType":"pfx",          "password":"<pfx-file-password>" }   To install certificates on a virtual         machine it is recommended to use the [Azure Key Vault virtual machine extension         for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    - `[SshPublicKeys <List<ISshPublicKey>>]`: The list of SSH public keys used to authenticate with linux based VMs.
      - `[KeyData <String>]`: SSH public key certificate used to authenticate with the VM through ssh. The         key needs to be at least 2048-bit and in ssh-rsa format. For creating ssh keys,         see [Create SSH keys on Linux and Mac for Linux VMs in         Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
      - `[Path <String>]`: Specifies the full path on the created VM where ssh public key is stored. If         the file already exists, the specified key is appended to the file. Example:         /home/user/.ssh/authorized_keys
    - `[WinRmListeners <List<IWinRmListener>>]`: The list of Windows Remote Management listeners
      - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a         secret. For adding a secret to the Key Vault, see [Add a key or secret to the         key         vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).         In this case, your certificate needs to be the Base64 encoding of the following         JSON Object which is encoded in UTF-8:    {          "data":"<Base64-encoded-certificate>",   "dataType":"pfx",          "password":"<pfx-file-password>" }   To install certificates on a virtual         machine it is recommended to use the [Azure Key Vault virtual machine extension         for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
      - `[Protocol <String>]`: Specifies the protocol of WinRM listener. Possible values are: **http,**         **https.**
    - `[WindowConfigurationAdditionalUnattendContent <List<IAdditionalUnattendContent>>]`: Specifies additional base-64 encoded XML formatted information that can be         included in the Unattend.xml file, which is used by Windows Setup.
      - `[ComponentName <String>]`: The component name. Currently, the only allowable value is         Microsoft-Windows-Shell-Setup.
      - `[Content <SecureString>]`: Specifies the XML formatted content that is added to the unattend.xml file for         the specified path and component. The XML must be less than 4KB and must         include the root element for the setting or feature that is being inserted.
      - `[PassName <String>]`: The pass name. Currently, the only allowable value is OobeSystem.
      - `[SettingName <String>]`: Specifies the name of the setting to which the content applies. Possible values         are: FirstLogonCommands and AutoLogon.
    - `[WindowConfigurationEnableAutomaticUpdates <Boolean?>]`: Indicates whether Automatic Updates is enabled for the Windows virtual machine.         Default value is true. For virtual machine scale sets, this property can be         updated and updates will take effect on OS reprovisioning.
    - `[WindowConfigurationEnableVMAgentPlatformUpdates <Boolean?>]`: Indicates whether VMAgent Platform Updates is enabled for the Windows virtual         machine. Default value is false.
    - `[WindowConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual         machine. When this property is not specified in the request body, it is set to         true by default. This will ensure that VM Agent is installed on the VM so that         extensions can be added to the VM later.
    - `[WindowConfigurationTimeZone <String>]`: Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".         Possible values can be         [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)         value from time zones returned by         [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
    - `[WindowsConfigurationPatchSettingsAssessmentMode <String>]`: Specifies the mode of VM Guest patch assessment for the IaaS virtual         machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You         control the timing of patch assessments on a virtual machine.<br /><br />         **AutomaticByPlatform** - The platform will trigger periodic patch assessments.         The property provisionVMAgent must be true.
    - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule <Boolean?>]`: Enables customer to schedule patching without accidental upgrades
    - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <String>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation         operations.
    - `[WindowsConfigurationPatchSettingsPatchMode <String>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual         machines associated to virtual machine scale set with OrchestrationMode as         Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You         control the application of patches to a virtual machine. You do this by         applying patches manually inside the VM. In this mode, automatic updates are         disabled; the property WindowsConfiguration.enableAutomaticUpdates must be         false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be         updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates         must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will         automatically updated by the platform. The properties provisionVMAgent and         WindowsConfiguration.enableAutomaticUpdates must be true
  - `[ProxyAgentSettingEnabled <Boolean?>]`: Specifies whether ProxyAgent feature should be enabled on the virtual machine         or virtual machine scale set.
  - `[ProxyAgentSettingKeyIncarnationId <Int32?>]`: Increase the value of this property allows user to reset the key used for         securing communication channel between guest and host.
  - `[ProxyAgentSettingMode <String>]`: Specifies the mode that ProxyAgent will execute on if the feature is enabled.         ProxyAgent will start to audit or monitor but not enforce access control over         requests to host endpoints in Audit mode, while in Enforce mode it will enforce         access control. The default value is Enforce mode.
  - `[SecurityPostureReferenceExcludeExtensions <List<String>>]`: List of virtual machine extension names to exclude when applying the security         posture.
  - `[SecurityPostureReferenceId <String>]`: The security posture reference id in the form of         /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest
  - `[SecurityPostureReferenceIsOverridable <Boolean?>]`: Whether the security posture can be overridden by the user.
  - `[SecurityProfileEncryptionAtHost <Boolean?>]`: This property can be used by user in the request to enable or disable the Host         Encryption for the virtual machine or virtual machine scale set. This will         enable the encryption for all the disks including Resource/Temp disk at host         itself. The default behavior is: The Encryption at host will be disabled unless         this property is set to true for the resource.
  - `[SecurityProfileSecurityType <String>]`: Specifies the SecurityType of the virtual machine. It has to be set to any         specified value to enable UefiSettings. The default behavior is: UefiSettings         will not be enabled unless this property is set.
  - `[ServiceArtifactReferenceId <String>]`: The service artifact reference id in the form of         /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}
  - `[StorageProfile <IVirtualMachineScaleSetStorageProfile>]`: Specifies the storage settings for the virtual machine disks.
    - `[DataDisks <List<IVirtualMachineScaleSetDataDisk>>]`: Specifies the parameters that are used to add data disks to the virtual         machines in the scale set. For more information about disks, see [About disks         and VHDs for Azure virtual         machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
      - `CreateOption <String>`: The create option.
      - `Lun <Int32>`: Specifies the logical unit number of the data disk. This value is used to         identify data disks within the VM and therefore must be unique for each data         disk attached to a VM.
      - `[Caching <String>]`: Specifies the caching requirements. Possible values are: **None,**         **ReadOnly,** **ReadWrite.** The default values are: **None for Standard         storage. ReadOnly for Premium storage.**
      - `[DeleteOption <String>]`: Specifies whether data disk should be deleted or detached upon VMSS Flex         deletion (This feature is available for VMSS with Flexible OrchestrationMode         only).   Possible values:    **Delete** If this value is used, the         data disk is deleted when the VMSS Flex VM is deleted.   **Detach** If         this value is used, the data disk is retained after VMSS Flex VM is         deleted.   The default value is set to **Delete**.
      - `[DiskIopsReadWrite <Int64?>]`: Specifies the Read-Write IOPS for the managed disk. Should be used only when         StorageAccountType is UltraSSD_LRS. If not specified, a default value would be         assigned based on diskSizeGB.
      - `[DiskMBpsReadWrite <Int64?>]`: Specifies the bandwidth in MB per second for the managed disk. Should be used         only when StorageAccountType is UltraSSD_LRS. If not specified, a default value         would be assigned based on diskSizeGB.
      - `[DiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used         to overwrite the size of the disk in a virtual machine image. The property         diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be         larger than 1023.
      - `[Id <String>]`: Resource Id
      - `[ManagedDiskStorageAccountType <String>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can         only be used with data disks, it cannot be used with OS Disk.
      - `[Name <String>]`: The disk name.
      - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
      - `[SecurityProfileSecurityEncryptionType <String>]`: Specifies the EncryptionType of the managed disk. It is set to         DiskWithVMGuestState for encryption of the managed disk along with VMGuestState         blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and         NonPersistedTPM for not persisting firmware state in the VMGuestState blob..         **Note:** It can be set for only Confidential VMs.
      - `[WriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.
    - `[DiffDiskSettingOption <String>]`: Specifies the ephemeral disk settings for operating system disk.
    - `[DiffDiskSettingPlacement <String>]`: Specifies the ephemeral disk placement for operating system disk. Possible         values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:         **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**         is used. Refer to the VM size documentation for Windows VM at         https://docs.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at         https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM         sizes exposes a cache disk.
    - `[DiskControllerType <String>]`: Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01
    - `[Id <String>]`: Resource Id
    - `[ImageReferenceCommunityGalleryImageId <String>]`: Specified the community gallery image unique id for vm deployment. This can be         fetched from community gallery image GET call.
    - `[ImageReferenceId <String>]`: Resource Id
    - `[ImageReferenceOffer <String>]`: Specifies the offer of the platform image or marketplace image used to create         the virtual machine.
    - `[ImageReferencePublisher <String>]`: The image publisher.
    - `[ImageReferenceSharedGalleryImageId <String>]`: Specified the shared gallery image unique id for vm deployment. This can be         fetched from shared gallery image GET call.
    - `[ImageReferenceSku <String>]`: The image SKU.
    - `[ImageReferenceVersion <String>]`: Specifies the version of the platform image or marketplace image used to create         the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.         Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest         version of an image available at deploy time. Even if you use 'latest', the VM         image will not automatically update after deploy time even if a new version         becomes available. Please do not use field 'version' for gallery image         deployment, gallery image should always use 'id' field for deployment, to use 'latest'         version of gallery image, just set         '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'         in the 'id' field without version input.
    - `[ImageUri <String>]`: Specifies the virtual hard disk's uri.
    - `[ManagedDiskStorageAccountType <String>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can         only be used with data disks, it cannot be used with OS Disk.
    - `[OSDiskCaching <String>]`: Specifies the caching requirements. Possible values are: **None,**         **ReadOnly,** **ReadWrite.** The default values are: **None for Standard         storage. ReadOnly for Premium storage.**
    - `[OSDiskCreateOption <String>]`: Specifies how the virtual machines in the scale set should be created. The only         allowed value is: **FromImage.** This value is used when you are using an image         to create the virtual machine. If you are using a platform image, you also use         the imageReference element described above. If you are using a marketplace         image, you  also use the plan element previously described.
    - `[OSDiskDeleteOption <String>]`: Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion         (This feature is available for VMSS with Flexible OrchestrationMode only).            Possible values:    **Delete** If this value is used, the OS         disk is deleted when VMSS Flex VM is deleted.   **Detach** If this value         is used, the OS disk is retained after VMSS Flex VM is deleted.    The         default value is set to **Delete**. For an Ephemeral OS Disk, the default value         is set to **Delete**. User cannot change the delete option for Ephemeral OS         Disk.
    - `[OSDiskName <String>]`: The disk name.
    - `[OSDiskOstype <String>]`: This property allows you to specify the type of the OS that is included in the         disk if creating a VM from user-image or a specialized VHD. Possible values         are: **Windows,** **Linux.**
    - `[OSDiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used         to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'         is the number of bytes x 1024^3 for the disk and the value cannot         be larger than 1023.
    - `[OSDiskVhdContainers <List<String>>]`: Specifies the container urls that are used to store operating system disks for         the scale set.
    - `[OSDiskWriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.
    - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
    - `[SecurityProfileSecurityEncryptionType <String>]`: Specifies the EncryptionType of the managed disk. It is set to         DiskWithVMGuestState for encryption of the managed disk along with VMGuestState         blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and         NonPersistedTPM for not persisting firmware state in the VMGuestState blob..         **Note:** It can be set for only Confidential VMs.
  - `[TerminateNotificationProfileEnable <Boolean?>]`: Specifies whether the Terminate Scheduled event is enabled or disabled.
  - `[TerminateNotificationProfileNotBeforeTimeout <String>]`: Configurable length of time a Virtual Machine being deleted will have to         potentially approve the Terminate Scheduled Event before the event is auto         approved (timed out). The configuration must be specified in ISO 8601 format,         the default value is 5 minutes (PT5M)
  - `[UefiSettingSecureBootEnabled <Boolean?>]`: Specifies whether secure boot should be enabled on the virtual machine. Minimum         api-version: 2020-12-01.
  - `[UefiSettingVTpmEnabled <Boolean?>]`: Specifies whether vTPM should be enabled on the virtual machine. Minimum         api-version: 2020-12-01.
  - `[UserData <String>]`: UserData for the virtual machines in the scale set, which must be base-64         encoded. Customer should not pass any secrets in here. Minimum api-version:         2021-03-01.
  - `[VMSizePropertyVcpUsAvailable <Int32?>]`: Specifies the number of vCPUs available for the VM. When this property is not         specified in the request body the default behavior is to set it to the value of         vCPUs available for that VM size exposed in api response of [List all available         virtual machine sizes in a         region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list).
  - `[VMSizePropertyVcpUsPerCore <Int32?>]`: Specifies the vCPU to physical core ratio. When this property is not specified         in the request body the default behavior is set to the value of vCPUsPerCore         for the VM Size exposed in api response of [List all available virtual machine         sizes in a         region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list).         **Setting this property to 1 also means that hyper-threading is disabled.**

`INPUTOBJECT <IFleetIdentity>`: Identity Parameter
  - `[FleetName <String>]`: The name of the Compute ComputeFleet
  - `[Name <String>]`: The name of the ComputeFleet
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[SubscriptionId <String>]`: The ID of the target subscription. The value must be an UUID.

`PROPERTIES <IFleetUpdate>`: ComputeFleet Update Model
  - `[AdditionalLocationProfileLocationProfiles <List<ILocationProfile>>]`: The list of location profiles.
    - `Location <String>`: The ARM location name of the additional region. If LocationProfile is specified, then location is required.
    - `[VirtualMachineProfileOverride <IBaseVirtualMachineProfile>]`: An override for computeProfile.baseVirtualMachineProfile specific to this region.         This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources deployed in this location.
      - `[ApplicationProfileGalleryApplications <List<IVMGalleryApplication>>]`: Specifies the gallery applications that should be made available to the VM/VMSS
        - `PackageReferenceId <String>`: Specifies the GalleryApplicationVersion resource id on the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
        - `[ConfigurationReference <String>]`: Optional, Specifies the uri to an azure blob that will replace the default         configuration for the package if provided
        - `[EnableAutomaticUpgrade <Boolean?>]`: If set to true, when a new Gallery Application version is available in PIR/SIG,         it will be automatically updated for the VM/VMSS
        - `[Order <Int32?>]`: Optional, Specifies the order in which the packages have to be installed
        - `[Tags <String>]`: Optional, Specifies a passthrough value for more generic context.
        - `[TreatFailureAsDeploymentFailure <Boolean?>]`: Optional, If true, any failure for any operation in the VmApplication will fail         the deployment
      - `[BootDiagnosticEnabled <Boolean?>]`: Whether boot diagnostics should be enabled on the Virtual Machine.
      - `[BootDiagnosticStorageUri <String>]`: Uri of the storage account to use for placing the console output and         screenshot. If storageUri is not specified while enabling boot diagnostics,         managed storage will be used.
      - `[CapacityReservationGroupId <String>]`: Resource Id
      - `[EncryptionIdentityUserAssignedIdentityResourceId <String>]`: Specifies ARM Resource ID of one of the user identities associated with the VM.
      - `[ExtensionProfileExtensions <List<IVirtualMachineScaleSetExtension>>]`: The virtual machine scale set child extension resources.
        - `[AutoUpgradeMinorVersion <Boolean?>]`: Indicates whether the extension should use a newer minor version if one is         available at deployment time. Once deployed, however, the extension will not         upgrade minor versions unless redeployed, even with this property set to true.
        - `[EnableAutomaticUpgrade <Boolean?>]`: Indicates whether the extension should be automatically upgraded by the         platform if there is a newer version of the extension available.
        - `[ForceUpdateTag <String>]`: If a value is provided and is different from the previous value, the extension         handler will be forced to update even if the extension configuration has not         changed.
        - `[Name <String>]`: The name of the extension.
        - `[PropertiesType <String>]`: Specifies the type of the extension; an example is "CustomScriptExtension".
        - `[ProtectedSettingFromKeyVaultSecretUrl <String>]`: The URL referencing a secret in a Key Vault.
        - `[ProtectedSettings <IVirtualMachineScaleSetExtensionPropertiesProtectedSettings>]`: The extension can contain either protectedSettings or         protectedSettingsFromKeyVault or no protected settings at all.
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ProvisionAfterExtensions <List<String>>]`: Collection of extension names after which this extension needs to be         provisioned.
        - `[Publisher <String>]`: The name of the extension handler publisher.
        - `[Settings <IVirtualMachineScaleSetExtensionPropertiesSettings>]`: Json formatted public settings for the extension.
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[SourceVaultId <String>]`: Resource Id
        - `[SuppressFailures <Boolean?>]`: Indicates whether failures stemming from the extension will be suppressed         (Operational failures such as not connecting to the VM will not be suppressed         regardless of this value). The default is false.
        - `[TypeHandlerVersion <String>]`: Specifies the version of the script handler.
      - `[ExtensionProfileExtensionsTimeBudget <String>]`: Specifies the time alloted for all extensions to start. The time duration         should be between 15 minutes and 120 minutes (inclusive) and should be         specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).         Minimum api-version: 2020-06-01.
      - `[HealthProbeId <String>]`: The ARM resource id in the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
      - `[LicenseType <String>]`: Specifies that the image or disk that is being used was licensed on-premises.            Possible values for Windows Server operating system are:            Windows_Client    Windows_Server    Possible values for Linux         Server operating system are:    RHEL_BYOS (for RHEL)    SLES_BYOS         (for SUSE)    For more information, see [Azure Hybrid Use Benefit for         Windows         Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)            [Azure Hybrid Use Benefit for Linux         Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)            Minimum api-version: 2015-06-15
      - `[NetworkProfileNetworkApiVersion <String>]`: specifies the Microsoft.Network API version used when creating networking         resources in the Network Interface Configurations for Virtual Machine Scale Set         with orchestration mode 'Flexible'
      - `[NetworkProfileNetworkInterfaceConfigurations <List<IVirtualMachineScaleSetNetworkConfiguration>>]`: The list of network configurations.
        - `Name <String>`: The network configuration name.
        - `[AuxiliaryMode <String>]`: Specifies whether the Auxiliary mode is enabled for the Network Interface         resource.
        - `[AuxiliarySku <String>]`: Specifies whether the Auxiliary sku is enabled for the Network Interface         resource.
        - `[DeleteOption <String>]`: Specify what happens to the network interface when the VM is deleted
        - `[DisableTcpStateTracking <Boolean?>]`: Specifies whether the network interface is disabled for tcp state tracking.
        - `[DnsSettingDnsServers <List<String>>]`: List of DNS servers IP addresses
        - `[EnableAcceleratedNetworking <Boolean?>]`: Specifies whether the network interface is accelerated networking-enabled.
        - `[EnableFpga <Boolean?>]`: Specifies whether the network interface is FPGA networking-enabled.
        - `[EnableIPForwarding <Boolean?>]`: Whether IP forwarding enabled on this NIC.
        - `[IPConfigurations <List<IVirtualMachineScaleSetIPConfiguration>>]`: Specifies the IP configurations of the network interface.
          - `Name <String>`: The IP configuration name.
          - `[ApplicationGatewayBackendAddressPools <List<ISubResource>>]`: Specifies an array of references to backend address pools of application         gateways. A scale set can reference backend address pools of multiple         application gateways. Multiple scale sets cannot use the same application         gateway.
            - `[Id <String>]`: Resource Id
          - `[ApplicationSecurityGroups <List<ISubResource>>]`: Specifies an array of references to application security group.
          - `[DeleteOption <String>]`: Specify what happens to the public IP when the VM is deleted
          - `[DnsSettingDomainNameLabel <String>]`: The Domain name label.The concatenation of the domain name label and vm index         will be the domain name labels of the PublicIPAddress resources that will be         created
          - `[DnsSettingDomainNameLabelScope <String>]`: The Domain name label scope.The concatenation of the hashed domain name label         that generated according to the policy from domain name label scope and vm         index will be the domain name labels of the PublicIPAddress resources that will         be created
          - `[IPTags <List<IVirtualMachineScaleSetIPTag>>]`: The list of IP tags associated with the public IP address.
            - `[IPTagType <String>]`: IP tag type. Example: FirstPartyUsage.
            - `[Tag <String>]`: IP tag associated with the public IP. Example: SQL, Storage etc.
          - `[IdleTimeoutInMinutes <Int32?>]`: The idle timeout of the public IP address.
          - `[LoadBalancerBackendAddressPools <List<ISubResource>>]`: Specifies an array of references to backend address pools of load balancers. A         scale set can reference backend address pools of one public and one internal         load balancer. Multiple scale sets cannot use the same basic sku load balancer.
          - `[LoadBalancerInboundNatPools <List<ISubResource>>]`: Specifies an array of references to inbound Nat pools of the load balancers. A         scale set can reference inbound nat pools of one public and one internal load         balancer. Multiple scale sets cannot use the same basic sku load balancer.
          - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more         than 1 network interface.
          - `[PrivateIPAddressVersion <String>]`: Available from Api-Version 2017-03-30 onwards, it represents whether the         specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible         values are: 'IPv4' and 'IPv6'.
          - `[PublicIPAddressConfigurationName <String>]`: The publicIP address configuration name.
          - `[PublicIPAddressVersion <String>]`: Available from Api-Version 2019-07-01 onwards, it represents whether the         specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible         values are: 'IPv4' and 'IPv6'.
          - `[PublicIPPrefixId <String>]`: Resource Id
          - `[SkuName <String>]`: Specify public IP sku name
          - `[SkuTier <String>]`: Specify public IP sku tier
          - `[SubnetId <String>]`: The ARM resource id in the form of         /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        - `[NetworkSecurityGroupId <String>]`: Resource Id
        - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more         than 1 network interface.
      - `[OSImageNotificationProfileEnable <Boolean?>]`: Specifies whether the OS Image Scheduled event is enabled or disabled.
      - `[OSImageNotificationProfileNotBeforeTimeout <String>]`: Length of time a Virtual Machine being reimaged or having its OS upgraded will         have to potentially approve the OS Image Scheduled Event before the event is         auto approved (timed out). The configuration is specified in ISO 8601 format,         and the value must not exceed 15 minutes (PT15M)
      - `[OSProfile <IVirtualMachineScaleSetOSProfile>]`: Specifies the operating system settings for the virtual machines in the scale         set.
        - `[AdminPassword <SecureString>]`: Specifies the password of the administrator account.    **Minimum-length         (Windows):** 8 characters    **Minimum-length (Linux):** 6 characters            **Max-length (Windows):** 123 characters    **Max-length         (Linux):** 72 characters    **Complexity requirements:** 3 out of 4         conditions below need to be fulfilled   Has lower characters  Has upper         characters   Has a digit   Has a special character (Regex match [\W_])            **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd",         "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1",         "Password22", "iloveyou!"    For resetting the password, see [How to         reset the Remote Desktop service or its login password in a Windows         VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)            For resetting root password, see [Manage users, SSH, and check or         repair disks on Azure Linux VMs using the VMAccess         Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        - `[AdminUsername <String>]`: Specifies the name of the administrator account.    **Windows-only         restriction:** Cannot end in "."    **Disallowed values:**         "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3",         "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup",         "console", "david", "guest", "john", "owner", "root", "server", "sql",         "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".            **Minimum-length (Linux):** 1  character    **Max-length         (Linux):** 64 characters    **Max-length (Windows):** 20 characters
        - `[AllowExtensionOperations <Boolean?>]`: Specifies whether extension operations should be allowed on the virtual machine         scale set. This may only be set to False when no extensions are present on the         virtual machine scale set.
        - `[ComputerNamePrefix <String>]`: Specifies the computer name prefix for all of the virtual machines in the scale         set. Computer name prefixes must be 1 to 15 characters long.
        - `[CustomData <SecureString>]`: Specifies a base-64 encoded string of custom data. The base-64 encoded string         is decoded to a binary array that is saved as a file on the Virtual Machine.         The maximum length of the binary array is 65535 bytes. For using cloud-init for         your VM, see [Using cloud-init to customize a Linux VM during         creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
        - `[LinuxConfigurationDisablePasswordAuthentication <Boolean?>]`: Specifies whether password authentication should be disabled.
        - `[LinuxConfigurationEnableVMAgentPlatformUpdates <Boolean?>]`: Indicates whether VMAgent Platform Updates is enabled for the Linux virtual         machine. Default value is false.
        - `[LinuxConfigurationPatchSettingsAssessmentMode <String>]`: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual         machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You         control the timing of patch assessments on a virtual machine. <br /><br />         **AutomaticByPlatform** - The platform will trigger periodic patch assessments.         The property provisionVMAgent must be true.
        - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule <Boolean?>]`: Enables customer to schedule patching without accidental upgrades
        - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <String>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation         operations.
        - `[LinuxConfigurationPatchSettingsPatchMode <String>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual         machines associated to virtual machine scale set with OrchestrationMode as         Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The         virtual machine's default patching configuration is used. <br /><br />         **AutomaticByPlatform** - The virtual machine will be automatically updated by         the platform. The property provisionVMAgent must be true
        - `[LinuxConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual         machine. When this property is not specified in the request body, default         behavior is to set it to true. This will ensure that VM Agent is installed on         the VM so that extensions can be added to the VM later.
        - `[PatchSettingEnableHotpatching <Boolean?>]`: Enables customers to patch their Azure VMs without requiring a reboot. For         enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'         must be set to 'AutomaticByPlatform'.
        - `[RequireGuestProvisionSignal <Boolean?>]`: Optional property which must either be set to True or omitted.
        - `[Secrets <List<IVaultSecretGroup>>]`: Specifies set of certificates that should be installed onto the virtual         machines in the scale set. To install certificates on a virtual machine it is         recommended to use the [Azure Key Vault virtual machine extension for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
          - `[SourceVaultId <String>]`: Resource Id
          - `[VaultCertificates <List<IVaultCertificate>>]`: The list of key vault references in SourceVault which contain certificates.
            - `[CertificateStore <String>]`: For Windows VMs, specifies the certificate store on the Virtual Machine to         which the certificate should be added. The specified certificate store is         implicitly in the LocalMachine account. For Linux VMs, the certificate file is         placed under the /var/lib/waagent directory, with the file name         &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and         &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem         formatted.
            - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a         secret. For adding a secret to the Key Vault, see [Add a key or secret to the         key         vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).         In this case, your certificate needs to be It is the Base64 encoding of the         following JSON Object which is encoded in UTF-8:    {          "data":"<Base64-encoded-certificate>",   "dataType":"pfx",          "password":"<pfx-file-password>" }   To install certificates on a virtual         machine it is recommended to use the [Azure Key Vault virtual machine extension         for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        - `[SshPublicKeys <List<ISshPublicKey>>]`: The list of SSH public keys used to authenticate with linux based VMs.
          - `[KeyData <String>]`: SSH public key certificate used to authenticate with the VM through ssh. The         key needs to be at least 2048-bit and in ssh-rsa format. For creating ssh keys,         see [Create SSH keys on Linux and Mac for Linux VMs in         Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
          - `[Path <String>]`: Specifies the full path on the created VM where ssh public key is stored. If         the file already exists, the specified key is appended to the file. Example:         /home/user/.ssh/authorized_keys
        - `[WinRmListeners <List<IWinRmListener>>]`: The list of Windows Remote Management listeners
          - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a         secret. For adding a secret to the Key Vault, see [Add a key or secret to the         key         vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).         In this case, your certificate needs to be the Base64 encoding of the following         JSON Object which is encoded in UTF-8:    {          "data":"<Base64-encoded-certificate>",   "dataType":"pfx",          "password":"<pfx-file-password>" }   To install certificates on a virtual         machine it is recommended to use the [Azure Key Vault virtual machine extension         for         Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)         or the [Azure Key Vault virtual machine extension for         Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
          - `[Protocol <String>]`: Specifies the protocol of WinRM listener. Possible values are: **http,**         **https.**
        - `[WindowConfigurationAdditionalUnattendContent <List<IAdditionalUnattendContent>>]`: Specifies additional base-64 encoded XML formatted information that can be         included in the Unattend.xml file, which is used by Windows Setup.
          - `[ComponentName <String>]`: The component name. Currently, the only allowable value is         Microsoft-Windows-Shell-Setup.
          - `[Content <SecureString>]`: Specifies the XML formatted content that is added to the unattend.xml file for         the specified path and component. The XML must be less than 4KB and must         include the root element for the setting or feature that is being inserted.
          - `[PassName <String>]`: The pass name. Currently, the only allowable value is OobeSystem.
          - `[SettingName <String>]`: Specifies the name of the setting to which the content applies. Possible values         are: FirstLogonCommands and AutoLogon.
        - `[WindowConfigurationEnableAutomaticUpdates <Boolean?>]`: Indicates whether Automatic Updates is enabled for the Windows virtual machine.         Default value is true. For virtual machine scale sets, this property can be         updated and updates will take effect on OS reprovisioning.
        - `[WindowConfigurationEnableVMAgentPlatformUpdates <Boolean?>]`: Indicates whether VMAgent Platform Updates is enabled for the Windows virtual         machine. Default value is false.
        - `[WindowConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual         machine. When this property is not specified in the request body, it is set to         true by default. This will ensure that VM Agent is installed on the VM so that         extensions can be added to the VM later.
        - `[WindowConfigurationTimeZone <String>]`: Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".         Possible values can be         [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)         value from time zones returned by         [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        - `[WindowsConfigurationPatchSettingsAssessmentMode <String>]`: Specifies the mode of VM Guest patch assessment for the IaaS virtual         machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You         control the timing of patch assessments on a virtual machine.<br /><br />         **AutomaticByPlatform** - The platform will trigger periodic patch assessments.         The property provisionVMAgent must be true.
        - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule <Boolean?>]`: Enables customer to schedule patching without accidental upgrades
        - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <String>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation         operations.
        - `[WindowsConfigurationPatchSettingsPatchMode <String>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual         machines associated to virtual machine scale set with OrchestrationMode as         Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You         control the application of patches to a virtual machine. You do this by         applying patches manually inside the VM. In this mode, automatic updates are         disabled; the property WindowsConfiguration.enableAutomaticUpdates must be         false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be         updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates         must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will         automatically updated by the platform. The properties provisionVMAgent and         WindowsConfiguration.enableAutomaticUpdates must be true
      - `[ProxyAgentSettingEnabled <Boolean?>]`: Specifies whether ProxyAgent feature should be enabled on the virtual machine         or virtual machine scale set.
      - `[ProxyAgentSettingKeyIncarnationId <Int32?>]`: Increase the value of this property allows user to reset the key used for         securing communication channel between guest and host.
      - `[ProxyAgentSettingMode <String>]`: Specifies the mode that ProxyAgent will execute on if the feature is enabled.         ProxyAgent will start to audit or monitor but not enforce access control over         requests to host endpoints in Audit mode, while in Enforce mode it will enforce         access control. The default value is Enforce mode.
      - `[SecurityPostureReferenceExcludeExtensions <List<String>>]`: List of virtual machine extension names to exclude when applying the security         posture.
      - `[SecurityPostureReferenceId <String>]`: The security posture reference id in the form of         /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest
      - `[SecurityPostureReferenceIsOverridable <Boolean?>]`: Whether the security posture can be overridden by the user.
      - `[SecurityProfileEncryptionAtHost <Boolean?>]`: This property can be used by user in the request to enable or disable the Host         Encryption for the virtual machine or virtual machine scale set. This will         enable the encryption for all the disks including Resource/Temp disk at host         itself. The default behavior is: The Encryption at host will be disabled unless         this property is set to true for the resource.
      - `[SecurityProfileSecurityType <String>]`: Specifies the SecurityType of the virtual machine. It has to be set to any         specified value to enable UefiSettings. The default behavior is: UefiSettings         will not be enabled unless this property is set.
      - `[ServiceArtifactReferenceId <String>]`: The service artifact reference id in the form of         /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}
      - `[StorageProfile <IVirtualMachineScaleSetStorageProfile>]`: Specifies the storage settings for the virtual machine disks.
        - `[DataDisks <List<IVirtualMachineScaleSetDataDisk>>]`: Specifies the parameters that are used to add data disks to the virtual         machines in the scale set. For more information about disks, see [About disks         and VHDs for Azure virtual         machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
          - `CreateOption <String>`: The create option.
          - `Lun <Int32>`: Specifies the logical unit number of the data disk. This value is used to         identify data disks within the VM and therefore must be unique for each data         disk attached to a VM.
          - `[Caching <String>]`: Specifies the caching requirements. Possible values are: **None,**         **ReadOnly,** **ReadWrite.** The default values are: **None for Standard         storage. ReadOnly for Premium storage.**
          - `[DeleteOption <String>]`: Specifies whether data disk should be deleted or detached upon VMSS Flex         deletion (This feature is available for VMSS with Flexible OrchestrationMode         only).   Possible values:    **Delete** If this value is used, the         data disk is deleted when the VMSS Flex VM is deleted.   **Detach** If         this value is used, the data disk is retained after VMSS Flex VM is         deleted.   The default value is set to **Delete**.
          - `[DiskIopsReadWrite <Int64?>]`: Specifies the Read-Write IOPS for the managed disk. Should be used only when         StorageAccountType is UltraSSD_LRS. If not specified, a default value would be         assigned based on diskSizeGB.
          - `[DiskMBpsReadWrite <Int64?>]`: Specifies the bandwidth in MB per second for the managed disk. Should be used         only when StorageAccountType is UltraSSD_LRS. If not specified, a default value         would be assigned based on diskSizeGB.
          - `[DiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used         to overwrite the size of the disk in a virtual machine image. The property         diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be         larger than 1023.
          - `[Id <String>]`: Resource Id
          - `[ManagedDiskStorageAccountType <String>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can         only be used with data disks, it cannot be used with OS Disk.
          - `[Name <String>]`: The disk name.
          - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
          - `[SecurityProfileSecurityEncryptionType <String>]`: Specifies the EncryptionType of the managed disk. It is set to         DiskWithVMGuestState for encryption of the managed disk along with VMGuestState         blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and         NonPersistedTPM for not persisting firmware state in the VMGuestState blob..         **Note:** It can be set for only Confidential VMs.
          - `[WriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.
        - `[DiffDiskSettingOption <String>]`: Specifies the ephemeral disk settings for operating system disk.
        - `[DiffDiskSettingPlacement <String>]`: Specifies the ephemeral disk placement for operating system disk. Possible         values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:         **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**         is used. Refer to the VM size documentation for Windows VM at         https://docs.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at         https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM         sizes exposes a cache disk.
        - `[DiskControllerType <String>]`: Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01
        - `[Id <String>]`: Resource Id
        - `[ImageReferenceCommunityGalleryImageId <String>]`: Specified the community gallery image unique id for vm deployment. This can be         fetched from community gallery image GET call.
        - `[ImageReferenceId <String>]`: Resource Id
        - `[ImageReferenceOffer <String>]`: Specifies the offer of the platform image or marketplace image used to create         the virtual machine.
        - `[ImageReferencePublisher <String>]`: The image publisher.
        - `[ImageReferenceSharedGalleryImageId <String>]`: Specified the shared gallery image unique id for vm deployment. This can be         fetched from shared gallery image GET call.
        - `[ImageReferenceSku <String>]`: The image SKU.
        - `[ImageReferenceVersion <String>]`: Specifies the version of the platform image or marketplace image used to create         the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.         Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest         version of an image available at deploy time. Even if you use 'latest', the VM         image will not automatically update after deploy time even if a new version         becomes available. Please do not use field 'version' for gallery image         deployment, gallery image should always use 'id' field for deployment, to use 'latest'         version of gallery image, just set         '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'         in the 'id' field without version input.
        - `[ImageUri <String>]`: Specifies the virtual hard disk's uri.
        - `[ManagedDiskStorageAccountType <String>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can         only be used with data disks, it cannot be used with OS Disk.
        - `[OSDiskCaching <String>]`: Specifies the caching requirements. Possible values are: **None,**         **ReadOnly,** **ReadWrite.** The default values are: **None for Standard         storage. ReadOnly for Premium storage.**
        - `[OSDiskCreateOption <String>]`: Specifies how the virtual machines in the scale set should be created. The only         allowed value is: **FromImage.** This value is used when you are using an image         to create the virtual machine. If you are using a platform image, you also use         the imageReference element described above. If you are using a marketplace         image, you  also use the plan element previously described.
        - `[OSDiskDeleteOption <String>]`: Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion         (This feature is available for VMSS with Flexible OrchestrationMode only).            Possible values:    **Delete** If this value is used, the OS         disk is deleted when VMSS Flex VM is deleted.   **Detach** If this value         is used, the OS disk is retained after VMSS Flex VM is deleted.    The         default value is set to **Delete**. For an Ephemeral OS Disk, the default value         is set to **Delete**. User cannot change the delete option for Ephemeral OS         Disk.
        - `[OSDiskName <String>]`: The disk name.
        - `[OSDiskOstype <String>]`: This property allows you to specify the type of the OS that is included in the         disk if creating a VM from user-image or a specialized VHD. Possible values         are: **Windows,** **Linux.**
        - `[OSDiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used         to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'         is the number of bytes x 1024^3 for the disk and the value cannot         be larger than 1023.
        - `[OSDiskVhdContainers <List<String>>]`: Specifies the container urls that are used to store operating system disks for         the scale set.
        - `[OSDiskWriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.
        - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
        - `[SecurityProfileSecurityEncryptionType <String>]`: Specifies the EncryptionType of the managed disk. It is set to         DiskWithVMGuestState for encryption of the managed disk along with VMGuestState         blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and         NonPersistedTPM for not persisting firmware state in the VMGuestState blob..         **Note:** It can be set for only Confidential VMs.
      - `[TerminateNotificationProfileEnable <Boolean?>]`: Specifies whether the Terminate Scheduled event is enabled or disabled.
      - `[TerminateNotificationProfileNotBeforeTimeout <String>]`: Configurable length of time a Virtual Machine being deleted will have to         potentially approve the Terminate Scheduled Event before the event is auto         approved (timed out). The configuration must be specified in ISO 8601 format,         the default value is 5 minutes (PT5M)
      - `[UefiSettingSecureBootEnabled <Boolean?>]`: Specifies whether secure boot should be enabled on the virtual machine. Minimum         api-version: 2020-12-01.
      - `[UefiSettingVTpmEnabled <Boolean?>]`: Specifies whether vTPM should be enabled on the virtual machine. Minimum         api-version: 2020-12-01.
      - `[UserData <String>]`: UserData for the virtual machines in the scale set, which must be base-64         encoded. Customer should not pass any secrets in here. Minimum api-version:         2021-03-01.
      - `[VMSizePropertyVcpUsAvailable <Int32?>]`: Specifies the number of vCPUs available for the VM. When this property is not         specified in the request body the default behavior is to set it to the value of         vCPUs available for that VM size exposed in api response of [List all available         virtual machine sizes in a         region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list).
      - `[VMSizePropertyVcpUsPerCore <Int32?>]`: Specifies the vCPU to physical core ratio. When this property is not specified         in the request body the default behavior is set to the value of vCPUsPerCore         for the VM Size exposed in api response of [List all available virtual machine         sizes in a         region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list).         **Setting this property to 1 also means that hyper-threading is disabled.**
  - `[AdditionalVirtualMachineCapabilityHibernationEnabled <Boolean?>]`: The flag that enables or disables hibernation capability on the VM.
  - `[AdditionalVirtualMachineCapabilityUltraSsdEnabled <Boolean?>]`: The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS.         Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled.
  - `[ComputeProfileBaseVirtualMachineProfile <IBaseVirtualMachineProfile>]`: Base Virtual Machine Profile Properties to be specified according to "specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile"
  - `[ComputeProfileComputeApiVersion <String>]`: Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.         The default value will be the latest supported computeApiVersion by Compute ComputeFleet.
  - `[ComputeProfilePlatformFaultDomainCount <Int32?>]`: Specifies the number of fault domains to use when creating the underlying VMSS.         A fault domain is a logical group of hardware within an Azure datacenter.         VMs in the same fault domain share a common power source and network switch.         If not specified, defaults to 1, which represents "Max Spreading" (using as many fault domains as possible).         This property cannot be updated.
  - `[IdentityType <String>]`: The type of managed identity assigned to this resource.
  - `[IdentityUserAssignedIdentities <IManagedServiceIdentityUpdateUserAssignedIdentities>]`: The identities assigned to this resource by the user.
    - `[(Any) <IComponentsQjfoe3SchemasManagedserviceidentityupdatePropertiesUserassignedidentitiesAdditionalproperties>]`: This indicates any property can be added to this object.
  - `[PlanName <String>]`: A user defined name of the 3rd Party Artifact that is being procured.
  - `[PlanProduct <String>]`: The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at the time of Data Market onboarding.
  - `[PlanPromotionCode <String>]`: A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
  - `[PlanPublisher <String>]`: The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic
  - `[PlanVersion <String>]`: The version of the desired product/artifact.
  - `[RegularPriorityProfileAllocationStrategy <String>]`: Allocation strategy to follow when determining the VM sizes distribution for Regular VMs.
  - `[RegularPriorityProfileCapacity <Int32?>]`: Total capacity to achieve. It is currently in terms of number of VMs.
  - `[RegularPriorityProfileMinCapacity <Int32?>]`: Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself.
  - `[SpotPriorityProfileAllocationStrategy <String>]`: Allocation strategy to follow when determining the VM sizes distribution for Spot VMs.
  - `[SpotPriorityProfileCapacity <Int32?>]`: Total capacity to achieve. It is currently in terms of number of VMs.
  - `[SpotPriorityProfileEvictionPolicy <String>]`: Eviction Policy to follow when evicting Spot VMs.
  - `[SpotPriorityProfileMaintain <Boolean?>]`: Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.         If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)         or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint) in order to achieve the desired capacity.         Maintain is enabled by default.
  - `[SpotPriorityProfileMaxPricePerVM <Single?>]`: Price per hour of each Spot VM will never exceed this.
  - `[SpotPriorityProfileMinCapacity <Int32?>]`: Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself.
  - `[Tags <IFleetUpdateTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[VMAttributes <IVMAttributes>]`: Attribute based ComputeFleet.
    - `[AcceleratorCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
    - `[AcceleratorCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
    - `[AcceleratorManufacturers <List<String>>]`: The accelerator manufacturers specified as a list.         acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.         If acceleratorSupport is "Excluded", this VMAttribute can not be used.
    - `[AcceleratorSupport <String>]`: Specifies whether the VMSize supporting accelerator should be used to build ComputeFleet or not.         acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.         If acceleratorSupport is "Excluded", this VMAttribute can not be used.
    - `[AcceleratorTypes <List<String>>]`: The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.         If acceleratorSupport is "Excluded", this VMAttribute can not be used.
    - `[ArchitectureTypes <List<String>>]`: The VM architecture types specified as a list. Optional parameter.
    - `[BurstableSupport <String>]`: Specifies whether the VMSize supporting burstable capability should be used to build ComputeFleet or not.
    - `[CpuManufacturers <List<String>>]`: The VM CPU manufacturers specified as a list. Optional parameter.
    - `[DataDiskCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
    - `[DataDiskCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
    - `[ExcludedVMSizes <List<String>>]`: Specifies which VMSizes should be excluded while building ComputeFleet. Optional parameter.
    - `[LocalStorageDiskTypes <List<String>>]`: The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.         If localStorageSupport is "Excluded", this VMAttribute can not be used.
    - `[LocalStorageInGiBMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
    - `[LocalStorageInGiBMin <Double?>]`: Minimum value. default 0. Double.MinValue()
    - `[LocalStorageSupport <String>]`: Specifies whether the VMSize supporting local storage should be used to build ComputeFleet or not.         Included - Default if not specified as most Azure VMs support local storage.
    - `[MemoryInGiBMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
    - `[MemoryInGiBMin <Double?>]`: Minimum value. default 0. Double.MinValue()
    - `[MemoryInGiBPerVcpuMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
    - `[MemoryInGiBPerVcpuMin <Double?>]`: Minimum value. default 0. Double.MinValue()
    - `[NetworkBandwidthInMbpsMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
    - `[NetworkBandwidthInMbpsMin <Double?>]`: Minimum value. default 0. Double.MinValue()
    - `[NetworkInterfaceCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
    - `[NetworkInterfaceCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
    - `[RdmaNetworkInterfaceCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
    - `[RdmaNetworkInterfaceCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
    - `[RdmaSupport <String>]`: Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build ComputeFleet or not.
    - `[VCpuCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
    - `[VCpuCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
    - `[VMCategories <List<String>>]`: The VM category specified as a list. Optional parameter.
  - `[VMSizesProfile <List<IVMSizeProfile>>]`: List of VM sizes supported for Compute ComputeFleet
    - `Name <String>`: The Sku name (e.g. 'Standard_DS1_v2')
    - `[Rank <Int32?>]`: The rank of the VM size. This is used with 'RegularPriorityAllocationStrategy.Prioritized'         The lower the number, the higher the priority. Starting with 0.

`VMATTRIBUTES <IVMAttributes>`: Attribute based ComputeFleet.
  - `[AcceleratorCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
  - `[AcceleratorCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
  - `[AcceleratorManufacturers <List<String>>]`: The accelerator manufacturers specified as a list.         acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.         If acceleratorSupport is "Excluded", this VMAttribute can not be used.
  - `[AcceleratorSupport <String>]`: Specifies whether the VMSize supporting accelerator should be used to build ComputeFleet or not.         acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.         If acceleratorSupport is "Excluded", this VMAttribute can not be used.
  - `[AcceleratorTypes <List<String>>]`: The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.         If acceleratorSupport is "Excluded", this VMAttribute can not be used.
  - `[ArchitectureTypes <List<String>>]`: The VM architecture types specified as a list. Optional parameter.
  - `[BurstableSupport <String>]`: Specifies whether the VMSize supporting burstable capability should be used to build ComputeFleet or not.
  - `[CpuManufacturers <List<String>>]`: The VM CPU manufacturers specified as a list. Optional parameter.
  - `[DataDiskCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
  - `[DataDiskCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
  - `[ExcludedVMSizes <List<String>>]`: Specifies which VMSizes should be excluded while building ComputeFleet. Optional parameter.
  - `[LocalStorageDiskTypes <List<String>>]`: The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.         If localStorageSupport is "Excluded", this VMAttribute can not be used.
  - `[LocalStorageInGiBMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
  - `[LocalStorageInGiBMin <Double?>]`: Minimum value. default 0. Double.MinValue()
  - `[LocalStorageSupport <String>]`: Specifies whether the VMSize supporting local storage should be used to build ComputeFleet or not.         Included - Default if not specified as most Azure VMs support local storage.
  - `[MemoryInGiBMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
  - `[MemoryInGiBMin <Double?>]`: Minimum value. default 0. Double.MinValue()
  - `[MemoryInGiBPerVcpuMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
  - `[MemoryInGiBPerVcpuMin <Double?>]`: Minimum value. default 0. Double.MinValue()
  - `[NetworkBandwidthInMbpsMax <Double?>]`: Maximum value. Double.MaxValue(1.7976931348623157E+308)
  - `[NetworkBandwidthInMbpsMin <Double?>]`: Minimum value. default 0. Double.MinValue()
  - `[NetworkInterfaceCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
  - `[NetworkInterfaceCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
  - `[RdmaNetworkInterfaceCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
  - `[RdmaNetworkInterfaceCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
  - `[RdmaSupport <String>]`: Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build ComputeFleet or not.
  - `[VCpuCountMax <Int32?>]`: Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.
  - `[VCpuCountMin <Int32?>]`: Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.
  - `[VMCategories <List<String>>]`: The VM category specified as a list. Optional parameter.

`VMSIZESPROFILE <IVMSizeProfile[]>`: List of VM sizes supported for Compute ComputeFleet
  - `Name <String>`: The Sku name (e.g. 'Standard_DS1_v2')
  - `[Rank <Int32?>]`: The rank of the VM size. This is used with 'RegularPriorityAllocationStrategy.Prioritized'         The lower the number, the higher the priority. Starting with 0.

## RELATED LINKS

