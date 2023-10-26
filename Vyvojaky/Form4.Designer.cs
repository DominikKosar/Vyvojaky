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
            mMoznosti = new MenuStrip();
            tbVstup = new TextBox();
            btSpustit = new Button();
            panelInformaci.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.BackColor = Color.White;
            panelPracovni.Location = new Point(809, 44);
            panelPracovni.Margin = new Padding(3, 4, 3, 4);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(628, 836);
            panelPracovni.TabIndex = 1;
            // 
            // panelInformaci
            // 
            panelInformaci.BackColor = Color.White;
            panelInformaci.Controls.Add(btSpustit);
            panelInformaci.Controls.Add(tbVstup);
            panelInformaci.Controls.Add(mMoznosti);
            panelInformaci.Location = new Point(14, 44);
            panelInformaci.Margin = new Padding(3, 4, 3, 4);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(366, 836);
            panelInformaci.TabIndex = 2;
            // 
            // mMoznosti
            // 
            mMoznosti.BackColor = Color.Gray;
            mMoznosti.Dock = DockStyle.None;
            mMoznosti.ImageScalingSize = new Size(20, 20);
            mMoznosti.Location = new Point(27, 358);
            mMoznosti.Name = "mMoznosti";
            mMoznosti.Size = new Size(202, 24);
            mMoznosti.TabIndex = 0;
            mMoznosti.Text = "menuStrip1";
            // 
            // tbVstup
            // 
            tbVstup.BackColor = SystemColors.ButtonShadow;
            tbVstup.Location = new Point(27, 401);
            tbVstup.Name = "tbVstup";
            tbVstup.Size = new Size(219, 27);
            tbVstup.TabIndex = 1;
            // 
            // btSpustit
            // 
            btSpustit.BackColor = Color.Gray;
            btSpustit.Location = new Point(27, 445);
            btSpustit.Name = "btSpustit";
            btSpustit.Size = new Size(135, 36);
            btSpustit.TabIndex = 2;
            btSpustit.Text = "Spustit";
            btSpustit.UseVisualStyleBackColor = false;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1450, 893);
            Controls.Add(panelInformaci);
            Controls.Add(panelPracovni);
            MainMenuStrip = mMoznosti;
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private TextBox tbVstup;
        private MenuStrip mMoznosti;
        private Button btSpustit;
    }
}