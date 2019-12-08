using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapaChicken
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == "NhanVien")
                {
                    f.Activate();
                    return;
                }
            }

            NhanVien nv = new NhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == "Quyen")
                {
                    f.Activate();
                    return;
                }
            }
            Quyen q = new Quyen();
            q.MdiParent = this;
            q.Show();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Luong")
                {
                    f.Activate();
                    return;
                }
            }
            Luong l = new Luong();
            l.MdiParent = this;
            l.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0.0");
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "SanPham")
                {
                    f.Activate();
                    return;
                }
            }
            SanPham l = new SanPham();
            l.MdiParent = this;
            l.Show();
        }
    }
}
