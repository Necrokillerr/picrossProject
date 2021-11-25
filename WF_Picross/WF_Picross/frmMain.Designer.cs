
namespace WF_Picross
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
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnAutoSolve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxPuzzle = new WF_Picross.Puzzle();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPuzzle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextStep
            // 
            this.btnNextStep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextStep.Location = new System.Drawing.Point(27, 44);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(179, 40);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.Text = "Next step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            // 
            // btnAutoSolve
            // 
            this.btnAutoSolve.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoSolve.Location = new System.Drawing.Point(27, 117);
            this.btnAutoSolve.Name = "btnAutoSolve";
            this.btnAutoSolve.Size = new System.Drawing.Size(179, 40);
            this.btnAutoSolve.TabIndex = 2;
            this.btnAutoSolve.Text = "Auto solve";
            this.btnAutoSolve.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNextStep);
            this.groupBox1.Controls.Add(this.btnAutoSolve);
            this.groupBox1.Location = new System.Drawing.Point(30, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Résolution";
            // 
            // pbxPuzzle
            // 
            this.pbxPuzzle.Location = new System.Drawing.Point(443, 176);
            this.pbxPuzzle.Name = "pbxPuzzle";
            this.pbxPuzzle.Size = new System.Drawing.Size(700, 700);
            this.pbxPuzzle.TabIndex = 3;
            this.pbxPuzzle.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbxPuzzle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nonograme - Picross Solver";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPuzzle)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNextStep;
		private System.Windows.Forms.Button btnAutoSolve;
		private System.Windows.Forms.GroupBox groupBox1;
        private Puzzle pbxPuzzle;
    }
}

