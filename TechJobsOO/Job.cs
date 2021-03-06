﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        public override string ToString()
        {
            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return " " + "\n" + "OOPS! This job does not seem to exist." + "\n" + " ";
            }
            else
            {
                string tempName;
                string tempEmpName;
                string tempEmpLocation;
                string tempJobType;
                string tempJobCompetency;
                if (Name == "") { tempName = "Data not available"; } else { tempName = Name; }
                if (EmployerName.Value == "") { tempEmpName = "Data not available"; } else { tempEmpName = EmployerName.Value; }
                if (EmployerLocation.Value == "") { tempEmpLocation = "Data not available"; } else { tempEmpLocation = EmployerLocation.Value; }
                if (JobType.Value == "") { tempJobType = "Data not available"; } else { tempJobType = JobType.Value; }
                if (JobCoreCompetency.Value == "") { tempJobCompetency = "Data not available"; } else { tempJobCompetency = JobCoreCompetency.Value; }
                return " " + "\n" + "ID: " + Id + "\n" + "Name: " + tempName + "\n" + "Employer: " + tempEmpName + "\n" + "Location: " + tempEmpLocation + "\n" + "Position Type: " + tempJobType + "\n" + "Core Competency: " + tempJobCompetency + "\n" + " ";
            }
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
