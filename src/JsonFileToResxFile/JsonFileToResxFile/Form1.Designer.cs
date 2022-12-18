namespace JsonFileToResxFile
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTo = new System.Windows.Forms.Button();
            this.richTextResx = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextJson = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvailableKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTo);
            this.tabPage1.Controls.Add(this.richTextResx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.richTextJson);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Converts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTo
            // 
            this.btnTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTo.Location = new System.Drawing.Point(377, 19);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(75, 23);
            this.btnTo.TabIndex = 9;
            this.btnTo.Text = ">>";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // richTextResx
            // 
            this.richTextResx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextResx.Location = new System.Drawing.Point(458, 19);
            this.richTextResx.Name = "richTextResx";
            this.richTextResx.ReadOnly = true;
            this.richTextResx.Size = new System.Drawing.Size(395, 463);
            this.richTextResx.TabIndex = 8;
            this.richTextResx.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resx:";
            // 
            // richTextJson
            // 
            this.richTextJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextJson.Location = new System.Drawing.Point(8, 19);
            this.richTextJson.Name = "richTextJson";
            this.richTextJson.Size = new System.Drawing.Size(364, 463);
            this.richTextJson.TabIndex = 6;
            this.richTextJson.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Json file Content: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtRegex);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtAvailableKey);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtTemplate);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Templete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Regex of matche key and value:";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(32, 125);
            this.txtRegex.Multiline = true;
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(778, 76);
            this.txtRegex.TabIndex = 4;
            this.txtRegex.Text = "\\\"([^\\\"\\\\]|\\\\([\\\"\\\\\\/bfnrt]|u[a-zA-Z\\d]{4}))*\\\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Keys :";
            // 
            // txtAvailableKey
            // 
            this.txtAvailableKey.Location = new System.Drawing.Point(32, 53);
            this.txtAvailableKey.Multiline = true;
            this.txtAvailableKey.Name = "txtAvailableKey";
            this.txtAvailableKey.ReadOnly = true;
            this.txtAvailableKey.Size = new System.Drawing.Size(778, 40);
            this.txtAvailableKey.TabIndex = 2;
            this.txtAvailableKey.Text = "$key$\r\n$value$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Template of resx:";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(32, 268);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(778, 94);
            this.txtTemplate.TabIndex = 0;
            this.txtTemplate.Text = "<data name=\"$key$\" xml:space=\"preserve\">\r\n    <value>$value$</value>\r\n  </data>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(636, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "* should be return a two values";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Json To Resx file";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnTo;
        private RichTextBox richTextResx;
        private Label label2;
        private RichTextBox richTextJson;
        private Label label1;
        private TabPage tabPage2;
        private Label label4;
        private TextBox txtAvailableKey;
        private Label label3;
        private TextBox txtTemplate;
        private Label label5;
        private TextBox txtRegex;
        private Label label6;
    }
}