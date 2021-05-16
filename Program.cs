using System;
using System.Collections.Generic;
using System.Linq;
using POO.ContentContext;
using POO.ContentContext.Enums;
using POO.SubscriptionContext;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Articles
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            // foreach(var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            //     Console.WriteLine("==================");
            // }
            #endregion


            var courses = new List<Course>();
            var courseOOP = new Course("Fundamento OOP", "fundamentos-oop", EContentLevel.Fundamental);
            var courseCSharp = new Course("Fundamento C#", "fundamentos-csharp", EContentLevel.Beginner);
            var courseAspNet = new Course("Fundamento ASP.NET", "fundamentos-aspnet", EContentLevel.Beginner);

            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "Aprenda .Net", "", courseAspNet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");   
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);
                    Console.WriteLine("======================");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }

                    var payPalSubscription = new PayPalSubscription();
                    var student =  new Student();
                    student.CrateSubscription(payPalSubscription);
                }
            }
        }
    }
}
