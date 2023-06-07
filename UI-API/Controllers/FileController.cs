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

[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    /*private readonly YourDbContext _dbContext;

    public FileController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFile(IFormFile file)
    {
        if (file != null && file.Length > 0)
        {
            // Save or process the file as needed
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine("uploads", fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Store the file URL in the database
            var fileEntity = new FileEntity
            {
                FileName = fileName,
                FilePath = filePath,
                FileUrl = GetFileUrl(filePath) // Provide the appropriate method to generate the file URL
            };

            _dbContext.FileEntities.Add(fileEntity);
            await _dbContext.SaveChangesAsync();

            return Ok(fileEntity.FileUrl);
        }

        return BadRequest("No file uploaded");
    }*/
}

