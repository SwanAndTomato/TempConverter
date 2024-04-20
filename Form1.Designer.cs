namespace TempConvert2
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
            txtTempInput = new TextBox();
            cmbInputUnit = new ComboBox();
            cmbOutputUnit = new ComboBox();
            label1 = new Label();
            lblResult = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // txtTempInput
            // 
            txtTempInput.Location = new Point(12, 14);
            txtTempInput.Name = "txtTempInput";
            txtTempInput.Size = new Size(82, 23);
            txtTempInput.TabIndex = 0;
            txtTempInput.TextChanged += textBox1_TextChanged;
            // 
            // cmbInputUnit
            // 
            cmbInputUnit.FormattingEnabled = true;
            cmbInputUnit.Location = new Point(100, 14);
            cmbInputUnit.Name = "cmbInputUnit";
            cmbInputUnit.Size = new Size(44, 23);
            cmbInputUnit.TabIndex = 1;
            // 
            // cmbOutputUnit
            // 
            cmbOutputUnit.FormattingEnabled = true;
            cmbOutputUnit.Location = new Point(175, 14);
            cmbOutputUnit.Name = "cmbOutputUnit";
            cmbOutputUnit.Size = new Size(44, 23);
            cmbOutputUnit.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 18);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 3;
            label1.Text = "To";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 51);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(37, 45);
            lblResult.TabIndex = 4;
            lblResult.Text = "0";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(225, 14);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 116);
            Controls.Add(btnConvert);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(cmbOutputUnit);
            Controls.Add(cmbInputUnit);
            Controls.Add(txtTempInput);
            Name = "Form1";
            Text = "Temp Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTempInput;
        private ComboBox cmbInputUnit;
        private ComboBox cmbOutputUnit;
        private Label label1;
        private Label lblResult;
        private Button btnConvert;
    }
}
