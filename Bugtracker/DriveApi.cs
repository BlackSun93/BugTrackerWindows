using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Bugtracker
{
    class DriveApi
    {
        // If modifying these scopes, delete your previously saved credentials at ~/bin/debug/BugTracker-a00ef4c2ddef.json
        static string[] Scopes = { DriveService.Scope.DriveReadonly, DriveService.Scope.Drive }; // Holds the chosen scope(s) used to interact with google drive files
        static string ApplicationName = "BugTracker"; // The name of the application as per the Google Developer account project
        static GoogleCredential Credential;
        static DriveService Service;
        static IList<Google.Apis.Drive.v3.Data.File> FileList; // Allows files to be referenced by index without storing locally


        public static void InitialiseDrive()
        {
            Credential = GetCredentials();
            Service = GetService();
            InitialiseFiles();

        }

        private static GoogleCredential GetCredentials()
        {
            GoogleCredential credential;

            using (FileStream stream = new FileStream(@"Properties\BugTracker-a00ef4c2ddef.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleCredential.FromStream(stream);
                if (credential.IsCreateScopedRequired)
                {
                    credential = credential.CreateScoped(Scopes);
                }
                new FileDataStore(credPath, true);
                MessageBox.Show("Credential file saved to: " + credPath); //for testing
            }

            return credential;
        }

        /// <summary>
        /// Create Drive API service.
        /// </summary>
        /// <returns>
        /// Google Drive Service
        /// </returns>
        private static DriveService GetService()
        {
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = Credential,
                ApplicationName = ApplicationName,
            });

        }

        private static void InitialiseFiles()
        {
            //Define parameters of request
            FilesResource.ListRequest listRequest = Service.Files.List();
            listRequest.PageSize = 10; // to be changed accordingly when bugs are paginated.
            listRequest.Fields = "nextPageToken, files(id, name)";

            FileList = listRequest.Execute().Files;

            MessageBox.Show("Files:"); //for testing

            if (FileList != null && FileList.Count > 0)
            {
                foreach (var file in FileList)
                {
                    MessageBox.Show(file.Name + " " + file.Id); //for testing
                }
            }
            else
            {
                MessageBox.Show("No files found.");
            }
        }

    }
}
