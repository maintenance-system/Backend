using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BL.Utils;

public class ReadApiPython
{

    public ReadApiPython()
    {

    }
    public string ReadFromPython()
    {
        var url = "http://127.0.0.1:5000/";

        var request = WebRequest.Create(url);
        request.Method = "GET";

        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();

        using var reader = new StreamReader(webStream);
        var data = reader.ReadToEnd();

       // Console.WriteLine(data);
        return data;
    }
    
}
