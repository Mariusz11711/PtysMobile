using PtysMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PtysMobile.ViewModel
{
    public class AddNodeTorty
    {
        public ObservableCollection<NodeTortyEleement> NodeTortyEleements { get; set; }
        public AddNodeTorty()
        {
            NodeTortyEleements = new ObservableCollection<NodeTortyEleement>();
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty standardowe" });
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty lodowe" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty weselne" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty dla dzieci" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty na chrzciny" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty na komunie" }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty dla firm," }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Torty okolicznosciowe," }); 
            NodeTortyEleements.Add(new NodeTortyEleement() { Name = "Fototorty," }); 
        }
    }
}
