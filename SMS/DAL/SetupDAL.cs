using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SetupDAL
    {
        public int InsertUpdateDelete_Category(int action, string category, int UserId, int catid=0)
        {
            int ret = 0;

            Database db;
            DbCommand dbCmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbCmd = db.GetStoredProcCommand("conSp_InsertUpdateCategory");
            db.AddInParameter(dbCmd, "action", DbType.Int32, action);
            db.AddInParameter(dbCmd, "CategoryId", DbType.Int32, catid);
            db.AddInParameter(dbCmd, "Category", DbType.String, category);
            db.AddInParameter(dbCmd, "EntryBy", DbType.Int32, UserId);
          
            ret = db.ExecuteNonQuery(dbCmd);

            return ret;
        }

        public int InsertUpdateDelete_SubCategory(int action,int CategoryId, string Subcategory, int UserId, int Subcatid = 0)
        {
            int ret = 0;

            Database db;
            DbCommand dbCmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbCmd = db.GetStoredProcCommand("conSp_InsertUpdateSubCategory");
            db.AddInParameter(dbCmd, "action", DbType.Int32, action);
            db.AddInParameter(dbCmd, "CategoryId", DbType.Int32, CategoryId);
            db.AddInParameter(dbCmd, "SubCategory", DbType.String, Subcategory);
            db.AddInParameter(dbCmd, "EntryBy", DbType.Int32, UserId);
            db.AddInParameter(dbCmd, "SubCategoryId", DbType.Int32, Subcatid);

            ret = db.ExecuteNonQuery(dbCmd);

            return ret;
        }

        public DataTable Set_getCategory()
        {
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbCmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbCmd = db.GetStoredProcCommand("SetupSp_GetCategory");
            dt = db.ExecuteDataSet(dbCmd).Tables[0];
            return dt;
        }

        public DataTable Set_getSubCategory()
        {
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbCmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbCmd = db.GetStoredProcCommand("SetupSp_GetSubCategory");
            dt = db.ExecuteDataSet(dbCmd).Tables[0];
            return dt;
        }


    }
}
