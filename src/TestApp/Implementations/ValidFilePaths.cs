using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iProspect.TestApp.Abstractions;

namespace iProspect.TestApp.Implementations
{
    public static  class ValidFilePaths 
    {
        public static  bool IsOutputPathValid(string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                return true;
            }
            return false;
        }

        public static   bool IsSourcePathValid(string sourcePath)
        {
          
            if (File.Exists(sourcePath) && Path.GetExtension(sourcePath) == ".csv")
            {
                return true;
            }
            return false;
        }
    }
}
