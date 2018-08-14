using CommonNS.CommonStructure;
using CommonNS.Helpers;
using CommonNS.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagermentTool
{
    class MainWindowViewModel: ViewModelBase
    {
        private ObservableCollection<BlogCategory> m_BlogContainers;

        public MainWindowViewModel()
        {
            // Initialize CreateNewBlogCategoryCommand
            CreateNewBlogCategoryCommand = new RelayCommand(CreateNewBlogCategory);

            // Initialize Coponents
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            BlogContainers = new ObservableCollection<BlogCategory>();
            BlogCategory item1 = new BlogCategory()
            {
                Name = "abc",
            };
            item1.SubItems = new ObservableCollection<IObjectContainer>();

            BlogCategory item2 = new BlogCategory()
            {
                Name = "abc2",
            };
            item1.SubItems.Add(item2);
            BlogContainers.Add(item1);
            BlogContainers.Add(item2);


        }

        /// <summary>
        /// BlogContainers
        /// </summary>
        public ObservableCollection<BlogCategory> BlogContainers
        {
            get
            {
                return m_BlogContainers;
            }
            set
            {
                if (m_BlogContainers != value)
                {
                    m_BlogContainers = value;
                    RaisePropertyChanged("BlogContainers");
                }
            }
        }
        #region CreateNewBlogCategoryCommand
        public RelayCommand CreateNewBlogCategoryCommand { get; internal set; }

        public IObjectContainer SelectedItem { get; set; }

        /// <summary>
        /// CreateNewBlogCategory
        /// </summary>
        /// <param name="param"></param>
        private void CreateNewBlogCategory(object param)
        {
            var objectselect = param as IObjectContainer;
            foreach (var item in BlogContainers)
            {
                item.IsSelected = false;
            }
            objectselect.IsSelected = true;
            SelectedItem = objectselect;
            RaisePropertyChanged("BlogContainers");
            RaisePropertyChanged("IsSelected");
        }
        #endregion
    }
}
