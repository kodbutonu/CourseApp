using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;

namespace CourseApp.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses=new();
         
         static Repository(){
           _courses=new List<Course>(){
           new Course(){Id=1,Title="Asp.net Kursu",Description="Güzel bir kurs",Image="1.jpg",Tags=new string[] {"Asp.net","Web geliştirme"},isActive=false,isHome=true},
           new Course(){Id=2,Title="Php Kursu",Description="Güzel bir kurs",Image="2.jpg",Tags=new string[] {"Php Kursu","Web geliştirme"},isActive=true,isHome=true},
           new Course(){Id=3,Title="C# Kursu",Description="Güzel bir kurs",Image="3.jpg",Tags=new string[] {"C# Kursu","Web geliştirme"},isActive=true,isHome=true},
           new Course(){Id=4,Title="Html Kursu",Description="Güzel bir kurs",Image="4.jpg",Tags=new string[] {"Html Kursu","Web geliştirme"},isActive=true,isHome=true}
        };
         }
       
        public static List<Course> Courses{

            get{
                return _courses;
            }
        }

        public static Course? GetById(int id){
            return _courses.FirstOrDefault(c => c.Id==id);
        }
    }
}