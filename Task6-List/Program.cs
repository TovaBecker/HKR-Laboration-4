using System;
using System.Collections.Generic;

namespace Task6_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome user
            Console.WriteLine("Welcome to The System");

            //Declare and create a list
            List<Students> myStudentList = new List<Students>();

            //Create and and 7 students to list
            myStudentList.Add(new Students("Henrik Persson", new DateTime(2011, 12, 30), "C# Programming", 1));
            myStudentList.Add(new Students("Fia Dunge", new DateTime(2001, 11, 06), "C# Programming", 2));
            myStudentList.Add(new Students("Willy Andersson", new DateTime(2001, 01, 11), "C# Programming", 5));
            myStudentList.Add(new Students("Johan Johansson", new DateTime(2001, 08, 19), "C# Programming", 4));
            myStudentList.Add(new Students("Kicki Fiasson", new DateTime(2003, 10, 17), "Software development", 3));
            myStudentList.Add(new Students("Mimmi Milk", new DateTime(2002, 01, 15), "Software development", 4));
            myStudentList.Add(new Students("Guy Happy", new DateTime(2001, 06, 24), "Software development", 1));

            Program system = new Program();
            system.Menu(myStudentList);
        }

        public void Menu(List<Students> myStudentList)
        {
            //Declare and create a bool to hold if user want to exit
            bool exit = false;

            //Program menu and options
            while (exit == false)
            {
                Console.WriteLine("\nPress one of the following letters to perform that action:" +
                    "\n\tA - Add new student" +
                    "\n\tC - Check whether a student is on the list" +
                    "\n\tS - Search for all students enrolled in course" +
                    "\n\tD - Display a sorted list with all students in the program" +
                    "\n\tR - Remove a student from a list" +
                    "\n\tX - To exit the The System\n");
                var input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "A":
                        //Add student
                        addStudent(myStudentList);
                        break;
                    case "C":
                        //Check if student extist
                        checkStudent(myStudentList);
                        break;
                    case "S":
                        searchCourse(myStudentList);
                        break;
                    case "D":
                        sortStudents(myStudentList);
                        break;
                    case "R":
                        removeStudent(myStudentList);
                        break;
                    case "X":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input please try again!\n");
                        break;
                }
            }
        }

        public void addStudent(List<Students> myStudentList)
        {
            //Fields for creating new student in list 
            string name = "";
            DateTime birthDate = DateTime.MinValue;
            string course = "";
            int grade = 0;

            //Declare and create a bool to hold if user input is correct
            bool correct = false;

            //Get name from user
            Console.Write("\nPlease enter the new student name: ");
            name = Console.ReadLine();

            //Get Birth Date from user
            while (correct == false)
            {
                //Tell user what the program wants
                Console.Write("Please enter the new student birth date: ");

                //Check if input is correct
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    if (DateTime.Now.AddYears(-135) <= birthDate && birthDate <= DateTime.Now.AddYears(-15))
                    {
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine($"Student birth date need to be between {DateTime.Now.AddYears(-135).AddDays(1).ToString("d")} - {DateTime.Now.AddYears(-15).ToString("d")}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input please try again!\n");
                }
            }

            //Set correct to false for next
            correct = false;

            //Get course from user
            while (correct == false)
            {
                //Tell user what the program wants
                Console.WriteLine("Please enter the new student course: " +
                    "\n\tC - C# Programming" +
                    "\n\tS - Software development");

                //Check if input is correct
                var input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "C":
                        course = "C# Programming";
                        correct = true;
                        break;
                    case "S":
                        course = "Software development";
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input please try again!\n");
                        break;
                }
            }
            //Set correct to false for next
            correct = false;

            //Get grade from user
            while (correct == false)
            {
                //Tell user what the program wants
                Console.Write("Please enter the new student grade: ");

                //Check if input is correct
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    if (0 < grade && grade < 6)
                    {
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("A grade can only be a number 1-5!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input please try again!\nInput need to be a number 1-5 ");
                }
            }

            //Create and and student to list
            myStudentList.Add(new Students(name, birthDate, course, grade));
        }

        public void checkStudent(List<Students> myStudentList)
        {
            //Tell user what the program wants
            Console.Write("Please enter the students name you want to check if it is on the list: ");

            //Get input from user
            string studName = Console.ReadLine();

            //Declare and create a bool to hold if a student is found
            bool found = false;
            foreach (Students stud in myStudentList)
            {
                if (stud.Name.ToUpper().Contains(studName.ToUpper()))
                {
                    //Write student info
                    infoStudent(stud);

                    //Set found to true because student wqas found
                    found = true;
                }
            }

            //Check if a student was not found
            if (found == false)
            {
                Console.WriteLine($"No student was found.");
            }
        }

        public void searchCourse(List<Students> myStudentList)
        {
            //Declare and create a bool to hold if user input is correct
            bool correct = false;

            //Get course from user
            while (correct == false)
            {
                //Tell user what the program wants
                Console.WriteLine("Please enter the course you want a list from: " +
                    "\n\tC - C# Programming" +
                    "\n\tS - Software development" +
                    "\n\tX - for exit");

                //Get input from user
                var inputCourse = Console.ReadLine().ToUpper();

                //feild to hold count
                int count = 0;

                //Check if input is correct
                switch (inputCourse)
                {
                    case "C":
                        //Tell user what list it gets
                        Console.WriteLine("Course C# Programmings studets:");

                        //Go though list and write the names
                        foreach (Students stud in myStudentList)
                        {
                            if (stud.Course.Contains("C# Programming"))
                            {
                                //Write student info
                                infoStudent(stud);
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine($"No student was found in the course.");
                        }
                        correct = true;
                        break;
                    case "S":
                        //Tell user what list it gets
                        Console.WriteLine("Course Software developments studets:");

                        //Go though list and write the names
                        foreach (Students stud in myStudentList)
                        {
                            if (stud.Course.Contains("Software development"))
                            {
                                //Write student info
                                infoStudent(stud);

                                count++;
                            }
                        }
                        if(count == 0)
                        {
                            Console.WriteLine($"No student was found in the course.");
                        }
                        correct = true;
                        break;
                    case "X":
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input please try again!\n");
                        break;
                }
            }
        }

        public void sortStudents(List<Students> myStudentList)
        {
            //Count how many students was found
            int count = 0;

            //Sort the list
            myStudentList.Sort((x, y) => x.Name.CompareTo(y.Name));
            //Go though list and write the names
            foreach (Students stud in myStudentList)
            {
                //Write student info
                infoStudent(stud);
                count++;
            }

            if (0 < count)
            {
                //Write student info
                Console.Write($"Studenat in this program: {count}");
            }
            else
            {
                //Write error message
                Console.Write("No students are in this program.");
            }
        }

        public void removeStudent(List<Students> myStudentList)
        {
            //Get name from user
            Console.Write("Please enter the student you want to remove name: ");
            string name = Console.ReadLine();

            //Declare and create a bool to hold if a student is found
            bool found = false;

            //Declare and create a bool to exit menu
            bool exit = false;

            //Create a referens to contain remove object
            Students studentRemove = null;

            //Go thought list to find the students
            foreach (Students stud in myStudentList)
            {
                if (stud.Name.ToUpper().Contains(name.ToUpper()))
                {

                    //Set found to true because student was found
                    found = true;

                    while (exit == false)
                    {
                        //Write student info
                        infoStudent(stud);

                        //Ask user want to remove the student that was found
                        Console.WriteLine($"Do you want to remove {stud.Name}?" +
                        "\n\tY - for yes" +
                        "\n\tN - for no" +
                        "\n\tX - for exit");

                        //Check if input is correct
                        string input = Console.ReadLine().ToUpper();
                        if (input == "Y")
                        {
                            //Set student to be removed
                            studentRemove = stud;

                            //Set exit to true 
                            exit = true;

                            //Exit the foreach loop
                            break;
                        }
                        else if (input == "N")
                        {
                            //Exit the foreach loop
                            break;
                        }
                        else if (input == "X")
                        {
                            //Set exit to true 
                            exit = true;

                            //Exit the foreach loop
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input please try again!\n");
                        }
                    }
                }
            }
            //Rmove the selected student
            if (studentRemove != null)
            {
                Console.WriteLine($"{studentRemove.Name} has been removed.");
                //Remove student
                myStudentList.Remove(studentRemove);
            }

            //Check if a student was not found
            if (found == false)
            {
                Console.WriteLine($"No student was found.");
            }
        }

        public void infoStudent(Students student)
        {
            //Write information about student
            Console.WriteLine($"Name: {student.Name} \tBirth date: {student.BirthDate.ToString("d")} \tCourse: {student.Course} \tGrade: {student.Grade}");
        }
    }
}
