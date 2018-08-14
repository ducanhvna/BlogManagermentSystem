using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BlogModel;
namespace BlogManagermentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BlogAdminMangermentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BlogAdminMangermentService.svc or BlogAdminMangermentService.svc.cs at the Solution Explorer and start debugging.
    public class BlogAdminMangermentService : IBlogAdminMangermentService
    {
        /// <summary>
        /// List Categories
        /// </summary>
        private ObservableCollection<Category> ListCategories;

        /// <summary>
        /// List Blog Group
        /// </summary>
        private ObservableCollection<BlogGroup> ListBlogGroup;

        /// <summary>
        /// List Blog Post
        /// </summary>
        private ObservableCollection<BlogPost> ListBlogPost;

        /// <summary>
        /// model
        /// </summary>
        BlogManagermentModel model;
        public BlogAdminMangermentService()
        {
            model = new BlogManagermentModel("", "dnA_db");
        }
       

        public void DoWork()
        {
        }

        #region Category area
        /// <summary>
        /// CreateNewCategory
        /// </summary>
        /// <returns></returns>
        public CreateObjectInfo CreateNewCategory()
        {
            short errorCode = 0;
            short objectId = model.CreateNewCategory(ref errorCode);
            return new CreateObjectInfo
            {
                ObjectId = objectId,
                ErrorCode = errorCode
            };
        }

        /// <summary>
        /// Get Category by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public OverviewInfo GetCategorybyIndex(int index)
        {
            if (index < 0 || index >= ListCategories.Count)
            {
                return null;
            }
            var resultObject = ListCategories[index];
            return new OverviewInfo
            {
                Key = resultObject._id.Pid,
                DisplayName = resultObject.Name
            };
        }

        /// <summary>
        /// Number of Categories
        /// </summary>
        /// <returns></returns>
        public int NumberCategories()
        {
            ListCategories = model.ListCategories;
            return ListCategories.Count;
        }

        #endregion
    }
}
