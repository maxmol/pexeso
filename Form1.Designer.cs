namespace pexeso {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.bStart = new System.Windows.Forms.Button();
			this.LNavod = new System.Windows.Forms.Label();
			this.LPocetTahu = new System.Windows.Forms.Label();
			this.bKonec = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.bHratZnovu = new System.Windows.Forms.Button();
			this.LVysledek = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bStart
			// 
			this.bStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.bStart.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.bStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bStart.Location = new System.Drawing.Point(12, 364);
			this.bStart.Name = "bStart";
			this.bStart.Size = new System.Drawing.Size(776, 74);
			this.bStart.TabIndex = 0;
			this.bStart.Text = "START";
			this.bStart.UseVisualStyleBackColor = false;
			this.bStart.Visible = false;
			this.bStart.Click += new System.EventHandler(this.bStartClick);
			// 
			// LNavod
			// 
			this.LNavod.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.LNavod.Location = new System.Drawing.Point(12, 9);
			this.LNavod.Name = "LNavod";
			this.LNavod.Size = new System.Drawing.Size(776, 352);
			this.LNavod.TabIndex = 1;
			this.LNavod.Text = "\r\n\r\n▶ PEXESO ◀\r\n\r\nPro spuštění hry stiskněte \"START\"";
			this.LNavod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LNavod.Visible = false;
			// 
			// LPocetTahu
			// 
			this.LPocetTahu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.LPocetTahu.Location = new System.Drawing.Point(538, 9);
			this.LPocetTahu.Name = "LPocetTahu";
			this.LPocetTahu.Size = new System.Drawing.Size(250, 70);
			this.LPocetTahu.TabIndex = 2;
			this.LPocetTahu.Text = "Počet tahů : 0";
			this.LPocetTahu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bKonec
			// 
			this.bKonec.BackColor = System.Drawing.Color.LightCoral;
			this.bKonec.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.bKonec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bKonec.Location = new System.Drawing.Point(538, 364);
			this.bKonec.Name = "bKonec";
			this.bKonec.Size = new System.Drawing.Size(250, 74);
			this.bKonec.TabIndex = 3;
			this.bKonec.Text = "KONEC";
			this.bKonec.UseVisualStyleBackColor = false;
			this.bKonec.Click += new System.EventHandler(this.bKonecClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 364);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// bHratZnovu
			// 
			this.bHratZnovu.BackColor = System.Drawing.Color.Orange;
			this.bHratZnovu.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.bHratZnovu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bHratZnovu.Location = new System.Drawing.Point(12, 364);
			this.bHratZnovu.Name = "bHratZnovu";
			this.bHratZnovu.Size = new System.Drawing.Size(776, 74);
			this.bHratZnovu.TabIndex = 5;
			this.bHratZnovu.Text = "Hrát Znovu";
			this.bHratZnovu.UseVisualStyleBackColor = false;
			this.bHratZnovu.Visible = false;
			this.bHratZnovu.Click += new System.EventHandler(this.bHratZnovu_Click);
			// 
			// LVysledek
			// 
			this.LVysledek.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.LVysledek.Location = new System.Drawing.Point(12, 9);
			this.LVysledek.Name = "LVysledek";
			this.LVysledek.Size = new System.Drawing.Size(776, 352);
			this.LVysledek.TabIndex = 6;
			this.LVysledek.Text = "Počet tahů\r\n▶ 123 ◀";
			this.LVysledek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LVysledek);
			this.Controls.Add(this.bHratZnovu);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bKonec);
			this.Controls.Add(this.LPocetTahu);
			this.Controls.Add(this.LNavod);
			this.Controls.Add(this.bStart);
			this.Location = new System.Drawing.Point(15, 15);
			this.Name = "Form1";
			this.Text = "Pexeso";
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Label LVysledek;

		private System.Windows.Forms.Button bHratZnovu;

		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.Button bKonec;

		private System.Windows.Forms.Label LPocetTahu;

		private System.Windows.Forms.Label LNavod;

		private System.Windows.Forms.Button bStart;

		#endregion
	}
}