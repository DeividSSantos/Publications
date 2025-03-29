namespace Publications
{
    partial class AddPublication
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImaBox_ImagePublication = new System.Windows.Forms.PictureBox();
            this.RicTexBox_ContentPublication = new System.Windows.Forms.RichTextBox();
            this.TexBox_TitlePublication = new System.Windows.Forms.TextBox();
            this.Lab_TitlePublication = new System.Windows.Forms.Label();
            this.Lab_ContentPublication = new System.Windows.Forms.Label();
            this.Lab_ImagePublication = new System.Windows.Forms.Label();
            this.DiaAbeArq_LocatárioImagem = new System.Windows.Forms.OpenFileDialog();
            this.But_SearchImage = new System.Windows.Forms.Button();
            this.TexBox_SearchImage = new System.Windows.Forms.TextBox();
            this.Lab_SearchImage = new System.Windows.Forms.Label();
            this.But_Publish = new System.Windows.Forms.Button();
            this.But_Erase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImaBox_ImagePublication)).BeginInit();
            this.SuspendLayout();
            // 
            // ImaBox_ImagePublication
            // 
            this.ImaBox_ImagePublication.BackColor = System.Drawing.Color.Gray;
            this.ImaBox_ImagePublication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImaBox_ImagePublication.Location = new System.Drawing.Point(27, 149);
            this.ImaBox_ImagePublication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImaBox_ImagePublication.Name = "ImaBox_ImagePublication";
            this.ImaBox_ImagePublication.Size = new System.Drawing.Size(669, 307);
            this.ImaBox_ImagePublication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImaBox_ImagePublication.TabIndex = 0;
            this.ImaBox_ImagePublication.TabStop = false;
            // 
            // RicTexBox_ContentPublication
            // 
            this.RicTexBox_ContentPublication.AcceptsTab = true;
            this.RicTexBox_ContentPublication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RicTexBox_ContentPublication.Location = new System.Drawing.Point(27, 495);
            this.RicTexBox_ContentPublication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RicTexBox_ContentPublication.Name = "RicTexBox_ContentPublication";
            this.RicTexBox_ContentPublication.Size = new System.Drawing.Size(668, 259);
            this.RicTexBox_ContentPublication.TabIndex = 4;
            this.RicTexBox_ContentPublication.Text = "";
            // 
            // TexBox_TitlePublication
            // 
            this.TexBox_TitlePublication.AcceptsTab = true;
            this.TexBox_TitlePublication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TexBox_TitlePublication.Location = new System.Drawing.Point(27, 42);
            this.TexBox_TitlePublication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TexBox_TitlePublication.Name = "TexBox_TitlePublication";
            this.TexBox_TitlePublication.Size = new System.Drawing.Size(669, 22);
            this.TexBox_TitlePublication.TabIndex = 1;
            // 
            // Lab_TitlePublication
            // 
            this.Lab_TitlePublication.AutoSize = true;
            this.Lab_TitlePublication.Location = new System.Drawing.Point(23, 22);
            this.Lab_TitlePublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_TitlePublication.Name = "Lab_TitlePublication";
            this.Lab_TitlePublication.Size = new System.Drawing.Size(129, 16);
            this.Lab_TitlePublication.TabIndex = 0;
            this.Lab_TitlePublication.Text = "Título da publicação";
            // 
            // Lab_ContentPublication
            // 
            this.Lab_ContentPublication.AutoSize = true;
            this.Lab_ContentPublication.Location = new System.Drawing.Point(23, 475);
            this.Lab_ContentPublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_ContentPublication.Name = "Lab_ContentPublication";
            this.Lab_ContentPublication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_ContentPublication.Size = new System.Drawing.Size(154, 16);
            this.Lab_ContentPublication.TabIndex = 0;
            this.Lab_ContentPublication.Text = "Conteúdo da publicação";
            // 
            // Lab_ImagePublication
            // 
            this.Lab_ImagePublication.AutoSize = true;
            this.Lab_ImagePublication.Location = new System.Drawing.Point(23, 129);
            this.Lab_ImagePublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_ImagePublication.Name = "Lab_ImagePublication";
            this.Lab_ImagePublication.Size = new System.Drawing.Size(145, 16);
            this.Lab_ImagePublication.TabIndex = 0;
            this.Lab_ImagePublication.Text = "Imagem da publicação";
            // 
            // DiaAbeArq_LocatárioImagem
            // 
            this.DiaAbeArq_LocatárioImagem.FileName = "LocatárioImagem";
            this.DiaAbeArq_LocatárioImagem.Filter = "(*jpg)|*jpg";
            this.DiaAbeArq_LocatárioImagem.InitialDirectory = "Downloads";
            this.DiaAbeArq_LocatárioImagem.ReadOnlyChecked = true;
            this.DiaAbeArq_LocatárioImagem.Title = "Abrir imagem";
            // 
            // But_SearchImage
            // 
            this.But_SearchImage.BackColor = System.Drawing.Color.White;
            this.But_SearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_SearchImage.Location = new System.Drawing.Point(601, 97);
            this.But_SearchImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.But_SearchImage.Name = "But_SearchImage";
            this.But_SearchImage.Size = new System.Drawing.Size(95, 28);
            this.But_SearchImage.TabIndex = 3;
            this.But_SearchImage.Text = "Procurar";
            this.But_SearchImage.UseVisualStyleBackColor = false;
            this.But_SearchImage.Click += new System.EventHandler(this.But_SearchImage_Click);
            // 
            // TexBox_SearchImage
            // 
            this.TexBox_SearchImage.AcceptsTab = true;
            this.TexBox_SearchImage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TexBox_SearchImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TexBox_SearchImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_SearchImage.Location = new System.Drawing.Point(27, 97);
            this.TexBox_SearchImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TexBox_SearchImage.Name = "TexBox_SearchImage";
            this.TexBox_SearchImage.Size = new System.Drawing.Size(566, 26);
            this.TexBox_SearchImage.TabIndex = 2;
            // 
            // Lab_SearchImage
            // 
            this.Lab_SearchImage.AutoSize = true;
            this.Lab_SearchImage.Location = new System.Drawing.Point(23, 78);
            this.Lab_SearchImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_SearchImage.Name = "Lab_SearchImage";
            this.Lab_SearchImage.Size = new System.Drawing.Size(134, 16);
            this.Lab_SearchImage.TabIndex = 0;
            this.Lab_SearchImage.Text = "Locatário da imagem";
            // 
            // But_Publish
            // 
            this.But_Publish.BackColor = System.Drawing.Color.White;
            this.But_Publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Publish.Location = new System.Drawing.Point(363, 770);
            this.But_Publish.Margin = new System.Windows.Forms.Padding(0);
            this.But_Publish.Name = "But_Publish";
            this.But_Publish.Size = new System.Drawing.Size(333, 32);
            this.But_Publish.TabIndex = 5;
            this.But_Publish.Text = "Publicar";
            this.But_Publish.UseVisualStyleBackColor = false;
            this.But_Publish.Click += new System.EventHandler(this.But_Publish_Click);
            // 
            // But_Erase
            // 
            this.But_Erase.BackColor = System.Drawing.Color.White;
            this.But_Erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Erase.Location = new System.Drawing.Point(27, 770);
            this.But_Erase.Margin = new System.Windows.Forms.Padding(0);
            this.But_Erase.Name = "But_Erase";
            this.But_Erase.Size = new System.Drawing.Size(333, 32);
            this.But_Erase.TabIndex = 6;
            this.But_Erase.Text = "Apagar";
            this.But_Erase.UseVisualStyleBackColor = false;
            this.But_Erase.Click += new System.EventHandler(this.But_Erase_Click);
            // 
            // AddPublication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 804);
            this.Controls.Add(this.But_Erase);
            this.Controls.Add(this.But_Publish);
            this.Controls.Add(this.Lab_SearchImage);
            this.Controls.Add(this.TexBox_SearchImage);
            this.Controls.Add(this.But_SearchImage);
            this.Controls.Add(this.Lab_ImagePublication);
            this.Controls.Add(this.Lab_ContentPublication);
            this.Controls.Add(this.Lab_TitlePublication);
            this.Controls.Add(this.TexBox_TitlePublication);
            this.Controls.Add(this.RicTexBox_ContentPublication);
            this.Controls.Add(this.ImaBox_ImagePublication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(727, 851);
            this.MinimumSize = new System.Drawing.Size(727, 851);
            this.Name = "AddPublication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPublication_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ImaBox_ImagePublication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lab_TitlePublication;
        private System.Windows.Forms.Label Lab_ContentPublication;
        private System.Windows.Forms.Label Lab_ImagePublication;
        private System.Windows.Forms.OpenFileDialog DiaAbeArq_LocatárioImagem;
        private System.Windows.Forms.Label Lab_SearchImage;
        private System.Windows.Forms.PictureBox ImaBox_ImagePublication;
        private System.Windows.Forms.RichTextBox RicTexBox_ContentPublication;
        private System.Windows.Forms.TextBox TexBox_TitlePublication;
        private System.Windows.Forms.Button But_SearchImage;
        private System.Windows.Forms.TextBox TexBox_SearchImage;
        private System.Windows.Forms.Button But_Publish;
        private System.Windows.Forms.Button But_Erase;
    }
}