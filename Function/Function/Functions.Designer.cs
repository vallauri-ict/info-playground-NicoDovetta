
namespace Function
{
	partial class Functions
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
			this.dgvDriver = new System.Windows.Forms.DataGridView();
			this.dgvFunction1 = new System.Windows.Forms.DataGridView();
			this.cmbNat = new System.Windows.Forms.ComboBox();
			this.btnFunct1 = new System.Windows.Forms.Button();
			this.btnFunction2 = new System.Windows.Forms.Button();
			this.numPodium = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFunction1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPodium)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDriver
			// 
			this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDriver.Location = new System.Drawing.Point(12, 12);
			this.dgvDriver.Name = "dgvDriver";
			this.dgvDriver.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvDriver.Size = new System.Drawing.Size(499, 190);
			this.dgvDriver.TabIndex = 0;
			// 
			// dgvFunction1
			// 
			this.dgvFunction1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFunction1.Location = new System.Drawing.Point(579, 12);
			this.dgvFunction1.Name = "dgvFunction1";
			this.dgvFunction1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvFunction1.Size = new System.Drawing.Size(499, 190);
			this.dgvFunction1.TabIndex = 1;
			// 
			// cmbNat
			// 
			this.cmbNat.FormattingEnabled = true;
			this.cmbNat.Location = new System.Drawing.Point(12, 234);
			this.cmbNat.Name = "cmbNat";
			this.cmbNat.Size = new System.Drawing.Size(48, 21);
			this.cmbNat.TabIndex = 2;
			// 
			// btnFunct1
			// 
			this.btnFunct1.Location = new System.Drawing.Point(90, 232);
			this.btnFunct1.Name = "btnFunct1";
			this.btnFunct1.Size = new System.Drawing.Size(158, 23);
			this.btnFunct1.TabIndex = 3;
			this.btnFunct1.Text = "Load driver country";
			this.btnFunct1.UseVisualStyleBackColor = true;
			this.btnFunct1.Click += new System.EventHandler(this.btnFunct1_Click);
			// 
			// btnFunction2
			// 
			this.btnFunction2.Location = new System.Drawing.Point(90, 281);
			this.btnFunction2.Name = "btnFunction2";
			this.btnFunction2.Size = new System.Drawing.Size(158, 23);
			this.btnFunction2.TabIndex = 4;
			this.btnFunction2.Text = "Get number of pilot/s";
			this.btnFunction2.UseVisualStyleBackColor = true;
			this.btnFunction2.Click += new System.EventHandler(this.btnFunction2_Click);
			// 
			// numPodium
			// 
			this.numPodium.Location = new System.Drawing.Point(12, 284);
			this.numPodium.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numPodium.Name = "numPodium";
			this.numPodium.Size = new System.Drawing.Size(48, 20);
			this.numPodium.TabIndex = 5;
			this.numPodium.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Functions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1091, 386);
			this.Controls.Add(this.numPodium);
			this.Controls.Add(this.btnFunction2);
			this.Controls.Add(this.btnFunct1);
			this.Controls.Add(this.cmbNat);
			this.Controls.Add(this.dgvFunction1);
			this.Controls.Add(this.dgvDriver);
			this.Name = "Functions";
			this.Text = "Functions";
			this.Load += new System.EventHandler(this.Functions_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFunction1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPodium)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDriver;
		private System.Windows.Forms.DataGridView dgvFunction1;
		private System.Windows.Forms.ComboBox cmbNat;
		private System.Windows.Forms.Button btnFunct1;
		private System.Windows.Forms.Button btnFunction2;
		private System.Windows.Forms.NumericUpDown numPodium;
	}
}

