if(($null -eq $TestName) -or ($TestName -contains 'New-AzComputeFleet'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzComputeFleet.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzComputeFleet' {
    It 'Create' {
        {
            $fleet = Get-AzComputeFleet -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -FleetName $env.FleetName
            $fleet.Name = $env.NewFleetName
            $fleet = New-AzComputeFleet -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -FleetName $env.FleetName -Resource $fleet
            $fleet.Name | Should -Be $env.NewFleetName
        } | Should -Not -Throw
    }

    It 'CreateViaIdentity' {
        {
            $fleet = Get-AzComputeFleet -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -FleetName $env.FleetName
            $fleet.Name = $env.NewFleetName
            $fleet = New-AzComputeFleet -InputObject $fleet -Resource $fleet
            $fleet.Name | Should -Be $env.NewFleetName
        } | Should -Not -Throw
    }

    It 'CreateExpanded' {
        {
            $fleet = Get-AzComputeFleet -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -FleetName $env.FleetName
            $fleet.Name = $env.NewFleetName
            $vmAttributes = $fleet.VMAttributes
            $fleet = New-AzComputeFleet -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -FleetName $env.FleetName -Location $env.Location -VMAttributes $vmAttributes
            $fleet.Name | Should -Be $env.NewFleetName
        } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' {
        {
            $fleet = Get-AzComputeFleet -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.ResourceGroupName -FleetName $env.FleetName
            $fleet.Name = $env.NewFleetName
            $computeProfileBaseVirtualMachineProfile = $fleet.ComputeProfileBaseVirtualMachineProfile
            $fleet = New-AzComputeFleet -InputObject $fleet -Resource $fleet -BaseVirtualMachineProfile $computeProfileBaseVirtualMachineProfile
            $fleet.Name | Should -Be $env.NewFleetName
        } | Should -Not -Throw
    }
}
