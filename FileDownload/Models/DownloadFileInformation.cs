using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileDownload.Models
{
    public class DownloadFileInformation
    {
        public int FileId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

    }
}