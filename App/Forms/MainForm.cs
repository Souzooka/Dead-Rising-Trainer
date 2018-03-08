using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using QuickPoke.Forms;




//#===================================GLOBAL CODE======================================================================
namespace Ascension.Forms.Dialog.Extras
{
    public partial class MainForm : Form
    {
        TreeNode OFF = new TreeNode();
        TreeNode OFF2 = new TreeNode();
        public MainForm()
        {
            InitializeComponent();
            ShowIcon = false;
            this.MaximizeBox = false;
            { }
        }
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void xex_offset_manager_Load(object sender, EventArgs e)
        {
        }
        //#===================================GLOBAL CODE=================================================================

        private void connectBtn_Click(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName("DeadRising");
            Process process;

            if (processes.Length == 0)
            {
                connectTxt.Text = "Not connected!";
            }
            else
            {
                //TODO: store process on some sort of static variable

                process = processes[0];
                connectTxt.Text = $"Connected to PID {process.Id.ToString("X8")}";
            }
        }

        //close program code KEEP
        private void pictureBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new ChangeLog().ShowDialog(); //keep
        }

        private void Gamesave_Click(object sender, EventArgs e)
        { }//keep

        private void mousedrag_Paint(object sender, PaintEventArgs e)
        { }//keep

        private void mousedrag_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void mousedrag_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;//keep
        }

        private void mousedrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y); //keep
            }
        }

        private void label56_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y); //keep
        }

        private void label56_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; //keep
        }

        private void label56_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) //keep
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y); //keep
            }
        }

        private void label55_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y); //keep
        }

        private void label55_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; //keep
        }

        private void label55_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) //keep
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //keep
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close(); //keep
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            versionTxt.ForeColor = Color.Orange;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            versionTxt.ForeColor = Color.Silver;
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void label10_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Orange;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Orange;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void FunctionsBeta_Click(object sender, EventArgs e)
        { }//KEEP

        private void Modifiers_Click(object sender, EventArgs e)
        { }//keep

        private void TOOL_DEBUG_Click(object sender, EventArgs e)
        { }//keep

        private void commandline_Click(object sender, EventArgs e)
        { }//keep

        private void label_debug_Console_ID_Click(object sender, EventArgs e)
        { }//keep

        private void commandline_MouseClick(object sender, MouseEventArgs e)
        {
            commandline.Clear(); //KEEP
        }

        private void commandline_KeyPress(object sender, KeyPressEventArgs e)
        { }//keep


        //===========DEBUG COMMAND LINE CODE==========================================================
        #region
        //|
        //|
        //|
        //|
        private void commandline_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (commandline.Text == ("quit"))
                    this.Close();
                //////////////////////////////////////////////////////////////////////////////////////
                else
                if (commandline.Text == ("close"))
                    MainTabControl.Controls.Remove(TOOL_DEBUG);
            }
        }
        //===========DEBUG COMMAND LINE==========================================================
        //|
        //|
        //|
        //|
        //examples metrotabcontrol functions:
        /////////////////////////////////////
        //metroTabControl1.EnableTab(Poke);
        //metroTabControl1.DisableTab(Poke);
        //metroTabControl1.HideTab(Poke);
        //metroTabControl1.ShowTab(Poke);
        //if (MainTabControl.SelectedTab == Poke)
        //MainTabControl.Size = new System.Drawing.Size(517, 323);
        //ActiveForm.Size = new Size(517, 333); //new size
        /////////////////////////////////////

        //loading a form into a panel:
        /////////////////////////////////////
        //panel5.Controls.Clear();
        //ModifierForm mod = new ModifierForm();
        //mod.TopLevel = false;
        //panel5.Controls.Add(mod);
        //mod.Show();
        /////////////////////////////////////
        #endregion


        private void commandline_TextChanged(object sender, EventArgs e)
        { }//keep

        private void metroTabControl1_KeyDown(object sender, KeyEventArgs e)
        { }//keep

        private void FunctionsBeta_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        { }//keep

        private void mousedrag_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        { }//keep

        private void xex_offset_manager_KeyDown(object sender, KeyEventArgs e)
        { }//keep

        private void button2_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = PAGE1; //KEEP
        }

        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (TEST.Checked == true)
            {
                MessageBox.Show("Shit, you did something.");
            }
            else
            {
                MessageBox.Show("Still something i guess?");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainTabControl.Controls.Remove(TOOL_DEBUG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just an example bro");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just an example bro");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = PAGE2; //KEEP
        }
    }
}
