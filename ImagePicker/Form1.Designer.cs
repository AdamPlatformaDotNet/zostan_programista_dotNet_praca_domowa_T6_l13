namespace ImagePicker;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureBox1 = new System.Windows.Forms.PictureBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.Color.DimGray;
        pictureBox1.Enabled = false;
        pictureBox1.Location = new System.Drawing.Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(332, 321);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.DeepSkyBlue;
        button1.Location = new System.Drawing.Point(12, 457);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(144, 37);
        button1.TabIndex = 1;
        button1.Text = "Wczytaj";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click_1;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.IndianRed;
        button2.Location = new System.Drawing.Point(200, 457);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(144, 37);
        button2.TabIndex = 2;
        button2.Text = "Usuń";
        button2.UseVisualStyleBackColor = false;
        button2.Visible = false;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(12, 347);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(332, 33);
        label1.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(356, 506);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}