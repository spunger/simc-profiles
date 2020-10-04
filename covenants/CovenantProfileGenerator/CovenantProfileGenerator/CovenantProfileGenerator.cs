using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovenantProfileGenerator
{
    public partial class CovenantProfileGenerator : Form
    {
        Profile profile;
        List<SpecProfileUserControl> specUserControls = new List<SpecProfileUserControl>();

        public CovenantProfileGenerator()
        {
            InitializeComponent();


        }
        private void InitProfile()
        {
            if (String.IsNullOrWhiteSpace(tbPathTemplate.Text))
                return;

            profile = new Profile(tbPathTemplate.Text);
            profileBindingSource.DataSource = profile;

            ResetSpecTabPages();
            specUserControls = new List<SpecProfileUserControl>();

            foreach (var specProfile in profile.SpecProfiles)
                AddSpecProfileTabPage(specProfile);

            tbNamePrefix.Text = "ProfileXyz";
            tbPathResult.Text = ConfigurationManager.AppSettings["defaultPathResult"];
            tbPathProfiles.Text = ConfigurationManager.AppSettings["defaultPathProfile"];
            cbOutputHtml.Checked = cbOutputJson.Checked = cbOutputText.Checked = true;
        }
        private void ResetSpecTabPages()
        {
            for (int i = tcMain.TabPages.Count-1; i == 1; i-- )
                tcMain.TabPages.RemoveAt(i);

        }
        private void AddSpecProfileTabPage(SpecProfile specProfile)
        {
            var tabPage = new TabPage(specProfile.Name);
            var specProfileUserControl = new SpecProfileUserControl();
            specProfileUserControl.Dock = DockStyle.Fill;
            specProfileUserControl.SpecProfile = specProfile;
            specProfileUserControl.Parent = tabPage;
            specUserControls.Add(specProfileUserControl);
            tcMain.TabPages.Add(tabPage);
        }
        private string SelectFolder(string defaultPath)
        {
            using (var dlg = new CommonOpenFileDialog())
            {
                dlg.IsFolderPicker = true;
                dlg.DefaultDirectory = defaultPath;
                
                if (dlg.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(dlg.FileName))
                {
                    return dlg.FileName;
                }
            }
            return null;
        }

        private void btnSelectPathTemplate_Click(object sender, EventArgs e)
        {
            tbPathTemplate.Text = SelectFolder(ConfigurationManager.AppSettings["defaultPathTemplate"]);
            InitProfile();
        }
        private void btnSelectPathProfiles_Click(object sender, EventArgs e)
        {
            tbPathProfiles.Text = SelectFolder(ConfigurationManager.AppSettings["defaultPathProfile"]);
        }
        private void btnSelectPathResult_Click(object sender, EventArgs e)
        {
            tbPathResult.Text = SelectFolder(ConfigurationManager.AppSettings["defaultPathResults"]);
        }

        private void tbOptionsRankConduits_Leave(object sender, EventArgs e)
        {
            if (profile == null)
                return;

            specUserControls.ForEach((x) => x.RefreshSpecProfile());
        }

        private void btnGenerateProfiles_Click(object sender, EventArgs e)
        {
            if (profile == null)
                return;

            profile.GenerateProfiles();
        }
    }
}
