using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Diagnostics;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace QuickPoke.Forms
{
    public partial class ChangeLog : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        public ChangeLog()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Orange;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Silver;
        }

        private void changelog_Load(object sender, EventArgs e)
        {}//KEEP

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Orange;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Silver;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
