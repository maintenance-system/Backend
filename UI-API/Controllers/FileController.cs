/*using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using System.Threading.Tasks;

namespace UI_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FileController : BaseController
    {
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                return BadRequest("No file was uploaded.");
            }

            // Process the uploaded file, store it, and get the URL
            // This is just an example, you will need to implement the storage logic based on your requirements
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine("uploads", fileName);
            // using (FileStream stream = new(filePath, FileMode.Create))
            FileStream fs = new(filePath, FileMode.Create); 
            
                await file.CopyToAsync(fs);
            

            var fileUrl = $"http://localhost:5029/{filePath}";

            return Ok(fileUrl);
        }

    }
}*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.DataObjects;
using BL.Utils;
using static BL.Utils.Status;

[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
   private readonly DBContext Context;
    Status Status;

    public FileController(DBContext Context)
    {
        Context = Context;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFile(IFormFile file)
    {
        if (file != null && file.Length > 0)
        {
            // Save or process the file as needed
            //var fileName = Guid.NewGuid().ToString();// + Path.GetExtension(file.FileName);
            var fileName = file.FileName;
            //var filePath = Path.Combine("uploads", fileName);
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var uploadDirectory = Path.Combine(rootPath, "uploads");
            Directory.CreateDirectory(uploadDirectory);
            var filePath = Path.Combine(uploadDirectory, fileName);
            using (FileStream stream = new(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }


            // Store the file URL in the database
            var fileEntity = new Files()
            {
                NameFile = fileName,
                PathFile = filePath,
                //UrlFile = GetFileUrl(filePath),
                UrlFile = filePath,
                Status = "Pending"
            };

            Context.Files.Add(fileEntity);
            await Context.SaveChangesAsync();

            return Ok(fileEntity.UrlFile);
        }
        else
        {
            return BadRequest("No file uploaded");

        }

    }
    /*    private string GetFileUrl(string filePath)
        {
            // Assuming the files are served from a static files directory named "uploads"
            var baseUrl = "https://storage.googleapis.com/bucket-name/filename.jpg";

            // Combine the base URL with the relative file path
            var fileUrl = baseUrl + filePath.Replace("\\", "/");

            return fileUrl;
        }*/

    [HttpGet("UrlsByStatus")]
    public IActionResult GetUrlsByStatus(string status)
    {
        var Urls = Context.Files
            .Where(file => file.Status == status)
            .Select(file => file.UrlFile)
            .ToList();
       
        return Ok(Urls);
    }
  
}


