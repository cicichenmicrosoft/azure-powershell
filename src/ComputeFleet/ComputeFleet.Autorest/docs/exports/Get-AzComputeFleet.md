---
external help file:
Module Name: Az.ComputeFleet
online version: https://learn.microsoft.com/powershell/module/computefleet/get-azcomputefleet
schema: 2.0.0
---

# Get-AzComputeFleet

## SYNOPSIS
Get a ComputeFleet

## SYNTAX

### List (Default)
```
Get-AzComputeFleet -SubscriptionId <String> [<CommonParameters>]
```

### Get
```
Get-AzComputeFleet -FleetName <String> -ResourceGroupName <String> -SubscriptionId <String>
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzComputeFleet -InputObject <IFleetIdentity> [<CommonParameters>]
```

### List1
```
Get-AzComputeFleet -ResourceGroupName <String> -SubscriptionId <String> [<CommonParameters>]
```

## DESCRIPTION
Get a ComputeFleet

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

### -FleetName
The name of the Compute ComputeFleet

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleetIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, List1
Aliases:

Required: True
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
Parameter Sets: Get, List, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleetIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Api20241101.IFleet

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IFleetIdentity>`: Identity Parameter
  - `[FleetName <String>]`: The name of the Compute ComputeFleet
  - `[Name <String>]`: The name of the ComputeFleet
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[SubscriptionId <String>]`: The ID of the target subscription. The value must be an UUID.

## RELATED LINKS

