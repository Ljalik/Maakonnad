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
        public Page1()
        {
            Picker picker;
            Entry entry;
            Image image;
            {
                Grid gr = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
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
                    Title = "Maakonnad"
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
                gr.Children.Add