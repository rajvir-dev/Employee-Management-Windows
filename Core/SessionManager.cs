using System;
using System.IO;
using Newtonsoft.Json;

namespace EmployeeManagement_Windows.Core
{
    /// <summary>
    /// Stores JWT token and authenticated user details for the current session.
    /// Persists data to local storage to support 'Remember Me' and auto-login.
    /// </summary>
    public static class SessionManager
    {
        private static readonly string SessionFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "EmployeeManagement",
            "session.json");

        public static string Token { get; set; } = string.Empty;
        public static string EmployeeId { get; set; } = string.Empty;
        public static string FullName { get; set; } = string.Empty;
        public static string PhotoBase64 { get; set; } = string.Empty;
        public static int EmployeeType { get; set; }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(Token);

        static SessionManager()
        {
            LoadSession();
        }

        /// <summary>
        /// Sets session data and persists it to local storage.
        /// </summary>
        public static void SetSession(string token, string employeeId, string fullName, int employeeType, string photoBase64 = "")
        {
            Token = token;
            EmployeeId = employeeId;
            FullName = fullName;
            EmployeeType = employeeType;
            PhotoBase64 = photoBase64;
            SaveSession();
        }

        /// <summary>
        /// Clears session data and removes the local storage file.
        /// </summary>
        public static void Clear()
        {
            Token = string.Empty;
            EmployeeId = string.Empty;
            FullName = string.Empty;
            PhotoBase64 = string.Empty;
            EmployeeType = 0;

            if (File.Exists(SessionFilePath))
            {
                try { File.Delete(SessionFilePath); } catch { }
            }
        }

        public static void SaveSession()
        {
            try
            {
                var directory = Path.GetDirectoryName(SessionFilePath);
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

                var sessionData = new
                {
                    Token,
                    EmployeeId,
                    FullName,
                    EmployeeType,
                    PhotoBase64
                };

                File.WriteAllText(SessionFilePath, JsonConvert.SerializeObject(sessionData));
            }
            catch { /* Ignore persistence errors */ }
        }

        private static void LoadSession()
        {
            try
            {
                if (File.Exists(SessionFilePath))
                {
                    var json = File.ReadAllText(SessionFilePath);
                    var sessionData = JsonConvert.DeserializeObject<dynamic>(json);
                    
                    if (sessionData != null)
                    {
                        Token = sessionData.Token;
                        EmployeeId = sessionData.EmployeeId;
                        FullName = sessionData.FullName;
                        EmployeeType = (int)sessionData.EmployeeType;
                        PhotoBase64 = sessionData.PhotoBase64 ?? string.Empty;
                    }
                }
            }
            catch { /* Ignore corruption errors */ }
        }
    }
}
