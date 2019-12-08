using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmtest
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        Panel a ;
        bool isCollaped = true;
        private void timer1_Tick(object sender, EventArgs e)
        {

          if(isCollaped)
            {
                a.Height += 10;
                if(a.Size == a.MaximumSize)
                {
                    timer1.Stop();
                    isCollaped = false;
                }
            }
          else
            {
                a.Height -= 10;
                if (a.Size == a.MinimumSize)
                {
                    timer1.Stop();
                    isCollaped = true;
                }
            }
            
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            a = pnlChicken;
            timer1.Start();
            pnlChicken = a;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            timer1.Start();
            numericUpDown1.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value += 1;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value -= 1;
        }

        private void btnTableChoosen_Click(object sender, EventArgs e)
        {

            pnlOnchoosentable.Visible = true;
            pnlOnFoods.Visible = false;
            pnlOnDrinks.Visible = false;
            pnlOncombo.Visible = false;
            pnlOnChange.Visible = false;
            pnlOnPayment.Visible = false;
            if(pnlOnchoosentable.Visible)
            {
                pnlTableChoosenArlert.BackColor = Color.LawnGreen;
                pnlFoodsArlert.BackColor = Color.Red;
                pnlDrinksArlert.BackColor = Color.Red;
                pnlComboArlert.BackColor = Color.Red;
                pnlChangeArlert.BackColor = Color.Red;
                pnlPaymentArlert.BackColor = Color.Red;
            }
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {

            pnlOnchoosentable.Visible = false;
            pnlOnFoods.Visible = true;
            pnlOnDrinks.Visible = false;
            pnlOncombo.Visible = false;
            pnlOnChange.Visible = false;
            pnlOnPayment.Visible = false;
            if(pnlOnFoods.Visible)
            {
                pnlTableChoosenArlert.BackColor = Color.Red;
                pnlFoodsArlert.BackColor = Color.LawnGreen;
                pnlDrinksArlert.BackColor = Color.Red;
                pnlComboArlert.BackColor = Color.Red;
                pnlChangeArlert.BackColor = Color.Red;
                pnlPaymentArlert.BackColor = Color.Red;
            }
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {

            pnlOnchoosentable.Visible = false;
            pnlOnFoods.Visible = false;
            pnlOnDrinks.Visible = true;
            pnlOncombo.Visible = false;
            pnlOnChange.Visible = false;
            pnlOnPayment.Visible = false;
            if(pnlOnDrinks.Visible)
            {
                pnlTableChoosenArlert.BackColor = Color.Red;
                pnlFoodsArlert.BackColor = Color.Red;
                pnlDrinksArlert.BackColor = Color.LawnGreen;
                pnlComboArlert.BackColor = Color.Red;
                pnlChangeArlert.BackColor = Color.Red;
                pnlPaymentArlert.BackColor = Color.Red;
            }
        }

        private void btnConbo_Click(object sender, EventArgs e)
        {

            pnlOnchoosentable.Visible = false;
            pnlOnFoods.Visible = false;
            pnlOnDrinks.Visible = false;
            pnlOncombo.Visible = true;
            pnlOnChange.Visible = false;
            pnlOnPayment.Visible = false;
            if(pnlOncombo.Visible)
            {
                pnlTableChoosenArlert.BackColor = Color.Red;
                pnlFoodsArlert.BackColor = Color.Red;
                pnlDrinksArlert.BackColor = Color.Red;
                pnlComboArlert.BackColor = Color.LawnGreen;
                pnlChangeArlert.BackColor = Color.Red;
                pnlPaymentArlert.BackColor = Color.Red;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            pnlOnchoosentable.Visible = false;
            pnlOnFoods.Visible = false;
            pnlOnDrinks.Visible = false;
            pnlOncombo.Visible = false;
            pnlOnChange.Visible = true;
            pnlOnPayment.Visible = false;
            if(pnlOnChange.Visible)
            {
                pnlTableChoosenArlert.BackColor = Color.Red;
                pnlFoodsArlert.BackColor = Color.Red;
                pnlDrinksArlert.BackColor = Color.Red;
                pnlComboArlert.BackColor = Color.Red;
                pnlChangeArlert.BackColor = Color.LawnGreen;
                pnlPaymentArlert.BackColor = Color.Red;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

            pnlOnchoosentable.Visible = false;
            pnlOnFoods.Visible = false;
            pnlOnDrinks.Visible = false;
            pnlOncombo.Visible = false;
            pnlOnChange.Visible = false;
            pnlOnPayment.Visible = true;
            if (pnlOnPayment.Visible)
            {
                pnlTableChoosenArlert.BackColor = Color.Red;
                pnlFoodsArlert.BackColor = Color.Red;
                pnlDrinksArlert.BackColor = Color.Red;
                pnlComboArlert.BackColor = Color.Red;
                pnlChangeArlert.BackColor = Color.Red;
                pnlPaymentArlert.BackColor = Color.LawnGreen;
            }
        }

        private void btnOrder_click(object sender, EventArgs e)
        {
            //Button but = sender as Button;
            //Panel pan = sender as Panel;
            //pan.Location = but.Location;
            //pan.Show();
          
            a = pnlChicken;
            timer1.Start();
            pnlChicken = a;
        }

        private void Chonban_click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            if(but.BackColor == Color.White)
            {
                but.BackColor = Color.Red;
                lblsoban.Text = but.Text + lblsoban.Text;
            }
            else
            {
                but.BackColor = Color.White;
              
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmTabledetais f = new frmTabledetais();
            f.Show();
        }
    }
}
