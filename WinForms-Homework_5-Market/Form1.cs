using Newtonsoft.Json;

namespace WinForms_Homework_5_Market;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
		
		DeserializerFunc();
	}

	public double money = 0;
	private void guna2CircleButton1_Click(object sender, EventArgs e)
	{
		if (sender is Guna.UI2.WinForms.Guna2CircleButton btn)
		{
			switch (btn.Tag)
			{
				case "10":
					money += 0.1;
					break;
				case "20":
					money += 0.2;
					break;
				case "50":
					money += 0.5;
					break;
				case "1":
					money += 1;
					break;
				case "5":
					money += 5;
					break;
				case "10Azn":
					money += 10;
					break;

			}

			tbox_EnteredMoney.Text = money.ToString();
			lbl_EnteredMoney.Text = money.ToString();
			
			while (tbox_EnteredMoney.Text.Length > 4)
				tbox_EnteredMoney.Text = tbox_EnteredMoney.Text.Remove(tbox_EnteredMoney.Text.Length - 1);
		}
	}

	List<string> list = new List<string>();
	private void Serialize()
	{
		foreach (var item in Controls)
		{
			if (item is Product_UC product)
				if (product.Checked)
				{
					if ((Convert.ToDouble(product.checkBox1.Text) - 1) == 0) 
						list.Add("NO ANY PRODUCT !"); 
					else 
						list.Add((Convert.ToDouble(product.checkBox1.Text) - 1).ToString());
				}
				else 
					list.Add(product.checkBox1.Text);
		}
	}

	double CalculatePrice()
	{
		double price = 0;

		list.Clear();
		
		foreach (var item in Controls)
			if (item is Product_UC product && product.Checked == true) 
				price += Convert.ToDouble(product.Price);
		
		return price;
	}

	private void btn_Buy_Click(object sender, EventArgs e)
	{
		double price = CalculatePrice();

		if (price == 0 && lbl_EnteredMoney.Text.Length != 0)
			MessageBox.Show("NO SHOPPING...", "", MessageBoxButtons.OK);
		else if (lbl_EnteredMoney.Text.Length != 0 && Convert.ToDouble(lbl_EnteredMoney.Text) - price >= 0)
		{
			if (Convert.ToDouble(lbl_EnteredMoney.Text) - price != 0)
			{
				label4.Visible = true;
				lbl_RemainingMoney.Visible = true;
				lbl_RemainingMoney.Text = (Convert.ToDouble(tbox_EnteredMoney.Text) - price).ToString();
			
				MessageBox.Show($"Remaining money: {lbl_RemainingMoney.Text}", "", MessageBoxButtons.OK);
			}
			else
				MessageBox.Show("BYE-BYE...", "", MessageBoxButtons.OK);
			
			SerializerFunc();
		}
		else
			MessageBox.Show("YOUR MONEY IS NOT ENOUGH...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	}

	void DeserializerFunc()
	{
		if (File.Exists("market.json"))
		{
			List<string>? newList = new List<string>();
			{
				var stringData = File.ReadAllText("market.json");
				newList = JsonConvert.DeserializeObject<List<string>>(stringData);
			}

			int num = 0;
			foreach (var item in Controls)
			{
				if (item is Product_UC product)
				{
					product.checkBox1.Text = newList[num++];
					if (product.checkBox1.Text == "NO ANY PRODUCT !") 
						product.Visible = false;
				}
			}
		}
	}

	void SerializerFunc()
	{
		Serialize();
		var json = System.Text.Json.JsonSerializer.Serialize(list);
		File.WriteAllText("market.json", json);
	}
}