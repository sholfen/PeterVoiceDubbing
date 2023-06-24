using BlazorBootstrap;
using Microsoft.Extensions.Configuration;

namespace PeterVoiceDubbingWebAP.Data
{
    public class VideoService
    {
        private readonly IConfiguration _configuration;

        public VideoService()
        {
            string jsonPath = "videolist.json";
            ConfigurationManager configurationManager = new ConfigurationManager();
            var configBuilder = configurationManager.AddJsonFile(jsonPath);
            _configuration = configBuilder.Build();
            string baseUrl = _configuration.GetValue<string>("baseUrl");
            VideoData.BaseUrl = baseUrl;
        }

        public List<VideoData> GetList() 
        {
            List<VideoData> videoDatas = _configuration.GetSection("list").Get<List<VideoData>>();
            return videoDatas;
        }
    }
}
