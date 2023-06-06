using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace UI_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FileController : WorksBaceController
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
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileUrl = $"http://localhost:5029/{filePath}";

            return Ok(fileUrl);
        }

    }
}
