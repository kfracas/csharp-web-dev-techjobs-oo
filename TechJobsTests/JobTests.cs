using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Job testJob2;
        Job testJob3;
        Job testJob4;

        [TestInitialize]
        public void CreateJobObjects()
        {
            testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob3 = new Job("Job Placeholder", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
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
            Assert.AreEqual(testJob1.ToString(), $" \nID: {testJob1.Id}\nName: {testJob1.Name}\nEmployer: {testJob1.EmployerName}\nLocation: {testJob1.EmployerLocation}\nPosition Type: {testJob1.JobType}\nCore Competency: {testJob1.JobCoreCompetency}\n ");
        }
        [TestMethod]
        public void ToStringDataNotAvailable()
        {
            Assert.AreEqual(testJob3.ToString(), $" \nID: {testJob3.Id}\nName: {testJob3.Name}\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n ");
        }
        [TestMethod]
        public void ToStringJobDoesNotExist()
        {
            Assert.AreEqual(testJob4.ToString(), " \nOOPS! This job does not seem to exist.\n ");
        }
    }
}
