using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP1._1
{
    class Proxy : IDownload
    {
        private Download downloaded = new Download();
        public List<string> urls = new List<string>();
        public List<string> imageName = new List<string>();
        public int i;

        //counts the number of links in urls
        public void CountImages(int i)
        {
            GetImage(imageName[i],urls[i]);
        }
        
        //downlaods teh image
        public void GetImage(string fileName, string url)
        {
            downloaded.GetImage(fileName, url);
        }
    }
}
