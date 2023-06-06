namespace calcut
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.j = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(109, 83);
            this.x1.Multiline = true;
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(175, 50);
            this.x1.TabIndex = 0;
            this.x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z
            // 
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.z.Location = new System.Drawing.Point(109, 259);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(111, 49);
            this.z.TabIndex = 1;
            this.z.Text = "×";
            this.z.UseVisualStyleBackColor = true;
            this.z.Click += new System.EventHandler(this.z_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "دو عدد وارد کنید";
            // 
            // t
            // 
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t.Location = new System.Drawing.Point(254, 259);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(111, 49);
            this.t.TabIndex = 3;
            this.t.Text = "÷";
            this.t.UseVisualStyleBackColor = true;
            this.t.Click += new System.EventHandler(this.t_Click);
            // 
            // m
            // 
            this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.m.Location = new System.Drawing.Point(528, 259);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(111, 49);
            this.m.TabIndex = 4;
            this.m.Text = "–";
            this.m.UseVisualStyleBackColor = true;
            this.m.Click += new System.EventHandler(this.m_Click);
            // 
            // j
            // 
            this.j.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.j.Location = new System.Drawing.Point(391, 259);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(111, 49);
            this.j.TabIndex = 5;
            this.j.Text = "+";
            this.j.UseVisualStyleBackColor = true;
            this.j.Click += new System.EventHandler(this.j_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(464, 83);
            this.x2.Multiline = true;
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(175, 50);
            this.x2.TabIndex = 6;
            this.x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.j);
            this.Controls.Add(this.m);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.z);
            this.Controls.Add(this.x1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Button z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button j;
        private System.Windows.Forms.TextBox x2;
    }
}

