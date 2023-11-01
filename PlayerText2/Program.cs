using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerText2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();

            while (true)
            {
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Display Teachers");
                Console.WriteLine("3. Update Teacher");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Add Teacher
                    Console.Write("Enter Teacher ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Teacher Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Class: ");
                    string teacherClass = Console.ReadLine();
                    Console.Write("Enter Section: ");
                    string section = Console.ReadLine();

                    teachers.Add(new Teacher
                    {
                        Id = id,
                        Name = name,
                        Class = teacherClass,
                        Section = section
                    });
                }
                else if (choice == 2)
                {
                    // Display Teachers
                    foreach (var teacher in teachers)
                    {
                        Console.WriteLine(teacher);
                    }
                }
                else if (choice == 3)
                {
                    // Update Teacher
                    Console.Write("Enter Teacher ID to update: ");
                    int idToUpdate = int.Parse(Console.ReadLine());
                    Teacher teacherToUpdate = teachers.Find(teacher => teacher.Id == idToUpdate);

                    if (teacherToUpdate != null)
                    {
                        Console.Write("Enter new Name: ");
                        teacherToUpdate.Name = Console.ReadLine();
                        Console.Write("Enter new Class: ");
                        teacherToUpdate.Class = Console.ReadLine();
                        Console.Write("Enter new Section: ");
                        teacherToUpdate.Section = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Teacher not found!");
                    }
                }
                else if (choice == 4)
                {
                    // Save data to a text file
                    using (StreamWriter writer = new StreamWriter("teachers.txt"))
                    {
                        foreach (var teacher in teachers)
                        {
                            writer.WriteLine($"{teacher.Id},{teacher.Name},{teacher.Class},{teacher.Section}");
                        }
                    }
                    break;
                }
            }
        }
    }
    }

