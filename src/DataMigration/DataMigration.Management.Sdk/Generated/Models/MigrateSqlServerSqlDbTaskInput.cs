// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Input for the task that migrates on-prem SQL Server databases to Azure SQL
    /// Database
    /// </summary>
    public partial class MigrateSqlServerSqlDbTaskInput : SqlMigrationTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the MigrateSqlServerSqlDbTaskInput class.
        /// </summary>
        public MigrateSqlServerSqlDbTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateSqlServerSqlDbTaskInput class.
        /// </summary>

        /// <param name="sourceConnectionInfo">Information for connecting to source
        /// </param>

        /// <param name="targetConnectionInfo">Information for connecting to target
        /// </param>

        /// <param name="selectedDatabases">Databases to migrate
        /// </param>

        /// <param name="validationOptions">Options for enabling various post migration validations. Available options,
        /// 1.) Data Integrity Check: Performs a checksum based comparison on source
        /// and target tables after the migration to ensure the correctness of the
        /// data.
        /// 2.) Schema Validation: Performs a thorough schema comparison between the
        /// source and target tables and provides a list of differences between the
        /// source and target database, 3.) Query Analysis: Executes a set of queries
        /// picked up automatically either from the Query Plan Cache or Query Store and
        /// execute them and compares the execution time between the source and target
        /// database.
        /// </param>
        public MigrateSqlServerSqlDbTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, System.Collections.Generic.IList<MigrateSqlServerSqlDbDatabaseInput> selectedDatabases, MigrationValidationOptions validationOptions = default(MigrationValidationOptions))

        : base(sourceConnectionInfo, targetConnectionInfo)
        {
            this.SelectedDatabases = selectedDatabases;
            this.ValidationOptions = validationOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets databases to migrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "selectedDatabases")]
        public System.Collections.Generic.IList<MigrateSqlServerSqlDbDatabaseInput> SelectedDatabases {get; set; }

        /// <summary>
        /// Gets or sets options for enabling various post migration validations.
        /// Available options,
        /// 1.) Data Integrity Check: Performs a checksum based comparison on source
        /// and target tables after the migration to ensure the correctness of the
        /// data.
        /// 2.) Schema Validation: Performs a thorough schema comparison between the
        /// source and target tables and provides a list of differences between the
        /// source and target database, 3.) Query Analysis: Executes a set of queries
        /// picked up automatically either from the Query Plan Cache or Query Store and
        /// execute them and compares the execution time between the source and target
        /// database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "validationOptions")]
        public MigrationValidationOptions ValidationOptions {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.SelectedDatabases == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SelectedDatabases");
            }


        }
    }
}