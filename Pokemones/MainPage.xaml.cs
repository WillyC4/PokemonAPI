using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly InterfacePokemon _Pokemones;

        public MainPage(InterfacePokemon service)
        {
            InitializeComponent();
            _Pokemones = service;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
          Loading.IsVisible = true;

            var data = await _Pokemones.Obtener();
            listViewPersonajes.ItemsSource = data;

            Loading.IsVisible = false;
        }
    }

}
