using Microsoft.AspNetCore.Mvc;
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
}
