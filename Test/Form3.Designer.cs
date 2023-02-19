namespace Test
{
    partial class Form3
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
            this.bt_LugaresDisponiveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_LugaresDisponiveis
            // 
            this.bt_LugaresDisponiveis.Location = new System.Drawing.Point(104, 64);
            this.bt_LugaresDisponiveis.Name = "bt_LugaresDisponiveis";
            this.bt_LugaresDisponiveis.Size = new System.Drawing.Size(138, 45);
            this.bt_LugaresDisponiveis.TabIndex = 0;
            this.bt_LugaresDisponiveis.Text = "LugaresDisponiveis";
            this.bt_LugaresDisponiveis.UseVisualStyleBackColor = true;
            this.bt_LugaresDisponiveis.Click += new System.EventHandler(this.bt_LugaresDisponiveis_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_LugaresDisponiveis);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_LugaresDisponiveis;
    }
}