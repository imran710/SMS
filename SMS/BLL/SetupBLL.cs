using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SetupBLL
    {
        SetupDAL objSetup = new SetupDAL();
        public int InsertUpdateDelete_CategoryInfo(int action, string category, int UserId, int catid = 0)
        {
            int ret = 0;
            ret = objSetup.InsertUpdateDelete_Category( action,  category, UserId,  catid );
            return ret;
        }

        public int InsertUpdateDelete_SubCategoryInfo(int action, int CategoryId, string Subcategory, int UserId, int Subcatid = 0)
        {
            int ret = 0;
            ret = objSetup.InsertUpdateDelete_SubCategory(action, CategoryId, Subcategory, UserId, Subcatid);
            return ret;
        }


        public DataTable Set_getCategoryInfo()
        {
            DataTable ret = new DataTable();
            ret = objSetup.Set_getCategory();
            return ret;
        }
        public DataTable Set_getSubCategoryInfo()
        {
            DataTable ret = new DataTable();
            ret = objSetup.Set_getSubCategory();
            return ret;
        }
    }
}
