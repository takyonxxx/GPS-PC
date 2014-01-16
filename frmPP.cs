using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using Functions;
using Fmod;
namespace ReadGPS
{

    public partial class frmPP : Form
    {

        
#region Member Variables

        // Local variables used to hold the present
        // position as latitude and longitude
        public string Latitude;
        public string Longitude;
        string port = "";
        string compassbar;       

#endregion
#region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public frmPP()
        {
            InitializeComponent();
          
        }

#endregion

                      
        private Graphics g ;
        public string dirName, filename, drive;
        public int maxlenth;
        public float currentlenth;
        private Bitmap imgSkyview ;
        private StringFormat sFormat = new StringFormat();
        private Pen penBlack = new Pen(Color.Black, 1);
        private Pen penGray = new Pen(Color.LightGray, 1);
        int iMargin = 4; //Distance to edge of image
        System.Drawing.Color[] Colors = { Color.Red , Color.Yellow ,  Color.Blue, Color.WhiteSmoke, Color.Red,
											  Color.Red , Color.Yellow,  Color.Blue, Color.WhiteSmoke,Color.Red, 
											  Color.Red , Color.Yellow,  Color.Blue, Color.WhiteSmoke,Color.Red};
       
        public bool ParseGPGSV(string[] lineArr)
        {
 
            string  PseudoRandomCode, Azimuth ,Elevation ,SignalToNoiseRatio;
            string[] Words = lineArr;            
            int Count = 0;
          
                for (Count = 1; Count <= 4; Count++)
                {
                    try
                    {
                        if ((Words.Length - 1) >= (Count * 4 + 3))
                        {

                            if (Words[Count * 4 + 1] != "" & Words[Count * 4 + 2] != "")
                            {

                                Elevation = Words[Count * 4 + 1].ToString();
                                Azimuth = Words[Count * 4 + 2].ToString();
                                if (Words[Count * 4 + 2].ToString() != "" & Words[Count * 4].ToString() != "")
                                {
                                    PseudoRandomCode = Words[Count * 4].ToString();
                                    if (Words[Count * 4 + 3].ToString().Length == 2)
                                    {
                                        SignalToNoiseRatio = Words[Count * 4 + 3].ToString();                                       
                                    }
                                    else
                                        SignalToNoiseRatio = "0";                                    
                                 }
                                else
                                {
                                    PseudoRandomCode = "0";
                                    SignalToNoiseRatio = "0";

                                }
                                // Notify of this satellite's information
                                double ang = 90.0 - Convert.ToDouble(Azimuth.ToString());
                                ang = ang / 180.0 * Math.PI;
                                int x = imgSkyview.Width / 2 + (int)Math.Round((Math.Cos(ang) * ((90.0 - Convert.ToInt32(Elevation.ToString())) / 90.0) * (imgSkyview.Width / 2.0 - iMargin)));
                                int y = imgSkyview.Height / 2 - (int)Math.Round((Math.Sin(ang) * ((90.0 - Convert.ToInt32(Elevation.ToString())) / 90.0) * (imgSkyview.Height / 2.0 - iMargin)));
                                g.FillEllipse(new System.Drawing.SolidBrush(Colors[Convert.ToInt32( Words[2].ToString())]), x - 1, y - 1,10,10);
                                g.DrawString("    " + PseudoRandomCode.ToString() + " - " + SignalToNoiseRatio.ToString(), new Font("Tahoma", 7, FontStyle.Regular), new System.Drawing.SolidBrush(Color.White), x, y, sFormat);
                                //g.FillRectangle(new System.Drawing.SolidBrush(Colors[3]), Count * 5, 0, 5, Convert.ToInt32(SignalToNoiseRatio.ToString()));
                               
                                
                            }
                        }
                    }
                    catch { }
                }

            picGSVSkyview.Image = imgSkyview;      
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BRate.Text = serialPort1.BaudRate.ToString();
            //Generate sky view    
            imgSkyview = new Bitmap(picGSVSkyview.Width, picGSVSkyview.Height);      
            g = Graphics.FromImage(imgSkyview);
            g.Clear(Color.Black);
            g.DrawEllipse(penGray, 0, 0, imgSkyview.Width - 1, imgSkyview.Height - 1);
            g.DrawEllipse(penGray, imgSkyview.Width / 4, imgSkyview.Height / 4, imgSkyview.Width / 2, imgSkyview.Height / 2);
            g.DrawLine(penGray, imgSkyview.Width / 2, 0, imgSkyview.Width / 2, imgSkyview.Height);
            g.DrawLine(penGray, 0, imgSkyview.Height / 2, imgSkyview.Width, imgSkyview.Height / 2);
            sFormat.LineAlignment = StringAlignment.Near;
            sFormat.Alignment = StringAlignment.Near;
            if (serialPort1.IsOpen)
            {
                string data = serialPort1.ReadExisting();
                label3.Text = data.ToString();
                string[] strArr = data.Split('$');
                for (int i = 0; i < strArr.Length; i++)
                {
                    string strTemp = strArr[i];
                    string[] lineArr = strTemp.Split(',');
                  
                        if (lineArr[0].ToString() == "GPGSV")
                        {
                            ParseGPGSV(lineArr);
                            try
                            {
                                if (lineArr[3].ToString() != "" & lineArr[7].ToString() != "")
                                {
                                   
                                    if (lineArr[3].ToString().Length == 2)
                                        satnumber.Text = lineArr[3].ToString();
                                    signal.Text = lineArr[7].Substring(0, 2).ToString() + " DB";
                                    
                                }
                            }catch {}
                        }
                        if (lineArr[0].ToString() == "GPRMC")
                        {

                            if (lineArr[2].ToString() != "")
                            {
                                satstatus.Text = lineArr[2].ToString();
                            }
                            else satstatus.Text = "No data";

                            if (lineArr[7].ToString() != "")
                            {

                                double Speed = Convert.ToDouble(lineArr[7]) * 1.852;
                                int ss = Convert.ToInt32(Speed);
                                speedtxt.Text = ss.ToString();
                            }
                            else speedtxt.Text = "0";
                            if (lineArr[8].ToString() != "")
                            {
                                compassbar = lineArr[8].ToString();
                                compass.Text = Convert.ToInt32(Convert.ToDouble(compassbar)).ToString();

                                //pictureBoxPoint.Left = (int)(645 + 100 * Math.Sin(Convert.ToDouble(compassbar) * Math.PI / 180));
                                //pictureBoxPoint.Top = (int)(131 - 100 * Math.Cos(Convert.ToDouble(compassbar) * Math.PI / 180));
                            }
                            else compass.Text = "No data";

                        }
                        if (lineArr[0].ToString() == "GPGGA")
                        {
                            if (lineArr[2].ToString() != "" & lineArr[3].ToString() != "" & lineArr[4].ToString() != "" & lineArr[5].ToString() != "")
                            {
                                try
                                {
                                    //Latitude
                                    Double dLat = Convert.ToDouble(lineArr[2]);
                                    dLat = dLat / 100;
                                    string[] lat = dLat.ToString().Split('.');
                                    Latitude = lineArr[3].ToString() + " " + lat[0].ToString() + "." + ((Convert.ToDouble(lat[1]) / 60)).ToString("#####");

                                    //Longitude
                                    Double dLon = Convert.ToDouble(lineArr[4]);
                                    dLon = dLon / 100;
                                    string[] lon = dLon.ToString().Split('.');
                                    Longitude = lineArr[5].ToString() + " " + lon[0].ToString() + "." + ((Convert.ToDouble(lon[1]) / 60)).ToString("#####");
                                    txtLat.Text = Latitude.ToString();
                                    txtLong.Text = Longitude.ToString();
                                }
                                catch
                                {
                                    txtLat.Text = "No data";
                                    txtLong.Text = "No data";
                                }
                            }
                            if (lineArr[9] != "")
                            {
                                double alt = Convert.ToDouble(lineArr[9].ToString());
                                int altint = Convert.ToInt32(alt);
                                alttxt.Text = altint.ToString();
                            }
                            else alttxt.Text = "0";
                            if (lineArr[6].ToString() != "")
                            {
                                switch (lineArr[6].ToString())
                                {
                                    case ("0"):
                                        gps_fix.Text = "Not fix";
                                        break;
                                    case ("1"):
                                        gps_fix.Text = "GPS fix (SPS)";
                                        break;
                                    case ("2"):
                                        gps_fix.Text = "DGPS fix";
                                        break;
                                    case ("3"):
                                        gps_fix.Text = "PPS fix";
                                        break;
                                    case ("4"):
                                        gps_fix.Text = "Real Time Kinematic";
                                        break;
                                    case ("5"):
                                        gps_fix.Text = "Float RTK";
                                        break;
                                    case ("6"):
                                        gps_fix.Text = "Estimated";
                                        break;
                                    case ("7"):
                                        gps_fix.Text = "Manual input mode";
                                        break;
                                    case ("8"):
                                        gps_fix.Text = "Simulation mode";
                                        break;
                                }
                            }
                            if (lineArr[1].ToString() != "")
                            {
                                int UtcHours = Convert.ToInt32(lineArr[1].Substring(0, 2));
                                int UtcMinutes = Convert.ToInt32(lineArr[1].Substring(2, 2));
                                int UtcSeconds = Convert.ToInt32(lineArr[1].Substring(4, 2));
                                int UtcMilliseconds;
                                // Extract milliseconds if it is available 
                                if (lineArr[1].Length > 7)
                                {
                                    UtcMilliseconds = Convert.ToInt32(lineArr[1].Substring(7));
                                }
                                // Now build a DateTime object with all values 
                                DateTime Today = System.DateTime.Now.ToUniversalTime();
                                System.DateTime SatelliteTime = new System.DateTime(Today.Year, Today.Month, Today.Day, UtcHours, UtcMinutes, UtcSeconds, 0);
                                sattime.Text = SatelliteTime.ToLocalTime().ToString();
                            }

                        }
                   

                }
            }
            else
            {
                txtLat.Text = "COM Port Closed";
                txtLong.Text = "COM Port Closed";

            }
            
        }


        /// <summary>
        /// Enable or disable the timer to start continuous
        /// updates or disable all updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                label3.Text = "";
            }   
            else
            {
                timer1.Enabled = true;
            }

            if (button1.Text == "Update")
                button1.Text = "Stop Updates";
            else
                button1.Text = "Update";
        }


        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        
        private void frmPP_Load(object sender, EventArgs e)
        {       
            int i,k;
            bool found_sign = true;
            serialPort1.BaudRate = 38400;
            for (i = 1; i < 10; i++)
            {
                try
                {
                    port = "COM" + i.ToString();
                    serialPort1.Close();
                    serialPort1.PortName = port;
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        
                        k = 0;
                        while (found_sign)
                        {
                            string data = serialPort1.ReadExisting();
                            gps_status.Text = "Searching Gps on " + port + " Try: " + k;
                            Thread.Sleep(100);
                            if (data.IndexOf("$", 0)==0 || k>=25)                            
                            {
                                found_sign = false;
                                if (k >= 25)
                                {
                                    timer1.Enabled = false;
                                    gps_status.Text = "GPS NOT FOUND...";
                                }
                                else
                                {
                                    timer1.Enabled = true;
                                    gps_status.Text = "GPS CONNECTED ON " + port;
                                    i = 11;
                                    k = 26;
                                }
                            }
                            k++;
                            Application.DoEvents();
                        }
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message,port);                    
                }
            }
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            F_MOD.FSOUND_Close();
            this.Dispose();
        }

        private void openMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMap f = new frmMap(Latitude, Longitude);
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 250;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 750;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 2400;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 4800;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 19200;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 38400;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 57600;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 115200;
        }

        public static IntPtr GetStream(string filename)
        {
            // Get the filename in bytes 
            byte[] filenamebytes = System.Text.Encoding.Default.GetBytes(filename + null);

            // Get a handle depending on which framework we are using 
            GCHandle hfile = GCHandle.Alloc(filenamebytes, GCHandleType.Pinned);
            if (Environment.Version.Major == 1) return new IntPtr(hfile.AddrOfPinnedObject().ToInt32() + 4);
            else return hfile.AddrOfPinnedObject();
        }



        private void start_mp3()
        {    
                  
 
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();            
            Int32 lendirectory;
            dirName = null;
            filename = null;
            listBox1.Items.Clear();
            fdlg.Title = "C# Help";
            fdlg.InitialDirectory = @"D:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                dirName = System.IO.Path.GetDirectoryName(fdlg.FileName);
                filename = System.IO.Path.GetFileName(fdlg.FileName);
                drive = dirName.Split(System.IO.Path.VolumeSeparatorChar)[0];
            }
              
            SuperString startFolder = dirName;
            lendirectory = dirName.Length;
            List<string> dirs = GetFilesRecursive(startFolder.ToString());
            foreach (SuperString p in dirs)
            {
               listBox1.Items.Add(p.Mid(lendirectory+1));
            }
            if (listBox1.Items.Count != 0)
            {
                listBox1.SelectedIndex = 0;
                btn_start.Enabled = true;
                btn_start.Text = "PAUSE";
                timer2.Enabled = true;
            }
           
        }
        public static List<string> GetFilesRecursive(string b)
        {
            
            List<string> result = new List<string>();           
            Stack<string> stack = new Stack<string>();
            stack.Push(b);          
            while (stack.Count > 0)
            {
               
                string dir = stack.Pop();
                try
                {
                    
                    result.AddRange(Directory.GetFiles(dir, "*.*"));                   
                    foreach (string dn in Directory.GetDirectories(dir))
                    {
                        stack.Push(dn);
                    }
                }
                catch
                {                   
                }
            }
            return result;
        }
        public IntPtr soundStream, soundHandle, speccy;
       
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(listBox1.Items.Count!=0)
                {
                    btn_start.Enabled = true;
                    if (btn_start.Text == "PLAY")
                    {
                        if (F_MOD.FSOUND_SetPaused(0, true))
                        {
                            F_MOD.FSOUND_SetPaused(0, false);
                            btn_start.Text = "PAUSE";
                        }
                        else
                        {
                            btn_start.Text = "PAUSE";
                            string filepath = @dirName + "\\" + listBox1.SelectedItem.ToString();
                            IntPtr i = new IntPtr(0);
                            F_MOD.FSOUND_Init(44100, 16, 0);
                            soundStream = GetStream(filepath);
                            soundHandle = F_MOD.FSOUND_Stream_Open(soundStream, 0x100, 0, 0);
                            F_MOD.FSOUND_Stream_Play(0, soundHandle);
                        }
                    }
                    else
                    {
                        F_MOD.FSOUND_SetPaused(0, true);
                        btn_start.Text = "PLAY";
                    }
              
                }
                else btn_start.Enabled = false;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                btn_start.Text = "PAUSE";
                string filepath = @dirName + "\\" + listBox1.SelectedItem.ToString();
                IntPtr i = new IntPtr(0);
                F_MOD.FSOUND_Init(44100, 16, 0);
                soundStream = GetStream(filepath);
                soundHandle = F_MOD.FSOUND_Stream_Open(soundStream, 0x100, 0, 0);
                F_MOD.FSOUND_Stream_Play(0, soundHandle);
                maxlenth = F_MOD.FSOUND_Stream_GetLengthMs(soundHandle) / 1000;
                progressBar1.Maximum = maxlenth;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            txt_mp3status.Text = "Rem: " + (maxlenth-(F_MOD.FSOUND_Stream_GetTime(soundHandle) / 1000)).ToString () + " Sec";
            progressBar1.Value=F_MOD.FSOUND_Stream_GetTime(soundHandle) / 1000;
            if (progressBar1.Value == maxlenth)
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {
           
                try
                {
                    uint val = (uint)((e.X * 100) / progressBar1.Width);
                    currentlenth = F_MOD.FSOUND_Stream_GetTime(soundHandle) / 1000 ;
                    F_MOD.FSOUND_Stream_SetTime(soundHandle, (int)(val * maxlenth / 100) * 1000);                                 
                   
                }
                catch (Exception ex)
                {
                   
                }
           
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex+1<listBox1.Items.Count)
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
        }        
       
    }  
    
}