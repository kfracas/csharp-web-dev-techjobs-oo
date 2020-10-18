using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");
            Job testJob = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            Assert.AreEqual(testJob.Name + testJob.EmployerName + testJob.EmployerLocation + testJob.JobType + testJob.JobCoreCompetency, "Product testerACMEDesertQuality controlPersistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");
            Job testJob1 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            Job testJob2 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            Assert.IsFalse(testJob1.Equals(testJob2));
        }
        [TestMethod]
        public void ToStringTest()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");
            Job testJob = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            Assert.AreEqual(testJob.ToString(),"Product tester - Employer Name: ACME, Location: Desert, Type: Quality control, Core Competency: Persistence");
        }
    }
}
