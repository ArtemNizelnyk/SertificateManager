using Ninject;
using SertificateManager.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelGenerator;

namespace SertificateManager.PL
{
    public partial class HomeForm : Form
    {
        IService sertificateService;
        public HomeForm(IService serv)
        {
            sertificateService = serv;
            InitializeComponent();
            Data.SearchEventHandler = new Data.SearchEvent(Find);
            Data.CreateEventHandler = new Data.CreateEvent(Create);
        }

        private void Create(BLL.DTO.SertificateDTO stfM)
        {
            this.sertificateService.MakeSertificate(stfM);
            Find(stfM.MySertificateId);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.sertificateService.Dispose();
        }

        private void getAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EnableAll(getAllToolStripMenuItem);
            tabControl1.SelectedTab = tabPage2;
            this.sertificateBindingSource.DataSource = new BindingList<SertificateManager.BLL.DTO.SertificateDTO>(this.sertificateService.GetSertificates());
            this.dataGridView.DataSource = this.sertificateBindingSource.DataSource;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EnableAll(findToolStripMenuItem);
            SearchForm f = new SearchForm(); // создаем
            f.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // EnableAll(printToolStripMenuItem);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EnableAll(newToolStripMenuItem);
            CreateForm f = new CreateForm(); // создаем
            f.ShowDialog();
        }

        public void Find(string id)
        {
            SertificateManager.BLL.DTO.SertificateDTO sertificate = this.sertificateService.GetSertificate(id);
            FillForm(sertificate);
            tabControl1.SelectedTab = tabPage3;
            
            
        }
        /* public void EnableAll(ToolStripMenuItem item)
         {
             newToolStripMenuItem.Enabled = true;
             printToolStripMenuItem.Enabled = true;
             findToolStripMenuItem.Enabled = true;
             getAllToolStripMenuItem.Enabled = true;
             item.Enabled = false;
         }*/
        public void FillForm(SertificateManager.BLL.DTO.SertificateDTO stf)
        {
            idTB.Text = stf.MySertificateId;
            EstTimeTB.Text = stf.EstimatedTime;
            NameTB.Text = stf.Name;
            TagTB.Text = stf.SertificateTag;
            CreatorTB.Text = stf.Creator;
            OwnerTB.Text = stf.Owner;
            DocTB.Text = stf.QualityDocument;
            ItemsTB.Text = stf.Items;
            ValidatorTB.Text = stf.Validator;
            ValidTimeTB.Text = stf.ValidateTime;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити свідоцтво №"+this.idTB.Text, "Видалення", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.sertificateService.Delete(this.idTB.Text);
                tabControl1.SelectedTab = tabPage2;
                this.sertificateBindingSource.DataSource = new BindingList<SertificateManager.BLL.DTO.SertificateDTO>(this.sertificateService.GetSertificates());
                this.dataGridView.DataSource = this.sertificateBindingSource.DataSource;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            SertificateManager.BLL.DTO.SertificateDTO stf = this.sertificateService.GetSertificate(this.idTB.Text);
            CreateForm f = new CreateForm(stf); // создаем
            f.ShowDialog();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            SertificateManager.BLL.DTO.SertificateDTO stf = this.sertificateService.GetSertificate(this.idTB.Text);
            ExcelGenerator.ExcelGenerator.DisplayInExcel(stf);
        }

    }
}
