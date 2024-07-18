using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualizeListViewMemoryLeak.Models;

namespace VirtualizeListViewMemoryLeak.ViewModels
{
    public partial class MainPageVm : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ItemGroup> _Items = new();

        public MainPageVm()
        {
            for (int i = 0; i < 20; i++)
            {
                var group = new ItemGroup();
                group.Name = $"Group {i}";
                group.Description = "This is a cool and friendly description for this group!";

                for (int x = 0; x < 100; x++)
                {
                    var item = new Item();
                    item.Name = $"Item {x}";
                    item.Description = "This is a cool and friendly description for this item!";

                    group.AllItems.Add(item);
                }

                Items.Add(group);
            }    
        }
    }
}
