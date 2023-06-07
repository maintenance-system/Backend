using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Utils.Status;

namespace BL.DTO
{
    public partial class FilesDTO
    {
        public int Id { get; set; }

        public string? NameFile { get; set; }

        public string UrlFile { get; set; } = null!;

        public string PathFile { get; set; } = null!;

        public FileStatus Status { get; set; } 
    }
}
