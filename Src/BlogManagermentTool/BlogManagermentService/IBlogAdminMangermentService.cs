using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlogManagermentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBlogAdminMangermentService" in both code and config file together.
    [ServiceContract]
    public interface IBlogAdminMangermentService
    {

        [OperationContract]
        void DoWork();

        #region Categories Area

        [OperationContract]
        CreateObjectInfo CreateNewCategory();

        [OperationContract]
        int NumberCategories();

        [OperationContract]
        OverviewInfo GetCategorybyIndex(int index);

        #endregion
    }
}
