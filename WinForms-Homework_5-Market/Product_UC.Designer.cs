namespace WinForms_Homework_5_Market;

partial class Product_UC
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

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_Price = new System.Windows.Forms.Label();
			this.lbl_Valyuta = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(29, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(125, 125);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lbl_Price
			// 
			this.lbl_Price.AutoSize = true;
			this.lbl_Price.Location = new System.Drawing.Point(61, 173);
			this.lbl_Price.Name = "lbl_Price";
			this.lbl_Price.Size = new System.Drawing.Size(17, 20);
			this.lbl_Price.TabIndex = 2;
			this.lbl_Price.Text = "0";
			// 
			// lbl_Valyuta
			// 
			this.lbl_Valyuta.AutoSize = true;
			this.lbl_Valyuta.Location = new System.Drawing.Point(77, 173);
			this.lbl_Valyuta.Name = "lbl_Valyuta";
			this.lbl_Valyuta.Size = new System.Drawing.Size(39, 20);
			this.lbl_Valyuta.TabIndex = 3;
			this.lbl_Valyuta.Text = "AZN";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(61, 218);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(55, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "100";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Product_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbl_Price);
			this.Controls.Add(this.lbl_Valyuta);
			this.Name = "Product_UC";
			this.Size = new System.Drawing.Size(189, 258);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	public PictureBox pictureBox1;
	public Label lbl_Price;
	public Label lbl_Valyuta;
	public CheckBox checkBox1;
}