using Microsoft.AspNetCore.Routing;

namespace basics.Models
{
    public class Repository{
        private static readonly List<Course> _courses=new();

        static Repository()
        {
            _courses=new List<Course>()
            {
            new Course() {Id = 0,Title= "asp kursu",Description="güzel bir kurs gerçekten",Image="1.jpeg"},
            new Course() {Id = 1,Title= "php kursu",Description="güzel bir kurs",Image="1.jpeg"},
            new Course() {Id = 2,Title= "java kursu",Description="güzel bir kurs",Image="1.jpeg"},


            };

        }


        public static List<Course> Couses
        {
            get{
                return _courses;
            }

        }
    }
}