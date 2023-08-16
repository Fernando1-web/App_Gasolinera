using System.Transactions;

namespace App_Gasolinera;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
		double Litros;
		double PrecioLitro;

		Litros = Convert.ToDouble(Entry1.Text);
		PrecioLitro = Convert.ToDouble(Entry2.Text);

		double Galones = Litros * PrecioLitro * 3.78;

		LblTotal.Text = Galones.ToString();
    }
}

