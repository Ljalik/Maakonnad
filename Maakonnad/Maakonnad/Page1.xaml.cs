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
                    Title = "Уезды"
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
