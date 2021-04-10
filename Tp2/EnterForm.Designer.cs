
namespace Tp2
{
    partial class EnterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btEfface = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(232, 58);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(168, 23);
            this.txtnom.TabIndex = 3;
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(232, 114);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(168, 23);
            this.txtpre.TabIndex = 4;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(232, 169);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(168, 23);
            this.txtage.TabIndex = 5;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(40, 228);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 6;
            this.btadd.Text = "Ajouter";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lister";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEfface
            // 
            this.btEfface.Location = new System.Drawing.Point(266, 228);
            this.btEfface.Name = "btEfface";
            this.btEfface.Size = new System.Drawing.Size(75, 23);
            this.btEfface.TabIndex = 8;
            this.btEfface.Text = "Effacer";
            this.btEfface.UseVisualStyleBackColor = true;
            this.btEfface.Click += new System.EventHandler(this.btEfface_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(381, 228);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 9;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 284);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btEfface);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnterForm";
            this.Text = "EnterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEfface;
        private System.Windows.Forms.Button btQuitter;
    }
}