using iProspect.TestApp.Abstractions;
using System;
using System.Collections.Generic;
namespace iProspect.TestApp.Implementations
{
    internal sealed class Job : IJob
    {
        private readonly IFileProvider fileProvider;
        private readonly IConverter converter;

        public Job( IFileProvider fileProvider, IConverter converter )
        {
            this.fileProvider = fileProvider;
            this.converter = converter;
        }

        public void Run( string sourcePath, string outputPath )
        {
            var source = fileProvider.Load( sourcePath );
            var outputFile = converter.Convert( source );
            fileProvider.Save( outputFile, outputPath );
        }
    }
}