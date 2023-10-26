namespace Vyvojaky
{
    partial class formHlavniProTvorbu
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
            panelPracovni = new Panel();
            panelInformaci = new Panel();
            panelConsole = new Panel();
            tbConsole = new TextBox();
            panelConsole.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.BackColor = Color.Gray;
            panelPracovni.Location = new Point(306, 50);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(951, 481);
            panelPracovni.TabIndex = 1;
            // 
            // panelInformaci
            // 
            panelInformaci.BackColor = Color.Gray;
            panelInformaci.Location = new Point(12, 50);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(288, 481);
            panelInformaci.TabIndex = 2;
            // 
            // panelConsole
            // 
            panelConsole.BackColor = Color.White;
            panelConsole.Controls.Add(tbConsole);
            panelConsole.Location = new Point(12, 545);
            panelConsole.Name = "panelConsole";
            panelConsole.Size = new Size(597, 113);
            panelConsole.TabIndex = 3;
            // 
            // tbConsole
            // 
            tbConsole.BackColor = Color.Black;
            tbConsole.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(3, 3);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(591, 107);
            tbConsole.TabIndex = 0;
            tbConsole.TabStop = false;
            tbConsole.Text = "> ";
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1269, 670);
            Controls.Add(panelConsole);
            Controls.Add(panelInformaci);
            Controls.Add(panelPracovni);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            panelConsole.ResumeLayout(false);
            panelConsole.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private Panel panelConsole;
        private TextBox tbConsole;
    }
}