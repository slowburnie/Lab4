using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.help.utils
{
    public static class HelpUtils
    {
        private static readonly string _helpPath = "C:\\Users\\User\\Desktop\\khai\\3kurs2\\spp\\L2\\L2\\helpLab3Docs.chm";

        public static void ShowHelp(Control parent, string topic)
        {
            if (!File.Exists(_helpPath))
            {
                MessageBox.Show("Doc file not found!");
                return;
            }

            Help.ShowHelp(parent, _helpPath, HelpNavigator.Topic, topic);
        }
    }
}
