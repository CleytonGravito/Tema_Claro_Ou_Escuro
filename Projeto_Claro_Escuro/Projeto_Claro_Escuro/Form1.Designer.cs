namespace Projeto_Claro_Escuro
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
            this.ToggleSwitch1 = new Siticone.UI.WinForms.SiticoneToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToggleSwitch1
            // 
            this.ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch1.CheckedState.Parent = this.ToggleSwitch1;
            this.ToggleSwitch1.Location = new System.Drawing.Point(157, 142);
            this.ToggleSwitch1.Name = "ToggleSwitch1";
            this.ToggleSwitch1.ShadowDecoration.Parent = this.ToggleSwitch1;
            this.ToggleSwitch1.Size = new System.Drawing.Size(41, 21);
            this.ToggleSwitch1.TabIndex = 0;
            this.ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch1.UncheckedState.Parent = this.ToggleSwitch1;
            this.ToggleSwitch1.CheckedChanged += new System.EventHandler(this.ToggleSwitch1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heavitas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(110, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToggleSwitch1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneToggleSwitch ToggleSwitch1;
        private System.Windows.Forms.Label label1;
    }
}

