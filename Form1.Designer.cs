namespace hellowin;

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
        // Form
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 1000);
        this.Text = "form text";
        this.Name = "form name";

        // button 1
        button1 = new Button();
        button1.Location = new System.Drawing.Point(50, 50);
        button1.Size = new System.Drawing.Size(100, 50);
        button1.Name = "button name";
        button1.Text = "button text";
        button1.TabIndex = 2;
        button1.UseVisualStyleBackColor = true;

        // label 1
        label1 = new Label();
        label1.Location = new System.Drawing.Point(600, 50);
        label1.Size = new System.Drawing.Size(100, 50);
        label1.Name = "label name";
        label1.Text = "label text";
        label1.TabIndex = 2;

        // textBox1
        textBox1 = new TextBox();
        textBox1.Location = new System.Drawing.Point(50,600);
        textBox1.Size = new System.Drawing.Size(500, 20);
        textBox1.Name = "textBox name";
        textBox1.TabIndex = 3;

        this.Controls.Add(button1);
        this.Controls.Add(label1);
        this.Controls.Add(textBox1);
    }

    private Button button1;
    private Label label1;
    private TextBox textBox1;

    #endregion
}
