namespace Week4
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
            this.chkSouthfacing = new System.Windows.Forms.CheckBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.trktemp = new System.Windows.Forms.TrackBar();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trktemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthfacing
            // 
            this.chkSouthfacing.AutoSize = true;
            this.chkSouthfacing.Location = new System.Drawing.Point(73, 28);
            this.chkSouthfacing.Name = "chkSouthfacing";
            this.chkSouthfacing.Size = new System.Drawing.Size(202, 17);
            this.chkSouthfacing.TabIndex = 0;
            this.chkSouthfacing.Text = "Do you have a south facing window?\r\n";
            this.chkSouthfacing.UseVisualStyleBackColor = true;
            this.chkSouthfacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(89, 67);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(128, 13);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "How warm Is your Home?";
            this.lblTemp.Click += new System.EventHandler(this.lblTemp_Click);
            // 
            // trktemp
            // 
            this.trktemp.Location = new System.Drawing.Point(73, 101);
            this.trktemp.Maximum = 90;
            this.trktemp.Minimum = 50;
            this.trktemp.Name = "trktemp";
            this.trktemp.Size = new System.Drawing.Size(229, 45);
            this.trktemp.TabIndex = 2;
            this.trktemp.Value = 50;
            this.trktemp.Scroll += new System.EventHandler(this.trktemp_Scroll);
            // 
            // btnSuggest
            // 
            this.btnSuggest.Location = new System.Drawing.Point(73, 152);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(75, 23);
            this.btnSuggest.TabIndex = 3;
            this.btnSuggest.Text = "Suggest!";
            this.btnSuggest.UseVisualStyleBackColor = true;
            this.btnSuggest.Click += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Location = new System.Drawing.Point(228, 162);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(111, 13);
            this.lblSuggestion.TabIndex = 4;
            this.lblSuggestion.Text = "Plant suggestion Here";
            this.lblSuggestion.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(117, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "houseplant411.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHousePlantInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.trktemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.chkSouthfacing);
            this.Name = "Form1";
            this.Text = "Houseplant suggestions";
            ((System.ComponentModel.ISupportInitialize)(this.trktemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthfacing;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TrackBar trktemp;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

