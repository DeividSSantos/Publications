namespace Publications
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_SearchImage = new System.Windows.Forms.Label();
            this.TexBox_SearchImage = new System.Windows.Forms.TextBox();
            this.But_ReplaceImage = new System.Windows.Forms.Button();
            this.Lab_ImagePublication = new System.Windows.Forms.Label();
            this.Lab_ContentPublication = new System.Windows.Forms.Label();
            this.Lab_TitlePublication = new System.Windows.Forms.Label();
            this.TexBox_TitlePublication = new System.Windows.Forms.TextBox();
            this.RicTexBox_ContentPublication = new System.Windows.Forms.RichTextBox();
            this.ImaBox_ImagePublication = new System.Windows.Forms.PictureBox();
            this.Lab_NumberPublication = new System.Windows.Forms.Label();
            this.But_NextPublication = new System.Windows.Forms.Button();
            this.But_PreviosPublication = new System.Windows.Forms.Button();
            this.But_Remove = new System.Windows.Forms.Button();
            this.But_Edit = new System.Windows.Forms.Button();
            this.DiaAbrArq_LocatárioImagem = new System.Windows.Forms.OpenFileDialog();
            this.But_AddPublication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImaBox_ImagePublication)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_SearchImage
            // 
            this.Label_SearchImage.AutoSize = true;
            this.Label_SearchImage.Location = new System.Drawing.Point(12, 92);
            this.Label_SearchImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SearchImage.Name = "Label_SearchImage";
            this.Label_SearchImage.Size = new System.Drawing.Size(134, 16);
            this.Label_SearchImage.TabIndex = 7;
            this.Label_SearchImage.Text = "Locatário da imagem";
            // 
            // TexBox_SearchImage
            // 
            this.TexBox_SearchImage.AcceptsTab = true;
            this.TexBox_SearchImage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TexBox_SearchImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TexBox_SearchImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_SearchImage.Location = new System.Drawing.Point(16, 112);
            this.TexBox_SearchImage.Margin = new System.Windows.Forms.Padding(4);
            this.TexBox_SearchImage.Name = "TexBox_SearchImage";
            this.TexBox_SearchImage.Size = new System.Drawing.Size(577, 26);
            this.TexBox_SearchImage.TabIndex = 4;
            // 
            // But_ReplaceImage
            // 
            this.But_ReplaceImage.BackColor = System.Drawing.Color.White;
            this.But_ReplaceImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_ReplaceImage.Location = new System.Drawing.Point(601, 112);
            this.But_ReplaceImage.Margin = new System.Windows.Forms.Padding(4);
            this.But_ReplaceImage.Name = "But_ReplaceImage";
            this.But_ReplaceImage.Size = new System.Drawing.Size(95, 28);
            this.But_ReplaceImage.TabIndex = 5;
            this.But_ReplaceImage.Text = "Substituir";
            this.But_ReplaceImage.UseVisualStyleBackColor = false;
            this.But_ReplaceImage.Click += new System.EventHandler(this.But_ReplaceImage_Click);
            // 
            // Lab_ImagePublication
            // 
            this.Lab_ImagePublication.AutoSize = true;
            this.Lab_ImagePublication.Location = new System.Drawing.Point(12, 144);
            this.Lab_ImagePublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_ImagePublication.Name = "Lab_ImagePublication";
            this.Lab_ImagePublication.Size = new System.Drawing.Size(145, 16);
            this.Lab_ImagePublication.TabIndex = 8;
            this.Lab_ImagePublication.Text = "Imagem da publicação";
            // 
            // Lab_ContentPublication
            // 
            this.Lab_ContentPublication.AutoSize = true;
            this.Lab_ContentPublication.Location = new System.Drawing.Point(12, 475);
            this.Lab_ContentPublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_ContentPublication.Name = "Lab_ContentPublication";
            this.Lab_ContentPublication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_ContentPublication.Size = new System.Drawing.Size(154, 16);
            this.Lab_ContentPublication.TabIndex = 9;
            this.Lab_ContentPublication.Text = "Conteúdo da publicação";
            // 
            // Lab_TitlePublication
            // 
            this.Lab_TitlePublication.AutoSize = true;
            this.Lab_TitlePublication.Location = new System.Drawing.Point(12, 44);
            this.Lab_TitlePublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_TitlePublication.Name = "Lab_TitlePublication";
            this.Lab_TitlePublication.Size = new System.Drawing.Size(129, 16);
            this.Lab_TitlePublication.TabIndex = 10;
            this.Lab_TitlePublication.Text = "Título da publicação";
            // 
            // TexBox_TitlePublication
            // 
            this.TexBox_TitlePublication.AcceptsTab = true;
            this.TexBox_TitlePublication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TexBox_TitlePublication.Location = new System.Drawing.Point(16, 64);
            this.TexBox_TitlePublication.Margin = new System.Windows.Forms.Padding(4);
            this.TexBox_TitlePublication.Name = "TexBox_TitlePublication";
            this.TexBox_TitlePublication.Size = new System.Drawing.Size(679, 22);
            this.TexBox_TitlePublication.TabIndex = 3;
            // 
            // RicTexBox_ContentPublication
            // 
            this.RicTexBox_ContentPublication.AcceptsTab = true;
            this.RicTexBox_ContentPublication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RicTexBox_ContentPublication.Location = new System.Drawing.Point(16, 495);
            this.RicTexBox_ContentPublication.Margin = new System.Windows.Forms.Padding(4);
            this.RicTexBox_ContentPublication.Name = "RicTexBox_ContentPublication";
            this.RicTexBox_ContentPublication.Size = new System.Drawing.Size(679, 303);
            this.RicTexBox_ContentPublication.TabIndex = 6;
            this.RicTexBox_ContentPublication.Text = "";
            // 
            // ImaBox_ImagePublication
            // 
            this.ImaBox_ImagePublication.BackColor = System.Drawing.Color.Gray;
            this.ImaBox_ImagePublication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImaBox_ImagePublication.Location = new System.Drawing.Point(16, 164);
            this.ImaBox_ImagePublication.Margin = new System.Windows.Forms.Padding(4);
            this.ImaBox_ImagePublication.Name = "ImaBox_ImagePublication";
            this.ImaBox_ImagePublication.Size = new System.Drawing.Size(679, 307);
            this.ImaBox_ImagePublication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImaBox_ImagePublication.TabIndex = 11;
            this.ImaBox_ImagePublication.TabStop = false;
            // 
            // Lab_NumberPublication
            // 
            this.Lab_NumberPublication.AutoSize = true;
            this.Lab_NumberPublication.Location = new System.Drawing.Point(312, 12);
            this.Lab_NumberPublication.Margin = new System.Windows.Forms.Padding(0);
            this.Lab_NumberPublication.Name = "Lab_NumberPublication";
            this.Lab_NumberPublication.Size = new System.Drawing.Size(85, 16);
            this.Lab_NumberPublication.TabIndex = 16;
            this.Lab_NumberPublication.Text = "Publicação 0";
            // 
            // But_NextPublication
            // 
            this.But_NextPublication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_NextPublication.Location = new System.Drawing.Point(425, 6);
            this.But_NextPublication.Margin = new System.Windows.Forms.Padding(4);
            this.But_NextPublication.Name = "But_NextPublication";
            this.But_NextPublication.Size = new System.Drawing.Size(33, 28);
            this.But_NextPublication.TabIndex = 2;
            this.But_NextPublication.Text = ">";
            this.But_NextPublication.UseVisualStyleBackColor = true;
            this.But_NextPublication.Click += new System.EventHandler(this.But_NextPublication_Click);
            // 
            // But_PreviosPublication
            // 
            this.But_PreviosPublication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_PreviosPublication.Location = new System.Drawing.Point(252, 6);
            this.But_PreviosPublication.Margin = new System.Windows.Forms.Padding(4);
            this.But_PreviosPublication.Name = "But_PreviosPublication";
            this.But_PreviosPublication.Size = new System.Drawing.Size(33, 28);
            this.But_PreviosPublication.TabIndex = 1;
            this.But_PreviosPublication.Text = "<";
            this.But_PreviosPublication.UseVisualStyleBackColor = true;
            this.But_PreviosPublication.Click += new System.EventHandler(this.But_PreviosPublication_Click);
            // 
            // But_Remove
            // 
            this.But_Remove.BackColor = System.Drawing.Color.White;
            this.But_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Remove.Location = new System.Drawing.Point(16, 820);
            this.But_Remove.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.But_Remove.Name = "But_Remove";
            this.But_Remove.Size = new System.Drawing.Size(220, 32);
            this.But_Remove.TabIndex = 7;
            this.But_Remove.Text = "Excluir";
            this.But_Remove.UseVisualStyleBackColor = false;
            this.But_Remove.Click += new System.EventHandler(this.But_Remove_Click);
            // 
            // But_Edit
            // 
            this.But_Edit.BackColor = System.Drawing.Color.White;
            this.But_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Edit.Location = new System.Drawing.Point(245, 820);
            this.But_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.But_Edit.Name = "But_Edit";
            this.But_Edit.Size = new System.Drawing.Size(220, 32);
            this.But_Edit.TabIndex = 8;
            this.But_Edit.Text = "Editar";
            this.But_Edit.UseVisualStyleBackColor = false;
            this.But_Edit.Click += new System.EventHandler(this.But_Edit_Click);
            // 
            // DiaAbrArq_LocatárioImagem
            // 
            this.DiaAbrArq_LocatárioImagem.FileName = "LocatárioImagem";
            this.DiaAbrArq_LocatárioImagem.Filter = "(*jpg)|*jpg";
            this.DiaAbrArq_LocatárioImagem.InitialDirectory = "Downloads";
            this.DiaAbrArq_LocatárioImagem.ReadOnlyChecked = true;
            this.DiaAbrArq_LocatárioImagem.Title = "Abrir imagem";
            // 
            // But_AddPublication
            // 
            this.But_AddPublication.BackColor = System.Drawing.Color.White;
            this.But_AddPublication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_AddPublication.Location = new System.Drawing.Point(476, 820);
            this.But_AddPublication.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.But_AddPublication.Name = "But_AddPublication";
            this.But_AddPublication.Size = new System.Drawing.Size(220, 32);
            this.But_AddPublication.TabIndex = 9;
            this.But_AddPublication.Text = "Adicionar publicação";
            this.But_AddPublication.UseVisualStyleBackColor = false;
            this.But_AddPublication.Click += new System.EventHandler(this.But_AddPublication_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 853);
            this.Controls.Add(this.But_AddPublication);
            this.Controls.Add(this.But_Remove);
            this.Controls.Add(this.But_Edit);
            this.Controls.Add(this.But_PreviosPublication);
            this.Controls.Add(this.But_NextPublication);
            this.Controls.Add(this.Lab_NumberPublication);
            this.Controls.Add(this.Label_SearchImage);
            this.Controls.Add(this.TexBox_SearchImage);
            this.Controls.Add(this.But_ReplaceImage);
            this.Controls.Add(this.Lab_ImagePublication);
            this.Controls.Add(this.Lab_ContentPublication);
            this.Controls.Add(this.Lab_TitlePublication);
            this.Controls.Add(this.TexBox_TitlePublication);
            this.Controls.Add(this.RicTexBox_ContentPublication);
            this.Controls.Add(this.ImaBox_ImagePublication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(727, 900);
            this.MinimumSize = new System.Drawing.Size(727, 873);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicações";
            ((System.ComponentModel.ISupportInitialize)(this.ImaBox_ImagePublication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SearchImage;
        private System.Windows.Forms.TextBox TexBox_SearchImage;
        private System.Windows.Forms.Button But_ReplaceImage;
        private System.Windows.Forms.Label Lab_ImagePublication;
        private System.Windows.Forms.Label Lab_ContentPublication;
        private System.Windows.Forms.Label Lab_TitlePublication;
        private System.Windows.Forms.TextBox TexBox_TitlePublication;
        private System.Windows.Forms.RichTextBox RicTexBox_ContentPublication;
        private System.Windows.Forms.PictureBox ImaBox_ImagePublication;
        private System.Windows.Forms.Label Lab_NumberPublication;
        private System.Windows.Forms.Button But_NextPublication;
        private System.Windows.Forms.Button But_PreviosPublication;
        private System.Windows.Forms.Button But_Remove;
        private System.Windows.Forms.Button But_Edit;
        private System.Windows.Forms.OpenFileDialog DiaAbrArq_LocatárioImagem;
        private System.Windows.Forms.Button But_AddPublication;
    };
};