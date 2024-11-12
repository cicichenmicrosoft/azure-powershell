---
external help file: Az.ComputeFleet-help.xml
Module Name: Az.ComputeFleet
online version: https://learn.microsoft.com/powershell/module/az.computefleet/update-azcomputefleet
schema: 2.0.0
---

# Update-AzComputeFleet

## SYNOPSIS
Update ComputeFleet resource

## SYNTAX

### UpdateExpanded
```
Update-AzComputeFleet -SubscriptionId <String> -ResourceGroupName <String> -FleetName <String>
 [-LocationProfiles <ILocationProfile>] [-HibernationEnabled] [-UltraSSDEnabled]
 [-BaseVirtualMachineProfile <IBaseVirtualMachineProfile>] [-ComputeApiVersion <String>]
 [-PlatformFaultDomainCount <Int32>] [-IdentityType <ManagedServiceIdentityType>]
 [-UserAssignedIdentities <IManagedServiceIdentityUpdateUserAssignedIdentities>] [-PlanName <String>]
 [-PlanProduct <String>] [-PlanPromotionCode <String>] [-PlanPublisher <String>] [-PlanVersion <String>]
 [-RegularPriorityAllocationStrategy <RegularPriorityAllocationStrategy>]
 [-RegularPriorityProfileCapacity <Int32>] [-RegularPriorityProfileMinCapacity <Int32>]
 [-SpotPriorityProfileAllocationStrategy <SpotAllocationStrategy>] [-SpotPriorityProfileCapacity <Int32>]
 [-SpotPriorityProfileEvictionPolicy <EvictionPolicy>] [-SpotPriorityProfileMaintain]
 [-SpotPriorityProfileMaxPricePerVM <Single>] [-SpotPriorityProfileMinCapacity <Int32>]
 [-Tags <IFleetUpdateTags>] [-VMAttributes <IVMAttributes>] [-VMSizesProfile <IVMSizeProfile>] [-AsJob]
 [-Break] [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait]
 [-Proxy <Uri>] [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-AzComputeFleet -SubscriptionId <String> -ResourceGroupName <String> -FleetName <String>
 -Properties <IFleetUpdate> [-AsJob] [-Break] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-AzComputeFleet -Properties <IFleetUpdate> -InputObject <IFleetIdentity> [-AsJob] [-Break]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzComputeFleet -InputObject <IFleetIdentity> [-LocationProfiles <ILocationProfile>]
 [-HibernationEnabled] [-UltraSSDEnabled] [-BaseVirtualMachineProfile <IBaseVirtualMachineProfile>]
 [-ComputeApiVersion <String>] [-PlatformFaultDomainCount <Int32>] [-IdentityType <ManagedServiceIdentityType>]
 [-UserAssignedIdentities <IManagedServiceIdentityUpdateUserAssignedIdentities>] [-PlanName <String>]
 [-PlanProduct <String>] [-PlanPromotionCode <String>] [-PlanPublisher <String>] [-PlanVersion <String>]
 [-RegularPriorityAllocationStrategy <RegularPriorityAllocationStrategy>]
 [-RegularPriorityProfileCapacity <Int32>] [-RegularPriorityProfileMinCapacity <Int32>]
 [-SpotPriorityProfileAllocationStrategy <SpotAllocationStrategy>] [-SpotPriorityProfileCapacity <Int32>]
 [-SpotPriorityProfileEvictionPolicy <EvictionPolicy>] [-SpotPriorityProfileMaintain]
 [-SpotPriorityProfileMaxPricePerVM <Single>] [-SpotPriorityProfileMinCapacity <Int32>]
 [-Tags <IFleetUpdateTags>] [-VMAttributes <IVMAttributes>] [-VMSizesProfile <IVMSizeProfile>] [-AsJob]
 [-Break] [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait]
 [-Proxy <Uri>] [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update ComputeFleet resource

## EXAMPLES

### EXAMPLE 1
```
Update-AzComputeFleet -SubscriptionId "00000000-0000-0000-0000-000000000000" -ResourceGroupName azure-rg-test -FleetName testFleet
```

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -BaseVirtualMachineProfile
Base Virtual Machine Profile Properties to be specified according to \"specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile\"

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IBaseVirtualMachineProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Break
Wait for .NET debugger to attach

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComputeApiVersion
Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.The default value will be the latest supported computeApiVersion by Compute ComputeFleet

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

### -FleetName
ComputeFleet name

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HibernationEnabled
The flag that enables or disables hibernation capability on the VM

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelineAppend
SendAsync Pipeline Steps to be appended to the front of the pipeline

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelinePrepend
SendAsync Pipeline Steps to be prepended to the front of the pipeline

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityType
The type of managed identity assigned to this resource

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Support.ManagedServiceIdentityType
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
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IFleetIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LocationProfiles
The list of location profiles

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.ILocationProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanName
A user defined name of the 3rd Party Artifact that is being procured

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
Product maps to the OfferID specified for the artifact at the time of Data Market onboarding

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
A publisher provided promotion code as provisioned in Data Market for the said product/artifact

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
The version of the desired product/artifact

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

### -PlatformFaultDomainCount
Specifies the number of fault domains to use when creating the underlying VMSS.A fault domain is a logical group of hardware within an Azure datacenter.VMs in the same fault domain share a common power source and network switch.If not specified, defaults to 1, which represents \"Max Spreading\" (using as many fault domains as possible).This property cannot be updated.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Properties
ComputeFleet properties

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IFleetUpdate
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IFleetUpdate
Parameter Sets: UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Proxy
The URI for the proxy server to use

```yaml
Type: System.Uri
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyCredential
Credentials for a proxy server to use for the remote call

```yaml
Type: System.Management.Automation.PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyUseDefaultCredentials
Use the default credentials for the proxy

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegularPriorityAllocationStrategy
Allocation strategy to follow when determining the VM sizes distribution for Regular VMs

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Support.RegularPriorityAllocationStrategy
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
It is currently in terms of number of VMs

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegularPriorityProfileMinCapacity
Minimum capacity to achieve which cannot be updated.
If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Resource group name

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileAllocationStrategy
Allocation strategy to follow when determining the VM sizes distribution for Spot VMs

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Support.SpotAllocationStrategy
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
It is currently in terms of number of VMs

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileEvictionPolicy
Eviction Policy to follow when evicting Spot VMs

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Support.EvictionPolicy
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileMaintain
Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint) in order to achieve the desired capacity.Maintain is enabled by default

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileMaxPricePerVM
Price per hour of each Spot VM will never exceed this

```yaml
Type: System.Single
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpotPriorityProfileMinCapacity
Minimum capacity to achieve which cannot be updated.
If we will not be able to ""guarantee"" minimum capacity, we will reject the request in the sync path itself

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Microsoft Azure subscription id

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
Resource tags

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IFleetUpdateTags
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UltraSSDEnabled
The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS.Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserAssignedIdentities
The identities assigned to this resource by the user

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IManagedServiceIdentityUpdateUserAssignedIdentities
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMAttributes
Attribute based ComputeFleet

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IVMAttributes
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
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IVMSizeProfile
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

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IFleet
## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.Api20241101.IFleet
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IFleet\>: Identity Parameter
  \[Id \<String\>\]: Resource identity path
  \[FleetName \<String\>\]: ComputeFleet resource name
  \[ResourceGroupName \<String\>\]: Resource group name
  \[SubscriptionId \<String\>\]: Microsoft Azure subscription id

## RELATED LINKS

[https://learn.microsoft.com/powershell/module/az.computefleet/update-azcomputefleet](https://learn.microsoft.com/powershell/module/az.computefleet/update-azcomputefleet)

