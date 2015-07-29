using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SertificateManager.BLL.DTO;


namespace SertificateManager.PL
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        public CreateForm(SertificateDTO stf)
        {
            InitializeComponent();
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
        private void createBtn_Click(object sender, EventArgs e)
        {
            SertificateDTO stf = new SertificateDTO
            {
                MySertificateId = idTB.Text.ToString(),
                EstimatedTime = EstTimeTB.Text.ToString(),
                Name = NameTB.Text.ToString(),
                SertificateTag = TagTB.Text.ToString(),
                Creator = CreatorTB.Text.ToString(),
                Owner = OwnerTB.Text.ToString(),
                QualityDocument = DocTB.Text.ToString(),
                Items = ItemsTB.Text.ToString(),
                Validator = ValidatorTB.Text.ToString(),
                ValidateTime = ValidTimeTB.Text.ToString()
            };

            Data.CreateEventHandler(stf);
            this.Close();
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
