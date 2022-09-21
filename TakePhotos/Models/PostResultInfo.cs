using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakePhotos.Models
{
    public class PostResultInfo
    {
        public int statusCode;
        public string message;
        public bool success;
        public StudentData data;
    }

    public class StudentData
    {
        public Student student { get; set; }
        public Examination examination { get; set; }
        public int orderNumber { get; set; }
        public UserInfo user { get; set; }
    }

    public class Examination
    {
        public string _id;
        public string name;
        public bool active;
        public bool canStart;
        public object examIds;
        public object createAt;
        public object updatedAt;
        public int __v;
        public string id;
    }
    public class Student
    {
        public string _id;
        public string studentCode;
        public string candidateCode;
        public string user;
        public object createdAt;
        public object updatedAt;
        public int __v;
    }

    public class UserInfo
    {
        public string _id;
        public string username;
        public string email;
        public string fullname;
        public object dob;
        public string avatar;
        public bool verified;
        public string userType;
        public bool active;
        public bool deleted;
        public object createdAt;
        public object updatedAt;
        public int __v;
    }
}
