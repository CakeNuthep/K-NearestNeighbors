namespace K_nearest_neighbors
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_eat = new System.Windows.Forms.TextBox();
            this.textBox_temperature = new System.Windows.Forms.TextBox();
            this.textBox_sick = new System.Windows.Forms.TextBox();
            this.button_predict = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.button_brows = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eat C Vit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sick:";
            // 
            // textBox_eat
            // 
            this.textBox_eat.Location = new System.Drawing.Point(193, 58);
            this.textBox_eat.Name = "textBox_eat";
            this.textBox_eat.Size = new System.Drawing.Size(62, 20);
            this.textBox_eat.TabIndex = 4;
            // 
            // textBox_temperature
            // 
            this.textBox_temperature.Location = new System.Drawing.Point(363, 58);
            this.textBox_temperature.Name = "textBox_temperature";
            this.textBox_temperature.Size = new System.Drawing.Size(57, 20);
            this.textBox_temperature.TabIndex = 5;
            // 
            // textBox_sick
            // 
            this.textBox_sick.Location = new System.Drawing.Point(460, 58);
            this.textBox_sick.Name = "textBox_sick";
            this.textBox_sick.ReadOnly = true;
            this.textBox_sick.Size = new System.Drawing.Size(63, 20);
            this.textBox_sick.TabIndex = 0;
            this.textBox_sick.TabStop = false;
            // 
            // button_predict
            // 
            this.button_predict.Location = new System.Drawing.Point(538, 56);
            this.button_predict.Name = "button_predict";
            this.button_predict.Size = new System.Drawing.Size(75, 23);
            this.button_predict.TabIndex = 6;
            this.button_predict.Text = "Predict";
            this.button_predict.UseVisualStyleBackColor = true;
            this.button_predict.Click += new System.EventHandler(this.button_predict_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "File Input";
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(68, 19);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.Size = new System.Drawing.Size(455, 20);
            this.textBox_filePath.TabIndex = 1;
            this.textBox_filePath.Text = "D:\\LearningC#\\page\\K_Nearest Neighbor\\K-nearest neighbors\\K-nearest neighbors\\Dat" +
    "a\\data.csv";
            // 
            // button_brows
            // 
            this.button_brows.Location = new System.Drawing.Point(538, 17);
            this.button_brows.Name = "button_brows";
            this.button_brows.Size = new System.Drawing.Size(75, 23);
            this.button_brows.TabIndex = 2;
            this.button_brows.Text = "Brows";
            this.button_brows.UseVisualStyleBackColor = true;
            this.button_brows.Click += new System.EventHandler(this.button_brows_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "K:";
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(69, 58);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(61, 20);
            this.textBox_k.TabIndex = 3;
            this.textBox_k.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_filePath);
            this.groupBox1.Controls.Add(this.button_brows);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_predict);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_sick);
            this.groupBox1.Controls.Add(this.textBox_eat);
            this.groupBox1.Controls.Add(this.textBox_temperature);
            this.groupBox1.Controls.Add(this.textBox_k);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cartesianChart1);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 248);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "output";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(0, 19);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(624, 223);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "K-Nearest Neighbors";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_eat;
        private System.Windows.Forms.TextBox textBox_temperature;
        private System.Windows.Forms.TextBox textBox_sick;
        private System.Windows.Forms.Button button_predict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_brows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}

