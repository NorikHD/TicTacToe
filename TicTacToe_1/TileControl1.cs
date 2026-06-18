using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_1
{
    public partial class TileControl1 : UserControl
    {
        public TileControl1()
        {
            InitializeComponent();
        }
        int Counter;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            Counter++;
            Lbl_Counter.Text = Counter.ToString();
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.LightCoral, 5);

            g.DrawRectangle(pen, 10, 10, 150, 150);
        }

        private void TileControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
