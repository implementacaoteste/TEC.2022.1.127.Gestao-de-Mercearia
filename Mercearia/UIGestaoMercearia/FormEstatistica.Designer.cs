namespace UIGestaoMercearia
{
    partial class FormEstatistica
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
            label1 = new Label();
            panel1 = new Panel();
            labelG = new Label();
            labelGanhos = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            labelGastos = new Label();
            labelGs = new Label();
            labelS = new Label();
            labelSaldo = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(467, 52);
            label1.TabIndex = 0;
            label1.Text = "Estatística de Ganhos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(labelS);
            panel1.Controls.Add(labelGs);
            panel1.Controls.Add(labelG);
            panel1.Controls.Add(labelSaldo);
            panel1.Controls.Add(labelGastos);
            panel1.Controls.Add(labelGanhos);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(11, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 130);
            panel1.TabIndex = 1;
            // 
            // labelG
            // 
            labelG.Anchor = AnchorStyles.Top;
            labelG.AutoSize = true;
            labelG.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelG.ForeColor = Color.White;
            labelG.Location = new Point(17, 20);
            labelG.Name = "labelG";
            labelG.Size = new Size(102, 29);
            labelG.TabIndex = 0;
            labelG.Text = "Ganhos:";
            // 
            // labelGanhos
            // 
            labelGanhos.Anchor = AnchorStyles.Top;
            labelGanhos.AutoSize = true;
            labelGanhos.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelGanhos.ForeColor = Color.White;
            labelGanhos.Location = new Point(17, 58);
            labelGanhos.Name = "labelGanhos";
            labelGanhos.Size = new Size(110, 51);
            labelGanhos.TabIndex = 1;
            labelGanhos.Text = "R$ 0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(11, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 388);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 153, 204);
            panel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(285, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 388);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 153, 204);
            panel5.Controls.Add(label1);
            panel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(-2, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 81);
            panel5.TabIndex = 3;
            // 
            // labelGastos
            // 
            labelGastos.Anchor = AnchorStyles.Top;
            labelGastos.AutoSize = true;
            labelGastos.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelGastos.ForeColor = Color.White;
            labelGastos.Location = new Point(183, 58);
            labelGastos.Name = "labelGastos";
            labelGastos.Size = new Size(110, 51);
            labelGastos.TabIndex = 1;
            labelGastos.Text = "R$ 0";
            // 
            // labelGs
            // 
            labelGs.Anchor = AnchorStyles.Top;
            labelGs.AutoSize = true;
            labelGs.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelGs.ForeColor = Color.White;
            labelGs.Location = new Point(183, 20);
            labelGs.Name = "labelGs";
            labelGs.Size = new Size(94, 29);
            labelGs.TabIndex = 0;
            labelGs.Text = "Gastos:";
            // 
            // labelS
            // 
            labelS.Anchor = AnchorStyles.Top;
            labelS.AutoSize = true;
            labelS.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelS.ForeColor = Color.White;
            labelS.Location = new Point(357, 20);
            labelS.Name = "labelS";
            labelS.Size = new Size(82, 29);
            labelS.TabIndex = 0;
            labelS.Text = "Saldo:";
            // 
            // labelSaldo
            // 
            labelSaldo.Anchor = AnchorStyles.Top;
            labelSaldo.AutoSize = true;
            labelSaldo.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaldo.ForeColor = Color.White;
            labelSaldo.Location = new Point(357, 58);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(110, 51);
            labelSaldo.TabIndex = 1;
            labelSaldo.Text = "R$ 0";
            // 
            // FormEstatistica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(566, 638);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstatistica";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormEstatistica_Load;
            KeyDown += FormEstatistica_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label labelGanhos;
        private Label labelG;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Label labelS;
        private Label labelGs;
        private Label labelSaldo;
        private Label labelGastos;
    }
}