namespace RAE.Analysis_Forms {
	partial class aprioriWnd {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aprioriWnd));
			this.confidenceLbl = new System.Windows.Forms.Label();
			this.supportLbl = new System.Windows.Forms.Label();
			this.confidenceFld = new System.Windows.Forms.ComboBox();
			this.supportFld = new System.Windows.Forms.ComboBox();
			this.output = new System.Windows.Forms.TextBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.runBtn = new System.Windows.Forms.Button();
			this.explanationLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// confidenceLbl
			// 
			this.confidenceLbl.AutoSize = true;
			this.confidenceLbl.Location = new System.Drawing.Point(190, 17);
			this.confidenceLbl.Name = "confidenceLbl";
			this.confidenceLbl.Size = new System.Drawing.Size(64, 13);
			this.confidenceLbl.TabIndex = 0;
			this.confidenceLbl.Text = "Confidence:";
			// 
			// supportLbl
			// 
			this.supportLbl.AutoSize = true;
			this.supportLbl.Location = new System.Drawing.Point(12, 17);
			this.supportLbl.Name = "supportLbl";
			this.supportLbl.Size = new System.Drawing.Size(47, 13);
			this.supportLbl.TabIndex = 1;
			this.supportLbl.Text = "Support:";
			// 
			// confidenceFld
			// 
			this.confidenceFld.FormattingEnabled = true;
			this.confidenceFld.Items.AddRange(new object[] {
            "1.0",
            "0.9",
            "0.8",
            "0.7",
            "0.6",
            "0.5",
            "0.4",
            "0.3",
            "0.2",
            "0.1"});
			this.confidenceFld.Location = new System.Drawing.Point(260, 14);
			this.confidenceFld.Name = "confidenceFld";
			this.confidenceFld.Size = new System.Drawing.Size(90, 21);
			this.confidenceFld.TabIndex = 3;
			this.confidenceFld.Text = "0.5";
			this.confidenceFld.SelectedIndexChanged += new System.EventHandler(this.confidenceFld_SelectedIndexChanged);
			// 
			// supportFld
			// 
			this.supportFld.FormattingEnabled = true;
			this.supportFld.Items.AddRange(new object[] {
            "1.0",
            "0.9",
            "0.8",
            "0.7",
            "0.6",
            "0.5",
            "0.4",
            "0.3",
            "0.2",
            "0.1"});
			this.supportFld.Location = new System.Drawing.Point(65, 14);
			this.supportFld.Name = "supportFld";
			this.supportFld.Size = new System.Drawing.Size(90, 21);
			this.supportFld.TabIndex = 4;
			this.supportFld.Text = "0.5";
			this.supportFld.SelectedIndexChanged += new System.EventHandler(this.supportFld_SelectedIndexChanged);
			// 
			// output
			// 
			this.output.Location = new System.Drawing.Point(15, 132);
			this.output.Multiline = true;
			this.output.Name = "output";
			this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.output.Size = new System.Drawing.Size(875, 479);
			this.output.TabIndex = 6;
			// 
			// saveBtn
			// 
			this.saveBtn.Image = global::RAE.Properties.Resources.save;
			this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveBtn.Location = new System.Drawing.Point(482, 12);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.saveBtn.Size = new System.Drawing.Size(118, 23);
			this.saveBtn.TabIndex = 21;
			this.saveBtn.Text = "Save Output";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// runBtn
			// 
			this.runBtn.Image = ((System.Drawing.Image)(resources.GetObject("runBtn.Image")));
			this.runBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.runBtn.Location = new System.Drawing.Point(382, 12);
			this.runBtn.Name = "runBtn";
			this.runBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.runBtn.Size = new System.Drawing.Size(75, 23);
			this.runBtn.TabIndex = 20;
			this.runBtn.Text = "Run";
			this.runBtn.UseVisualStyleBackColor = true;
			this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
			// 
			// explanationLbl
			// 
			this.explanationLbl.Location = new System.Drawing.Point(12, 56);
			this.explanationLbl.Name = "explanationLbl";
			this.explanationLbl.Size = new System.Drawing.Size(878, 60);
			this.explanationLbl.TabIndex = 22;
			this.explanationLbl.Text = resources.GetString("explanationLbl.Text");
			this.explanationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// aprioriWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 623);
			this.Controls.Add(this.explanationLbl);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.runBtn);
			this.Controls.Add(this.output);
			this.Controls.Add(this.supportFld);
			this.Controls.Add(this.confidenceFld);
			this.Controls.Add(this.supportLbl);
			this.Controls.Add(this.confidenceLbl);
			this.Name = "aprioriWnd";
			this.Text = "Associations";
			this.Load += new System.EventHandler(this.aprioriWnd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label confidenceLbl;
		private System.Windows.Forms.Label supportLbl;
		private System.Windows.Forms.ComboBox confidenceFld;
		private System.Windows.Forms.ComboBox supportFld;
		private System.Windows.Forms.TextBox output;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.Label explanationLbl;
	}
}