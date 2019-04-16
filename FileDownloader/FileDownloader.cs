using System.Net;
class FileDownloaderClass
{
    private string url;
    private string targetFile;

    public string URL
    {
        //getter and setter
        get { return url; }
        set {
            if (!string.IsNullOrEmpty(value))
            {
                url = value;
            } else
            {
                throw new System.ArgumentNullException();
            }
          }
    }
    public string DEST
    { 
        get { return targetFile; }
        set {
            if (!string.IsNullOrEmpty(value))
            { targetFile = @"C:\temp\" + value; }
            else { targetFile = @"C:\temp\a.dat"; }
        }
    }

    
    public void DownloadAndSave()
    {
        WebClient wc = new WebClient();
       wc.DownloadFile(new System.Uri( this.URL),this.DEST);
    }
    
}