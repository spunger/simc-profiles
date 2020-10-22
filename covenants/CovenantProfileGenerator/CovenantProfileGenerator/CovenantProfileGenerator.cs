using CovenantProfileGenerator.Soulbinds;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;

namespace CovenantProfileGenerator
{
    public partial class CovenantProfileGenerator : Form
    {
        Profile profile;
        List<SpecProfileUserControl> specUserControls = new List<SpecProfileUserControl>();

        public CovenantProfileGenerator()
        {
            InitializeComponent();

            //var options = new SoulbindPathOptions()
            //{
            //    Class = "Mage", // forgot to define class
            //    Spec = "Arcane",
            //    Renown = 39,
            //    RankConduits = 7,
            //    IgnoredSoulbindAbilities = Data.GetSoulbindAbilities().Where(a => a.IgnoredDefault),
            //    AllowedFinesseConduits = Data.GetConduits().Where(x => x.AllowedDefault && x.Type == SoulbindAbilityType.FinesseConduit),
            //    AllowedEnduranceConduits = Data.GetConduits().Where(x => x.AllowedDefault && x.Type == SoulbindAbilityType.EnduranceConduit),
            //    IgnoredPotencyConduits = Data.GetConduits().Where(x => x.IgnoredDefault && x.Type == SoulbindAbilityType.PotencyConduit),
            //    MustHavePotencyConduits = Data.GetConduits().Where(x => x.MusthaveDefault && x.Type == SoulbindAbilityType.PotencyConduit)
            //};

            //var soulbind = Data.GetSoulbinds().Where(x => x.Code == "Mari").First();
            //var paths = soulbind.GetSoulbindPaths(options).ToList();
            //TestSoulbinds();
        }
        private void TestSoulbinds()
        {
            var dir = @"C:\Users\SpanierTh\source\repos\simc-profiles\covenants\Results\ST_RenMax_R7_Leggos";
            var files = Directory.GetFiles(dir, "*.json*");

            var results = new List<Result>();

            foreach (var file in files)
            {
                string fileTxt = $"{Path.GetDirectoryName(file)}{Path.DirectorySeparatorChar}{Path.GetFileNameWithoutExtension(file)}.txt";
                var linesTxt = File.ReadAllLines(fileTxt);
                var talents = linesTxt.Where(l => l.Contains("Talents:")).FirstOrDefault()?.Trim().Replace("Talents: ", "");
                var resultJson = File.ReadAllText(file);
                var simcResult = JsonConvert.DeserializeObject<SimcResult>(resultJson);
                var spec = Path.GetFileNameWithoutExtension(file).Split('_')[0];
                var covenant = Path.GetFileNameWithoutExtension(file).Split('_')[1];
                var intellect = 1250;
                var haste = 750;
                var crit = 700;
                var mastery = 200;
                var versatility = 200;
                string legendary = "none";
                var targets = simcResult.sim.targets.Count();

                switch (spec)
                {
                    case "Fire":
                        legendary = "Firestorm";
                        break;
                    case "Arcane":
                        legendary = "Harmony";
                        break;
                    case "Frost":
                        legendary = "Split Ice";
                        break;
                }

                foreach (var profileset in simcResult.sim.profilesets.results)
                {
                    results.Add(new Result()
                    {
                        NameProfileset = profileset.name,
                        DpsMedian = profileset.median,
                        Spec = spec,
                        Covenant = covenant,
                        Talents = talents,
                        Targets = targets,
                        Legendary = legendary,
                        Int = intellect,
                        Crit = crit,
                        Mastery = mastery,
                        Haste = haste,
                        Versatility = versatility
                    }); 
                }

            }
            using (var writer = new StreamWriter($"{dir}{Path.DirectorySeparatorChar}summary.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.CurrentCulture))
            {
                csv.WriteRecords(results.OrderByDescending(r=>r.DpsMedian));
            }
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
