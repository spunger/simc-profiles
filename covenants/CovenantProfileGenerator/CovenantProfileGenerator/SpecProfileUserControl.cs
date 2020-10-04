using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovenantProfileGenerator
{
    public partial class SpecProfileUserControl : UserControl
    {
        private SpecProfile specProfile;

        public SpecProfileUserControl()
        {
            InitializeComponent();
        }
        public SpecProfile SpecProfile
        {
            get => specProfile;
            set
            {
                specProfile = value;
                InitSpecProfile();
            }
        }

        private void InitSpecProfile()
        {
            if (specProfile == null)
                return;

            specProfileBindingSource.DataSource = specProfile;
        }
        public void RefreshSpecProfile()
        {
            specProfileBindingSource.ResetCurrentItem();
        }
    }
}
