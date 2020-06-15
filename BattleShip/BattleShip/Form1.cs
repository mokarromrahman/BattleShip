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
        public Form1()
        {
            InitializeComponent();

            _drawingPanel.Paint += _drawingPanel_Paint;
            Click += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            _drawingPanel.Visible = !_drawingPanel.Visible;
        }

        private void _drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 1), new Rectangle(25, 25, 25, 30));
        }
    }
}
