
namespace JennyCasey_Assign6
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
            this.exitButton = new System.Windows.Forms.Button();
            this.graph1Button = new System.Windows.Forms.Button();
            this.graph2Button = new System.Windows.Forms.Button();
            this.graph3Button = new System.Windows.Forms.Button();
            this.graph4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please click a button below to view different graphs!";
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(13, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // graph1Button
            // 
            this.graph1Button.ForeColor = System.Drawing.Color.Black;
            this.graph1Button.Location = new System.Drawing.Point(105, 376);
            this.graph1Button.Name = "graph1Button";
            this.graph1Button.Size = new System.Drawing.Size(98, 42);
            this.graph1Button.TabIndex = 3;
            this.graph1Button.Text = "Graph ";
            this.graph1Button.UseVisualStyleBackColor = true;
            // 
            // graph2Button
            // 
            this.graph2Button.ForeColor = System.Drawing.Color.Black;
            this.graph2Button.Location = new System.Drawing.Point(303, 376);
            this.graph2Button.Name = "graph2Button";
            this.graph2Button.Size = new System.Drawing.Size(98, 42);
            this.graph2Button.TabIndex = 4;
            this.graph2Button.Text = "Graph ";
            this.graph2Button.UseVisualStyleBackColor = true;
            // 
            // graph3Button
            // 
            this.graph3Button.ForeColor = System.Drawing.Color.Black;
            this.graph3Button.Location = new System.Drawing.Point(491, 376);
            this.graph3Button.Name = "graph3Button";
            this.graph3Button.Size = new System.Drawing.Size(98, 42);
            this.graph3Button.TabIndex = 5;
            this.graph3Button.Text = "Graph ";
            this.graph3Button.UseVisualStyleBackColor = true;
            this.graph3Button.Click += new System.EventHandler(this.graph3Button_Click);
            // 
            // graph4Button
            // 
            this.graph4Button.ForeColor = System.Drawing.Color.Black;
            this.graph4Button.Location = new System.Drawing.Point(675, 376);
            this.graph4Button.Name = "graph4Button";
            this.graph4Button.Size = new System.Drawing.Size(98, 42);
            this.graph4Button.TabIndex = 6;
            this.graph4Button.Text = "Graph ";
            this.graph4Button.UseVisualStyleBackColor = true;
            this.graph4Button.Click += new System.EventHandler(this.graph4Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(901, 516);
            this.Controls.Add(this.graph4Button);
            this.Controls.Add(this.graph3Button);
            this.Controls.Add(this.graph2Button);
            this.Controls.Add(this.graph1Button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Graphing Welcome Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button graph1Button;
        private System.Windows.Forms.Button graph2Button;
        private System.Windows.Forms.Button graph3Button;
        private System.Windows.Forms.Button graph4Button;
    }
}

