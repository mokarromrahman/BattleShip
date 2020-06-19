using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    class Cell:Control
    {
        Color originalColor;
        public Cell(Color color)
        {
            Size = new Size(50, 50);
            BackColor = color;
            originalColor = color;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.Yellow;
        }
        //protected override void OnMouseHover(EventArgs e)
        //{
        //    base.OnMouseHover(e);
        //    this.BackColor = Color.Yellow;
        //}

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = originalColor;
        }
    }
}
