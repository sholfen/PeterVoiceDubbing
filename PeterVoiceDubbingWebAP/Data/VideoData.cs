namespace PeterVoiceDubbingWebAP.Data
{
    public class VideoData
    {
        public static string BaseUrl = string.Empty;

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string VideoUrl => BaseUrl + Url;
    }
}
