namespace RoladorDeDadosMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnRolarDadoClicked(object sender, EventArgs e)
    {
        if (LadosPicker.SelectedItem is int lados)
        {
            Random random = new Random();
            int resultado = random.Next(lados + 1);
            ResultadoLabel.Text = resultado.ToString();
        }
        else
        {
            ResultadoLabel.Text = "⚠️";
        }
    }
}
