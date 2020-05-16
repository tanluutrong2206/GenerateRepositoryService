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
            var folderRepoInterface = txtRepoInterface.Text;
            var folderRepoImplement = txtRepoImplement.Text;
            var folderServiceInterface = txtServiceInterface.Text;
            var folderServiceImplement = txtServiceImplement.Text;

            var contentFileRepoInterface = File.ReadAllText(txtFileRepoInterface.Text);
            var contentFileRepoImplement = File.ReadAllText(txtFileRepoImplement.Text);
            var contentFileServiceInterface = File.ReadAllText(txtFileServiceInterface.Text);
            var contentFileServiceImplement = File.ReadAllText(txtFileServiceImplement.Text);

            foreach (var file in Directory.GetFiles(folderEntity))
            {
                if (file.ToLower().EndsWith(".cs"))
                {
                    var fileName = Path.GetFileName(file);
                    // create file repo interface
                    var fileNameRepoInterface = $"I{ReplaceName(fileName)}Repository.cs";
                    if (!File.Exists($"{folderRepoInterface}/{fileNameRepoInterface}"))
                    {
                        using var tw = new StreamWriter($"{folderRepoInterface}/{fileNameRepoInterface}", true);
                        tw.Write(ReplaceName(contentFileRepoInterface));
                    }
                    // create file repo implement
                    var fileNameRepoImplement = $"{ReplaceName(fileName)}Repository.cs";
                    if (!File.Exists($"{folderRepoImplement}/{fileNameRepoImplement}"))
                    {
                        using var tw = new StreamWriter($"{folderRepoImplement}/{fileNameRepoImplement}", true);
                        tw.Write(ReplaceName(contentFileRepoImplement));
                    }
                    // create file service interface
                    var fileNameServiceInterface = $"I{ReplaceName(fileName)}Service.cs";
                    if (!File.Exists($"{folderServiceInterface}/{fileNameServiceInterface}"))
                    {
                        using var tw = new StreamWriter($"{folderServiceInterface}/{fileNameServiceInterface}", true);
                        tw.Write(ReplaceName(contentFileServiceInterface));
                    }
                    // create file service implement
                    var fileNameServiceImplement = $"{ReplaceName(fileName)}Service.cs";
                    if (!File.Exists($"{folderServiceImplement}/{fileNameServiceImplement}"))
                    {
                        using var tw = new StreamWriter($"{folderServiceImplement}/{fileNameServiceImplement}", true);
                        tw.Write(ReplaceName(contentFileServiceImplement));
                    }
                }
            }
        }

        private string ReplaceName(string content)
        {
            var strReplace1 = txtReplace1.Text;
            var strReplace2 = txtReplace2.Text;
            var strReplace3 = txtReplace3.Text;

            var strReplaceTo1 = txtReplaceTo1.Text;
            var strReplaceTo2 = txtReplaceTo2.Text;
            var strReplaceTo3 = txtReplaceTo3.Text;

            if (!string.IsNullOrEmpty(strReplace1))
            {
                content.Replace(strReplace1, strReplaceTo1);
            }
            if (!string.IsNullOrEmpty(strReplace2))
            {
                content.Replace(strReplace2, strReplaceTo2);
            }
            if (!string.IsNullOrEmpty(strReplace3))
            {
                content.Replace(strReplace3, strReplaceTo3);
            }
            return content;
        }
    }
}
