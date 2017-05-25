using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimTimSushi.Paginas
{
    public class IndexPage : BasePage
    {
        public IndexPage()
        {
            var telefone = new Button() { Text = "+55 (51) 98408-3153" };
            telefone.Clicked += Telefone_Clicked;

            Content = new ContentView()
            {
                Content = new StackLayout
                {
                    Children = {
                        new Image{
                            Aspect = Aspect.AspectFit,
                            Source = ImageSource.FromFile("logo.png")//Device.OnPlatform(ImageSource.FromFile("logo.png"), ImageSource.FromFile("logo.png"), null)
                        },
                        telefone
                    }
                },
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }
        
        private void Telefone_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel://+5551984083153"));
        }
    }
}
