using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public DateTime DateOfJoining { get; set; }
        public List<string> Tasks { get; set; }

        public Employee(int employeeId, string? name, string? position, DateTime dateOfJoining)
        {
            EmployeeId = employeeId;
            Name = name ?? "Unknown";
            Position = position ?? "Unspecified";
            DateOfJoining = dateOfJoining;
            Tasks = new List<string>();
        }

        public void AssignTask(string task)
        {
            Tasks.Add(task);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Date of Joining: " + DateOfJoining.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("Tasks Assigned:");
            foreach (var task in Tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }
}