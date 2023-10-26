namespace Vyvojaky
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btNovySoubor = new Button();
            btExistujici = new Button();
            SuspendLayout();
            // 
            // btNovySoubor
            // 
            btNovySoubor.Location = new Point(208, 244);
            btNovySoubor.Name = "btNovySoubor";
            btNovySoubor.Size = new Size(121, 40);
            btNovySoubor.TabIndex = 0;
            btNovySoubor.Text = "Nový soubor";
            btNovySoubor.UseVisualStyleBackColor = true;
            btNovySoubor.Click += btNovySoubor_Click;
            // 
            // btExistujici
            // 
            btExistujici.Location = new Point(389, 244);
            btExistujici.Name = "btExistujici";
            btExistujici.Size = new Size(143, 40);
            btExistujici.TabIndex = 1;
            btExistujici.Text = "Existující soubor";
            btExistujici.UseVisualStyleBackColor = true;
            btExistujici.Click += btExistujici_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btExistujici);
            Controls.Add(btNovySoubor);
            Name = "Form1";
            Text = "Vyvojaky - uvitaci";
            ResumeLayout(false);
        }

        #endregion

        private Button btNovySoubor;
        private Button btExistujici;
    }
}