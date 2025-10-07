namespace RoladorDeDadosMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnRolarDadoClicked(object sender, EventArgs e)
    {
        try
        {
            int lados = (int)LadosPicker.SelectedItem;
            Random rnd = new();
            int resultado = rnd.Next(1, lados + 1);
            ResultadoLabel.Text = resultado.ToString();
        }

        catch (Exception ex)
        {
            ResultadoLabel.Text = "error";
        }
    }
}
