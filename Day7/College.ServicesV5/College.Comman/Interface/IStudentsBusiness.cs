﻿using College.Common.Entities;
using System.Collections.Generic;

namespace College.Common.Interface
{
    public interface IStudentsBusiness
    {
        IEnumerable<Student> GetAllStudents();
    }

}