using System;

namespace EmployeeManagementSystem
{
    public static class LoginPage
    {
        public static bool Authenticate(string? username, string? password)
        {
            // Dummy authentication for simplicity
            if (username == "admin" && password == "password123")
            {
                return true;
            }
            return false;
        }
    }
}