using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Repository.DAL;
using Procurement.Controllers;
using System.Reflection;

namespace Procurement
{
    public partial class FrmBOM : Form
    {
        DataTable _dtSalesBOM;
        DataTable _dtDesignBOM;
        decimal _projectCode;
        public FrmBOM()
        {
            InitializeComponent();
        }

        private void FrmBOM_Load(object sender, EventArgs e)
        {
            try
            {
                ProjectController pc = new ProjectController();
                List<Project> oblst = pc.GetModels();
                //insert into the list
                dataGridViewProjects.DataSource = oblst;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void LoadBOM_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg_im = new OpenFileDialog();
                dlg_im.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
                //dlg_im.Filter = "Excel File|*.xlsx";

                if (dlg_im.ShowDialog() == DialogResult.OK)
                {
                    //dataGridView1.Rows.Clear();
                    textBox1.Text = dlg_im.FileName;


                    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    OleDbConnection Con = new OleDbConnection(constr);

                    Con.Open();

                    // Get the name of the first worksheet:
                    DataTable dbSchema = Con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dbSchema == null || dbSchema.Rows.Count < 1)
                    {
                        throw new Exception("Error: Could not determine the name of the first worksheet.");
                    }
                    string firstSheetName = dbSchema.Rows[0]["TABLE_NAME"].ToString();



                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + firstSheetName + "]", Con);



                    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                    _dtSalesBOM = new DataTable();
                    sda.Fill(_dtSalesBOM);
                    dataGridView1.DataSource = _dtSalesBOM;

                    //dataGridView1.ReadOnly = true;
                    //dataGridView1.Columns[0].Width = 320;
                    //dataGridView1.ClearSelection();
                    Con.Close();
                    //MessageBox.Show("Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //mnuCopyAllToDesignBOM.ShowDropDown();
            //contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MenuStripSaleBOM.Show(Cursor.Position);
            }
        }

        private void mnuCopyAllToDesignBOM_Click(object sender, EventArgs e)
        {
            _dtDesignBOM = new DataTable();
            _dtDesignBOM = _dtSalesBOM.Copy();

            //dataGridView2.DataSource =dataGridView1.DataSource;
            dataGridView2.DataSource = _dtDesignBOM;
            tabControl1.SelectedTab = tabDesignBOM;

        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            //mnuCopyAllToDesignBOM.ShowDropDown();
            //contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MenuStripDesignBOM.Show(Cursor.Position);
            }
        }
        private void mnuCopyAllToActualBOM_Click(object sender, EventArgs e)
        {
            DataTable dtActualBOM = new DataTable();
            dtActualBOM = _dtDesignBOM.Copy();

            //dataGridView2.DataSource =dataGridView1.DataSource;
            dataGridView3.DataSource = dtActualBOM;
            tabControl1.SelectedTab = tabActualBOM;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Project projModel = FillProjectModel();
            ProjectController pc = new ProjectController(projModel);
            pc.Save();
            //------------------
            BOMController bc;
            List<BOM> LstObjBom;

            LstObjBom = FillBOMModel1(projModel.ProjectCode);
            bc = new BOMController(LstObjBom);
            bc.SaveList();
            //---
            LstObjBom = FillBOMModel2(projModel.ProjectCode);
            bc = new BOMController(LstObjBom);
            bc.SaveList();
            //---
            LstObjBom = FillBOMModel3(projModel.ProjectCode);
            bc = new BOMController(LstObjBom);
            bc.SaveList();
        }
        private List<BOM> FillBOMModel1(decimal pProjectModel)
        {
            List<BOM> LstObjBom = new List<BOM>();
            foreach (DataGridViewRow gvr in dataGridView1.Rows)
            {
                //string colName=gvr.Cells[0].OwningColumn.HeaderText;

                bool isAdd = false;
                for (int i = 0; i < gvr.Cells.Count; i++)
                {
                    if (gvr.Cells[i].Value == null || gvr.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(gvr.Cells[i].Value.ToString()))
                    {
                        isAdd = false;
                    }
                    else
                    {
                        isAdd = true;
                        break;
                    }
                }

                //if (lObjBom.SORef != null && lObjBom.SerialNo != null && lObjBom.ProductCategory != null && lObjBom.Product != null && lObjBom.CostHead != null && lObjBom.CostSubHead != null
                //     && lObjBom.System != null && lObjBom.Area != null && lObjBom.Panel != null && lObjBom.Description != null && lObjBom.Qty != null && lObjBom.UnitCost != null
                //      && lObjBom.ExCost != null && lObjBom.UnitPrice != null && lObjBom.ExPrice != null)
                //if (!(string.IsNullOrEmpty( gvr.Cells[0].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[1].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[2].Value.ToString())
                //    && string.IsNullOrEmpty(gvr.Cells[3].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[4].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[5].Value.ToString())
                //    && string.IsNullOrEmpty(gvr.Cells[6].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[7].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[8].Value.ToString())
                //    && string.IsNullOrEmpty(gvr.Cells[9].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[10].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[11].Value.ToString())
                //    && string.IsNullOrEmpty(gvr.Cells[12].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[13].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[14].Value.ToString())
                //    && string.IsNullOrEmpty(gvr.Cells[15].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[16].Value.ToString()) && string.IsNullOrEmpty(gvr.Cells[17].Value.ToString())))

                if (isAdd == true)
                {
                    BOM lObjBom = new BOM();
                    //lObjBom.BOMCode = (string)gvr.Cells[0].Value;
                    lObjBom.BOMTypeCode = 1;//(string)gvr.Cells[0].Value;
                    lObjBom.ProjectCode = pProjectModel;

                    lObjBom.SORef = gvr.Cells[0].Value.ToString();
                    lObjBom.SerialNo = gvr.Cells[1].Value.ToString();
                    lObjBom.ProductCategory = gvr.Cells[2].Value.ToString();
                    lObjBom.Product = gvr.Cells[3].Value.ToString();
                    lObjBom.CostHead = gvr.Cells[4].Value.ToString();
                    lObjBom.CostSubHead = gvr.Cells[5].Value.ToString();
                    lObjBom.System = gvr.Cells[6].Value.ToString();
                    lObjBom.Area = gvr.Cells[7].Value.ToString();
                    lObjBom.Panel = gvr.Cells[8].Value.ToString();
                    lObjBom.Category = gvr.Cells[9].Value.ToString();
                    lObjBom.Manufacturer = gvr.Cells[10].Value.ToString();
                    lObjBom.PartNo = gvr.Cells[11].Value.ToString();
                    lObjBom.Description = gvr.Cells[12].Value.ToString();
                    lObjBom.Qty = gvr.Cells[13].Value.ToString();
                    lObjBom.UnitCost = gvr.Cells[14].Value.ToString();
                    lObjBom.ExCost = gvr.Cells[15].Value.ToString();
                    lObjBom.UnitPrice = gvr.Cells[16].Value.ToString();
                    lObjBom.ExPrice = gvr.Cells[17].Value.ToString();

                    LstObjBom.Add(lObjBom);


                }


            }
            return LstObjBom;

        }

        private List<BOM> FillBOMModel2(decimal pProjectModel)
        {
            List<BOM> LstObjBom = new List<BOM>();
            foreach (DataGridViewRow gvr in dataGridView2.Rows)
            {
                //string colName=gvr.Cells[0].OwningColumn.HeaderText;

                bool isAdd = false;
                for (int i = 0; i < gvr.Cells.Count; i++)
                {
                    if (gvr.Cells[i].Value == null || gvr.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(gvr.Cells[i].Value.ToString()))
                    {
                        isAdd = false;
                    }
                    else
                    {
                        isAdd = true;
                        break;
                    }
                }


                if (isAdd == true)
                {
                    BOM lObjBom = new BOM();
                    //lObjBom.BOMCode = (string)gvr.Cells[0].Value;
                    lObjBom.BOMTypeCode = 1;//(string)gvr.Cells[0].Value;
                    lObjBom.ProjectCode = pProjectModel;

                    lObjBom.SORef = gvr.Cells[0].Value.ToString();
                    lObjBom.SerialNo = gvr.Cells[1].Value.ToString();
                    lObjBom.ProductCategory = gvr.Cells[2].Value.ToString();
                    lObjBom.Product = gvr.Cells[3].Value.ToString();
                    lObjBom.CostHead = gvr.Cells[4].Value.ToString();
                    lObjBom.CostSubHead = gvr.Cells[5].Value.ToString();
                    lObjBom.System = gvr.Cells[6].Value.ToString();
                    lObjBom.Area = gvr.Cells[7].Value.ToString();
                    lObjBom.Panel = gvr.Cells[8].Value.ToString();
                    lObjBom.Category = gvr.Cells[9].Value.ToString();
                    lObjBom.Manufacturer = gvr.Cells[10].Value.ToString();
                    lObjBom.PartNo = gvr.Cells[11].Value.ToString();
                    lObjBom.Description = gvr.Cells[12].Value.ToString();
                    lObjBom.Qty = gvr.Cells[13].Value.ToString();
                    lObjBom.UnitCost = gvr.Cells[14].Value.ToString();
                    lObjBom.ExCost = gvr.Cells[15].Value.ToString();
                    lObjBom.UnitPrice = gvr.Cells[16].Value.ToString();
                    lObjBom.ExPrice = gvr.Cells[17].Value.ToString();

                    LstObjBom.Add(lObjBom);


                }


            }
            return LstObjBom;

        }
        private List<BOM> FillBOMModel3(decimal pProjectModel)
        {
            List<BOM> LstObjBom = new List<BOM>();
            foreach (DataGridViewRow gvr in dataGridView3.Rows)
            {
                //string colName=gvr.Cells[0].OwningColumn.HeaderText;

                bool isAdd = false;
                for (int i = 0; i < gvr.Cells.Count; i++)
                {
                    if (gvr.Cells[i].Value == null || gvr.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(gvr.Cells[i].Value.ToString()))
                    {
                        isAdd = false;
                    }
                    else
                    {
                        isAdd = true;
                        break;
                    }
                }

                if (isAdd == true)
                {
                    BOM lObjBom = new BOM();
                    //lObjBom.BOMCode = (string)gvr.Cells[0].Value;
                    lObjBom.BOMTypeCode = 1;//(string)gvr.Cells[0].Value;
                    lObjBom.ProjectCode = pProjectModel;

                    lObjBom.SORef = gvr.Cells[0].Value.ToString();
                    lObjBom.SerialNo = gvr.Cells[1].Value.ToString();
                    lObjBom.ProductCategory = gvr.Cells[2].Value.ToString();
                    lObjBom.Product = gvr.Cells[3].Value.ToString();
                    lObjBom.CostHead = gvr.Cells[4].Value.ToString();
                    lObjBom.CostSubHead = gvr.Cells[5].Value.ToString();
                    lObjBom.System = gvr.Cells[6].Value.ToString();
                    lObjBom.Area = gvr.Cells[7].Value.ToString();
                    lObjBom.Panel = gvr.Cells[8].Value.ToString();
                    lObjBom.Category = gvr.Cells[9].Value.ToString();
                    lObjBom.Manufacturer = gvr.Cells[10].Value.ToString();
                    lObjBom.PartNo = gvr.Cells[11].Value.ToString();
                    lObjBom.Description = gvr.Cells[12].Value.ToString();
                    lObjBom.Qty = gvr.Cells[13].Value.ToString();
                    lObjBom.UnitCost = gvr.Cells[14].Value.ToString();
                    lObjBom.ExCost = gvr.Cells[15].Value.ToString();
                    lObjBom.UnitPrice = gvr.Cells[16].Value.ToString();
                    lObjBom.ExPrice = gvr.Cells[17].Value.ToString();

                    LstObjBom.Add(lObjBom);


                }


            }
            return LstObjBom;

        }
        private Project FillProjectModel()
        {
            Project lObjProj = new Project();
            //lObjProj.ProjectCode = decimal.Parse(txtProjectCode.Text);
            lObjProj.ProjectName = txtProjectName.Text;
            lObjProj.EndUser = txtProjectEndUser.Text;
            lObjProj.Customer = txtProjectCustomerName.Text;
            return lObjProj;

        }

        private void dataGridViewProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewProjects.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewProjects.Rows[selectedrowindex];
                _projectCode = Convert.ToDecimal(selectedRow.Cells["ProjectCode"].Value);
                //MessageBox.Show(a);




                BOMController bc = new BOMController();
                ProjectController pc = new ProjectController();
                //List<BOM> LstObjBom;


                //LstObjBom = FillBOMModel1(projModel.ProjectCode);
                //bc = new BOMController(LstObjBom);

                //lObjBom.SORef = gvr.Cells[0].Value.ToString();
                //lObjBom.SerialNo = gvr.Cells[1].Value.ToString();
                //lObjBom.ProductCategory = gvr.Cells[2].Value.ToString();
                //lObjBom.Product = gvr.Cells[3].Value.ToString();
                //lObjBom.CostHead = gvr.Cells[4].Value.ToString();
                //lObjBom.CostSubHead = gvr.Cells[5].Value.ToString();
                //lObjBom.System = gvr.Cells[6].Value.ToString();
                //lObjBom.Area = gvr.Cells[7].Value.ToString();
                //lObjBom.Panel = gvr.Cells[8].Value.ToString();
                //lObjBom.Category = gvr.Cells[9].Value.ToString();
                //lObjBom.Manufacturer = gvr.Cells[10].Value.ToString();
                //lObjBom.PartNo = gvr.Cells[11].Value.ToString();
                //lObjBom.Description = gvr.Cells[12].Value.ToString();
                //lObjBom.Qty = gvr.Cells[13].Value.ToString();
                //lObjBom.UnitCost = gvr.Cells[14].Value.ToString();
                //lObjBom.ExCost = gvr.Cells[15].Value.ToString();
                //lObjBom.UnitPrice = gvr.Cells[16].Value.ToString();
                //lObjBom.ExPrice = gvr.Cells[17].Value.ToString();



                var source1 = new BindingSource();
                //List<BOM> list = new List<BOM> { new MyStruct("fff", "b"), new MyStruct("c", "d") };
                List<BOM> list = bc.GetModels().Where(x => x.ProjectCode == _projectCode).ToList();

                //public DataTable ToDataTable<T>(List<T> items)
                DataTable UserDt = ToDataTable<BOM>(list);

                //ToDataTable<BOM>(List<BOM> list);
                dataGridView1.DataSource = UserDt;
                //dataGridView1.DataBind();

                //source1.DataSource = list.Where(x => x.BOMTypeCode == 1).Select(x => new
                //{
                //    x.SORef,
                //    x.SerialNo,
                //    x.ProductCategory,
                //    x.Product,
                //    x.CostHead,
                //    x.CostSubHead,
                //    x.System,
                //    x.Area,
                //    x.Panel,
                //    x.Category,
                //    x.Manufacturer,
                //    x.PartNo,
                //    x.Description,
                //    x.Qty,
                //    x.UnitCost,
                //    x.ExCost,
                //    x.UnitPrice,
                //    x.ExPrice
                //});
                //dataGridView1.DataSource = source1;
                //this.dataGridView1.AllowUserToAddRows = true;
                var source2 = new BindingSource();
                source2.DataSource = list.Where(x => x.BOMTypeCode == 2).Select(x => new
                {
                    x.SORef,
                    x.SerialNo,
                    x.ProductCategory,
                    x.Product,
                    x.CostHead,
                    x.CostSubHead,
                    x.System,
                    x.Area,
                    x.Panel,
                    x.Category,
                    x.Manufacturer,
                    x.PartNo,
                    x.Description,
                    x.Qty,
                    x.UnitCost,
                    x.ExCost,
                    x.UnitPrice,
                    x.ExPrice
                });
                dataGridView2.DataSource = source2;
                this.dataGridView2.AllowUserToAddRows = true;
                var source3 = new BindingSource();
                source3.DataSource = list.Where(x => x.BOMTypeCode == 3).Select(x => new
                {
                    x.SORef,
                    x.SerialNo,
                    x.ProductCategory,
                    x.Product,
                    x.CostHead,
                    x.CostSubHead,
                    x.System,
                    x.Area,
                    x.Panel,
                    x.Category,
                    x.Manufacturer,
                    x.PartNo,
                    x.Description,
                    x.Qty,
                    x.UnitCost,
                    x.ExCost,
                    x.UnitPrice,
                    x.ExPrice
                });
                dataGridView3.DataSource = source3;
                this.dataGridView3.AllowUserToAddRows = true;


                Project project = pc.GetModelByID(_projectCode);
                txtProjectCode.Text = project.ProjectCode.ToString();
                txtProjectName.Text = project.ProjectName;
                txtProjectCustomerName.Text = project.Customer;
                txtProjectEndUser.Text = project.Customer;






            }

        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
