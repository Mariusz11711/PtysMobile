using PtysMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PtysMobile.ViewModel
{
    public class AddNodeTorty
    {
        public ObservableCollection<NodeItem> NodeItemElement { get; set; }
        public ObservableCollection<NodeTortyEleement> NodeTortyEleements { get; set; }

        NodeTortyEleement selectedCategories;
        public NodeTortyEleement SelectedCategories
        {
            get
            {
                return selectedCategories;
            }
            set
            {
                if (selectedCategories != value)
                {
                    selectedCategories = value;
                }
            }
        }
        public AddNodeTorty()
        {
            NodeItemElement = new ObservableCollection<NodeItem>();

            NodeTortyEleements = new ObservableCollection<NodeTortyEleement>();
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty standardowe" });
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty lodowe" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty weselne" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty dla dzieci" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty na chrzciny" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty na komunie" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty dla firm," }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Torty okolicznosciowe," }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { NameMenu = "Fototorty," });

            selectedCategories = NodeTortyEleements.Skip(0).FirstOrDefault();
        }
    }
}
