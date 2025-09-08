using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;

namespace DbConnectionsPOCs
{
    public class HILTestCase : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            // Arrange
            Log("Test run started for HILTestCase.");

            // Act
            RunWorkflow(@"HIL.cs" );

            // Assert
            // To start using activities, use IntelliSense (CTRL + Space) to discover the available services, e.g. testing.VerifyExpression(...).
        }
    }
}