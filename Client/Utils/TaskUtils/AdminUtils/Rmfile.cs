﻿using Client.Models;

using static Client.Models.Client;

namespace Client.Utils
{
    class Rmfile : Models.AdminTask
    {
        private string targetFile { get; set; }
        public override string TaskName => "RmFile";

        public override string Desc => "Removes a file";

        public override string AdminUtilExec(string[] opts)
        {
            try
            {

                if (opts is null) { throw new ZodException($"[*] Usage: RmFile [targetFile]\n"); }
                if (!(opts.Length == 2)) { throw new ZodException($"[*] Usage: RmFile [targetFile]\n"); }
                if (CurrentImplant is null) { throw new ZodException("[-] No connected implant"); }

                targetFile = opts[1];

                return TaskOps.sendAdminUtil(TaskName, targetFile);
            }
            catch (ZodException e) { return e.Message; }
        }
    }
}
