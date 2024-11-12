<!-- region Generated -->
# ComputeFleet
This directory contains the PowerShell module for the ComputeFleet service.

---
## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `ComputeFleet`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
# lock the commit
commit: 366aaa13cdd218b9adac716680e49473673410c8
# lock the commit
input-file:
  - $(repo)/specification/azurefleet/resource-manager/Microsoft.AzureFleet/stable/2024-11-01/azurefleet.json
try-require: 
  - $(repo)/specification/azurefleet/resource-manager/readme.powershell.md

title: ComputeFleet
module-version: 0.1.0

identity-correction-for-post: true
resourcegroup-append: true
nested-object-to-string: true
auto-switch-view: false

inlining-threshold: 50

use-extension: 
  "@autorest/powershell": "4.x"

directive:
  # The regex(^/(?<scope>[^/]+)/) mathch failed because the scope inlcude '/' character.
  # Replace regex to fixed it. 
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/global::System.Text.RegularExpressions.Regex\(\"\^\/\(\?\<scope\>\[\^\/\]\+\)/g, 'global::System.Text.RegularExpressions.Regex("^/(?<scope>.+)');

  # Remove the set Workspace cmdlet
  - where:
      variant: ^(Create|Update).*(?<!Expanded|JsonFilePath|JsonString)$
    remove: true
  - where:
      verb: Set
    remove: true
    
  - where:
      verb: Get
      subject: RequestStatus|Usage
      variant: ^GetViaIdentity$
    remove: true

  # Rename parameter
  - where:
      werb: New
      parameter-name: NameValue
    set:
      parameter-name: Name
  # Hide parameter
  # future extendibility. It’s not used currently
  - where:
      verb: New|Update
      parameter-name: AnyProperty
    hide: true

  - where:
      werb: Get
      subject: Usage
      parameter-name: ResourceName
    set:
      parameter-name: Name

  - where:
      model-name: CurrentQuotaLimitBase
    set:
      format-table:
        properties:
          - Name
          - NameLocalizedValue
          - LimitObjectType
          - Unit
          - ETag
  - where:
      model-name: CurrentUsagesBase
    set:
      format-table:
        properties:
          - Name
          - NameLocalizedValue
          - UsageUsagesType
          - UsageValue
          - ETag
  - where:
      model-name: QuotaRequestDetails
    set:
      format-table:
        properties:
          - Name
          - ProvisioningState
          - ErrorMessage
          - Code
  
  - no-inline:
    - LimitJsonObject
    
  - model-cmdlet:
    - model-name: LimitObject
      cmdlet-name: New-AzQuotaLimitObject
```
