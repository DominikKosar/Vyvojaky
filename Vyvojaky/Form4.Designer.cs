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
            btSpustit = new Button();
            textBox1 = new TextBox();
            mMoznosti = new MenuStrip();
            typyToolStripMenuItem = new ToolStripMenuItem();
            int16ToolStripMenuItem = new ToolStripMenuItem();
            int32ToolStripMenuItem = new ToolStripMenuItem();
            int64ToolStripMenuItem = new ToolStripMenuItem();
            floatToolStripMenuItem = new ToolStripMenuItem();
            doubleToolStripMenuItem = new ToolStripMenuItem();
            boolToolStripMenuItem = new ToolStripMenuItem();
            stringToolStripMenuItem = new ToolStripMenuItem();
            charToolStripMenuItem = new ToolStripMenuItem();
            panelInformaci.SuspendLayout();
            mMoznosti.SuspendLayout();
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
            // btSpustit
            // 
            btSpustit.Location = new Point(15, 744);
            btSpustit.Name = "btSpustit";
            btSpustit.Size = new Size(117, 34);
            btSpustit.TabIndex = 2;
            btSpustit.Text = "Spustit";
            btSpustit.UseVisualStyleBackColor = true;
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
            mMoznosti.Items.AddRange(new ToolStripItem[] { typyToolStripMenuItem });
            mMoznosti.Location = new Point(15, 655);
            mMoznosti.Name = "mMoznosti";
            mMoznosti.Size = new Size(61, 28);
            mMoznosti.TabIndex = 0;
            mMoznosti.Text = "menuStrip1";
            // 
            // typyToolStripMenuItem
            // 
            typyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { int16ToolStripMenuItem, int32ToolStripMenuItem, int64ToolStripMenuItem, floatToolStripMenuItem, doubleToolStripMenuItem, boolToolStripMenuItem, stringToolStripMenuItem, charToolStripMenuItem });
            typyToolStripMenuItem.Name = "typyToolStripMenuItem";
            typyToolStripMenuItem.Size = new Size(53, 24);
            typyToolStripMenuItem.Text = "Typy";
            // 
            // int16ToolStripMenuItem
            // 
            int16ToolStripMenuItem.Name = "int16ToolStripMenuItem";
            int16ToolStripMenuItem.Size = new Size(224, 26);
            int16ToolStripMenuItem.Text = "Int16";
            // 
            // int32ToolStripMenuItem
            // 
            int32ToolStripMenuItem.Name = "int32ToolStripMenuItem";
            int32ToolStripMenuItem.Size = new Size(224, 26);
            int32ToolStripMenuItem.Text = "Int32";
            // 
            // int64ToolStripMenuItem
            // 
            int64ToolStripMenuItem.Name = "int64ToolStripMenuItem";
            int64ToolStripMenuItem.Size = new Size(224, 26);
            int64ToolStripMenuItem.Text = "Int64";
            // 
            // floatToolStripMenuItem
            // 
            floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            floatToolStripMenuItem.Size = new Size(224, 26);
            floatToolStripMenuItem.Text = "Float";
            // 
            // doubleToolStripMenuItem
            // 
            doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            doubleToolStripMenuItem.Size = new Size(224, 26);
            doubleToolStripMenuItem.Text = "Double";
            // 
            // boolToolStripMenuItem
            // 
            boolToolStripMenuItem.Name = "boolToolStripMenuItem";
            boolToolStripMenuItem.Size = new Size(224, 26);
            boolToolStripMenuItem.Text = "Bool";
            // 
            // stringToolStripMenuItem
            // 
            stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            stringToolStripMenuItem.Size = new Size(224, 26);
            stringToolStripMenuItem.Text = "String";
            // 
            // charToolStripMenuItem
            // 
            charToolStripMenuItem.Name = "charToolStripMenuItem";
            charToolStripMenuItem.Size = new Size(224, 26);
            charToolStripMenuItem.Text = "Char";
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
            mMoznosti.ResumeLayout(false);
            mMoznosti.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private TextBox textBox1;
        private MenuStrip mMoznosti;
        private Button btSpustit;
        private ToolStripMenuItem typyToolStripMenuItem;
        private ToolStripMenuItem int16ToolStripMenuItem;
        private ToolStripMenuItem int32ToolStripMenuItem;
        private ToolStripMenuItem int64ToolStripMenuItem;
        private ToolStripMenuItem floatToolStripMenuItem;
        private ToolStripMenuItem doubleToolStripMenuItem;
        private ToolStripMenuItem boolToolStripMenuItem;
        private ToolStripMenuItem stringToolStripMenuItem;
        private ToolStripMenuItem charToolStripMenuItem;
    }
}