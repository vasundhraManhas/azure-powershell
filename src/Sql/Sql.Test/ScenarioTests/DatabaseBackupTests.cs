// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ScenarioTest.SqlTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Sql.Test.ScenarioTests
{
    public class DatabaseBackupTests : SqlTestsBase
    {
        public DatabaseBackupTests(ITestOutputHelper output) : base(output)
        {
            base.resourceTypesToIgnoreApiVersion = new string[] {
                "Microsoft.Sql/servers"
            };
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListDatabaseRestorePoints()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            RunPowerShellTest("Test-ListDatabaseRestorePoints");
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRestoreGeoBackup()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-RestoreGeoBackup");
            }
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRestoreDeletedDatabaseBackup()
        {
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-RestoreDeletedDatabaseBackup");
            }
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRestorePointInTimeBackup()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-RestorePointInTimeBackup");
            }
        }

        [Fact(Skip = "LTR-V1 restore service is retiring in Prod.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRestoreLongTermRetentionBackup()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-RestoreLongTermRetentionBackup");
            }
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestLongTermRetentionV2Policy()
        {
            RunPowerShellTest("Test-LongTermRetentionV2Policy");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestLongTermRetentionV2Backup()
        {
            RunPowerShellTest("Test-LongTermRetentionV2Backup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestLongTermRetentionV2ResourceGroupBasedBackup()
        {
            RunPowerShellTest("Test-LongTermRetentionV2ResourceGroupBasedBackup");
        }

        [Fact(Skip = "This is not recordable test")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestLongTermRetentionV2()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-LongTermRetentionV2");
            }
        }

        [Fact(Skip = "This is not recordable test")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCopyLongTermRetentionBackup()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-CopyLongTermRetentionBackup");
            }
        }

        [Fact(Skip = "This is not recordable test")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateLongTermRetentionBackup()
        {
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-UpdateLongTermRetentionBackup");
            }
        }


        [Fact(Skip = "This is not recordable test")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestLongTermRetentionV2ResourceGroupBased()
        {
            RunPowerShellTest("Test-LongTermRetentionV2ResourceGroupBased");
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseGeoBackupPolicy()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-DatabaseGeoBackupPolicy");
            }
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewDatabaseRestorePoint()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-NewDatabaseRestorePoint");
            }
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveDatabaseRestorePoint()
        {
            // TODO Rewrite SQL backup tests to be recordable
            // TODO https://github.com/Azure/azure-powershell/issues/4155
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-RemoveDatabaseRestorePoint");
            }
        }

        [Fact(Skip = "Not recordable")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestShortTermRetentionPolicy()
        {
            if (TestMockSupport.RunningMocked)
            {
                RunPowerShellTest("Test-ShortTermRetentionPolicy");
            }
        }

        [Fact(Skip = "Location 'East US 2 EUAP' is not accepting creation of new Windows Azure SQL Database servers at this time.'")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateRestoreRegularAndZoneRedundantDatabaseWithSourceNotZoneRedundant()
        {
            RunPowerShellTest("Test-CreateRestoreRegularAndZoneRedundantDatabaseWithSourceNotZoneRedundant");
        }

        [Fact(Skip = "Location 'East US 2 EUAP' is not accepting creation of new Windows Azure SQL Database servers at this time.'")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateRestoreRegularAndZoneRedundantDatabaseWithSourceZoneRedundant()
        {
            RunPowerShellTest("Test-CreateRestoreRegularAndZoneRedundantDatabaseWithSourceZoneRedundant");
        }
    }
}
