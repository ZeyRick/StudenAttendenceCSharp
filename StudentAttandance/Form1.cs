using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttandance
{
    public partial class Form1 : Form
    {
        //Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DraginForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //functions oppen child form
        private Form activeForm = null;
        private void OpenChildform(Form childForm)
        {
            if(activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the Application?", "confirm"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            OpenChildform(new frmAddClasses());
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            OpenChildform(new frmAddSubject());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenChildform(new frmAddStudent());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OpenChildform(new frmAttendence());
        }

        private void FullScreenbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
             

            }
            else this.WindowState = FormWindowState.Normal;
        }
    }
}
