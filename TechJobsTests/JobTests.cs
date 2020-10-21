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
        Job testJob3;
        Job testJob4;

        [TestInitialize]
        public void CreateJobObjects()
        {
            testEmployer = new Employer("ACME");
            testLocation = new Location("Desert");
            testPositionType = new PositionType("Quality control");
            testCoreCompetency = new CoreCompetency("Persistence");
            testJob1 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            testJob2 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            testJob3 = new Job("Job Placeholder");
            testJob4 = new Job();
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
        public void ToStringBlankLineTest()
        {
            Assert.IsTrue(testJob1.ToString().StartsWith(' ') && testJob1.ToString().EndsWith(' '));
        }
        [TestMethod]
        public void ToStringPrintData()
        {
            Assert.AreEqual(testJob1.ToString(), " \nID: 29\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n ");
        }
        [TestMethod]
        public void ToStringDataNotAvailable()
        {
            Assert.AreEqual(testJob3.ToString(), " \nID: 23\nName: Job Placeholder\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n ");
        }
        [TestMethod]
        public void ToStringJobDoesNotExist()
        {
            Assert.AreEqual(testJob4.ToString(), " \nOOPS! This job does not seem to exist.\n ");
        }
    }
}
