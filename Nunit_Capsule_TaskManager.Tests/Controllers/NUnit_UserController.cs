using Capsule_TaskManager.Controllers;
using Capsule_TaskManager.Models.User;
using NUnit.Framework;

namespace Nunit_Capsule_TaskManager.Tests.Controllers
{
    [TestFixture]
    public class NUnit_UserController
    {
        #region Public Declaration

        UserController objUserController = new UserController();

        #endregion

        #region GetUserDetails
        /// <summary>
        /// To get User details
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserDetails()
        {
            var vlsit = objUserController.GetUserDetails();
            Assert.IsTrue(vlsit != null);
        }
        #endregion

        #region SubmitUserDetail
        /// <summary>
        /// Insert the User details which user entered
        /// </summary>
        /// <param name="objGET_User_DETAILS_Result"></param>
        /// <returns></returns>
        [Test, Order(1)]
        public void InsertUserDetail()
        {
            UserModel userModel = new UserModel();
            userModel.User_ID = 0;
            userModel.First_Name = "Vijay";
            userModel.Last_Name = "Palani";
            userModel.Employee_ID = 1;
            userModel.Action = "insert";
            userModel.Project_ID = 1;
            userModel.Task_ID = 1;

            var isInserted = objUserController.SubmitUserDetail(userModel);
            Assert.IsTrue(isInserted);
        }

        [Test]
        public void UpdateUserDetail()
        {
            UserModel userModel = new UserModel();
            userModel.User_ID = 1;
            userModel.First_Name = "Vijayakumar";
            userModel.Last_Name = "Palani";
            userModel.Employee_ID = 1;
            userModel.Action = "update";
            userModel.Project_ID = 1;
            userModel.Task_ID = 1;

            var isUpdated = objUserController.SubmitUserDetail(userModel);
            Assert.IsTrue(isUpdated);
        }
        #endregion

        
    }
}
