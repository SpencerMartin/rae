namespace RAE {
	partial class menuWnd {
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
			this.titleLbl = new System.Windows.Forms.Label();
			this.prepareDataBtn = new System.Windows.Forms.Button();
			this.chooseAttributesBtn = new System.Windows.Forms.Button();
			this.runAnalysisBtn = new System.Windows.Forms.Button();
			this.saveHistoryBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleLbl
			// 
			this.titleLbl.Font = new System.Drawing.Font("PT Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLbl.Location = new System.Drawing.Point(-1, -1);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(385, 60);
			this.titleLbl.TabIndex = 0;
			this.titleLbl.Text = "Retention Analysis";
			this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// prepareDataBtn
			// 
			this.prepareDataBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prepareDataBtn.Location = new System.Drawing.Point(93, 85);
			this.prepareDataBtn.Name = "prepareDataBtn";
			this.prepareDataBtn.Size = new System.Drawing.Size(210, 63);
			this.prepareDataBtn.TabIndex = 1;
			this.prepareDataBtn.Text = "Prepare Data";
			this.prepareDataBtn.UseVisualStyleBackColor = true;
			this.prepareDataBtn.Click += new System.EventHandler(this.prepareDataBtn_Click);
			// 
			// chooseAttributesBtn
			// 
			this.chooseAttributesBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseAttributesBtn.Location = new System.Drawing.Point(93, 163);
			this.chooseAttributesBtn.Name = "chooseAttributesBtn";
			this.chooseAttributesBtn.Size = new System.Drawing.Size(210, 63);
			this.chooseAttributesBtn.TabIndex = 2;
			this.chooseAttributesBtn.Text = "Choose Attributes";
			this.chooseAttributesBtn.UseVisualStyleBackColor = true;
			this.chooseAttributesBtn.Click += new System.EventHandler(this.chooseAttributesBtn_Click);
			// 
			// runAnalysisBtn
			// 
			this.runAnalysisBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.runAnalysisBtn.Location = new System.Drawing.Point(93, 242);
			this.runAnalysisBtn.Name = "runAnalysisBtn";
			this.runAnalysisBtn.Size = new System.Drawing.Size(210, 63);
			this.runAnalysisBtn.TabIndex = 4;
			this.runAnalysisBtn.Text = "Run Analysis";
			this.runAnalysisBtn.UseVisualStyleBackColor = true;
			this.runAnalysisBtn.Click += new System.EventHandler(this.runAnalysisBtn_Click);
			// 
			// saveHistoryBtn
			// 
			this.saveHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveHistoryBtn.Image = global::RAE.Properties.Resources.save;
			this.saveHistoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveHistoryBtn.Location = new System.Drawing.Point(113, 331);
			this.saveHistoryBtn.Name = "saveHistoryBtn";
			this.saveHistoryBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.saveHistoryBtn.Size = new System.Drawing.Size(173, 23);
			this.saveHistoryBtn.TabIndex = 5;
			this.saveHistoryBtn.Text = "Save command history";
			this.saveHistoryBtn.UseVisualStyleBackColor = true;
			this.saveHistoryBtn.Click += new System.EventHandler(this.saveHistoryBtn_Click);
			// 
			// menuWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 390);
			this.Controls.Add(this.saveHistoryBtn);
			this.Controls.Add(this.runAnalysisBtn);
			this.Controls.Add(this.chooseAttributesBtn);
			this.Controls.Add(this.prepareDataBtn);
			this.Controls.Add(this.titleLbl);
			this.Name = "menuWnd";
			this.Text = "RAE - Menu";
			this.Load += new System.EventHandler(this.menuWnd_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.Button prepareDataBtn;
		private System.Windows.Forms.Button chooseAttributesBtn;
		private System.Windows.Forms.Button runAnalysisBtn;
		private System.Windows.Forms.Button saveHistoryBtn;
	}
}

