using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += ShopForm_KeyDown;
        }
        private void ShopForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                Close();
            }
        }

    }
}
