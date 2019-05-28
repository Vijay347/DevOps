using Capsule_TaskManager.Models.User;
using Capsule_TaskManagerDL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsule_TaskManagerDL
{
    public class UserDL
    {
        #region GetUserDetails
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetUserDetails()
        {
            List<UserModel> userModelList = null;
            using (TaskManagerEntities db = new TaskManagerEntities())
            {
                var userList = db.GET_USER_DETAILS();

                if (userList != null)
                {
                    userModelList = new List<UserModel>();

                    foreach (var item in userList)
                    {
                        userModelList.Add(new UserModel()
                        {
                            User_ID = item.User_ID,
                            First_Name = item.First_Name,
                            Last_Name = item.Last_Name,
                            Employee_ID = item.Employee_ID
                        });
                    }
                }

                return userModelList;
            }
        }
        #endregion

        #region Insert/Update User Detail
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskModel"></param>
        /// <returns></returns>

        public bool SubmitUserDetail(UserModel userModel)
        {
            var isSubmitted = false;

            using (TaskManagerEntities objEntities = new TaskManagerEntities())
            {
                var existingTask = objEntities.INSERT_USER_DETAILS(userModel.User_ID, userModel.First_Name, userModel.Last_Name, userModel.Employee_ID, userModel.Project_ID, userModel.Task_ID, userModel.Action);
                var updatedRecord = objEntities.SaveChanges();
                isSubmitted = existingTask > 0;
            }

            return isSubmitted;
        }
    }
    #endregion
}