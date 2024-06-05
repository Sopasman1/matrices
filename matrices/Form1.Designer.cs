namespace matrices
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
            txtTemperature = new TextBox();
            BtnSaveTemperature = new Button();
            btnAverageTemp = new Button();
            btnClearMatrix = new Button();
            dataGridViewMatrix = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(135, 40);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(213, 23);
            txtTemperature.TabIndex = 0;
            // 
            // BtnSaveTemperature
            // 
            BtnSaveTemperature.Location = new Point(12, 89);
            BtnSaveTemperature.Name = "BtnSaveTemperature";
            BtnSaveTemperature.Size = new Size(117, 23);
            BtnSaveTemperature.TabIndex = 1;
            BtnSaveTemperature.Text = "Save Temperature.";
            BtnSaveTemperature.UseVisualStyleBackColor = true;
            BtnSaveTemperature.Click += BtnSaveTemperature_Click;
            // 
            // btnAverageTemp
            // 
            btnAverageTemp.Location = new Point(12, 148);
            btnAverageTemp.Name = "btnAverageTemp";
            btnAverageTemp.Size = new Size(117, 23);
            btnAverageTemp.TabIndex = 2;
            btnAverageTemp.Text = "Average Temp.";
            btnAverageTemp.UseVisualStyleBackColor = true;
            btnAverageTemp.Click += btnAverageTemp_Click;
            // 
            // btnClearMatrix
            // 
            btnClearMatrix.Location = new Point(12, 205);
            btnClearMatrix.Name = "btnClearMatrix";
            btnClearMatrix.Size = new Size(117, 23);
            btnClearMatrix.TabIndex = 3;
            btnClearMatrix.Text = "Clear Matrix.";
            btnClearMatrix.UseVisualStyleBackColor = true;
            btnClearMatrix.Click += btnClearMatrix_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(135, 89);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.Size = new Size(519, 235);
            dataGridViewMatrix.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Temperature";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(btnClearMatrix);
            Controls.Add(btnAverageTemp);
            Controls.Add(BtnSaveTemperature);
            Controls.Add(txtTemperature);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTemperature;
        private Button BtnSaveTemperature;
        private Button btnAverageTemp;
        private Button btnClearMatrix;
        private DataGridView dataGridViewMatrix;
        private Label label1;
    }
}
