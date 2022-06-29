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
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace IncludeResourceReference
{
    public partial class WorkSpace : Form
    {
        Assembly Assemblys;
        StreamReader SR;

        public WorkSpace()
        {
            InitializeComponent();
        }

        private void btn_data_access_Click(object sender, EventArgs e)
        {
            try
            {
                Assemblys = Assembly.GetExecutingAssembly();
                string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();

                using (SR = new StreamReader(Assemblys.GetManifestResourceStream(resourceNames[1])))
                {
                    textbox_data.Text = SR.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
