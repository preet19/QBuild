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
    public partial class QBuildForm : Form
    {
        public QBuildForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qBuildDataSet.bom' table. You can move, or remove it, as needed.
            this.bomTableAdapter.Fill(this.qBuildDataSet.bom);

           

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

        private void button1_Click(object sender, EventArgs e)
        {
            QBuildGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            search db = new search();
            var tree = treeView1.SelectedNode.Name;
            parentLabel.Text = "Parent Child Part: " + treeView1.SelectedNode.FullPath;
            parentLabel.ForeColor = Color.Red;
            currentBodyLabel.ForeColor = Color.Green;
            currentBodyLabel.Text = "Current Part: "+ tree;

            // var list = (from bom in db.boms where bom.PARENT_NAME==tree  select bom).ToList();

            var  result = (from lang in db.boms
                             where lang.PARENT_NAME == tree
                             join c in db.parts
                             on lang.PARENT_NAME equals c.NAME
                          select new
                          {
                              lang.PARENT_NAME,
                              lang.COMPONENT_NAME,
                              c.PART_NUMBER,
                              c.TITLE,
                              lang.QUANTITY,
                              c.TYPE,
                              c.ITEM,
                              c.MATERIAL
                          }).ToList();

                QBuildGridView.DataSource = result;

            //dataGridView1.DataSource = list;

            populateDataButton.Enabled = false;
            

            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
