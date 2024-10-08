namespace Backup_Program
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new BackupProgramMainForm());
        }
    }
}