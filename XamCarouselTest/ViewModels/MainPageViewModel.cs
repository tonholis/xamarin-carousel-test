using System;
using System.Collections.Generic;
using Prism.Mvvm;
using Prism.Navigation;

namespace XamCarouselTest.ViewModels
{
  
    public class MainPageViewModel : BindableBase, INavigatedAware
    {
        public MainPageViewModel()
        {
            
        }

        private List<MyItem> _items;
        public List<MyItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Items = new List<MyItem> {
                new MyItem { Title = "Page 1", Active = false },
                new MyItem { Title = "Page 2", Active = false },
                new MyItem { Title = "Page 3", Active = false },
                new MyItem { Title = "Page 4", Active = true },
            };
        }
    }

    public class MyItem : BindableBase
    {
        private bool _active;
        private string _title;

        public bool Active
        {
            get => _active;
            set => SetProperty(ref _active, value);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
