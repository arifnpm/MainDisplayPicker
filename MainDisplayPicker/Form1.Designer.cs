
namespace MainDisplayPicker
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetAsMain = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnShowThisOnly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetAsMain
            // 
            this.btnSetAsMain.Location = new System.Drawing.Point(12, 114);
            this.btnSetAsMain.Name = "btnSetAsMain";
            this.btnSetAsMain.Size = new System.Drawing.Size(134, 23);
            this.btnSetAsMain.TabIndex = 1;
            this.btnSetAsMain.Text = "Set this monitor as main";
            this.btnSetAsMain.UseVisualStyleBackColor = true;
            this.btnSetAsMain.Click += new System.EventHandler(this.btnSetAsMain_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(152, 114);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(134, 23);
            this.btnExtend.TabIndex = 2;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnShowThisOnly
            // 
            this.btnShowThisOnly.Location = new System.Drawing.Point(292, 114);
            this.btnShowThisOnly.Name = "btnShowThisOnly";
            this.btnShowThisOnly.Size = new System.Drawing.Size(134, 23);
            this.btnShowThisOnly.TabIndex = 3;
            this.btnShowThisOnly.Text = "Show this monitor only";
            this.btnShowThisOnly.UseVisualStyleBackColor = true;
            this.btnShowThisOnly.Click += new System.EventHandler(this.btnShowThisOnly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 149);
            this.Controls.Add(this.btnShowThisOnly);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.btnSetAsMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Display Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSetAsMain;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnShowThisOnly;
    }
}

