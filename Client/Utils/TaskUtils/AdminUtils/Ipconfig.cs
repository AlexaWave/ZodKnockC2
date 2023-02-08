﻿using Client.Models;

using static Client.Models.Client;

namespace Client.Utils
{
    class Ipconfig : Models.AdminTask
    {
        public override string TaskName => "Ipconfig";

        public override string Desc => "Fetch data on local network interfaces";

        public override string AdminUtilExec(string[] opts)
        {
            try
            {

                if (opts != null && !(opts.Length > 1)) { throw new ZodException($"[*] Usage: Ipconfig\n"); }
                if (CurrentImplant is null) { throw new ZodException("[-] No connected implant"); }

                return TaskOps.sendAdminUtil(TaskName);

            }
            catch (ZodException e) { return e.Message; }
        }
    }
}
