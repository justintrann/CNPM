using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_lichsu : Form
    {
        int listViewOffset;

        public form_dashboard_lichsu()
        {
            InitializeComponent();
            listViewOffset = 24;

        }

        private void form_history_Resize(object sender, EventArgs e)
        {
            listViewProductIn.Width = getNewListViewWidth();
            listViewProductIn.Height = getNewListViewHeight();
            listViewProductOut.Width = getNewListViewWidth() - 11;
            listViewProductOut.Height = getNewListViewHeight();

            listViewProductOut.Location = new Point(this.Width / 2, listViewProductOut.Location.Y);
        }

        private int getNewListViewWidth()
        {
            return this.Width / 2 - listViewOffset;
        }

        private int getNewListViewHeight()
        {
            return this.Height - 117;
        }
    }
}
