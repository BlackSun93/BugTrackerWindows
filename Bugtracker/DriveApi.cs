using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
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
        private static DriveApi _instance; // single instance of class

        // If modifying these scopes, delete your previously saved credentials at ~/bin/debug/credentials.json
        string[] scopes = { DriveService.Scope.DriveReadonly, DriveService.Scope.Drive }; // Holds the chosen scope(s) used to interact with google drive files
        UserCredential credential; // Holds the access token needed to access google drive
        DriveService service; // Used to create, search and download files from the google drive
        IList<Google.Apis.Drive.v3.Data.File> fileList; // Allows files to be referenced by index without storing locally

        public static DriveApi GetDriveService()
        {
            if (_instance == null)
            {
                _instance = new DriveApi();
                _instance.InitialiseDrive();
            }

            return _instance;
        }

        /// <summary>
        /// Called only when the instance of class is created.
        /// Authenticates user & the google drive service and saves all image metadata to an Ilist.
        /// </summary>
        private void InitialiseDrive()
        {
            credential = GetCredentials();
            service = GetService();
            InitialiseFiles();
        }

        private UserCredential GetCredentials()
        {
            UserCredential credential;

            using (FileStream stream = new FileStream(@"Properties\credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }

            return credential;
        }

        /// <summary>
        /// Create Drive API service.
        /// This is used to interact with files on the google drive.
        /// </summary>
        /// <returns>
        /// Google Drive Service
        /// </returns>
        private DriveService GetService()
        {
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "bug-tracker",
            });

        }

        /// <summary>
        /// Reads all files on the google drive.
        /// These can be referenced through an Ilist.
        /// </summary>
        private void InitialiseFiles()
        {
            //Define parameters of request
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10; // to be changed accordingly when bugs are paginated.
            listRequest.Fields = "nextPageToken, files(id, name)";

            fileList = listRequest.Execute().Files; // initialise the ilist with data form the images located on google drive

            if (fileList != null && fileList.Count > 0)
            {
                foreach (var file in fileList)
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
        private void DownloadImage(Google.Apis.Drive.v3.Data.File file)
        {
            FileStream stream = new FileStream(file.Name, FileMode.OpenOrCreate); // the stream must remain open for the lifetime of the image 

            var request = service.Files.Get(file.Id);
            request.DownloadWithStatus(stream);
        }


        public Google.Apis.Drive.v3.Data.File UploadFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.JPG)| *.JPG";
            string filePath = openFile.FileName;

            if (System.IO.File.Exists(filePath))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = Path.GetFileName(filePath);
                body.MimeType = "image/jpeg";
                byte[] byteArray = System.IO.File.ReadAllBytes(filePath);
                MemoryStream stream = new MemoryStream(byteArray);
                try
                {
                    FilesResource.CreateMediaUpload request = service.Files.Create(body, stream, body.MimeType);
                    request.SupportsTeamDrives = true;
                    // You can bind event handler with progress changed event and response recieved(completed event)
                    //request.ProgressChanged += Request_ProgressChanged;
                    //request.ResponseReceived += Request_ResponseReceived;
                    request.Upload();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error Occured");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.", "404");
                return null;
            }
        }

    }
}
