using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maakonnad
{
    public partial class MainPage : ContentPage
    {
        Picker uez, stol;
        Entry entry;
        Image img;
        public MainPage()
        {
            //InitializeComponent();
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            uez = new Picker
            {
                Title = "Уезды"
            };
            uez.Items.Add("Валгамаа");
            uez.Items.Add("Вильяндимаа");
            uez.Items.Add("Вырумаа");
            uez.Items.Add("Ида-Вирумаа");
            uez.Items.Add("Йыгевамаа");
            gr.Children.Add(uez, 0, 0);
            uez.SelectedIndexChanged += Picker_SelectedIndexChanged;

            stol = new Picker
            {
                Title = "Город"
            };
            stol.Items.Add("Валга");
            stol.Items.Add("Вильянди");
            stol.Items.Add("Выру");
            stol.Items.Add("Йыхви");
            stol.Items.Add("Йыгева");
            gr.Children.Add(stol, 1, 0);
            stol.SelectedIndexChanged += Stol_SelectedIndexChanged;

            entry = new Entry
            {
                Text = "Уезд"
            };
            gr.Children.Add(entry, 1, 1);

            img = new Image
            {
                Source = "Virumaa.png"
            };
            gr.Children.Add(img, 0, 1);
            Content = gr;
        }

        private void Stol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stol.SelectedIndex == 0)
            {
                img.Source = "Valga.png";
                uez.Title = uez.Items[stol.SelectedIndex];
            }
            else if (stol.SelectedIndex == 1)
            {
                img.Source = "Viljandimaa.jpg";
                uez.Title = uez.Items[stol.SelectedIndex];
            }
            else if (stol.SelectedIndex == 2)
            {
                img.Source = "Virumaa.png";
                uez.Title = uez.Items[stol.SelectedIndex];
            }
            else if (stol.SelectedIndex == 3)
            {
                img.Source = "Idavirumaa";
                uez.Title = uez.Items[stol.SelectedIndex];
            }
            else if (stol.SelectedIndex == 4)
            {
                img.Source = "iigeva";
                uez.Title = uez.Items[stol.SelectedIndex];
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uez.SelectedIndex == 0)
            {
                img.Source = "Valga.png";
                stol.Title = stol.Items[uez.SelectedIndex];
            }
            else if (uez.SelectedIndex == 1)
            {
                img.Source = "Viljandimaa.jpg";
                stol.Title = stol.Items[uez.SelectedIndex];
            }
            else if (uez.SelectedIndex == 2)
            {
                img.Source = "Virumaa.png";
                stol.Title = stol.Items[uez.SelectedIndex];
            }
            else if (uez.SelectedIndex == 3)
            {
                img.Source = "Idavirumaa";
                stol.Title = stol.Items[uez.SelectedIndex];
            }
            else if (uez.SelectedIndex == 4)
            {
                img.Source = "iigeva";
                stol.Title = stol.Items[uez.SelectedIndex];
            }

        }
    }
}
