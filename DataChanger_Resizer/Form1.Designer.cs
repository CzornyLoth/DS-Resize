namespace DataChanger_Resizer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.open_directory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Image_name = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImagePreview = new System.Windows.Forms.PictureBox();
            this.size_change = new System.Windows.Forms.Button();
            this.add_data = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ścieżka Folderu:";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(101, 10);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(359, 20);
            this.textBoxDirectory.TabIndex = 1;
            // 
            // open_directory
            // 
            this.open_directory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_directory.Location = new System.Drawing.Point(466, 10);
            this.open_directory.Name = "open_directory";
            this.open_directory.Size = new System.Drawing.Size(150, 61);
            this.open_directory.TabIndex = 2;
            this.open_directory.Text = "Otwórz Folder";
            this.open_directory.UseVisualStyleBackColor = true;
            this.open_directory.Click += new System.EventHandler(this.open_directory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.Image_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 475);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zdjęcia";
            // 
            // Image_name
            // 
            this.Image_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Image_name.FormattingEnabled = true;
            this.Image_name.Location = new System.Drawing.Point(6, 19);
            this.Image_name.Name = "Image_name";
            this.Image_name.Size = new System.Drawing.Size(224, 446);
            this.Image_name.TabIndex = 0;
            this.Image_name.SelectedIndexChanged += new System.EventHandler(this.Image_name_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBoxImagePreview);
            this.groupBox2.Controls.Add(this.size_change);
            this.groupBox2.Location = new System.Drawing.Point(274, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 475);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podgląd";
            // 
            // pictureBoxImagePreview
            // 
            this.pictureBoxImagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagePreview.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImagePreview.Name = "pictureBoxImagePreview";
            this.pictureBoxImagePreview.Size = new System.Drawing.Size(892, 450);
            this.pictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagePreview.TabIndex = 0;
            this.pictureBoxImagePreview.TabStop = false;
            // 
            // size_change
            // 
            this.size_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.size_change.Location = new System.Drawing.Point(741, 444);
            this.size_change.Name = "size_change";
            this.size_change.Size = new System.Drawing.Size(157, 47);
            this.size_change.TabIndex = 5;
            this.size_change.Text = "Zmień Rozmiar Zdjęcia";
            this.size_change.UseVisualStyleBackColor = true;
            this.size_change.Visible = false;
            this.size_change.Click += new System.EventHandler(this.size_change_Click);
            // 
            // add_data
            // 
            this.add_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_data.Location = new System.Drawing.Point(835, 24);
            this.add_data.Name = "add_data";
            this.add_data.Size = new System.Drawing.Size(343, 93);
            this.add_data.TabIndex = 6;
            this.add_data.Text = "Zmień Rozmiar i Dodaj Datę";
            this.add_data.UseVisualStyleBackColor = true;
            this.add_data.Click += new System.EventHandler(this.add_data_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Obecny Rozmiar pliku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rozmiar Zdjęcia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rozmiar Zdjęcia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wysokość x Szerokość";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 626);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.open_directory);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DataChanger_Resizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button open_directory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Image_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button size_change;
        private System.Windows.Forms.Button add_data;
        private System.Windows.Forms.PictureBox pictureBoxImagePreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

