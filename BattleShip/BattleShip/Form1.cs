using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        int number = 0;

        public Form1()
        {
            InitializeComponent();

            //_drawingPanel.Paint += _drawingPanel_Paint;
            Click += Form1_Click;
            _tblPanel.Click += _tblPanel_Click;
            //_btnTestME.Click += _btnTestME_Click;
            MouseClick += Form1_MouseClick;
            _tblPanel.MouseClick += _tblPanel_MouseClick;
            Load += Form1_Load;

            //Host button
            _btnHost.Click += _btnHost_Click;

            //Connect button
            _btnConnect.Click += _btnConnect_Click;
        }

        //Connect to server
        private void _btnConnect_Click(object sender, EventArgs e)
        {
            //Connect to  the server

            //create a new socket
            Socket connectSocket = null;

            //ensure that the supplied string is an IPAddress
            if (IPAddress.TryParse(_tbIPAddress.Text, out IPAddress address))
            {
                //if there supplied socket is null....
                if (connectSocket is null)
                {
                    //used for timing the progress bar for timeout
                    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                    stopwatch.Restart();

                    //build a client socket
                    connectSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    try
                    {
                        //attempt a connection to the server
                        connectSocket.BeginConnect(_tbIPAddress.Text, 1666, ConnectComplete, connectSocket);

                        ////wait 10 seconds, then inform the user that the connection attempt has timed out
                        //while (pbrConnectionTimer.Value < pbrConnectionTimer.Maximum && !connectSocket.Connected)
                        //{
                        //    //move the progress bar every 500 ms
                        //    if (stopwatch.ElapsedMilliseconds > 500)
                        //    {
                        //        pbrConnectionTimer.PerformStep();
                        //        stopwatch.Restart();
                        //    }

                        //    //display timeout message
                        //    if (pbrConnectionTimer.Value >= pbrConnectionTimer.Maximum)
                        //    {
                        //        MessageBox.Show("Connection Timeout");
                        //        return;
                        //    }

                        //}
                    }
                    catch (Exception eMessage)
                    {
                        MessageBox.Show(eMessage.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Invlalid IP Address");
                _tbIPAddress.Text = "";
            }
            //check if ipaddress

            //connect
            //new socket
            //begin connect
            //callback connect
            //end connect
            //success/failure
        }

        /// <summary>
        /// callback for the BeginConnect call 
        /// </summary>
        /// <param name="ar">BeginConnect response</param>
        private void ConnectComplete(IAsyncResult ar)
        {
            //unpack object as a socket
            Socket sock = (Socket)(ar.AsyncState);

            //Invoke(new delVoidInt(UpdateProgress), pbrConnectionTimer.Maximum);

            ////end the pending asynchronous connection request and update the UI
            //try
            //{
            //    sock.EndConnect(ar);

            //    Invoke(new delVoidBoolString(ConnectResult), true, "Success");

            //}
            //catch (Exception eMessage)
            //{
            //    //something bad happened, should deal with it
            //    Invoke(new delVoidBoolString(ConnectResult), false, eMessage.Message);
            //}
        }

        //Turns this machine into a server
        private void _btnHost_Click(object sender, EventArgs e)
        {
            //Start listening for client connection
                //create new socket
                //bind
                //listen
                //begin accept
                    //accept callback receives a socket
                        //socket is sent to handle accept method
                            //sets the socket to the global socket
                            //start the thread
                            //start the client connection to this server
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool red = true;

            for (int i = 0; i < _tblPanel.ColumnCount; ++i)
            {
                for (int j = 0; j < _tblPanel.RowCount; ++j)
                {
                    Cell c = new Cell(red ? Color.Red : Color.Blue);
                    red = !red;
                    _tblPanel.Controls.Add(c);
                }
            }
        }

        

        private void _tblPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(_tblPanel.GetControlFromPosition(;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location);
        }

        private void _btnTestME_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(_btnTestME.Location);
        }

        private void _tblPanel_Click(object sender, EventArgs e)
        {
            //number++;
            //Button test = new Button();
            //test.Text = number.ToString();
            //test.Click += Test_Click;
            //_tblPanel.Controls.Add(test);
            //Console.WriteLine(_tblPanel.GetCellPosition);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Console.WriteLine((sender as Button).Location);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //_drawingPanel.Visible = !_drawingPanel.Visible;
            //_tblPanel.col
            //Console.WriteLine()
        }

        private void _drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 1), new Rectangle(25, 25, 25, 30));
        }
    }
}
