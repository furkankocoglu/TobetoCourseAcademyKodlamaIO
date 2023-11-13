﻿
using Entities.Concretes;
using Business.Concretes;
using Microsoft.Data.SqlClient;
using DataAccess.Concretes.EntityFramework;

Category category1 = new Category();
category1.Name = "Programlama";

Instructor instructor1= new Instructor();
instructor1.Name = "Engin Demiroğ";

Course course1 = new Course();
course1.Name = "Js";
course1.CategoryId = 1;
course1.InstructorId = 1;
course1.Title = "Javascript";
////CategoryManager categoryManager=new CategoryManager(); yükleyebilirim
////categoryManager.Add(course1);

Course course2 = new Course();
course2.Name = "Java Dersleri";
course2.CategoryId = 1;
course2.InstructorId = 1;
course2.Title = "Java kodluyoruz";
//categoryManager.Add(course2);

//DataManager dataManager = new DataManager();
//dataManager.Add(course1);


CourseManager courseManager =new CourseManager(new EfCourseDal());
CategoryManager categoryManager=new CategoryManager(new EfCategoryDal());
InstructorManager instructorManager=new InstructorManager(new EfInstructorDal());
//instructorManager.Add(instructor1);
//categoryManager.Add(category1);
//courseManager.Add(course1);
//courseManager.Add(course2); 
Console.WriteLine("------Kurslar-----");
List<Course> courses = courseManager.GetAll();
foreach (var item in courses)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Title);
}
Console.WriteLine("------Eğitmenler------");
List<Instructor> instructors = instructorManager.GetAll();
foreach (var item in instructors)
{
    Console.WriteLine(item.Name);

}
Console.WriteLine("-------Kategoriler----");
List<Category> categories = categoryManager.GetAll();
foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}




































