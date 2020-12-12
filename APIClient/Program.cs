using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var httpclient = new swaggerClient("https://localhost:5001/",new HttpClient());

            var AllCourse = await httpclient.CourseAllAsync();

            foreach (var Course in AllCourse)
            {
                Console.WriteLine(Course.Title);
            }

         
        }
    }
}
