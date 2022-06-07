using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace rest.ViewModel
{
public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        private List<Pick> GetPicks()
        {

            return new List<Pick>
            {
                new Pick
                { Title = "Desayuno", Image = "IMG01.png", Description = "ordene un desayuno europeo" },
                 new Pick
                { Title = "Almuerzo", Image = "IMG03.png", Description = "ordene un desayuno europeo" },
            };
        }

    }

    public class Pick
    {
        public String Title { get; set; }
        public String Image { get; set; }
        public String Description { get; set; }
        public String Price { get; set; }
    }

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged([CallerMemberName] String name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        }

    }
}




