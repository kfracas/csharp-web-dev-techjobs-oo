using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Employer testEmployer;
        Location testLocation;
        PositionType testPositionType;
        CoreCompetency testCoreCompetency;
        Job testJob1;
        Job testJob2;

        [TestInitialize]
        public void CreateJobObjects()
        {
            testEmployer = new Employer("ACME");
            testLocation = new Location("Desert");
            testPositionType = new PositionType("Quality control");
            testCoreCompetency = new CoreCompetency("Persistence");
            testJob1 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            testJob2 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(testJob2.Id == testJob1.Id + 1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(testJob1.Name + testJob1.EmployerName + testJob1.EmployerLocation + testJob1.JobType + testJob1.JobCoreCompetency, "Product testerACMEDesertQuality controlPersistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testJob1.Equals(testJob2));
        }
        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual(testJob1.ToString(),"Product tester - Employer Name: ACME, Location: Desert, Type: Quality control, Core Competency: Persistence");
        }
    }
}
