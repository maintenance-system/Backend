using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.Utils;

namespace UI_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UtilsController : ControllerBase
{
    [HttpGet]
    public string GetStr()
    {
        ReadApiPython rap = new();
        string s = rap.ReadFromPython();
        return s;
    }
}
