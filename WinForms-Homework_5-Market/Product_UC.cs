namespace WinForms_Homework_5_Market;

public partial class Product_UC : UserControl
{
	public string Labeltxt { get => lbl_Valyuta.Text; set => lbl_Valyuta.Text = value; }
	public string ProductCount { get => checkBox1.Text; set => checkBox1.Text = value; }
	public string Price { get => lbl_Price.Text; set => lbl_Price.Text = value; }
	public bool Checked { get => checkBox1.Checked; set => checkBox1.Checked = value; }
	
	public Product_UC()
	{
		InitializeComponent();
	}

	public Image picturebox
	{
		get 
		{ 
			return pictureBox1.Image; 
		}

		set 
		{ 
			pictureBox1.Image = value; 
		}
	}
}