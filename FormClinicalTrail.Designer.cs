
namespace ClinicalTrial
{
  partial class frmClinicalTrial
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClinicalTrial));
      this.dgvPatients = new System.Windows.Forms.DataGridView();
      this.lblStatus = new System.Windows.Forms.Label();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnAllocate1 = new System.Windows.Forms.Button();
      this.btnAllocate4 = new System.Windows.Forms.Button();
      this.btnAllocate3 = new System.Windows.Forms.Button();
      this.btnAllocate2 = new System.Windows.Forms.Button();
      this.lblPillIcon1 = new System.Windows.Forms.Label();
      this.lblPillIcon2 = new System.Windows.Forms.Label();
      this.lblPillIcon3 = new System.Windows.Forms.Label();
      this.lblPillIcon4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvPatients
      // 
      this.dgvPatients.AllowUserToAddRows = false;
      this.dgvPatients.AllowUserToDeleteRows = false;
      this.dgvPatients.AllowUserToOrderColumns = true;
      this.dgvPatients.AllowUserToResizeColumns = false;
      this.dgvPatients.AllowUserToResizeRows = false;
      this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPatients.Location = new System.Drawing.Point(51, 60);
      this.dgvPatients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dgvPatients.Name = "dgvPatients";
      this.dgvPatients.Size = new System.Drawing.Size(662, 228);
      this.dgvPatients.TabIndex = 0;
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(48, 25);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(204, 16);
      this.lblStatus.TabIndex = 1;
      this.lblStatus.Text = "Please allocate pills to each patient.";
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(51, 360);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(116, 23);
      this.btnReset.TabIndex = 2;
      this.btnReset.Text = "Reset Allocations";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnAllocate1
      // 
      this.btnAllocate1.Location = new System.Drawing.Point(51, 308);
      this.btnAllocate1.Name = "btnAllocate1";
      this.btnAllocate1.Size = new System.Drawing.Size(116, 23);
      this.btnAllocate1.TabIndex = 3;
      this.btnAllocate1.Text = "Allocate";
      this.btnAllocate1.UseVisualStyleBackColor = true;
      this.btnAllocate1.Click += new System.EventHandler(this.btnAllocate1_Click);
      // 
      // btnAllocate4
      // 
      this.btnAllocate4.Location = new System.Drawing.Point(597, 308);
      this.btnAllocate4.Name = "btnAllocate4";
      this.btnAllocate4.Size = new System.Drawing.Size(116, 23);
      this.btnAllocate4.TabIndex = 5;
      this.btnAllocate4.Text = "Allocate";
      this.btnAllocate4.UseVisualStyleBackColor = true;
      this.btnAllocate4.Click += new System.EventHandler(this.btnAllocate4_Click);
      // 
      // btnAllocate3
      // 
      this.btnAllocate3.Location = new System.Drawing.Point(416, 308);
      this.btnAllocate3.Name = "btnAllocate3";
      this.btnAllocate3.Size = new System.Drawing.Size(116, 23);
      this.btnAllocate3.TabIndex = 6;
      this.btnAllocate3.Text = "Allocate";
      this.btnAllocate3.UseVisualStyleBackColor = true;
      this.btnAllocate3.Click += new System.EventHandler(this.btnAllocate3_Click);
      // 
      // btnAllocate2
      // 
      this.btnAllocate2.Location = new System.Drawing.Point(226, 308);
      this.btnAllocate2.Name = "btnAllocate2";
      this.btnAllocate2.Size = new System.Drawing.Size(116, 23);
      this.btnAllocate2.TabIndex = 7;
      this.btnAllocate2.Text = "Allocate";
      this.btnAllocate2.UseVisualStyleBackColor = true;
      this.btnAllocate2.Click += new System.EventHandler(this.btnAllocate2_Click);
      // 
      // lblPillIcon1
      // 
      this.lblPillIcon1.AutoSize = true;
      this.lblPillIcon1.Image = ((System.Drawing.Image)(resources.GetObject("lblPillIcon1.Image")));
      this.lblPillIcon1.Location = new System.Drawing.Point(55, 312);
      this.lblPillIcon1.Name = "lblPillIcon1";
      this.lblPillIcon1.Size = new System.Drawing.Size(20, 16);
      this.lblPillIcon1.TabIndex = 8;
      this.lblPillIcon1.Text = "    ";
      // 
      // lblPillIcon2
      // 
      this.lblPillIcon2.AutoSize = true;
      this.lblPillIcon2.Image = ((System.Drawing.Image)(resources.GetObject("lblPillIcon2.Image")));
      this.lblPillIcon2.Location = new System.Drawing.Point(230, 311);
      this.lblPillIcon2.Name = "lblPillIcon2";
      this.lblPillIcon2.Size = new System.Drawing.Size(20, 16);
      this.lblPillIcon2.TabIndex = 9;
      this.lblPillIcon2.Text = "    ";
      // 
      // lblPillIcon3
      // 
      this.lblPillIcon3.AutoSize = true;
      this.lblPillIcon3.Image = ((System.Drawing.Image)(resources.GetObject("lblPillIcon3.Image")));
      this.lblPillIcon3.Location = new System.Drawing.Point(420, 311);
      this.lblPillIcon3.Name = "lblPillIcon3";
      this.lblPillIcon3.Size = new System.Drawing.Size(20, 16);
      this.lblPillIcon3.TabIndex = 10;
      this.lblPillIcon3.Text = "    ";
      // 
      // lblPillIcon4
      // 
      this.lblPillIcon4.AutoSize = true;
      this.lblPillIcon4.Image = ((System.Drawing.Image)(resources.GetObject("lblPillIcon4.Image")));
      this.lblPillIcon4.Location = new System.Drawing.Point(601, 311);
      this.lblPillIcon4.Name = "lblPillIcon4";
      this.lblPillIcon4.Size = new System.Drawing.Size(20, 16);
      this.lblPillIcon4.TabIndex = 11;
      this.lblPillIcon4.Text = "    ";
      // 
      // frmClinicalTrial
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(766, 428);
      this.Controls.Add(this.lblPillIcon4);
      this.Controls.Add(this.lblPillIcon3);
      this.Controls.Add(this.lblPillIcon2);
      this.Controls.Add(this.lblPillIcon1);
      this.Controls.Add(this.btnAllocate2);
      this.Controls.Add(this.btnAllocate3);
      this.Controls.Add(this.btnAllocate4);
      this.Controls.Add(this.btnAllocate1);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.dgvPatients);
      this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "frmClinicalTrial";
      this.Text = "Clinical Trials";
      ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvPatients;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnAllocate1;
    private System.Windows.Forms.Button btnAllocate4;
    private System.Windows.Forms.Button btnAllocate3;
    private System.Windows.Forms.Button btnAllocate2;
    private System.Windows.Forms.Label lblPillIcon1;
    private System.Windows.Forms.Label lblPillIcon2;
    private System.Windows.Forms.Label lblPillIcon3;
    private System.Windows.Forms.Label lblPillIcon4;
  }
}

