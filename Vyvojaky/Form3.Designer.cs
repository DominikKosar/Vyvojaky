namespace Vyvojaky
{
    partial class formExistujiciSoubory
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
            btExistujici = new Button();
            SuspendLayout();
            // 
            // btExistujici
            // 
            btExistujici.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btExistujici.Location = new Point(517, 310);
            btExistujici.Name = "btExistujici";
            btExistujici.Size = new Size(271, 71);
            btExistujici.TabIndex = 0;
            btExistujici.Text = "Otevřít existující soubor";
            btExistujici.UseVisualStyleBackColor = true;
            btExistujici.Click += btExistujici_Click;
            // 
            // formExistujiciSoubory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btExistujici);
            Name = "formExistujiciSoubory";
            Text = "Existující soubory";
            ResumeLayout(false);
        }

        #endregion

        private Button btExistujici;
    }
}