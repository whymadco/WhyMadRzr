using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WhyMad.Models;

namespace WhyMad.Services
{
    public class JsonPostService
    {
        IWebHostEnvironment webHostEnvironment;        

        public JsonPostService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public string jsonFileName
        {
            get { return Path.Combine(webHostEnvironment.WebRootPath, "data", "post"); }
        }

        public List<PostModel> GetPosts()
        {
            using var json = File.OpenText(jsonFileName);
            
            return JsonSerializer.Deserialize<PostModel[]>(json.ReadToEnd()).ToList();
        }
    }
}