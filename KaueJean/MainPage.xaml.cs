namespace KaueJean;

public partial class MainPage : ContentPage
{
    public string Personagem

   Cachorro Scooby;
   Gato Miau;
   Tigre Tiger; 
   Personagem atual;

public MainPage()
    {
    InitializeComponent();

    Scooby = new Cachorro();
    Miau = new Gato();
    Tiger = new Tigre();

    atual = Scooby;

    }


}
