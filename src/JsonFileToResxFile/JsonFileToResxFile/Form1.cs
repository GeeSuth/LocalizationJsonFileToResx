using System.Text.RegularExpressions;

namespace JsonFileToResxFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            richTextResx.Clear();

            if (richTextJson.Text.Length == 0)
                return;

            if (txtTemplate.Text.Trim().Length == 0)
            {
                MessageBox.Show("Warning","Please fill the template field inside the template tab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var JsonLines = richTextJson.Text.Split("\n");

            foreach (var item in JsonLines)
            {
                string line = item.Trim();
                var matches = Regex.Matches(line, txtRegex.Text); // regex of key and value
                if (matches.Count != 2)
                    continue;

                string key = matches[0].Value.Replace("\"","");
                string value = matches[1].Value.Replace("\"", "");

                richTextResx.Text += GenerateTag(key,value);
            }

        }

        private string GenerateTag(string key, string value)
        {
            return txtTemplate.Text
                .Replace("$key$", key)
                .Replace("$value$", value)
                + "\n";
        }
    }
}