using Client.Models;

using static Client.Models.Client;

namespace Client.Utils
{
    class Pwd : Models.AdminTask
    {
        public override string TaskName => "Pwd";

        public override string Desc => "returns the current directory";

        public override string AdminUtilExec(string[] opts)
        {
            try
            {
                if (opts != null && opts.Length > 1) { throw new ZodException($"[*] Usage: Pwd\n"); }
                if (CurrentImplant is null) { throw new ZodException("[-] No connected implant"); }

                return TaskOps.sendAdminUtil(TaskName);

            }
            catch (ZodException e) { return e.Message; }
        }
    }
}
