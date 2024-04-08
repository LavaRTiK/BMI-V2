namespace BMI_V2
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.Validating += textBox1_Validating;
            textBox1.Validated += textBox1_Validated;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(359, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            textBox2.Validating += textBox2_Validating;
            textBox2.Validated += textBox2_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 70);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 2;
            label1.Text = "Зріст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 157);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 3;
            label2.Text = "Вага";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 242);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 4;
            label3.Text = "IMT:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}
