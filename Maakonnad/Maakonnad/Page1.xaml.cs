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
                        entry.Text = "Уезд Валгамаа расположен в южной части Эстонии. Этот регион граничит с Латвийской республикой. Административным центром уезда является город Валга, побратимом которого считается латвийский Валка. В некоторой степени эти города составляют единое целое, однако административно они разделены границей.";
                    }
                    else if (picker.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ви́льяндимаа — уезд в Эстонии, расположенный в южной части страны. Административный центр — город Вильянди. Уезд состоит из трёх городов и 9 волостей.";
                    }
                    else if (picker.SelectedIndex == 2)
                    {
                        img.Source = "voruma.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Вырумаа (эст. Võrumaa или Võru maakond, выруск. Võromaa или Võro maakund) — уезд в Эстонии, расположенный в юго-восточной части страны. Граничит с Россией, Латвией, уездами Валгамаа и Пылвамаа. Административный центр — город Выру (тж. Верро). Уезд в административном отношении делится на один город и 4 волости (с 2017 года).";
                    }
                    else if (picker.SelectedIndex == 3)
                    {
                        img.Source = "ida.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "И́да-Ви́румаа (эст. Ida-Virumaa), или И́да-Ви́руский уезд (эст. Ida-Viru maakond) — уезд (мааконд) на северо-востоке Эстонии, граничит на севере и востоке с Россией. Территория уезда простирается до Финского залива на севере, до реки Нарвы на востоке и до Чудского озера на юге. На западе и юго-западе уезда граница тянется через леса и болота Алутагузе[2], вдоль территории Ляэне-Вируского и Йыгеваского уездов. Площадь Ида-Вирумаа — 3364,05 км², что составляет 7,4 % от площади всей Эстонии. В середине северной части уезда, в 165 км от Таллина, находится административный центр Ида-Вирумаа — город Йыхви. ";
                    }
                    else if (picker.SelectedIndex == 4)
                    {
                        img.Source = "jigi.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Йыгевамаа (эст. Jõgevamaa или Jõgeva maakond) — уезд в Эстонии, расположенный в восточной части страны. Административный центр — город Йыгева. Уезд в административном отношении делится на 3 города и 10 волостей. ";
                    }
                    else if (picker.SelectedIndex == 5)
                    {
                        img.Source = "laene.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ля́эне-Ви́румаа (эст. Lääne-Virumaa или Lääne-Viru maakond) — уезд в Эстонии, расположенный в северо-восточной части страны. Административный центр — город Раквере. ";
                    }
                    else if (picker.SelectedIndex == 6)
                    {
                        img.Source = "laenemaa.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ляэнемаа (эст. Läänemaa или Lääne maakond) — уезд в Эстонии, расположенный на крайнем западе материковой части страны. С севера и запада омывается Балтийским морем. Граничит с уездами Харьюмаа на северо-востоке, Рапламаа на востоке и Пярнумаа на юге. Административный центр — город Хаапсалу. Уезд в административном отношении делится на 1 город и 9 волостей.";
                    }
                    else if (picker.SelectedIndex == 7)
                    {
                        img.Source = "polvama.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Пы́лвамаа (старое написание Пыльвамаа; эст. Põlvamaa или Põlva maakond) — уезд на юго-востоке Эстонии. Граничит с Россией на востоке, а также с уездами Вырумаа, Валгамаа и Тартумаа. Административный центр — город Пылва. До административной реформы местных самоуправлений Эстонии 2017 года уезд делился на 13 волостей, после — на 3 волости";
                    }
                    else if (picker.SelectedIndex == 8)
                    {
                        img.Source = "parnu.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Пярнумаа (эст. Pärnumaa или Pärnu maakond) — самый крупный по площади уезд в Эстонии, расположенный в юго-западной части страны на побережье Рижского залива. Граничит с уездами Ляэнемаа и Рапламаа на севере и Ярвамаа и Вильяндимаа на востоке. Административный центр — город Пярну. Уезд в административном отношении делится на 2 города и 17 волостей.";
                    }
                    else if (picker.SelectedIndex == 9)
                    {
                        img.Source = "rapla.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Рапламаа (эст. Raplamaa или Rapla maakond) — уезд в Эстонии, расположенный в западной части страны. Граничит с уездами Ярвамаа на востоке, Пярнумаа на юге, Ляэнемаа на западе и Харьюмаа на севере. Административный центр — город Рапла. Уезд в административном отношении делится на 10 волостей.";
                    }
                    else if (picker.SelectedIndex == 10)
                    {
                        img.Source = "sarema.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Са́аремаа (эст. Saaremaa или Saare maakond) — уезд в Эстонии, территория которого состоит из островов Сааремаа, Муху, Абрука, Вилсанди, Рухну и других более мелких островов.";
                    }
                    else if (picker.SelectedIndex == 11)
                    {
                        img.Source = "tartu.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Та́ртумаа (также Та́ртуский уе́зд — эст. Tartu maakond) — один из 15 уездов Эстонской Республики. Административный центр — город Тарту. Площадь — 2993 км², население — 153 479 (2012). ";
                    }
                    else if (picker.SelectedIndex == 12)
                    {
                        img.Source = "harju.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Харьюмаа, или Харью (эст. Harju maakond или Harjumaa), — один из 15 уездов Эстонии. Административный центр — столица страны Таллин. С 21 декабря 2009 года старейшина уезда — Юлле Раясалу (Ülle Rajasalu). ";
                    }
                    else if (picker.SelectedIndex == 13)
                    {
                        img.Source = "hiju.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Хийумаа (эст. Hiiu maakond) — уезд в Эстонии, территория которого состоит из острова Хийумаа и окружающих его малых островов. Административный центр уезда — город Кярдла. ";
                    }
                    else if (picker.SelectedIndex == 14)
                    {
                        img.Source = "jarva.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ярвамаа (эст. Järvamaa или Järva maakond) — уезд в Эстонии, расположенный в центральной части страны. Административный центр — город Пайде. Уезд в административном отношении делится на один городской муниципалитет и две волости.";
                    }
                }
                {  
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
