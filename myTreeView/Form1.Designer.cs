
namespace myTreeView
{
    partial class frmMain
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
            this.tvDemo = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnAddPlayerName = new System.Windows.Forms.Button();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvDemo
            // 
            this.tvDemo.Location = new System.Drawing.Point(80, 62);
            this.tvDemo.Name = "tvDemo";
            this.tvDemo.Size = new System.Drawing.Size(220, 326);
            this.tvDemo.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(343, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(343, 122);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(122, 33);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "Initialize";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnAddPlayerName
            // 
            this.btnAddPlayerName.Location = new System.Drawing.Point(649, 176);
            this.btnAddPlayerName.Name = "btnAddPlayerName";
            this.btnAddPlayerName.Size = new System.Drawing.Size(95, 28);
            this.btnAddPlayerName.TabIndex = 4;
            this.btnAddPlayerName.Text = "Add Player Name";
            this.btnAddPlayerName.UseVisualStyleBackColor = true;
            this.btnAddPlayerName.Click += new System.EventHandler(this.btnAddPlayerName_Click);
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(344, 176);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(268, 22);
            this.tbPlayerName.TabIndex = 5;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(343, 219);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(95, 22);
            this.tbNumber.TabIndex = 6;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(460, 214);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(104, 27);
            this.btnAddNumber.TabIndex = 7;
            this.btnAddNumber.Text = "Add Number";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.btnAddPlayerName);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tvDemo);
            this.Name = "frmMain";
            this.Text = "Tree View Fun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDemo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnAddPlayerName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnAddNumber;
    }
}

