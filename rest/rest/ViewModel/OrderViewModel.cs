using System;
using System.Collections.Generic;
using System.Text;


using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;


namespace rest.ViewModel
{
    class OrderViewModel : BaseViewModel
    {
        public String CurrentSearch;
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }
        public List<Pick> CurrentMenu { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
        public ICommand SearchCommand => new Command(() => filterSearch());
        
        private void filterSearch()
        {
            List<Pick> newList = new List<Pick>();

            foreach (var pick in MenuList)
            {
                if (pick.Title.Contains(CurrentSearch))
                {
                    newList.Add(pick);
                }
            }

            CurrentMenu = newList;
        }
        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "The Ultimate Pack", Image = "IMG05.png", Description = "Prime beef burger topped with pepper jack cheese and crispy bacon.", Price = "$23.99" },
                new Pick { Title = "Lamb Bundle", Image = "IMG04.png", Description = "Lamb leg cooked in a Thai style yellow curry, with baby corn, string beans and chilies.", Price = "$19.99" },
                new Pick { Title = "Juicy Mushroom", Image = "IMG01.png", Description = "Wild mushroom and pea in a parmesan risotto served with crispy fried chicken.", Price = "$25.25" }
            };
        }
    }

}
