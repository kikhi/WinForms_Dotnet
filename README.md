# WinForms Dotnet
How create forms on visual studio whit .net 6


### Get started
- Visual studio code
- .net 6 (C#)
    
    
### Instructions
- Create new folder and create project
    
```
        dotnet new winforms --name hellowin
```

- Add in Form1.Designer.cs for the objects (In this case is 'button1')

```
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

        this.Controls.Add(button1);

    }

    private Button button1;

    #endregion
}
```


- Now on Form1.cs put action for click

```
    public partial class Form1 : Form
    {
    public Form1()
    {
        InitializeComponent();

        button1.Click += button1_Click;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        button1.Text = "Hello World!";
    }
}
```

- For run or build project use

```
    dotnet build
    dotnet run
```
