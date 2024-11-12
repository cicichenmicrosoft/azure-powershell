@{
  GUID = 'd911fabc-d107-439b-a98e-f0d3289c7b0b'
  RootModule = './ComputeFleet.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/ComputeFleet.private.dll'
  FormatsToProcess = './ComputeFleet.format.ps1xml'
  FunctionsToExport = 'Get-ComputeFleet', 'Get-FleetVirtualMachineScaleSet', 'Get-Operation', 'New-ComputeFleet', 'Remove-ComputeFleet', 'Update-ComputeFleet'
  PrivateData = @{
    PSData = @{
      Tags = ''
      LicenseUri = ''
      ProjectUri = ''
      ReleaseNotes = ''
    }
  }
}
