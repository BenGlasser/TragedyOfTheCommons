/* **Author: Ben Glasser
 *   Date:  3/1/2012
 *   File:  ModelGUI.cs
 *   Purpose:  This is the front end GUI for the ABM
 *   Project:  This project attempts to model a phenomemon know as tragedy of the commons 
 *   by allowing heterogeneous agents to buy and sell pollution credits on an open market
 *   as they seek only to satisfy their preference for consumption/pollution.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace TragedyOfCommons
{
    public partial class ModelGUI : Form
    {
        //create output file
        static StreamWriter file = new StreamWriter("agent_log.txt");
        static Rectangle myRect = new Rectangle(new Point(0, 20), new Size(30, 30));
        static int Xinc = 3, Yinc = 2;
        static bool agentSet = false,
                set = false,
                go = false;
        static int PatchDim, numAgents, numRows, 
            PEC, TotalPollution, Income, 
            iterations, TotalMoves, imgNum = 0;
        static Random myRand = new Random();

        static ArrayList AgentList, PatchList;
        static List<Double> PollutionPoints;
      

        SolidBrush myBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
        Bitmap bitMap;

        public ModelGUI()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            //set PAC and PEC values;
            PEC = trackBar_PEC.Value;
            Income = trackBar_Income.Value;
            //initialize lists
            AgentList = new ArrayList();
            PatchList = new ArrayList();
            PollutionPoints = new List<Double>();
            //set pach dimensions to 1/10 of pictureBox.
            numRows = 50;
            PatchDim = pictureBox.Height / numRows;
            //initialize text Box Values
            textBox_Speed.Text = trackBar_Speed.Value.ToString();
            textBox_Agents.Text = trackBar_Agents.Value.ToString();
            textBox_PEC.Text = trackBar_PEC.Value.ToString();
            textBox_Income.Text = trackBar_Income.Value.ToString();
            //init chartsd
            //PollutionChart.Series.FirstOrDefault().Points.Clear();
            //MovesChart.Series.FirstOrDefault().Points.Clear();
            //MovesChart.Series.FirstOrDefault().Points.AddY(0);
            //PollutionChart.Series.FirstOrDefault().Points.AddY(0);
            //initialize tooltips
            
        }
        //TRACKBARS---------------------------------------------------------------------------------------
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (trackBar_Speed.Maximum - trackBar_Speed.Value) + 1;
            textBox_Speed.Text = trackBar_Speed.Value.ToString();
        }
        private void trackBar_Agents_ValueChanged(object sender, EventArgs e)
        {
            textBox_Agents.Text = trackBar_Agents.Value.ToString();
        }
        private void trackBar_PEC_ValueChanged(object sender, EventArgs e)
        {
            textBox_PEC.Text = trackBar_PEC.Value.ToString();
        }
        private void trackBar_Income_ValueChanged(object sender, EventArgs e)
        {
            textBox_Income.Text = trackBar_Income.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int val = -1;
            try
            {
                val = Convert.ToInt32(textBox_Speed.Text);
                if ((val >= 0 || val <= 100))
                    trackBar_Speed.Value = val;
            }
            catch { }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int val = -1;
            try
            {
                val = Convert.ToInt32(textBox_Agents.Text);
                if ((val >= 0 || val <= 100))
                    trackBar_Agents.Value = val;
            }
            catch { }
        }
        private void textBox_PEC_TextChanged(object sender, EventArgs e)
        {
            int val = -1;
            try
            {
                val = Convert.ToInt32(textBox_PEC.Text);
                if ((val >= 0 || val <= 255))
                    trackBar_PEC.Value = val;
            }
            catch { }
        }
        private void textBox_Income_TextChanged(object sender, EventArgs e)
        {

            int val = -1;
            try
            {
                val = Convert.ToInt32(textBox_Income.Text);
                if ((val >= 0 || val <= 255))
                    trackBar_Income.Value = val;
            }
            catch { }

        }


        private void trackBar_Agents_Scroll(object sender, EventArgs e)
        {
            agentSet = true;
        }
        //------------------------------------------------------------------------------------------------
        //BUTTONS-----------------------------------------------------------------------------------------
        private void goButton_CheckedChanged(object sender, EventArgs e)
        {
            go = !go;
            //if (!agentSet) MessageBox.Show("Please Select Number of Agents for Simulation");
            //sets time timer and kick it off
            if (go)
            {
                timer.Interval = (trackBar_Speed.Maximum - trackBar_Speed.Value + 1);
                timer.Start();
            }
            else
                timer.Stop();
            //Thread t = new Thread(iteration);        // Kick off a new thread
            //t.Start();                               // running iteration()


        }
        private void goOnceButton_Click(object sender, EventArgs e)
        {
            //if (!agentSet) MessageBox.Show("Please Select Number of Agents for Simulation");
            iteration();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            init();
            goOnceButton.Enabled =
            goButton.Enabled =
            ResetButton.Enabled =
            SaveButton.Enabled =
            photoButton.Enabled = true;
            numAgents = trackBar_Agents.Value;
            PEC = trackBar_PEC.Value;
            Income = trackBar_Income.Value;
            Thread t = new Thread(setup);          // Kick off a new thread
            t.Start();                             // running setup()

        }
        private void setup()
        {
            PatchList.Clear();
            AgentList.Clear();

            //if (!agentSet) MessageBox.Show("Please Select Number of Agents for Simulation");
            //Populate AgentList
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    //new patch with random incom and vegetation
                    PatchList.Add(new Patch(new Point(j, i)));
                }
            }
            for (int i = 0; i < numAgents; ++i)
            {
                //find an empty patch for agent.
                Patch newHome = ((Patch)(PatchList.ToArray()[myRand.Next(PatchList.Count)]));
                while (!newHome.IsEmpty)
                    newHome = ((Patch)(PatchList.ToArray()[myRand.Next(PatchList.Count)]));
                AgentList.Add(new Agent(newHome, myRand.Next(Income), PEC));
                //put all occupied patches at the front of the list
                PatchList.Remove(newHome);
                PatchList.Insert(0, newHome);
            }

            for (int i = 0; i < PatchList.Count; ++i)
            {
                System.Console.WriteLine(PatchList.ToArray()[i].ToString());
                //MessageBox.Show(PatchList.ToArray()[i].ToString());
            }

            set = true;
            pictureBox.Invalidate();
        }
        //------------------------------------------------------------------------------------------------

        private void timer_Tick(object sender, EventArgs e)
        {
            iteration();
            ballBounce(); /* uncomment this line to see the bouncing ball in the picture box */
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Point windowLocation = new Point(0,0);
            if (set)
            {
                bitMap = new Bitmap(pictureBox.Width, pictureBox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Patch thisPatch = null;
                Graphics picBox = e.Graphics,
                    g = Graphics.FromImage(bitMap);
                for (int i = 0; i < PatchList.Count; ++i)
                {
                    thisPatch = ((Patch)(PatchList.ToArray()[i]));
                    myBrush.Color = Color.FromArgb(0, (255-thisPatch.Pollution), 0);
                    g.FillRectangle(myBrush, new Rectangle(thisPatch.Location.X * numRows, thisPatch.Location.Y * numRows, numRows, numRows));
                }
                //g.FillEllipse(Brushes.Blue, myRect);
                picBox.DrawImage(bitMap, windowLocation);
            }
        }
        //This does nothing it is just a bouncing ball for fun :)
        private void ballBounce()
        {
            if (myRect.Location.X > pictureBox.Width - 30)
                Xinc = Xinc * -1;
            else if (myRect.Location.X < 0)
                Xinc = Xinc * -1;
            if (myRect.Location.Y > pictureBox.Height - 30)
                Yinc = Yinc * -1;
            else if (myRect.Location.Y < 0)
                Yinc = Yinc * -1;

            myRect.X += Xinc;
            myRect.Y += Yinc;

            pictureBox.Invalidate();
        }
        //------------------------------------------------------------------------------------------------
        //ITERATIVE METHODS-------------------------------------------------------------------------------
        private void AgentActions()
        {
            TotalMoves = 0;
            Agent myAgent;
            listView_AgentData.Items.Clear();
            for (int i = 0; i < AgentList.Count; ++i)
            {
                myAgent = ((Agent)(AgentList.ToArray()[i]));
                myAgent.Analyze(myAgent.MyPatch);
                myAgent.Decide(PatchList);
                if (myAgent.Moved) TotalMoves++;
                string[] row = { myAgent.Income.ToString(), 
                               myAgent.PollutionMax.ToString(), myAgent.GrowMax.ToString(),
                               myAgent.Moves.ToString()};
                listView_AgentData.Items.Add(i.ToString()).SubItems.AddRange(row);
            }
            MovesChart.Series.FirstOrDefault().Points.AddY(TotalMoves);
        }
        private void PatchActions()
        {
            TotalPollution = 0;
            Patch myPatch;
            for (int i = 0; i < PatchList.Count; ++i)
            {
                myPatch = ((Patch)(PatchList.ToArray()[i]));
                TotalPollution += myPatch.Pollution;
            }
            PollutionChart.Series.FirstOrDefault().Points.AddY(TotalPollution);
        }
        //------------------------------------------------------------------------------------------------
        private void iteration()
        {
            Agent agent = null;
            AgentActions();
            PatchActions();
            pictureBox.Invalidate();
            iterations++;


            //print log screen and file.
            for (int i = 0; i < AgentList.Count; ++i)
            {
                agent = ((Agent)(AgentList.ToArray()[i]));
                //check for legal pollution vals and warn if out of bounds
                if (agent.MyPatch.Pollution > 255 || agent.MyPatch.Pollution < 0)
                {
                    file.WriteLine("Agent " + i + " is out of bounds.  PAC = " + agent.MyPatch.Pollution.ToString());
                    MessageBox.Show("Agent " + i + " is out of bounds.  PAC = " + agent.MyPatch.Pollution.ToString());
                }
                file.WriteLine("Agent " + i + " pollution total = " + agent.MyPatch.Pollution.ToString());            
            }
        }
        private void photoButton_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            Bitmap myPic = new Bitmap(bitMap);
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Bitmap Image|*.bmp|Jpeg Image|*.jpg|Gif Image|*.gif";
            saveFileDialog1.Title = "Save Image File";
            saveFileDialog1.FileName = "Model_IMG_" + String.Format("{0:00}",imgNum);
            DialogResult res = saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && res != DialogResult.Cancel)
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        switch (GraphTabs.SelectedIndex)
                        {
                            case 0: // Save vizualization
                                myPic.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                imgNum++;
                                break;
                            case 1: // Save Pollution Chart
                                PollutionChart.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                imgNum++;
                                break;
                            case 2:// Save Moves Chart
                                MovesChart.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                imgNum++;
                                break;
                            default:
                                myPic.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                imgNum++;
                                break;
                        }
                        break;
                    case 2:
                        switch (GraphTabs.SelectedIndex)
                        {
                            case 0: // Save vizualization
                                myPic.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                imgNum++;
                                break;
                            case 1: // Save Pollution Chart
                                PollutionChart.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                imgNum++;
                                break;
                            case 2: // Save Moves chart
                                MovesChart.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                imgNum++;
                                break;
                            default:
                                myPic.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                imgNum++;
                                break;
                        }
                        break;
                    case 3:
                        switch (GraphTabs.SelectedIndex)
                        {
                            case 0: // Save vizualization
                                myPic.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                imgNum++;
                                break;
                            case 1: // Save Pollution
                                PollutionChart.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                imgNum++;
                                break;
                            case 2:// Save Moves chart
                                MovesChart.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                imgNum++;
                                break;
                            default:
                                myPic.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                imgNum++;
                                break;
                        }
                        break;
                }

                fs.Close();
            }

        }
        private void chartUpdate()
        {
            Double[] points = (Double[])(PollutionPoints.ToArray());
            Series series = PollutionChart.Series.FirstOrDefault();//.Add("Pollution");
            series.Points.Add(points);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV file|*.csv|Text file|*.txt";
            saveFileDialog1.FileName = "Model_Data_" + String.Format("{0:00}", imgNum);
            saveFileDialog1.Title = "Save Data File";
            DialogResult res = saveFileDialog1.ShowDialog();
                        
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && res != DialogResult.Cancel)
            {
                int size;
                Agent myAgent;
                System.IO.StreamWriter fs =
                   new System.IO.StreamWriter(saveFileDialog1.OpenFile());
                switch (GraphTabs.SelectedIndex)
                {
                    case 0:
                        size = (listView_AgentData.Items.Count);
                        fs.WriteLine("AGENT DATA");
                        fs.WriteLine("Iterations = " + iterations);
                        fs.WriteLine("PEC = " + PEC);
                        fs.WriteLine("Agents = " + numAgents);
                        fs.WriteLine("Patches = " + 100);
                        fs.WriteLine("Agent, Income, Pollution Max, Grow Max, Moves");
                        for (int i = 0; i < size; i++)
                        {
                            myAgent = (Agent)AgentList.ToArray()[i];
                            fs.WriteLine(i.ToString() + "," +
                               myAgent.Income.ToString() + "," +
                               myAgent.PollutionMax.ToString() + "," +
                               myAgent.GrowMax.ToString() + "," +
                               myAgent.Moves.ToString());
                        }
                        fs.Close();
                        imgNum++;
                        break;
                    case 1:
                        size = (PollutionChart.Series.FirstOrDefault().Points.Count);
                        fs.WriteLine("POLLUTION");
                        fs.WriteLine("Iteration, Total Pollution");
                        for (int i = 0; i < size; i++)
                        {
                            fs.WriteLine(i + "," + PollutionChart.Series.FirstOrDefault().Points.ToArray()[i].YValues[0]);
                        }
                        fs.Close();
                        imgNum++;
                        break;
                    case 2:
                        size = (MovesChart.Series.FirstOrDefault().Points.Count);
                        fs.WriteLine("MOVES");
                        fs.WriteLine("Iteration, Moves");
                        for (int i = 0; i < size; i++)
                        {
                            fs.WriteLine(i + "," + MovesChart.Series.FirstOrDefault().Points.ToArray()[i].YValues[0]);
                        }
                        imgNum++;
                        fs.Close();
                        break;
                    case 3:
                        size = (listView_AgentData.Items.Count);
                        fs.WriteLine("AGENT DATA");
                        fs.WriteLine("Iterations = " + iterations);
                        fs.WriteLine("PEC = " + PEC);
                        fs.WriteLine("Agents = " + numAgents);
                        fs.WriteLine("Patches = " + 100);
                        fs.WriteLine("Agent, Income, Pollution Max, Grow Max, Moves");
                        for (int i = 0; i < size; i++)
                        {
                            myAgent = (Agent)AgentList.ToArray()[i];
                            fs.WriteLine(i.ToString() + "," +
                               myAgent.Income.ToString() + "," +
                               myAgent.PollutionMax.ToString() + "," +
                               myAgent.GrowMax.ToString() + "," +
                               myAgent.Moves.ToString());
                        }
                        fs.Close();
                        imgNum++;
                        break;
                }
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            PollutionChart.Series.FirstOrDefault().Points.Clear();
            MovesChart.Series.FirstOrDefault().Points.Clear();
            PollutionChart.Series.FirstOrDefault().Points.Add(1);
            MovesChart.Series.FirstOrDefault().Points.Add(1);
        }




    }
}