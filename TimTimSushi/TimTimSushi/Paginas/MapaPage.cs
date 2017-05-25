using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TimTimSushi.Paginas
{
    public class MapaPage : BasePage
    {
        public MapaPage()
        {
            //-30.029773, -51.209844
            var posicao = new Position(-30.029773f, -51.209844f);
            var mapa = new Map(MapSpan.FromCenterAndRadius(posicao, Distance.FromKilometers(0.3f)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            mapa.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = posicao,
                Label = "Tim Tim Sushi",
                Address = "Felipe Camarão, 59"
            });

            Content = new StackLayout
            {
              Children =
                {
                    mapa
                }
            };
        }
    }
}
