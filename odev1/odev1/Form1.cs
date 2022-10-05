using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double trDogru, trYanlis, trNet, matDogru, matYanlis, matNet;

       

        private void txtMatYanlis_TextChanged(object sender, EventArgs e)
        {
            matYanlis=Convert.ToDouble(txtMatYanlis.Text);
            matNet = matDogru - matYanlis / 4;
            txtMatNet.Text= matNet.ToString();  
        }

        private void txtMatDogru_TextChanged(object sender, EventArgs e)
        {
            matDogru=Convert.ToDouble(txtMatDogru.Text);
        }

        private void txtTrDogru_TextChanged(object sender, EventArgs e)
        {
            trDogru=Convert.ToDouble(txtTrDogru.Text);
        }

        private void txtTrYanlis_TextChanged(object sender, EventArgs e)
        {
            trYanlis = Convert.ToDouble(txtTrYanlis.Text);
            trNet = trDogru - trYanlis / 4;
            txtTrNet.Text = trNet.ToString();
        }
    }
}
