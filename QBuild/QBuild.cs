using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QBuild.Models;

namespace QBuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qBuildDataSet.bom' table. You can move, or remove it, as needed.
            this.bomTableAdapter.Fill(this.qBuildDataSet.bom);

            search db = new search();

            var list = (from quantity in db.boms select quantity).ToList();

            dataGridView1.DataSource = list;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bomTableAdapter.FillBy(this.qBuildDataSet.bom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
