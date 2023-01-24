using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3._3
{
    public struct Person //creation of struct person
    {
        public string first_name; //{ get; set; }
        public string last_name; //{ get; set; }
        public sbyte per_age; //{ get; set; }

       /* public Person(string f_name, string l_name, sbyte age)
        {
            first_name = f_name;
            last_name = l_name;
            per_age = age;
        }*/

    }

    public struct Student //creation of struct student
    {
        public Person st_data;
        public uint stud_id; //{ get; set; }
        public string college_name; //{ get; set; }
        public string city_name; //{ get; set; }
        public string col_address; //{ get; set; }

        /*public Student(Person data, uint id, string col_name, string city, string add)
        {
            st_data = data;
            stud_id = id;
            college_name = col_name;
            city_name = city;
            col_address = add;
        }*/
        
        
    }

    internal class Program
    {

        static void Main(string[] args)
        {
           
            //hard coding the first student
            Student student1;
            student1.st_data.first_name = "Bruno";
            student1.st_data.last_name = "Lopes";
            student1.st_data.per_age = 34;
            student1.stud_id = 1234567;
            student1.college_name = "Lasalle";
            student1.city_name = "Montreal";
            student1.col_address = "adress 1";
            
            Student[] student = new Student[5]; //creating an array of students type Student

            List<Student> stdlist = new List<Student>(); //creating the list of students type Student
            var st = new Student();
            student[0] = student1; //including the student 1 in the array of students
            int counter = 1;
            int opt = 0;

            do
            { //menu with options

            label0:
                Console.WriteLine("\n---------------------\n" + counter + " students registered");
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Enter with the option\n1) Add a student in the Array\n2) Add a student in the List\n3) Display the information from the Array\n4) Display the information from the List\n5) quit the application");
                Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                    if (opt < 1 || opt > 5)
                    {
                        Console.WriteLine("Enter with one of the options numers 1, 2 or 3");
                        goto label0;
                    }

                }
                catch (Exception ex0)
                {
                    Console.WriteLine(ex0.Message + "Enter with a valid number from the list");
                    goto label0;
                }

                switch (opt)
                {

                    case 1:
                        {

                            if (counter < student.Length)
                            {
                                Console.WriteLine("Enter with information of student:");

                                Console.Write("First Name: ");

                                student[counter].st_data.first_name = Console.ReadLine();

                                Console.Write("Last Name: ");

                                student[counter].st_data.last_name = Console.ReadLine();

                            label1:
                                Console.Write("Age: ");
                                try
                                {
                                    student[counter].st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                    if (student[counter].st_data.per_age < 18 || student[counter].st_data.per_age > 65)
                                    {
                                        Console.WriteLine("Enter with a valid age (between 18 and 65)");
                                        goto label1;

                                    }
                                }
                                catch (Exception ex3)
                                {
                                    Console.WriteLine(ex3.Message + "Enter with a valid age");
                                    goto label1;
                                }
                            label2: // 
                                Console.Write("Student ID: ");
                                try
                                {
                                    student[counter].stud_id = Convert.ToUInt32(Console.ReadLine());

                                }
                                catch (Exception ex4)
                                {
                                    Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                    goto label2;
                                }

                                Console.Write("College Name: ");

                                student[counter].college_name = Console.ReadLine();


                                Console.Write("City: ");

                                student[counter].city_name = Console.ReadLine();

                                Console.Write("Address: ");

                                student[counter].col_address = Console.ReadLine();

                                counter++;

                            }
                            else
                            {
                                Console.WriteLine("Sorry, the number of students are completed");

                            }


                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter with information of student:");

                            Console.Write("First Name: ");
                            st.st_data.first_name = Console.ReadLine();

                            Console.Write("Last Name: ");
                            st.st_data.last_name = Console.ReadLine();

                        label3:
                            Console.Write("Age: ");
                            try
                            {
                                st.st_data.per_age = Convert.ToSByte(Console.ReadLine());
                                if(st.st_data.per_age<18 || st.st_data.per_age > 65)
                                {
                                    Console.WriteLine("Enter with a valid age (between 18 and 65)");
                                    goto label3;
                                }
                            }
                            catch(Exception ex5)
                            {
                                Console.WriteLine(ex5.Message+"Enter with a valid age");
                            }

                        label4:
                            Console.Write("Student ID: ");
                            try
                            {
                                st.stud_id = Convert.ToUInt32(Console.ReadLine());

                            }
                            catch (Exception ex4)
                            {
                                Console.WriteLine(ex4.Message + "Enter with a valid ID");
                                goto label4;
                            }

                            Console.Write("College Name: ");

                            st.college_name = Console.ReadLine();


                            Console.Write("City: ");

                            st.city_name = Console.ReadLine();

                            Console.Write("Address: ");

                            st.col_address = Console.ReadLine();

                            counter++;

                            stdlist.Add(st);
                            
                            break;
                        }

                    case 3:
                        {
                            for (int i = 0; i < student.Length; i++)
                            {
                                if (student[i].st_data.first_name != null)
                                {
                                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\n");
                                    Console.WriteLine($"STUDENT {i + 1}: {student[i].st_data.first_name,-5} {student[i].st_data.last_name,-5}, {student[i].st_data.per_age,5} years old.\nStudent ID: {student[i].stud_id,5}, study at {student[i].college_name,-5}, City: {student[i].city_name,-5}, Address: {student[i].col_address,-5}");
                                }


                            }

                            break;

                        }
                    case 4:
                        {
                            foreach(Student i in stdlist)
                            {
                                Console.WriteLine($"{i.st_data.first_name,-5} {i.st_data.last_name,-5}, {i.st_data.per_age,5} years old.\nStudent ID: {i.stud_id,5}, study at {i.college_name,-5}, City: {i.city_name,-5}, Address: {i.col_address,-5}");
                            }
                            break;
                        }


                    case 5:
                        {
                            Console.WriteLine("bye bye");
                            break;
                        }
                }

            } while (opt != 5);

        }
    }
}

