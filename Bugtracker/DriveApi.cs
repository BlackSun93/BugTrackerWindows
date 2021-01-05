using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Drawing;
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
        // If modifying these scopes, delete your previously saved credentials at ~/bin/debug/credentials.json
        static string[] Scopes = { DriveService.Scope.DriveReadonly, DriveService.Scope.Drive }; // Holds the chosen scope(s) used to interact with google drive files
        static UserCredential Credential; // Holds the access token needed to access google drive
        static DriveService Service; // Used to create, search and download files from the google drive
        static IList<Google.Apis.Drive.v3.Data.File> FileList; // Allows files to be referenced by index without storing locally


        public static void InitialiseDrive()
        {
            Credential = GetCredentials();
            Service = GetService();
            InitialiseFiles();

        }

        private static UserCredential GetCredentials()
        {
            UserCredential credential;

            using (FileStream stream = new FileStream(@"Properties\credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }

            return credential;
        }

        /// <summary>
        /// Create Drive API service.
        /// This 
        /// </summary>
        /// <returns>
        /// Google Drive Service
        /// </returns>
        private static DriveService GetService()
        {
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = Credential,
                ApplicationName = "bug-tracker",
            });

        }

        private static void InitialiseFiles()
        {
            //Define parameters of request
            FilesResource.ListRequest listRequest = Service.Files.List();
            listRequest.PageSize = 10; // to be changed accordingly when bugs are paginated.
            listRequest.Fields = "nextPageToken, files(id, name)";

            FileList = listRequest.Execute().Files; // initialise the ilist with data form the images located on google drive

            if (FileList != null && FileList.Count > 0)
            {
                foreach (var file in FileList)
                {
                    DownloadImage(file); // for now all files are downloaded and stored locally at runtime.
                }
            }
            else
            {
                MessageBox.Show("No files found.");
            }
        }

        /// <summary>
        /// Downloads file from google drive and stores locally.
        /// This is fine for now but will look into a more efficient method when the number of downloads impacts performance.
        /// </summary>
        /// <param name="file"></param>
        private static void DownloadImage(Google.Apis.Drive.v3.Data.File file)
        {
            using (FileStream stream = new FileStream(file.Name, FileMode.OpenOrCreate))
            {
                var request = Service.Files.Copy(file, file.Id);
            }
        }
    }
}
