using System;

namespace EmployeeManagementSystem
{
    public static class UserLoginPage // Renamed the class
    {
        public static bool Authenticate(string? username, string? password)
        {
           
            if (username == "admin" && password == "Password123")
            {
                return true;
            }
            return false;
        }
    }
}