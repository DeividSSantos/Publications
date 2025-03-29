using System;
using System.Windows.Forms;
namespace Publications
{
    public partial class AddPublication : Form
    {
        public AddPublication() => InitializeComponent();
        private void But_SearchImage_Click(object sender, EventArgs e)
        {
            if(this.DiaAbeArq_LocatárioImagem.ShowDialog() == DialogResult.OK)
            {
                this.TexBox_SearchImage.Text = this.DiaAbeArq_LocatárioImagem.FileName;
                this.ImaBox_ImagePublication.ImageLocation = this.DiaAbeArq_LocatárioImagem.FileName;
            }
        }
        private void But_Erase_Click(object sender, EventArgs e)
        {
            this.TexBox_TitlePublication.Clear();
            this.TexBox_SearchImage.Clear();
            this.ImaBox_ImagePublication.Image = null;
            this.RicTexBox_ContentPublication.Clear();
        }
        private void But_Publish_Click(object sender, EventArgs e)
        {
            if(this.TexBox_TitlePublication.Text != "" || this.TexBox_SearchImage.Text != "" || this.ImaBox_ImagePublication.Image != null || this.RicTexBox_ContentPublication.Text != "")
            {
                if(DataBaseManager.AddPublication(this.TexBox_TitlePublication.Text, this.TexBox_SearchImage.Text, this.RicTexBox_ContentPublication.Text))
                    MessageBox.Show("Publicação realizada com sucesso.");
            }
            else
                MessageBox.Show("Ocorreu um erro na publicação.\nVerifique se algum campo está vazio.");
        }
        private void AddPublication_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.DefinitionTable();
        }
    };
};