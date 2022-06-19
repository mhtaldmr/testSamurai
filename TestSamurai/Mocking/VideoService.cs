using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestSamurai.Mocking
{

    public class VideoService
    {
        private readonly IFileReader _fileReader;

        public VideoService(IFileReader fileReader = null)
        {
            _fileReader = fileReader ?? new FileReader();
        }

        public string ReadVideoTitle()
        {
            string? str = _fileReader.Read("video.txt");
            Video? video = JsonConvert.DeserializeObject< Video>(str);
            return video == null ? "Error parsing the video." : video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            List<int>? videoIds = new();

            using VideoContext? context = new();
            var videos =
                (from video in context.Videos
                 where !video.IsProcessed
                 select video).ToList();

            foreach (var v in videos)
            {
                videoIds.Add(v.Id);
            }

            return string.Join(",", videoIds);
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }

}
