namespace IdentityNumber
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.epControl = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epControl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtInput.Location = new System.Drawing.Point(42, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInput.Size = new System.Drawing.Size(142, 30);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnControl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnControl.Location = new System.Drawing.Point(42, 91);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(142, 33);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "CONTROL";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // epControl
            // 
            this.epControl.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 162);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.ErrorProvider epControl;
    }
}

