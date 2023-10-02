using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Face_Recognition_App
{
    public partial class DataViewer : Form
    {
        public DataViewer()
        {
            InitializeComponent();
        }

        private void DataViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faceDataSet.faces' table. You can move, or remove it, as needed.
            this.facesTableAdapter.Fill(this.faceDataSet.faces);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
