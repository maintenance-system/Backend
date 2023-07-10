using DAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BL.Implementation;

internal class File
{
    public async Task<IActionResult> readFile(IFormFile file)
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
        }
    }
}
