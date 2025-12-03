namespace Biblioteka
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttytul = new TextBox();
            tabControl1 = new TabControl();
            ksiazki = new TabPage();
            Szykaj = new Label();
            txtSzukaj = new TextBox();
            listBox1 = new ListBox();
            DodajKsiazki = new TabPage();
            pictureBox1 = new PictureBox();
            dodajKsiazke = new Button();
            label6 = new Label();
            txtkategory = new TextBox();
            label5 = new Label();
            rokwydaniaint = new NumericUpDown();
            txtautor = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            ksiazki.SuspendLayout();
            DodajKsiazki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rokwydaniaint).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 1;
            label2.Text = "tytuł";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(881, 42);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 2;
            // 
            // txttytul
            // 
            txttytul.BackColor = Color.FromArgb(192, 192, 255);
            txttytul.Font = new Font("Tahoma", 12F);
            txttytul.Location = new Point(6, 116);
            txttytul.Name = "txttytul";
            txttytul.Size = new Size(282, 32);
            txttytul.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ksiazki);
            tabControl1.Controls.Add(DodajKsiazki);
            tabControl1.Font = new Font("Tahoma", 12F);
            tabControl1.Location = new Point(2, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1080, 533);
            tabControl1.TabIndex = 5;
            // 
            // ksiazki
            // 
            ksiazki.BackColor = Color.FromArgb(224, 224, 224);
            ksiazki.BackgroundImageLayout = ImageLayout.None;
            ksiazki.Controls.Add(Szykaj);
            ksiazki.Controls.Add(txtSzukaj);
            ksiazki.Controls.Add(listBox1);
            ksiazki.Location = new Point(4, 33);
            ksiazki.Name = "ksiazki";
            ksiazki.Padding = new Padding(3);
            ksiazki.Size = new Size(1072, 496);
            ksiazki.TabIndex = 0;
            ksiazki.Text = "Książki";
            // 
            // Szykaj
            // 
            Szykaj.AutoSize = true;
            Szykaj.Location = new Point(96, 15);
            Szykaj.Name = "Szykaj";
            Szykaj.Size = new Size(74, 24);
            Szykaj.TabIndex = 2;
            Szykaj.Text = "Szukaj ";
            // 
            // txtSzukaj
            // 
            txtSzukaj.Location = new Point(190, 12);
            txtSzukaj.Name = "txtSzukaj";
            txtSzukaj.Size = new Size(125, 32);
            txtSzukaj.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(17, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1033, 436);
            listBox1.TabIndex = 0;
            // 
            // DodajKsiazki
            // 
            DodajKsiazki.BackColor = Color.FromArgb(224, 224, 224);
            DodajKsiazki.BorderStyle = BorderStyle.Fixed3D;
            DodajKsiazki.Controls.Add(pictureBox1);
            DodajKsiazki.Controls.Add(dodajKsiazke);
            DodajKsiazki.Controls.Add(label6);
            DodajKsiazki.Controls.Add(txtkategory);
            DodajKsiazki.Controls.Add(label5);
            DodajKsiazki.Controls.Add(rokwydaniaint);
            DodajKsiazki.Controls.Add(txtautor);
            DodajKsiazki.Controls.Add(label4);
            DodajKsiazki.Controls.Add(label3);
            DodajKsiazki.Controls.Add(txttytul);
            DodajKsiazki.Controls.Add(label2);
            DodajKsiazki.Location = new Point(4, 33);
            DodajKsiazki.Name = "DodajKsiazki";
            DodajKsiazki.Padding = new Padding(3);
            DodajKsiazki.Size = new Size(1072, 496);
            DodajKsiazki.TabIndex = 1;
            DodajKsiazki.Text = "DodajKsiazki";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book;
            pictureBox1.Location = new Point(625, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 262);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // dodajKsiazke
            // 
            dodajKsiazke.Font = new Font("MS Reference Specialty", 48F, FontStyle.Italic, GraphicsUnit.Point, 2);
            dodajKsiazke.Location = new Point(735, 349);
            dodajKsiazke.Name = "dodajKsiazke";
            dodajKsiazke.Size = new Size(282, 137);
            dodajKsiazke.TabIndex = 11;
            dodajKsiazke.Text = "Dodaj";
            dodajKsiazke.UseVisualStyleBackColor = true;
            dodajKsiazke.Click += dodajKsiazke_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 367);
            label6.Name = "label6";
            label6.Size = new Size(96, 24);
            label6.TabIndex = 10;
            label6.Text = "Kategoria";
            // 
            // txtkategory
            // 
            txtkategory.AcceptsReturn = true;
            txtkategory.BackColor = Color.FromArgb(192, 192, 255);
            txtkategory.Font = new Font("Tahoma", 12F);
            txtkategory.Location = new Point(6, 417);
            txtkategory.Name = "txtkategory";
            txtkategory.Size = new Size(186, 32);
            txtkategory.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 265);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 8;
            label5.Text = "Rok Wydania";
            // 
            // rokwydaniaint
            // 
            rokwydaniaint.BackColor = Color.FromArgb(192, 192, 255);
            rokwydaniaint.Location = new Point(6, 316);
            rokwydaniaint.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            rokwydaniaint.Name = "rokwydaniaint";
            rokwydaniaint.Size = new Size(150, 32);
            rokwydaniaint.TabIndex = 7;
            rokwydaniaint.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // txtautor
            // 
            txtautor.AcceptsReturn = true;
            txtautor.BackColor = Color.FromArgb(192, 192, 255);
            txtautor.Font = new Font("Tahoma", 12F);
            txtautor.Location = new Point(4, 216);
            txtautor.Name = "txtautor";
            txtautor.Size = new Size(282, 32);
            txtautor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 172);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 5;
            label4.Text = "Autor";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1094, 606);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteka";
            tabControl1.ResumeLayout(false);
            ksiazki.ResumeLayout(false);
            ksiazki.PerformLayout();
            DodajKsiazki.ResumeLayout(false);
            DodajKsiazki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rokwydaniaint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttytul;
        private TabControl tabControl1;
        private TabPage ksiazki;
        private TabPage DodajKsiazki;
        private TextBox txtautor;
        private Label label4;
        private Label label6;
        private TextBox txtkategory;
        private Label label5;
        private NumericUpDown rokwydaniaint;
        private Button dodajKsiazke;
        private PictureBox pictureBox1;
        private Label Szykaj;
        private TextBox txtSzukaj;
        private ListBox listBox1;
    }
}
