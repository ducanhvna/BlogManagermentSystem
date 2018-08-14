using CommonNS.CommonStructure;
using CommonNS.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BlogManagermentTool
{
    class BlogCategory : ViewModelBase, IObjectContainer
    {
        public bool m_isSelected;
        public bool IsSelected
        {
            get
            {
                return m_isSelected;
            }
            set
            {
                m_isSelected = value;
                RaisePropertyChanged("IsSelected");
            }
        }
        public int Key { get; set; }
        public string Name { get; set; }
        public object Data { get; set; }

        public ObservableCollection<IObjectContainer> SubItems { get; set; }

        public UserControl DiagramView => throw new NotImplementedException();

        public UserControl PropertiesView => throw new NotImplementedException();

        public UserControl CommandView => throw new NotImplementedException();
    }
}
