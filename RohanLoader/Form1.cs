using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace RohanLoader
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        string connectionInfoMain = "1st Server ip here";
        string connectionInfoTest = "2nd Server ip here";
        string website = "Website here";
        string registerSite = "Register Site here";
        string facebookSite = "Facebook Site here";
        string patchCheckout = @"location of patch info";
        string patchDownloadLink = @"patch location";
        string patchLocation = @"patch.txt";
        string downloadedPatchLocation = @"patch.zip";

        string startPath = @"c:\example\start";
        string zipPath = @"patch.zip";
        string extractPath = @"c:\example\extract";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pingServers();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.QuitBtnActive));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.QuitBtnInactive));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if((rbMainServer.Checked && lblMainServStatus.Text == "Online")||(rbTestServer.Checked && lblTestServStatus.Text == "Online"))
            {
                if (rbMainServer.Checked)
                {
                    try
                    {
                        Process.Start(@"rohanclient", connectionInfoMain);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (rbTestServer.Checked)
                {
                    try
                    {
                        Process.Start(@"rohanclient", connectionInfoTest);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                this.Close();
            }
            else if((rbMainServer.Checked && lblMainServStatus.Text == "Offline")||(rbTestServer.Checked && lblTestServStatus.Text == "Offline"))
            {
                MessageBox.Show("Server you selected is offline. Please select different server.", "Server is offline.");
            }
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.StartButtonActive));
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.StartButtonInActive));
        }
        public void pingServers()
        {
            try
            {
                Ping x = new Ping();
                PingReply reply = x.Send(IPAddress.Parse("1st Server ip here"));
                if (reply.Status == IPStatus.Success)
                {
                    lblMainServStatus.Text = "Online";
                    lblMainServStatus.ForeColor = System.Drawing.Color.LawnGreen;
                }
                else
                {
                    lblMainServStatus.Text = "Offline";
                    lblMainServStatus.ForeColor = System.Drawing.Color.Red;
                }
                Ping xx = new Ping();
                PingReply replyx = xx.Send(IPAddress.Parse("2nd Server ip here"));
                if (replyx.Status == IPStatus.Success)
                {
                    lblTestServStatus.Text = "Online";
                    lblTestServStatus.ForeColor = System.Drawing.Color.LawnGreen;
                }
                else
                {
                    lblTestServStatus.Text = "Offline";
                    lblTestServStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(website);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(registerSite);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(facebookSite);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetPatch();
        }
        public void GetPatch()
        {
            try
            {
                string[] lastPatch = { };
                int PatchId;
                string[] currPatch = { };
                int currPatchId;
                lblStatus.Text = "Checking files";

                WebClient webClient = new WebClient();
                webClient.DownloadFile(patchCheckout + "patch.txt", patchLocation);

                using (StreamReader sr = new StreamReader(patchLocation))
                {
                    lastPatch = sr.ReadToEnd().Split('_');
                }
                PatchId = int.Parse(lastPatch[1]);

                if (!File.Exists("loader.txt"))
                {
                    
                    lblStatus.Text = "Downloading files";
                    for (int i = 1; i <= PatchId; i++)
                    {
                        DownloadFile(i);
                        Decompress(i);
                    }
                    File.Copy("patch.txt", "loader.txt");
                    File.Delete("patch.zip");
                    File.Delete("patch.txt");
                    MessageBox.Show("Patch done.");
                }
                using (StreamReader sr2 = new StreamReader("loader.txt"))
                {
                    currPatch = sr2.ReadToEnd().Split('_');
                }
                currPatchId = int.Parse(lastPatch[1]);
                if (currPatchId != PatchId)
                {
                    lblStatus.Text = "Downloading files";
                    for (int i = 1; i <= PatchId; i++)
                    {
                        DownloadFile(i);
                        Decompress(i);
                    }
                    System.IO.StreamWriter file = new System.IO.StreamWriter("loader.txt");
                    file.WriteLine("patch_" + currPatchId);
                    file.Close();
                    File.Delete("patch.zip");
                    File.Delete("patch.txt");
                    MessageBox.Show("Patch done.");
                }
                lblStatus.Text = "Game is patched";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DownloadFile(int patch_id)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(patchDownloadLink + "patch" + patch_id + ".zip", downloadedPatchLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Decompress(int patch_id)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read("patch.zip"))
                {
                    foreach (ZipEntry e in zip)
                    {
                        //File.Delete(e.FileName);
                        e.Extract(ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CheckBtnActive));
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CheckBtnInActive));
        }
    }
}
