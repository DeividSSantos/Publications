using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Publications
{
    public partial class MainWindow : Form
    {
        private ushort tableIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            DefinitionTable();
        }
        public void DefinitionTable()
        {
            if(this.tableIndex >= DataBaseManager.Publications.Rows.Count - 1)
                this.But_NextPublication.Enabled = false;
            else
                this.But_NextPublication.Enabled = true;
            if(this.tableIndex <= 0)
                this.But_PreviosPublication.Enabled = false;
            else
                this.But_PreviosPublication.Enabled = true;
            if(DataBaseManager.Publications.Rows.Count > 0)
            {
                Lab_NumberPublication.Text = String.Format($"Publicação {DataBaseManager.Publications.Rows[this.tableIndex].Field<Int32>("Index")}");
                TexBox_TitlePublication.Text = DataBaseManager.Publications.Rows[this.tableIndex].Field<String>("Title");
                using(MemoryStream memory = new MemoryStream(DataBaseManager.Publications.Rows[this.tableIndex].Field<Byte[]>("Image")))
                {
                    ImaBox_ImagePublication.Image = Image.FromStream(memory);
                }
                RicTexBox_ContentPublication.Text = DataBaseManager.Publications.Rows[this.tableIndex].Field<String>("Content");
                return;
            }
            Lab_NumberPublication.Text = "Publicações";
        }
        private void But_PreviosPublication_Click(object sender, EventArgs e)
        {
            this.tableIndex -= 1;
            DefinitionTable();
        }
        private void But_NextPublication_Click(object sender, EventArgs e)
        {
            this.tableIndex += 1;
            DefinitionTable();
        }
        private void But_ReplaceImage_Click(object sender, EventArgs e)
        {
            if(this.DiaAbrArq_LocatárioImagem.ShowDialog() == DialogResult.OK)
            {
                this.TexBox_SearchImage.Text = this.DiaAbrArq_LocatárioImagem.FileName;
                this.ImaBox_ImagePublication.ImageLocation = this.DiaAbrArq_LocatárioImagem.FileName;
            }
        }
        private void But_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir esta publicação?", "Exclusão de publicação", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
                if(DataBaseManager.RemovePublication(this.tableIndex))
                {
                    MessageBox.Show("Exclusão realizada com sucesso.");
                    this.tableIndex -= 1;
                    DefinitionTable();
                }
        }
        private void But_Edit_Click(object sender, EventArgs e)
        {
            if(this.TexBox_TitlePublication.Text != "" || this.ImaBox_ImagePublication.Image != null || this.RicTexBox_ContentPublication.Text != "")
            {
                if(this.TexBox_SearchImage.Text == "")
                {
                    if(DataBaseManager.AlterPublication(this.tableIndex, this.TexBox_TitlePublication.Text, "", this.RicTexBox_ContentPublication.Text))
                        MessageBox.Show("Edição realizada com sucesso.");
                    return;
                }
                if(DataBaseManager.AlterPublication(this.tableIndex, this.TexBox_TitlePublication.Text, this.TexBox_SearchImage.Text, this.RicTexBox_ContentPublication.Text))
                    MessageBox.Show("Edição realizada com sucesso.");
            }
            else
                MessageBox.Show("Ocorreu um erro na publicação.\nVerifique se algum campo está vazio.");
        }
        private void But_AddPublication_Click(object sender, EventArgs e)
        {
            AddPublication addPublication = new AddPublication();
            addPublication.ShowDialog();
            addPublication.Focus();
        }
    };
};