using System.IO;
using System.Windows.Forms;

namespace Client.Utils
{
    public static class HelpUtils
    {
        private static readonly string _helpPath = "C:\\Users\\User\\Desktop\\khai\\3kurs2\\spp\\L2\\Client\\help\\Lab3Docs.chm";

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