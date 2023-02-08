using System.Text;

namespace Client.Utils
{
    public class Banner : Models.Util
    {
        
        public override string UtilName => "Banner";
        public override string Desc => "Display banner";
        public override string UtilExecute(string[] opts)
        {
            StringBuilder _out = new StringBuilder();

           _out.AppendLine(
                @" _______              ________      _______  ________      " + "\n" +
                @"|___   /   _______   |   ___  \    /  _____| \_____  \      " + "\n" +
                @"   /  /   /  ___  \  |  |   \  |  |  /        /  ____/     " + "\n" +
                @"  /  /   |  /   \  | |  |    | |  |  |       /       \      " + "\n" +
                @" /  /__  |  \___/  | |  |___/  |  |  \_____  \_______ \       " + "\n" +
                @"/______|  \_______/  |________/    \_______|         \/" + "\n" +
                $"\tVer: {Models.Client.Ver} \n\tAuthor: Grimmie\n"
            );

            return _out.ToString();
        }

    }
}
