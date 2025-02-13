// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Base class for backup policy. Workload-specific backup policies are derived
    /// from this class.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ProtectionPolicy")]
    public partial class ProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionPolicy class.
        /// </summary>
        public ProtectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectionPolicy class.
        /// </summary>

        /// <param name="protectedItemsCount">Number of items associated with this policy.
        /// </param>

        /// <param name="resourceGuardOperationRequests">ResourceGuard Operation Requests
        /// </param>
        public ProtectionPolicy(int? protectedItemsCount = default(int?), System.Collections.Generic.IList<string> resourceGuardOperationRequests = default(System.Collections.Generic.IList<string>))

        {
            this.ProtectedItemsCount = protectedItemsCount;
            this.ResourceGuardOperationRequests = resourceGuardOperationRequests;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets number of items associated with this policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedItemsCount")]
        public int? ProtectedItemsCount {get; set; }

        /// <summary>
        /// Gets or sets resourceGuard Operation Requests
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGuardOperationRequests")]
        public System.Collections.Generic.IList<string> ResourceGuardOperationRequests {get; set; }
    }
}