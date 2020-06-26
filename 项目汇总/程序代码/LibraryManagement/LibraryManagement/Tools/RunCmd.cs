namespace LibraryManagement.Tools
{
    class RunCmd
    {
        public string runCmd(string mysqldumPath, string strCmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = mysqldumPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(strCmd);
            p.StandardInput.WriteLine("exit");
            return p.StandardError.ReadToEnd();
        }
    }
}
