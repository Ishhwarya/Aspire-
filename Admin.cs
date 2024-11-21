using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem
{
    public class Admin : Employee               //Inheritance 
    {
        private List<Employee> employeeList;

        public Admin(int employeeId, string name, DateTime dateOfJoining)
            : base(employeeId, name, "Admin", dateOfJoining)
        {
            employeeList = new List<Employee>();
        }

        public void CreateEmployee(int id, string? name, DateTime joiningDate, string? position)
        {
            Console.WriteLine("Creating new employee...");
            Employee newEmployee = new Employee(id, name ?? "Unknown", position ?? "Unspecified", joiningDate);
            employeeList.Add(newEmployee);
            Console.WriteLine("Employee Created Successfully!");
        }

        public void DeleteEmployee(int employeeId)
        {
            var employeeToRemove = employeeList.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employeeToRemove != null)
            {
                employeeList.Remove(employeeToRemove);
                Console.WriteLine("Employee with ID " + employeeId + " has been deleted.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine("\nList of Employees:");
            foreach (var employee in employeeList)
            {
                employee.DisplayDetails();
                Console.WriteLine();
            }
        }

        public void UpdateEmployeeDetails(int employeeId)
        {
            var employeeToUpdate = employeeList.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employeeToUpdate != null)
            {
                Console.WriteLine("Updating details for Employee ID " + employeeId + "...\n");

                Console.Write("Enter new name (current: " + employeeToUpdate.Name + "): ");
                string? newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName)) employeeToUpdate.Name = newName;

                Console.Write("Enter new position (current: " + employeeToUpdate.Position + "): ");
                string? newPosition = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newPosition)) employeeToUpdate.Position = newPosition;

                Console.Write("Enter new date of joining (current: " + employeeToUpdate.DateOfJoining.ToString("yyyy-MM-dd") + "): ");
                string? dateInput = Console.ReadLine();
                if (DateTime.TryParse(dateInput, out DateTime newJoiningDate))
                {
                    employeeToUpdate.DateOfJoining = newJoiningDate;
                }

                Console.WriteLine("Employee details updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}