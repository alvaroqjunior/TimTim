using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimTimSushi.Paginas
{
    public class CardapioPage : BasePage
    {
        public CardapioPage()
        {
            var lista = new ListView();
            lista.ItemsSource = new[]
            {
                "Combinado 1",
                "Temaki",
                "Uraki",
                "Combinado 2"
            };
            
            lista.ItemTapped += Lista_ItemTapped;
            Content = lista;
        }

        private void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Cardápio", (string)((ListView)sender).SelectedItem, "Ok");
            ((ListView)sender).SelectedItem = null;
        }

    }
}
