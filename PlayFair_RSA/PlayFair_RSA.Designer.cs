namespace PlayFair_RSA
{
    partial class PlayFair_RSA
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
            Tab = new TabControl();
            tabPage_PlayFair = new TabPage();
            button_randomkey = new Button();
            button_file = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_CypherText = new TextBox();
            textBox_Key = new TextBox();
            textBox_PlainText = new TextBox();
            tabPage2 = new TabPage();
            txtDecrypted = new TextBox();
            txtEncrypted = new TextBox();
            btnDecrypted = new Button();
            btnEncrypted = new Button();
            txtMessage = new TextBox();
            txtPrivateKey = new TextBox();
            txtPublicKey = new TextBox();
            btnGenerateKeys = new Button();
            txtQ = new TextBox();
            txtP = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            Tab.SuspendLayout();
            tabPage_PlayFair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Tab
            // 
            Tab.Controls.Add(tabPage_PlayFair);
            Tab.Controls.Add(tabPage2);
            Tab.Location = new Point(2, 12);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new Size(796, 438);
            Tab.TabIndex = 1;
            // 
            // tabPage_PlayFair
            // 
            tabPage_PlayFair.Controls.Add(button_randomkey);
            tabPage_PlayFair.Controls.Add(button_file);
            tabPage_PlayFair.Controls.Add(dataGridView1);
            tabPage_PlayFair.Controls.Add(button1);
            tabPage_PlayFair.Controls.Add(label3);
            tabPage_PlayFair.Controls.Add(label2);
            tabPage_PlayFair.Controls.Add(label1);
            tabPage_PlayFair.Controls.Add(textBox_CypherText);
            tabPage_PlayFair.Controls.Add(textBox_Key);
            tabPage_PlayFair.Controls.Add(textBox_PlainText);
            tabPage_PlayFair.Location = new Point(4, 29);
            tabPage_PlayFair.Name = "tabPage_PlayFair";
            tabPage_PlayFair.Padding = new Padding(3);
            tabPage_PlayFair.Size = new Size(788, 405);
            tabPage_PlayFair.TabIndex = 0;
            tabPage_PlayFair.Text = "PlayFair";
            tabPage_PlayFair.UseVisualStyleBackColor = true;
            // 
            // button_randomkey
            // 
            button_randomkey.Location = new Point(664, 73);
            button_randomkey.Name = "button_randomkey";
            button_randomkey.Size = new Size(102, 29);
            button_randomkey.TabIndex = 6;
            button_randomkey.Text = "Tạo khóa";
            button_randomkey.UseVisualStyleBackColor = true;
            button_randomkey.Click += button_randomkey_Click;
            // 
            // button_file
            // 
            button_file.Location = new Point(664, 23);
            button_file.Name = "button_file";
            button_file.Size = new Size(102, 29);
            button_file.TabIndex = 6;
            button_file.Text = "Chọn file";
            button_file.UseVisualStyleBackColor = true;
            button_file.Click += button_file_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(182, 168);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(664, 135);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 4;
            button1.Text = "Mã hóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 354);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Cypher Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 3;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Plain Text";
            // 
            // textBox_CypherText
            // 
            textBox_CypherText.Location = new Point(115, 347);
            textBox_CypherText.Name = "textBox_CypherText";
            textBox_CypherText.ReadOnly = true;
            textBox_CypherText.Size = new Size(528, 27);
            textBox_CypherText.TabIndex = 2;
            // 
            // textBox_Key
            // 
            textBox_Key.Location = new Point(115, 75);
            textBox_Key.Name = "textBox_Key";
            textBox_Key.Size = new Size(528, 27);
            textBox_Key.TabIndex = 2;
            // 
            // textBox_PlainText
            // 
            textBox_PlainText.Location = new Point(115, 23);
            textBox_PlainText.Name = "textBox_PlainText";
            textBox_PlainText.Size = new Size(528, 27);
            textBox_PlainText.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtDecrypted);
            tabPage2.Controls.Add(txtEncrypted);
            tabPage2.Controls.Add(btnDecrypted);
            tabPage2.Controls.Add(btnEncrypted);
            tabPage2.Controls.Add(txtMessage);
            tabPage2.Controls.Add(txtPrivateKey);
            tabPage2.Controls.Add(txtPublicKey);
            tabPage2.Controls.Add(btnGenerateKeys);
            tabPage2.Controls.Add(txtQ);
            tabPage2.Controls.Add(txtP);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "RSA";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(586, 203);
            txtDecrypted.Multiline = true;
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.ReadOnly = true;
            txtDecrypted.Size = new Size(159, 56);
            txtDecrypted.TabIndex = 16;
            // 
            // txtEncrypted
            // 
            txtEncrypted.Location = new Point(383, 203);
            txtEncrypted.Multiline = true;
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.ReadOnly = true;
            txtEncrypted.Size = new Size(163, 56);
            txtEncrypted.TabIndex = 15;
            // 
            // btnDecrypted
            // 
            btnDecrypted.Location = new Point(597, 81);
            btnDecrypted.Name = "btnDecrypted";
            btnDecrypted.Size = new Size(94, 29);
            btnDecrypted.TabIndex = 14;
            btnDecrypted.Text = "Decrypt";
            btnDecrypted.UseVisualStyleBackColor = true;
            btnDecrypted.Click += btnDecrypted_Click;
            // 
            // btnEncrypted
            // 
            btnEncrypted.Location = new Point(423, 80);
            btnEncrypted.Name = "btnEncrypted";
            btnEncrypted.Size = new Size(94, 29);
            btnEncrypted.TabIndex = 13;
            btnEncrypted.Text = "Encrypt";
            btnEncrypted.UseVisualStyleBackColor = true;
            btnEncrypted.Click += btnEncrypted_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(563, 35);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(123, 27);
            txtMessage.TabIndex = 12;
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Location = new Point(19, 294);
            txtPrivateKey.Multiline = true;
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.ReadOnly = true;
            txtPrivateKey.Size = new Size(294, 55);
            txtPrivateKey.TabIndex = 11;
            // 
            // txtPublicKey
            // 
            txtPublicKey.Location = new Point(19, 203);
            txtPublicKey.Multiline = true;
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.ReadOnly = true;
            txtPublicKey.Size = new Size(294, 56);
            txtPublicKey.TabIndex = 10;
            // 
            // btnGenerateKeys
            // 
            btnGenerateKeys.Location = new Point(187, 107);
            btnGenerateKeys.Name = "btnGenerateKeys";
            btnGenerateKeys.Size = new Size(126, 29);
            btnGenerateKeys.TabIndex = 9;
            btnGenerateKeys.Text = "Create";
            btnGenerateKeys.UseVisualStyleBackColor = true;
            btnGenerateKeys.Click += btnGenerateKeys_Click_1;
            // 
            // txtQ
            // 
            txtQ.Location = new Point(188, 74);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(125, 27);
            txtQ.TabIndex = 8;
            // 
            // txtP
            // 
            txtP.Location = new Point(188, 38);
            txtP.Name = "txtP";
            txtP.Size = new Size(125, 27);
            txtP.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(586, 179);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 6;
            label10.Text = "Giải mã:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 179);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 5;
            label9.Text = "Mã hóa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 38);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 4;
            label8.Text = "Nhập thông điệp (số):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 271);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 3;
            label7.Text = "Khóa bí mật:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 179);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 2;
            label6.Text = "Khóa công khai:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 71);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 1;
            label5.Text = "Nhập số nguyên tố q:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 41);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 0;
            label4.Text = "Nhập số nguyên tố p:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // PlayFair_RSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tab);
            Name = "PlayFair_RSA";
            Text = "PlayFair_RSA";
            Tab.ResumeLayout(false);
            tabPage_PlayFair.ResumeLayout(false);
            tabPage_PlayFair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tab;
        private TabPage tabPage_PlayFair;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox_PlainText;
        private Button button1;
        private Label label2;
        private TextBox textBox_Key;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox_CypherText;
        private Button button_randomkey;
        private Button button_file;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtMessage;
        private TextBox txtPrivateKey;
        private TextBox txtPublicKey;
        private Button btnGenerateKeys;
        private TextBox txtQ;
        private TextBox txtP;
        private TextBox txtDecrypted;
        private TextBox txtEncrypted;
        private Button btnDecrypted;
        private Button btnEncrypted;
    }
}
