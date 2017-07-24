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

        /*
         * get the data from database
         * and populate data in gridview on click of a button
         */
        private void button1_Click(object sender, EventArgs e)
        {
            // change color of alternate rows of gridview
            QBuildGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            //create a new connection to database
            search db = new search();
            // returns the selected node
            var tree = QBuildTreeView.SelectedNode.Name;
            // set the label to full path of selected node
            parentLabel.Text = "Parent Child Part: " + QBuildTreeView.SelectedNode.FullPath;
            // change color of parent node label
            parentLabel.ForeColor = Color.Red;
            // change color of current node label
            currentBodyLabel.ForeColor = Color.Green;
            // set the current label to selected node text
            currentBodyLabel.Text = "Current Part: "+ tree;

           
            // query to join the part and bom tables and return the selected columns
            // using the entity framework to query the database
            var  result = (  from bom in db.boms
                             where bom.PARENT_NAME == tree
                             join part in db.parts
                             on bom.COMPONENT_NAME equals part.NAME
                          select new
                          {
                              bom.PARENT_NAME,
                              bom.COMPONENT_NAME,
                              part.PART_NUMBER,
                              part.TITLE,
                              bom.QUANTITY,
                              part.TYPE,
                              part.ITEM,
                              part.MATERIAL
                          }).ToList();

            // populate the gridview with query result
                QBuildGridView.DataSource = result;

            
            // disable the populate button after the query is done
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
