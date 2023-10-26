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
            textBox1 = new TextBox();
            mMoznosti = new MenuStrip();
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
            panelInformaci.Controls.Add(textBox1);
            panelInformaci.Controls.Add(mMoznosti);
            panelInformaci.Location = new Point(14, 44);
            panelInformaci.Margin = new Padding(3, 4, 3, 4);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(366, 836);
            panelInformaci.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 698);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 1;
            // 
            // mMoznosti
            // 
            mMoznosti.BackColor = Color.Gray;
            mMoznosti.Dock = DockStyle.None;
            mMoznosti.ImageScalingSize = new Size(20, 20);
            mMoznosti.Location = new Point(15, 655);
            mMoznosti.Name = "mMoznosti";
            mMoznosti.Size = new Size(202, 24);
            mMoznosti.TabIndex = 0;
            mMoznosti.Text = "menuStrip1";
            // 
            // btSpustit
            // 
            btSpustit.Location = new Point(15, 744);
            btSpustit.Name = "btSpustit";
            btSpustit.Size = new Size(117, 34);
            btSpustit.TabIndex = 2;
            btSpustit.Text = "Spustit";
            btSpustit.UseVisualStyleBackColor = true;
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
        private TextBox textBox1;
        private MenuStrip mMoznosti;
        private Button btSpustit;
    }
}