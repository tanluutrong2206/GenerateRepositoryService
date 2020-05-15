using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GenerateRepositoryServiceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var btnName = ((Button)sender).Name;
            var txtName = btnName.Replace("btn", "txt");
            var txtControl = Controls.Find(txtName, true).FirstOrDefault() as TextBox;
            if (!btnName.Contains("File"))
            {
                using var fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtControl.Text = fbd.SelectedPath;
                }
            } else
            {
                openFileDialog1.Filter = "CSharp files|*.cs";
                openFileDialog1.FileName = string.Empty;
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog1.FileName))
                {
                    txtControl.Text = openFileDialog1.FileName;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var folderEntity = txtFolderEntity.Text;
            var content
            foreach (var file in Directory.GetFiles(folderEntity))
            {
                if (file.ToLower().EndsWith(".cs"))
                {
                    var fileName = Path.GetFileName(file);

                }
            }
        }
    }
}
