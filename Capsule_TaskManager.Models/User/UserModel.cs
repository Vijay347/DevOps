﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsule_TaskManager.Models.User
{
    public class UserModel
    {
        public Nullable<int> User_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public Nullable<int> Project_ID { get; set; }
        public Nullable<int> Task_ID { get; set; }
        public string Action { get; set; }
    }
}
