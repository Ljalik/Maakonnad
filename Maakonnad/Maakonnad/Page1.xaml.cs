using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maakonnad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private Picker stol;

        public Page1()
        {
            Picker picker;
            Entry entry;
            Image img;
            {
                Grid gr = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }
                };
                picker = new Picker
                {
                    Title = "Уезды Эстонии"
                };
                picker.Items.Add("Валгамаа");
                picker.Items.Add("Вильяндимаа");
                picker.Items.Add("Вырумаа");
                picker.Items.Add("Ида-Вирумаа");
                picker.Items.Add("Йыгевамаа");
                picker.Items.Add("Ляэне-Вирумаа");
                picker.Items.Add("Ляэнемаа");
                picker.Items.Add("Пылвамаа");
                picker.Items.Add("Пярнумаа");
                picker.Items.Add("Рапламаа");
                picker.Items.Add("Сааремаа");
                picker.Items.Add("Тартумаа");
                picker.Items.Add("Харьюмаа");
                picker.Items.Add("Хийумаа");
                picker.Items.Add("Ярвамаа");
                gr.Children.Add(picker, 0, 0);
                picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

                stol = new Picker
                {
                    Title = "Административные центры уездов"
                };
                stol.Items.Add("Валга");
                stol.Items.Add("Вильянди");
                stol.Items.Add("Выру");
                stol.Items.Add("Йихви");
                stol.Items.Add("Йигева");
                stol.Items.Add("Раквере");
                stol.Items.Add("Хаапсалу");
                stol.Items.Add("Пылва");
                stol.Items.Add("Пярну");
                stol.Items.Add("Рапла");
                stol.Items.Add("Курусааре");
                stol.Items.Add("Тарту");
                stol.Items.Add("Таллинн");
                stol.Items.Add("Кярдла");
                stol.Items.Add("Пайде");
                gr.Children.Add(stol, 0, 0);

                stol.SelectedIndexChanged += Stol_SelectedIndexChanged;
                entry = new Entry
                {
                    Text = "Уезд"
                };
                gr.Children.Add(entry, 1, 1);

                img = new Image
                {
                    Source = "harju.jpg"
                };
                {
                    if (stol.SelectedIndex == 0)
                    {
                        img.Source = "valga.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 2)
                    {
                        img.Source = "voruma.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 3)
                    {
                        img.Source = "ida.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 4)
                    {
                        img.Source = "jigi.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 5)
                    {
                        img.Source = "laene.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 6)
                    {
                        img.Source = "laenemaa.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 7)
                    {
                        img.Source = "polvama.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 8)
                    {
                        img.Source = "parnu.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 9)
                    {
                        img.Source = "rapla.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 10)
                    {
                        img.Source = "sarema.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 11)
                    {
                        img.Source = "tartu.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 12)
                    {
                        img.Source = "harju.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 13)
                    {
                        img.Source = "hiju.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 14)
                    {
                        img.Source = "jarva.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                }
                {
                    if (picker.SelectedIndex == 0)
                    {
                        img.Source = "valga.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 2)
                    {
                        img.Source = "voruma.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 3)
                    {
                        img.Source = "ida.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 4)
                    {
                        img.Source = "jigi.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 5)
                    {
                        img.Source = "laene.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 6)
                    {
                        img.Source = "laenemaa.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 7)
                    {
                        img.Source = "polvama.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 8)
                    {
                        img.Source = "parnu.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 9)
                    {
                        img.Source = "rapla.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 10)
                    {
                        img.Source = "sarema.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 11)
                    {
                        img.Source = "tartu.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 12)
                    {
                        img.Source = "tartu.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 13)
                    {
                        img.Source = "harju.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 14)
                    {
                        img.Source = "hiju.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                    else if (picker.SelectedIndex == 15)
                    {
                        img.Source = "jarva.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                    }
                }
                {
                    throw new NotImplementedException();
                }
            }
        }

        private void Stol_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
