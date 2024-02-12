namespace BitcoinWallet
{
    partial class Form1
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
            btnPrivKeyGen = new Button();
            label2 = new Label();
            label3 = new Label();
            tbxPrivateKey = new TextBox();
            tbxAddress1 = new TextBox();
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            btnSeedPhrGen = new Button();
            tbxAddress2 = new TextBox();
            label1 = new Label();
            tbxMnemonic = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrivKeyGen
            // 
            btnPrivKeyGen.Location = new Point(29, 32);
            btnPrivKeyGen.Name = "btnPrivKeyGen";
            btnPrivKeyGen.Size = new Size(166, 23);
            btnPrivKeyGen.TabIndex = 1;
            btnPrivKeyGen.Text = "Generate via private key";
            btnPrivKeyGen.UseVisualStyleBackColor = true;
            btnPrivKeyGen.Click += btnPrivKeyGen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 96);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Private key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 156);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // tbxPrivateKey
            // 
            tbxPrivateKey.Location = new Point(99, 93);
            tbxPrivateKey.Name = "tbxPrivateKey";
            tbxPrivateKey.ReadOnly = true;
            tbxPrivateKey.Size = new Size(478, 23);
            tbxPrivateKey.TabIndex = 2;
            // 
            // tbxAddress1
            // 
            tbxAddress1.Location = new Point(99, 153);
            tbxAddress1.Name = "tbxAddress1";
            tbxAddress1.ReadOnly = true;
            tbxAddress1.Size = new Size(314, 23);
            tbxAddress1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPrivKeyGen);
            groupBox1.Controls.Add(tbxAddress1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxPrivateKey);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 225);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generate address by private key";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 225;
            splitContainer1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSeedPhrGen);
            groupBox2.Controls.Add(tbxAddress2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbxMnemonic);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 221);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generate address by seed phrase";
            // 
            // btnSeedPhrGen
            // 
            btnSeedPhrGen.Location = new Point(29, 38);
            btnSeedPhrGen.Name = "btnSeedPhrGen";
            btnSeedPhrGen.Size = new Size(166, 23);
            btnSeedPhrGen.TabIndex = 4;
            btnSeedPhrGen.Text = "Generate via seed phrase";
            btnSeedPhrGen.UseVisualStyleBackColor = true;
            btnSeedPhrGen.Click += btnSeedPhrGen_Click;
            // 
            // tbxAddress2
            // 
            tbxAddress2.Location = new Point(99, 153);
            tbxAddress2.Name = "tbxAddress2";
            tbxAddress2.ReadOnly = true;
            tbxAddress2.Size = new Size(314, 23);
            tbxAddress2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 96);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Mnemonic";
            // 
            // tbxMnemonic
            // 
            tbxMnemonic.Location = new Point(99, 93);
            tbxMnemonic.Name = "tbxMnemonic";
            tbxMnemonic.ReadOnly = true;
            tbxMnemonic.Size = new Size(478, 23);
            tbxMnemonic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 156);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bitcoin Wallet";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPrivKeyGen;
        private Label label2;
        private Label label3;
        private TextBox tbxPrivateKey;
        private TextBox tbxAddress1;
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Button btnSeedPhrGen;
        private TextBox tbxAddress2;
        private Label label1;
        private TextBox tbxMnemonic;
        private Label label4;
    }
}
