using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
