﻿using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        public CourseViewModel GetCourses();
        void CreateCourse(CourseViewModel courseViewModel);
    }
}
