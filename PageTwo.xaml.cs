namespace Ejercicio1_PM2;

public partial class PageTwo : ContentPage
{
	public PageTwo()
	{
		
	}

	public PageTwo(string resultado)
	{
        InitializeComponent();
        lblResultado.Text = "El resultado es:" + resultado;
    }


}