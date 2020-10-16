using CovenantProfileGenerator.Soulbinds;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
            TestSoulbinds();
        }
        private void TestSoulbinds()
        {
            var soulbinds = Data.GetSoulbinds();

            var options = new SoulbindPathOptions()
            {
                Class = "Mage",
                Spec = "Frost",
                Renown = 39,
                RankConduits = 7,
                IgnoredSoulbindAbilities = Data.GetSoulbindAbilities().Where(a => a.IgnoredDefault),
                AllowedFinesseConduits = Data.GetConduits().Where(x => x.AllowedDefault && x.Type == SoulbindAbilityType.FinesseConduit),
                AllowedEnduranceConduits = Data.GetConduits().Where(x => x.AllowedDefault && x.Type == SoulbindAbilityType.EnduranceConduit),
                IgnoredPotencyConduits = Data.GetConduits().Where(x => x.IgnoredDefault && x.Type == SoulbindAbilityType.PotencyConduit),
                MustHavePotencyConduits = Data.GetConduits().Where(x => x.MusthaveDefault && x.Type == SoulbindAbilityType.PotencyConduit)
            };

            StringBuilder sb = new StringBuilder();
            foreach (var soulbind in soulbinds)
                foreach (var path in soulbind.GetSoulbindPaths(options))
                    sb.AppendLine(path.SimcProfilesetString);

            textBox1.Text = sb.ToString();
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
            var specProfileUserControl = new SpecProfileUserControl
            {
                Dock = DockStyle.Fill,
                SpecProfile = specProfile,
                Parent = tabPage
            };
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

        private void BtnSelectPathTemplate_Click(object sender, EventArgs e)
        {
            tbPathTemplate.Text = SelectFolder(ConfigurationManager.AppSettings["defaultPathTemplate"]);
            InitProfile();
        }
        private void BtnSelectPathProfiles_Click(object sender, EventArgs e)
        {
            tbPathProfiles.Text = SelectFolder(ConfigurationManager.AppSettings["defaultPathProfile"]);
        }
        private void BtnSelectPathResult_Click(object sender, EventArgs e)
        {
            tbPathResult.Text = SelectFolder(ConfigurationManager.AppSettings["defaultPathResults"]);
        }

        private void TbOptionsRankConduits_Leave(object sender, EventArgs e)
        {
            if (profile == null)
                return;

            specUserControls.ForEach((x) => x.RefreshSpecProfile());
        }

        private void BtnGenerateProfiles_Click(object sender, EventArgs e)
        {
            if (profile == null)
                return;

            profile.GenerateProfiles();
        }
    }
}
