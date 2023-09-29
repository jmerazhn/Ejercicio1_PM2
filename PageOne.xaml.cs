namespace Ejercicio1_PM2;

public partial class PageOne : ContentPage
{

    Control control;
    public PageOne()
	{
		InitializeComponent();
		control = new Control();
	}

    private void btnsuma_Clicked(object sender, EventArgs e)
    {
        control.Num1 = double.Parse(n1.Text);
        control.Num2 = double.Parse(n2.Text);


        var resultado = control.Suma();
        Navigation.PushAsync(new PageTwo(resultado.ToString()));
    }

    private void btnresta_Clicked(object sender, EventArgs e)
    {
        control.Num1 = double.Parse(n1.Text);
        control.Num2 = double.Parse(n2.Text);


        var resultado = control.Resta();
        Navigation.PushAsync(new PageTwo(resultado.ToString()));

    }

    private void btndivi_Clicked(object sender, EventArgs e)
    {

        control.Num1 = double.Parse(n1.Text);
        control.Num2 = double.Parse(n2.Text);


        var resultado = control.Division();
        Navigation.PushAsync(new PageTwo(resultado.ToString()));
    }

    private void btnmuti_Clicked(object sender, EventArgs e)
    {
        control.Num1 = double.Parse(n1.Text);
        control.Num2 = double.Parse(n2.Text);


        var resultado = control.Multiplicacion();
        Navigation.PushAsync(new PageTwo(resultado.ToString()));
    }
}