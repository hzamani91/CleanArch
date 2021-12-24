using System;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services;
public interface ICourseService
{
    IEnumerable<CourseViewModel> GetCourses();
}


