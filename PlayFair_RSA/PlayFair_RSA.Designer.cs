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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox_Key = new TextBox();
            textBox_PlainText = new TextBox();
            tabPage2 = new TabPage();
            Tab.SuspendLayout();
            tabPage_PlayFair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPage_PlayFair.Controls.Add(dataGridView1);
            tabPage_PlayFair.Controls.Add(button1);
            tabPage_PlayFair.Controls.Add(label3);
            tabPage_PlayFair.Controls.Add(label2);
            tabPage_PlayFair.Controls.Add(label1);
            tabPage_PlayFair.Controls.Add(textBox1);
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
            button1.Location = new Point(665, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
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
            // textBox1
            // 
            textBox1.Location = new Point(115, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(528, 27);
            textBox1.TabIndex = 2;
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "RSA";
            tabPage2.UseVisualStyleBackColor = true;
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
        private TextBox textBox1;
    }
}
