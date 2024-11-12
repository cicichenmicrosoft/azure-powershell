@{
  GUID = 'd911fabc-d107-439b-a98e-f0d3289c7b0b'
  RootModule = './Fleet.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Fleet.private.dll'
  FormatsToProcess = './Fleet.format.ps1xml'
  FunctionsToExport = 'Get-Fleet', 'Get-FleetVirtualMachineScaleSet', 'Get-Operation', 'New-Fleet', 'Remove-Fleet', 'Update-Fleet'
  PrivateData = @{
    PSData = @{
      Tags = ''
      LicenseUri = ''
      ProjectUri = ''
      ReleaseNotes = ''
    }
  }
}
