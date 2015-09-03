using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RocketLeagueRecentPlayed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("UserProfile") + @"\Documents\My Games\Rocket League\TAGame\Logs\";
            if (Directory.Exists(path))
            {
                folderBrowserDialog1.SelectedPath = path;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string[] logFiles = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach(string fileName in logFiles)
                {
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.SelectedItems.Count == 1)
            {
                string currentLogFile = listBox1.SelectedItem.ToString();
                StreamReader file = new StreamReader(currentLogFile);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Match match = Regex.Match(line, @"Name=(.+?) ID=Steam-(.+?)-0");
                    if (match.Success)
                    {
                        //SteamUser user = new SteamUser { name = match.Groups[1].Value, id = match.Groups[2].Value };
                        if (!listBox2.Items.Contains(match.Value))
                        {
                            listBox2.Items.Add(match.Value);
                        }
                    }
                }
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if(listBox2.SelectedItems.Count == 1)
            {
                Match match = Regex.Match(listBox2.SelectedItem.ToString(), @"Name=(.+?) ID=Steam-(.+?)-0");
                System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/" + match.Groups[2].Value);
            }
        }
    }
}
