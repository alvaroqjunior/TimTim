using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimTimSushi.Paginas
{
    public class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";

            Children.Add(new IndexPage()
            {
                Title = "Início",
                Icon = "home.png"
            });

            Children.Add(new CardapioPage()
            {
                Title = "Cardápio",
                Icon = "lista.png"
            });

            Children.Add(new CardapioPage()
            {
                Title = "Localização",
                Icon = "local.png"
            });


        }
    }
}
