using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationTest
{
    public class FileHelper
    {

        /// <summary>
        /// 遍历目录
        /// </summary>
        public static void listDirectory(DirectoryInfo directoryInfo)
        {
      
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach(var file in fileInfo)
            {
                Console.WriteLine("文件名：" + file.FullName);
            }
            DirectoryInfo[] subInfo = directoryInfo.GetDirectories();
            foreach (var directory in subInfo)
            {
                Console.WriteLine("目录：" + directory.FullName);
                listDirectory(directory);
            }

        }
    }
}
