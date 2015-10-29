using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace FileDownload.Models
{
    public class DownloadFiles
    {
        public List<DownloadFileInformation> GetFiles()
        {
            var lstFiles = new List<DownloadFileInformation>();

            DirectoryInfo dirInfo = new DirectoryInfo(HostingEnvironment.MapPath("~/MyFiles"));

            int i = 0;
            foreach (var item in dirInfo.GetFiles())
            {
                lstFiles.Add(new DownloadFileInformation()
                    {
                        FileId = i + 1,
                        FileName = item.Name,
                        FilePath = dirInfo.FullName + @"\" + item.Name

                    });

                i++;
            }
            return lstFiles;
        }


    }
}