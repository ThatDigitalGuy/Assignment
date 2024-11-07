using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Hospital.classes
{
    public class Auth
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Groups { get; set; }
        public bool isAuthenticated { get; set; }

        public string authFilePath = "./Auth.txt";
        public string authLogFilePath = "./Log.txt";

        public Auth()
        {
            Id = "";
            Name = "";
            Email = "";
            Groups = new List<string>();
            Password = "";
            isAuthenticated = false;
        }

        public string LogIn(string username, string password)
        {
            bool userNameChecked = false;
            bool passwordChecked = false;

            // Checks if the user is already logged in.
            if (isAuthenticated == true) { return "Already authenticated"; };

            // Opens the authentication file.
            try
            {
                using (StreamReader reader = new StreamReader(authFilePath))
                {
                    String line = reader.ReadLine();
                    string[] data = line.Split(",");

                    if(data == null) { return "Invalid"; }

                    foreach (string s in data)
                    {
                        if (userNameChecked && passwordChecked)
                        {
                            Id = data[2];
                            Name = data[3];
                            Email = data[0];

                            // Add the groups to the list
                            string[] currentGroup = data[4].Split(";");

                            foreach (string group in currentGroup)
                            {
                                if (group == null || group.Length == 0) { break; }
                                Groups.Add(group);
                            }
                            break;
                        }

                        if (data[0] != username || data[1] != password) { return "Invalid"; }

                        // Check username
                        if (data[0] == username)
                        {
                            userNameChecked = true;
                        }

                        // Check password
                        if (data[1] == password)
                        {
                            passwordChecked = true;
                        }

                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("IOException " + ex.ToString());
            }

            return "Error";
        }

        public void LogEvents(string e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(authLogFilePath))
                {
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("IOException " + ex.ToString());
            }
        }
    }
}
