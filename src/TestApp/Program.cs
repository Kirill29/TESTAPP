using System;
using Autofac;
using iProspect.TestApp.Abstractions;
using iProspect.TestApp.Implementations;
namespace iProspect.TestApp
{
    internal static class Program
    {
        public static void Main()
        {
            using ( var container = AppContainerBuilder.Build() )
            {
                Console.WriteLine( "Enter source file path" );

                var sourcePath = Console.ReadLine();
                if (!ValidFilePaths.IsSourcePathValid(sourcePath))
                {
                    Console.WriteLine("Invalid source file path!");
                }

                Console.WriteLine( "Enter output file path" );
                var outputPath = Console.ReadLine();
                if (!ValidFilePaths.IsOutputPathValid(outputPath))
                {
                    Console.WriteLine("Invalid output file path!");
                }

                if (ValidFilePaths.IsOutputPathValid(outputPath) && ValidFilePaths.IsSourcePathValid(sourcePath))
                {
                    var job = container.Resolve<IJob>();
                    job.Run(sourcePath, outputPath);
                }

               
              

               
            }
        }
    }
}