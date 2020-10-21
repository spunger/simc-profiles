using CovenantProfileGenerator.Soulbinds;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CovenantProfileGenerator
{
    public class Profile
    {
        private const string FILENAME_OPTIONS_GLOBAL = "Global.simc";
        private const string FILENAME_SPECS = "Specs.txt";
        private const string PATH_APL = "APL";
        private const string PATH_EQUIP = "Equip";
        private const string PATH_GENERAL = "General";

        private const string CODE_COVENANT_KYR = "KYR";
        private const string CODE_COVENANT_NEC = "NEC";
        private const string CODE_COVENANT_FAE = "FAE";
        private const string CODE_COVENANT_VEN = "VEN";

        private readonly string pathTemplate;
        private int rankConduits = 7;
        private int renown = 39;

        public string Name { get; set; }
        public string GlobalOptions { get; set; }

        public int RankConduits
        {
            get => rankConduits;
            set
            {
                int oldValue = rankConduits;

                rankConduits = value;

                if (oldValue != renown)
                    UpdateSoulbinds();
            }
        }
        public int Renown
        {
            get => renown;
            set
            {
                int oldValue = renown;

                renown = value;

                if (oldValue != renown)
                    UpdateSoulbinds();
            }
        }
        private void UpdateSoulbinds()
        {
            var soulbinds = Data.GetSoulbinds();

            var options = new SoulbindPathOptions()
            {
                Class = "Mage", // forgot to define class
                Renown = Renown,
                RankConduits = RankConduits,
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
            
            foreach (var specProfile in SpecProfiles)
            {
                options.Spec = specProfile.Name;

                specProfile.SoulbindsKyr = BuildProfileSetsForCovenants(soulbinds, options, CODE_COVENANT_KYR);
                specProfile.SoulbindsNec = BuildProfileSetsForCovenants(soulbinds, options, CODE_COVENANT_NEC);
                specProfile.SoulbindsNightfae = BuildProfileSetsForCovenants(soulbinds, options, CODE_COVENANT_FAE);
                specProfile.SoulbindsVenthyr = BuildProfileSetsForCovenants(soulbinds, options, CODE_COVENANT_VEN);
            }
        }
        private string BuildProfileSetsForCovenants(IEnumerable<Soulbind> soulbinds, SoulbindPathOptions options, string codeCovenant)
        {
            var soulbindsCovenant = soulbinds.Where(s => s.CovenantCode == codeCovenant);
            StringBuilder sb = new StringBuilder();
            
            switch (codeCovenant)
            {
                case CODE_COVENANT_KYR:
                    sb.AppendLine("covenant=kyrian");
                    break;
                case CODE_COVENANT_NEC:
                    sb.AppendLine("covenant=necrolord");
                    break;
                case CODE_COVENANT_FAE:
                    sb.AppendLine("covenant=night_fae");
                    break;
                case CODE_COVENANT_VEN:
                    sb.AppendLine("covenant=venthyr");
                    break;

            }

            foreach (var soulbind in soulbindsCovenant)
                foreach (var path in soulbind.GetSoulbindPaths(options))
                    sb.AppendLine(path.SimcProfilesetString);

            return sb.ToString();
        }

        public string PathProfiles { get; set; }
        public string PathOutput { get; set; }
        public bool OutputText { get; set; }
        public bool OutputJson { get; set; }
        public bool OutputHtml { get; set; }

        public List<SpecProfile> SpecProfiles { get; set; }

        public Profile(string pathTemplate)
        {
            this.pathTemplate = pathTemplate;

            this.SpecProfiles = new List<SpecProfile>();

            GlobalOptions = GetGlobalOptionsFromTemplate();

            var specs = GetSpecsFromTemplate();

            foreach (var spec in specs)
            {
                SpecProfiles.Add(new SpecProfile()
                {
                    Name = spec,
                    Apl = GetAplFromTemplate(spec),
                    General = GetGeneralFromTemplate(spec),
                    Equip = GetEquipFromTemplate(spec),
                });
            }
            UpdateSoulbinds();
        }

        private string GetEquipFromTemplate(string spec)
            => File.ReadAllText($@"{pathTemplate}{Path.DirectorySeparatorChar}{PATH_EQUIP}{Path.DirectorySeparatorChar}{spec}.simc");

        private string GetGeneralFromTemplate(string spec)
            => File.ReadAllText($@"{pathTemplate}{Path.DirectorySeparatorChar}{PATH_GENERAL}{Path.DirectorySeparatorChar}{spec}.simc");

        private string GetAplFromTemplate(string spec)
            => File.ReadAllText($@"{pathTemplate}{Path.DirectorySeparatorChar}{PATH_APL}{Path.DirectorySeparatorChar}{spec}.simc");

        private string GetGlobalOptionsFromTemplate()
            => File.ReadAllText($@"{pathTemplate}{Path.DirectorySeparatorChar}{FILENAME_OPTIONS_GLOBAL}");

        private string[] GetSpecsFromTemplate()
            => File.ReadAllLines($@"{pathTemplate}{Path.DirectorySeparatorChar}{FILENAME_SPECS}");

        public void GenerateProfiles()
        {
            var files = new List<(string fileName, string content)>();

            foreach (var specProfile in SpecProfiles)
            {
                files.Add((
                    $"{specProfile.Name}_{CODE_COVENANT_KYR}.simc",
                    BuildProfile(specProfile, CODE_COVENANT_KYR)));

                files.Add((
                    $"{specProfile.Name}_{CODE_COVENANT_NEC}.simc",
                    BuildProfile(specProfile, CODE_COVENANT_NEC)));

                files.Add((
                    $"{specProfile.Name}_{CODE_COVENANT_FAE}.simc",
                    BuildProfile(specProfile, CODE_COVENANT_FAE)));

                files.Add((
                    $"{specProfile.Name}_{CODE_COVENANT_VEN}.simc",
                    BuildProfile(specProfile, CODE_COVENANT_VEN)));
            }


            string profilePath = $@"{this.PathProfiles}{Path.DirectorySeparatorChar}{this.Name}";
            var di = Directory.CreateDirectory(profilePath);

            foreach (var (fileName, content) in files)
                File.WriteAllText($@"{di.FullName}{Path.DirectorySeparatorChar}{fileName}", content);

            File.WriteAllText($@"{di.FullName}{Path.DirectorySeparatorChar}runall.bat", BuildBatch(di.FullName));

        }
        private string BuildProfile(SpecProfile specProfile, string covenant)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(BuildProfileGeneral(specProfile.Name, covenant));
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(specProfile.General);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(specProfile.Equip);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(specProfile.Apl);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(BuildProfileSoulbinds(specProfile, covenant));

            return sb.ToString();
        }
        private string BuildProfileGeneral(string specName, string covenant)
        {
            StringBuilder sb = new StringBuilder();
            if (this.OutputText)
                sb.AppendLine($@"output={this.PathOutput}{Path.DirectorySeparatorChar}{this.Name}{Path.DirectorySeparatorChar}{specName}_{covenant}.txt");
            if (this.OutputJson)
                sb.AppendLine($@"json2={this.PathOutput}{Path.DirectorySeparatorChar}{this.Name}{Path.DirectorySeparatorChar}{specName}_{covenant}.json");
            if (this.OutputHtml)
                sb.AppendLine($@"html={this.PathOutput}{Path.DirectorySeparatorChar}{this.Name}{Path.DirectorySeparatorChar}{specName}_{covenant}.html");

            sb.AppendLine();
            sb.Append(this.GlobalOptions);

            return sb.ToString();
        }
        private string BuildProfileSoulbinds(SpecProfile spec, string covenant)
        {
            StringBuilder sb = new StringBuilder();

            switch (covenant)
            {
                case CODE_COVENANT_KYR:
                    sb.Append(spec.SoulbindsKyr);
                    break;
                case CODE_COVENANT_NEC:
                    sb.Append(spec.SoulbindsNec);
                    break;
                case CODE_COVENANT_FAE:
                    sb.Append(spec.SoulbindsNightfae);
                    break;
                case CODE_COVENANT_VEN:
                    sb.Append(spec.SoulbindsVenthyr);
                    break;
            }

            return sb.ToString();
        }
        private string BuildBatch(string path)
        {
            StringBuilder sb = new StringBuilder();

            var files = Directory.GetFiles(path, "*.simc");

            foreach (var file in files)
                sb.AppendLine($"simc.exe {Path.GetFileName(file)}");

            return sb.ToString();
        }
    }
}
