using System;
using System.Collections.Generic;
using ClassLibrary;

namespace _8aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string answer = "";
            string fullname = "";
            string exname = "";
            string No;
            int no;
            int expoint;
            string point;
            string choosingexam;
            string remove;
            do
            {
                Console.WriteLine("1-Telebe elave edin\n2-Telebeye imtahan elave et\n-3Telebenin bir imtahan balina bax\n4-Telelbenin butun imtahanlarini goster\n5-Telebenin imtahan ortalamasini goster\n6-Telebenin imtahanini sil\n0-Proqrami bitir");

                answer = Console.ReadLine();

                if (answer == "1")
                {
                    do
                    {
                        Console.WriteLine("Zehmet olmasa telebenin adini daxil edin?:");
                        fullname = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(fullname));
                    Student student = new Student();
                    student.Fullname = fullname;
                    students.Add(student);
                }
                else if (answer == "2")
                {
                    do
                    {
                        Console.WriteLine("Zehmet olmaSA imtahan adini daxil edin");
                        exname = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(exname));
                    do
                    {
                        Console.WriteLine("Zehmet olmasa telebenin nomresini daxil edin ");
                        No = Console.ReadLine();
                    } while (!int.TryParse(No, out no));
                    do
                    {
                        Console.WriteLine("Zehmet olmasa telebenin imtahan balini daxil edin");
                        point = Console.ReadLine();

                    } while (!int.TryParse(point, out expoint));
                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            item.AddExam(exname, expoint);
                        }
                    }


                }

                else if (answer == "3")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        No = Console.ReadLine();
                    } while (!int.TryParse(No, out no));
                    do
                    {
                        Console.WriteLine("telebenin baxmaq istediyiniz imtahanin adini yazin: ");
                        choosingexam = Console.ReadLine();
                    } while (String.IsNullOrEmpty(choosingexam));
                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            Console.WriteLine(item.GetExamResult(exname)); ;
                        }
                    }
                }
                else if (answer == "4")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        No = Console.ReadLine();
                    } while (!int.TryParse(No, out no));
                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            foreach (var exam in item.Exams)
                            {
                                Console.WriteLine($"imtahan adi: {exam.Key}  imtahan neticesi: {exam.Value}");
                            };
                        }

                    }
                }
                else if (answer == "5")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        No = Console.ReadLine();
                    } while (!int.TryParse(No, out no));
                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            Console.WriteLine(item.GetExamAvg());
                        }
                    }
                }
                else if (answer == "6")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        No = Console.ReadLine();
                    } while (!int.TryParse(No, out no));
                    do
                    {
                        Console.WriteLine("Zehmet olmasa silmek istediyiniz imtahanin adini yazin: ");
                        remove = Console.ReadLine();
                    } while (String.IsNullOrEmpty(remove));
                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            item.Exams.Remove(remove);
                        }
                    }
                }



            } while (answer != "0");
        }
    }
}
