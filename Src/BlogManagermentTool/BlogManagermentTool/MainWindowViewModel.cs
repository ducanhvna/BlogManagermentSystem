using CommonNS.CommonStructure;
using CommonNS.Helpers;
using CommonNS.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogManagermentTool.BlogManagermentServiceReference;

namespace BlogManagermentTool
{
    class MainWindowViewModel: ViewModelBase
    {
        private ObservableCollection<BlogCategory> m_BlogContainers;
        private BlogAdminMangermentServiceClient m_ModelClient ;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindowViewModel()
        {
            // Init model
            Global.ModelClient = new BlogAdminMangermentServiceClient();

            // Init SelectObjectContainerCommand
            SelectObjectContainerCommand = new RelayCommand(SelectObjectContainer);

            // Init client
            m_ModelClient = Global.ModelClient;

            // Initialize CreateNewBlogCategoryCommand
            CreateNewBlogCategoryCommand = new RelayCommand(CreateNewBlogCategory);

            // Initialize Coponents
            InitializeComponents();
        }

        /// <summary>
        /// Initialize components content
        /// </summary>
        private void InitializeComponents()
        {

            BlogContainers = new ObservableCollection<BlogCategory>();
            var numberCategory = m_ModelClient.NumberCategories();
            for (var i = 0; i < numberCategory; i++)
            {
                BlogContainers.Add(new BlogCategory()
                {
                    Name = "Temp"
                });
            }
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

        #region SelectObjectContainer
        public RelayCommand SelectObjectContainerCommand { get; internal set; }
        private void SelectObjectContainer(object param)
        {
            var objectselect = param as IObjectContainer;
            foreach (var item in BlogContainers)
            {
                item.IsSelected = false;
            }
            objectselect.IsSelected = true;
            SelectedItem = objectselect;
        }
        #endregion

        #region CreateNewBlogCategoryCommand
        /// <summary>
        /// CreateNewBlogCategoryCommand
        /// </summary>
        public RelayCommand CreateNewBlogCategoryCommand { get; internal set; }

        /// <summary>
        /// Selected items
        /// </summary>
        public IObjectContainer SelectedItem { get; set; }

        /// <summary>
        /// CreateNewBlogCategory
        /// </summary>
        /// <param name="param"></param>
        private void CreateNewBlogCategory(object param)
        {
            var createResult = m_ModelClient.CreateNewCategory();
            if (createResult.ErrorCode == 0)
            {
                InitializeComponents();
            }
        }
        #endregion
    }
}
