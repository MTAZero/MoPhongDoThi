using MoPhongDoThi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.GUI
{
    public partial class FrmVeDoThi : Form
    {

        #region constructor
        private DoThi dothi = new DoThi();
        public FrmVeDoThi()
        {
            InitializeComponent();
        }

        public FrmVeDoThi(DoThi dt)
        {
            InitializeComponent();
            dothi = dt;
        }
        #endregion

        #region paint
        private void FrmVeDoThi_Paint(object sender, PaintEventArgs e)
        {
            dothi.Draw(e);
        }
        #endregion
    }
}
