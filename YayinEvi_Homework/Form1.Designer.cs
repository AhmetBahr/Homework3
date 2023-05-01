namespace YayinEvi_Homework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxEditor = new System.Windows.Forms.ListBox();
            this.comboBoxYayinEvi = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editor_isim1 = new System.Windows.Forms.TextBox();
            this.editor_soyisim1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBoxYazar = new System.Windows.Forms.ComboBox();
            this.btmYazar = new System.Windows.Forms.Button();
            this.Isım = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBoxKitap = new System.Windows.Forms.ComboBox();
            this.btmKitap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editor_isim2 = new System.Windows.Forms.TextBox();
            this.editor_soyisim2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 314);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 277);
            this.listBox1.TabIndex = 0;
            // 
            // listBoxEditor
            // 
            this.listBoxEditor.FormattingEnabled = true;
            this.listBoxEditor.Location = new System.Drawing.Point(458, 314);
            this.listBoxEditor.Name = "listBoxEditor";
            this.listBoxEditor.Size = new System.Drawing.Size(170, 277);
            this.listBoxEditor.TabIndex = 2;
            this.listBoxEditor.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // comboBoxYayinEvi
            // 
            this.comboBoxYayinEvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxYayinEvi.FormattingEnabled = true;
            this.comboBoxYayinEvi.Location = new System.Drawing.Point(685, 314);
            this.comboBoxYayinEvi.Name = "comboBoxYayinEvi";
            this.comboBoxYayinEvi.Size = new System.Drawing.Size(121, 150);
            this.comboBoxYayinEvi.TabIndex = 3;
            this.comboBoxYayinEvi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtYayin
            // 
            this.txtYayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayin.Location = new System.Drawing.Point(609, 69);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(180, 27);
            this.txtYayin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(606, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yayin Evi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(606, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Editor Ekle";
            // 
            // editor_isim1
            // 
            this.editor_isim1.Location = new System.Drawing.Point(609, 132);
            this.editor_isim1.Name = "editor_isim1";
            this.editor_isim1.Size = new System.Drawing.Size(100, 20);
            this.editor_isim1.TabIndex = 12;
            // 
            // editor_soyisim1
            // 
            this.editor_soyisim1.Location = new System.Drawing.Point(609, 158);
            this.editor_soyisim1.Name = "editor_soyisim1";
            this.editor_soyisim1.Size = new System.Drawing.Size(100, 20);
            this.editor_soyisim1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Isim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Soy isim";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(241, 314);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 277);
            this.listBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(238, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yazar Ekle";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(241, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(241, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // comboBoxYazar
            // 
            this.comboBoxYazar.FormattingEnabled = true;
            this.comboBoxYazar.Location = new System.Drawing.Point(241, 95);
            this.comboBoxYazar.Name = "comboBoxYazar";
            this.comboBoxYazar.Size = new System.Drawing.Size(120, 21);
            this.comboBoxYazar.TabIndex = 20;
            // 
            // btmYazar
            // 
            this.btmYazar.Location = new System.Drawing.Point(383, 95);
            this.btmYazar.Name = "btmYazar";
            this.btmYazar.Size = new System.Drawing.Size(71, 22);
            this.btmYazar.TabIndex = 21;
            this.btmYazar.Text = "Add";
            this.btmYazar.UseVisualStyleBackColor = true;
            this.btmYazar.Click += new System.EventHandler(this.btmYazar_Click);
            // 
            // Isım
            // 
            this.Isım.AutoSize = true;
            this.Isım.Location = new System.Drawing.Point(358, 43);
            this.Isım.Name = "Isım";
            this.Isım.Size = new System.Drawing.Size(25, 13);
            this.Isım.TabIndex = 22;
            this.Isım.Text = "Isım";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Soy isim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Yazar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 25;
            // 
            // comboBoxKitap
            // 
            this.comboBoxKitap.FormattingEnabled = true;
            this.comboBoxKitap.Location = new System.Drawing.Point(15, 75);
            this.comboBoxKitap.Name = "comboBoxKitap";
            this.comboBoxKitap.Size = new System.Drawing.Size(95, 21);
            this.comboBoxKitap.TabIndex = 26;
            // 
            // btmKitap
            // 
            this.btmKitap.Location = new System.Drawing.Point(136, 75);
            this.btmKitap.Name = "btmKitap";
            this.btmKitap.Size = new System.Drawing.Size(72, 21);
            this.btmKitap.TabIndex = 27;
            this.btmKitap.Text = "Add";
            this.btmKitap.UseVisualStyleBackColor = true;
            this.btmKitap.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editor_isim2
            // 
            this.editor_isim2.Location = new System.Drawing.Point(715, 132);
            this.editor_isim2.Name = "editor_isim2";
            this.editor_isim2.Size = new System.Drawing.Size(100, 20);
            this.editor_isim2.TabIndex = 29;
            // 
            // editor_soyisim2
            // 
            this.editor_soyisim2.Location = new System.Drawing.Point(715, 158);
            this.editor_soyisim2.Name = "editor_soyisim2";
            this.editor_soyisim2.Size = new System.Drawing.Size(100, 20);
            this.editor_soyisim2.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 629);
            this.Controls.Add(this.editor_soyisim2);
            this.Controls.Add(this.editor_isim2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmKitap);
            this.Controls.Add(this.comboBoxKitap);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Isım);
            this.Controls.Add(this.btmYazar);
            this.Controls.Add(this.comboBoxYazar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editor_soyisim1);
            this.Controls.Add(this.editor_isim1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYayin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxYayinEvi);
            this.Controls.Add(this.listBoxEditor);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxEditor;
        private System.Windows.Forms.ComboBox comboBoxYayinEvi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editor_isim1;
        private System.Windows.Forms.TextBox editor_soyisim1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBoxYazar;
        private System.Windows.Forms.Button btmYazar;
        private System.Windows.Forms.Label Isım;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBoxKitap;
        private System.Windows.Forms.Button btmKitap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox editor_isim2;
        private System.Windows.Forms.TextBox editor_soyisim2;
    }
}

