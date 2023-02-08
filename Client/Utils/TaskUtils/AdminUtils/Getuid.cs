using Client.Models;

using static Client.Models.Client;

namespace Client.Utils
{
    class Getuid : Models.AdminTask
    {
        public override string TaskName => "Getuid";

        public override string Desc => "Fetch user id of user running implant process";

        public override string AdminUtilExec(string[] opts)
        {
            try
            {

                if (opts != null && !(opts.Length > 1)) { throw new ZodException($"[*] Usage: Getuid\n"); }
                if (CurrentImplant is null) { throw new ZodException("[-] No connected implant"); }

                return TaskOps.sendAdminUtil(TaskName);

            }
            catch (ZodException e) { return e.Message; }
        }
    }
}
