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
    public class SteamUser
    {
        public string UserName { get; set; }
        public string ID { get; set; }
    }
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        List<SteamUser> userList = new List<SteamUser>();
        private void OpenLogBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("UserProfile") + @"\Documents\My Games\Rocket League\TAGame\Logs\";
            if (Directory.Exists(path))
            {
                folderBrowserDialog1.SelectedPath = path;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                IEnumerable<string> logFiles = Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, "*.log");
                foreach(string fileName in logFiles)
                {
                    LogListBox.Items.Add(fileName);
                }
            }
        }

        private void LogListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserListBox.DataSource = null;
            userList.Clear();
            UserListBox.Items.Clear();
            if (LogListBox.SelectedItems.Count == 1)
            {
                string currentLogFile = LogListBox.SelectedItem.ToString();
                try
                {
                    IEnumerable<string> lines = File.ReadLines(currentLogFile);
                    foreach (string line in lines)
                    {
                        Match match = Regex.Match(line, @"Name=(.+?) ID=Steam-(.+?)-0");
                        if (match.Success)
                        {
                            SteamUser user = new SteamUser { UserName = match.Groups[1].Value, ID = match.Groups[2].Value };
                            if (!userList.Exists(listUser => listUser.UserName == user.UserName))
                            {
                                userList.Add(user);
                            }
                        }
                    }
                    UserListBox.DataSource = userList;
                    UserListBox.DisplayMember = "UserName";
                    UserListBox.ValueMember = "ID";
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserListBox_DoubleClick(object sender, EventArgs e)
        {
            if(UserListBox.SelectedItems.Count == 1)
            {
                SteamUser selected = (SteamUser) UserListBox.SelectedItem;
                System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/" + selected.ID);
            }
        }
    }
}
