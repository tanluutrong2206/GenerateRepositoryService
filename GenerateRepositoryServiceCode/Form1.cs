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
            }
            else
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

            var contentFileRepoInterface = string.Empty;
            var contentFileRepoImplement = string.Empty;
            var contentFileServiceInterface = string.Empty;
            var contentFileServiceImplement = string.Empty;
            if (!string.IsNullOrEmpty(folderRepoInterface))
            {
                contentFileRepoInterface = File.ReadAllText(txtFileRepoInterface.Text);
            }
            if (!string.IsNullOrEmpty(folderRepoImplement))
            {
                contentFileRepoImplement = File.ReadAllText(txtFileRepoImplement.Text);
            }
            if (!string.IsNullOrEmpty(folderServiceInterface))
            {
                contentFileServiceInterface = File.ReadAllText(txtFileServiceInterface.Text);
            }
            if (!string.IsNullOrEmpty(folderServiceImplement))
            {
                contentFileServiceImplement = File.ReadAllText(txtFileServiceImplement.Text);
            }
            try
            {
                foreach (var file in Directory.GetFiles(folderEntity))
                {
                    if (file.ToLower().EndsWith(".cs"))
                    {
                        var fileName = Path.GetFileName(file).Replace(".cs", "");
                        // create file repo interface
                        if (!string.IsNullOrEmpty(folderRepoInterface))
                        {
                            var fileNameRepoInterface = $"I{ReplaceName(fileName, fileName)}Repository.cs";
                            if (!File.Exists($"{folderRepoInterface}/{fileNameRepoInterface}"))
                            {
                                using var tw = new StreamWriter($"{folderRepoInterface}/{fileNameRepoInterface}", true);
                                tw.WriteLine(ReplaceName(contentFileRepoInterface, fileName));
                            }
                        }

                        // create file repo implement
                        if (!string.IsNullOrEmpty(folderRepoImplement))
                        {
                            var fileNameRepoImplement = $"{ReplaceName(fileName, fileName)}Repository.cs";
                            if (!File.Exists($"{folderRepoImplement}/{fileNameRepoImplement}"))
                            {
                                using var tw = new StreamWriter($"{folderRepoImplement}/{fileNameRepoImplement}", true);
                                tw.WriteLine(ReplaceName(contentFileRepoImplement, fileName));
                            }
                        }

                        // create file service interface
                        if (!string.IsNullOrEmpty(folderServiceInterface))
                        {
                            var fileNameServiceInterface = $"I{ReplaceName(fileName, fileName)}Service.cs";
                            if (!File.Exists($"{folderServiceInterface}/{fileNameServiceInterface}"))
                            {
                                using var tw = new StreamWriter($"{folderServiceInterface}/{fileNameServiceInterface}", true);
                                tw.WriteLine(ReplaceName(contentFileServiceInterface, fileName));
                            }
                        }
                        // create file service implement
                        if (!string.IsNullOrEmpty(folderServiceImplement))
                        {
                            var fileNameServiceImplement = $"{ReplaceName(fileName, fileName)}Service.cs";
                            if (!File.Exists($"{folderServiceImplement}/{fileNameServiceImplement}"))
                            {
                                using var tw = new StreamWriter($"{folderServiceImplement}/{fileNameServiceImplement}", true);
                                tw.WriteLine(ReplaceName(contentFileServiceImplement, fileName));
                            }
                        }
                    }
                }

                MessageBox.Show("Generate Successfuly");
            }
            catch
            {
                MessageBox.Show("There was an error when executing");
            }
        }

        private string ReplaceName(string content, string fileName)
        {
            var strReplace1 = txtReplace1.Text;
            var strReplace2 = txtReplace2.Text;
            var strReplace3 = txtReplace3.Text;

            if (!string.IsNullOrEmpty(strReplace1))
            {
                content = content.Replace(strReplace1, txtReplaceTo1.Text == "{fileName}" ? fileName : txtReplaceTo1.Text);
            }
            if (!string.IsNullOrEmpty(strReplace2))
            {
                content = content.Replace(strReplace2, txtReplaceTo2.Text == "{fileName}" ? fileName : txtReplaceTo2.Text);
            }
            if (!string.IsNullOrEmpty(strReplace3))
            {
                content = content.Replace(strReplace3, txtReplaceTo3.Text == "{fileName}" ? fileName : txtReplaceTo3.Text);
            }
            return content;
        }
    }
}
