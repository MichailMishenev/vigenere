namespace vigenere
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            txtMessage = new System.Windows.Forms.TextBox();
            btnEncrypt = new System.Windows.Forms.Button();
            txtKey = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnDecrypt = new System.Windows.Forms.Button();
            txtResult = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnLoadFile = new System.Windows.Forms.Button();
            btnSaveFile = new System.Windows.Forms.Button();
            btnGuide = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(45, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 42);
            label1.TabIndex = 0;
            label1.Text = "Поле ввода:";
            // 
            // txtMessage
            // 
            txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            txtMessage.Location = new System.Drawing.Point(283, 4);
            txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtMessage.Size = new System.Drawing.Size(398, 118);
            txtMessage.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            btnEncrypt.BackgroundImage = Properties.Resources.button_4;
            btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            btnEncrypt.Location = new System.Drawing.Point(101, 471);
            btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new System.Drawing.Size(282, 82);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Шифровать";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtKey
            // 
            txtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            txtKey.Location = new System.Drawing.Point(283, 130);
            txtKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtKey.Multiline = true;
            txtKey.Name = "txtKey";
            txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtKey.Size = new System.Drawing.Size(398, 100);
            txtKey.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label4.Location = new System.Drawing.Point(155, 159);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 42);
            label4.TabIndex = 8;
            label4.Text = "Ключ:";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            btnDecrypt.BackgroundImage = Properties.Resources.button_4;
            btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            btnDecrypt.Location = new System.Drawing.Point(426, 471);
            btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new System.Drawing.Size(282, 82);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Дешифровать";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = System.Drawing.SystemColors.Window;
            txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            txtResult.Location = new System.Drawing.Point(283, 238);
            txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtResult.Size = new System.Drawing.Size(398, 118);
            txtResult.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label2.Location = new System.Drawing.Point(70, 276);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(207, 42);
            label2.TabIndex = 12;
            label2.Text = "Результат:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            tableLayoutPanel1.Controls.Add(txtMessage, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtKey, 1, 1);
            tableLayoutPanel1.Controls.Add(txtResult, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLoadFile, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSaveFile, 2, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(2, 84);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new System.Drawing.Size(760, 360);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnLoadFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnLoadFile.BackgroundImage = Properties.Resources.Download_icon_smooth;
            btnLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLoadFile.FlatAppearance.BorderSize = 2;
            btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            btnLoadFile.Location = new System.Drawing.Point(687, 19);
            btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new System.Drawing.Size(70, 88);
            btnLoadFile.TabIndex = 13;
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSaveFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnSaveFile.BackgroundImage = Properties.Resources.Upload_icon_smooth1;
            btnSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSaveFile.FlatAppearance.BorderSize = 2;
            btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            btnSaveFile.Location = new System.Drawing.Point(687, 253);
            btnSaveFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new System.Drawing.Size(70, 88);
            btnSaveFile.TabIndex = 14;
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnGuide
            // 
            btnGuide.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnGuide.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnGuide.BackgroundImage = Properties.Resources.q;
            btnGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGuide.FlatAppearance.BorderSize = 2;
            btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            btnGuide.Location = new System.Drawing.Point(12, 469);
            btnGuide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGuide.Name = "btnGuide";
            btnGuide.Size = new System.Drawing.Size(70, 88);
            btnGuide.TabIndex = 15;
            btnGuide.UseVisualStyleBackColor = false;
            btnGuide.Click += btnGuide_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Виженер", "Цезарь", "Атбаш" });
            comboBox1.Location = new System.Drawing.Point(328, 16);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(176, 39);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_31;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(792, 569);
            Controls.Add(comboBox1);
            Controls.Add(btnGuide);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(810, 616);
            Name = "Form1";
            Text = "Шифровальщик";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

