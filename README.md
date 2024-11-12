---
title: week8

---

新視窗建立方式
右上角專案>加入新項目>表單 ?

換行\r\n ?

public = 公用的 ?

$ = shift + 4 ?




# 式

1.主介面
```csharp
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public static string msg = ""; //公用的 不可更動的
    public static double prise = 0;

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
    private void button1_Click(object sender, EventArgs e)
    {
        Form2 f1 = new Form2();
        f1.ShowDialog();
    }
    private void button2_Click(object sender, EventArgs e)
    {
        Form2 f1 = new Form2();
        f1.ShowDialog();
    }


    private void button3_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
    }
    private void button4_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    
    private void Form1_Activated(object sender, EventArgs e)
    {
        textBox1.Text = msg;
    }

    
}
```
2.點餐
```csharp
public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    string[] mainDish = new string[] { "綠色氣泡", "紫色氣泡", "金色氣泡" };
    int[] dishPrise = new int[] { 20, 50, 100 };
    string[] ing = new string[] { "QUASO", "Ak47", "大拇指" };
    int[] ingPrise = new int[] { 30, 47, 50 };

    private void Form2_Load(object sender, EventArgs e)
    {
        comboBox1.Items.AddRange(mainDish);
        comboBox1.SelectedIndex = 0;
        comboBox2.Items.AddRange(ing);
        comboBox2.SelectedIndex = 0;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form1.msg += comboBox1.Text + " " + dishPrise[comboBox1.SelectedIndex] + "\r\n";
        Form1.msg += comboBox2.Text + " " + ingPrise[comboBox2.SelectedIndex] + "\n";

        Form1.prise = dishPrise[comboBox1.SelectedIndex] + ingPrise[comboBox2.SelectedIndex];
        Form1.msg += $"合計{Form1.prise}元\n";
        
        this.Dispose(); 
        Form3 f1 = new Form3();
        f1.ShowDialog();
        
        
    }
}
```
3.折扣
```csharp
public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form1.msg += "====================\r\n";
        
        if(checkBox1.Checked) 
        {
            Form1.prise = Form1.prise * 0.8 ;
            Form1.msg += "會員打八折\r\n";
        }
        if(checkBox2.Checked) 
        {
            Form1.prise = Form1.prise - 10 ;
            Form1.msg += "折扣10元\r\n";
        }
        
        Form1.msg += $"實收"+Math.Round(Form1.prise,0).ToString()+"元";

        this.Dispose();
        
    }
```

# 畫面
![image](https://hackmd.io/_uploads/S14YSYxG1e.png)

*點選內用/外帶=>點餐介面
![image](https://hackmd.io/_uploads/B1RxUKef1l.png)
*點餐完成=>折扣介面
![image](https://hackmd.io/_uploads/rJTB8Kezkl.png)
*折扣設定完成=>回主介面
![image](https://hackmd.io/_uploads/HksQvYxMJx.png)

*!新介面!*
(明明垮鬆只是配料
卻充滿垮鬆的點餐機)
![image](https://hackmd.io/_uploads/Sy0MsFlfJl.png)


