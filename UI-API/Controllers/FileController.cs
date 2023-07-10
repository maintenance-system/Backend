﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.DataObjects;
using BL.Utils;

[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    //private readonly DBContext Context;
    //Status Status;


    public FileController(/*DBContext Context*/)
    {
        //this.Context = Context;
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

            //Context.Files.Add(fileEntity);
            //await Context.SaveChangesAsync();

            return Ok(fileEntity.UrlFile);
        }
        else
        {
            return BadRequest("No file uploaded");

        }

    }

    [HttpGet("UrlsByStatus")]
    public IActionResult GetUrlsByStatus(string status)
    {
        var Urls = 0;//= /*Context.Files*/
            /*.Where(file => file.Status == status)
            .Select(file => file.UrlFile)
            .ToList();*/
       
        return Ok(Urls);
    }
  
}


