namespace iProspect.TestApp.Abstractions
{
    public interface IJob
    {
        void Run( string sourcePath, string outputPath );
    }
}