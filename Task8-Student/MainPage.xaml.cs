using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Task8_Student
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Field to hold list
        List<Students> myStudentList = new List<Students>();
        List<Students> foundRemoveStudentList = new List<Students>();
        int foundRemoveStudentIndex = 0;

        //Create a referens to contain remove object
        Students studentRemove = null;

        public MainPage()
        {
            this.InitializeComponent();

            //Declare and create a list

            //Create and and 7 students to list
            myStudentList.Add(new Students("Henrik Persson", new DateTime(2011, 12, 30), "C# Programming", 1));
            myStudentList.Add(new Students("Fia Dunge", new DateTime(2001, 11, 06), "C# Programming", 2));
            myStudentList.Add(new Students("Willy Andersson", new DateTime(2001, 01, 11), "C# Programming", 5));
            myStudentList.Add(new Students("Johan Johansson", new DateTime(2001, 08, 19), "C# Programming", 4));
            myStudentList.Add(new Students("Kicki Fiasson", new DateTime(2003, 10, 17), "Software development", 3));
            myStudentList.Add(new Students("Mimmi Milk", new DateTime(2002, 01, 15), "Software development", 4));
            myStudentList.Add(new Students("Guy Happy", new DateTime(2001, 06, 24), "Software development", 1));

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Menu
            btnAdd.Visibility = Visibility.Collapsed;
            btnRemove.Visibility = Visibility.Visible;
            btnSearch.Visibility = Visibility.Visible;
            btnCheck.Visibility = Visibility.Visible;
            btnDisplay.Visibility = Visibility.Visible;

            //Add, Remove, Check
            nameLabel.Visibility = Visibility.Visible;
            textName.Visibility = Visibility.Visible;
            textName.Text = "";
            //Add
            birthLabel.Visibility = Visibility.Visible;
            datePicker.Visibility = Visibility.Visible;
            //datePicker.SelectedDate.Value.Date = DateTime.Now.AddYears(-15);
            datePicker.MaxYear = DateTime.Now.AddYears(-15);
            datePicker.MinYear = DateTime.Now.AddYears(-135);
            corseLabel.Visibility = Visibility.Visible;
            rbtnC_Programming_Add.Visibility = Visibility.Visible;
            rbtnC_Programming_Add.IsChecked = false;
            rbtnSoftwareDevelopments_Add.Visibility = Visibility.Visible;
            rbtnSoftwareDevelopments_Add.IsChecked = false;
            gradeLabel.Visibility = Visibility.Visible;
            textGrade.Visibility = Visibility.Visible;
            textGrade.Text = "";
            btnAddStudent.Visibility = Visibility.Visible;
            messageAdd.Visibility = Visibility.Collapsed;
            messageAdd.Text = "";
            //Search
            rbtnC_Programming_Search.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Search.IsChecked = false;
            rbtnSoftwareDevelopments_Search.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Search.IsChecked = false;
            searchResualt.Visibility = Visibility.Collapsed;
            searchResualt.Text = "";
            //Check
            btnCheckStudent.Visibility = Visibility.Collapsed;
            //Remove
            btnFindStudent.Visibility = Visibility.Collapsed;
            btnRemoveStudent.Visibility = Visibility.Collapsed;
            btnRemoveNextStudent.Visibility = Visibility.Collapsed;
            messageRemove.Visibility = Visibility.Collapsed;
            messageRemove.Text = "";
            //Remove, Check
            foundRemoveCheckStudentResult.Visibility = Visibility.Collapsed;
            foundRemoveCheckStudentResult.Text = "";
            //Display
            DisplayResualt.Visibility = Visibility.Collapsed;
            DisplayResualt.Text = "";

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Menu
            btnAdd.Visibility = Visibility.Visible;
            btnRemove.Visibility = Visibility.Collapsed;
            btnSearch.Visibility = Visibility.Visible;
            btnCheck.Visibility = Visibility.Visible;
            btnDisplay.Visibility = Visibility.Visible;

            //Add, Remove, Check
            nameLabel.Visibility = Visibility.Visible;
            textName.Visibility = Visibility.Visible;
            textName.Text = "";
            //Add
            birthLabel.Visibility = Visibility.Collapsed;
            datePicker.Visibility = Visibility.Collapsed;
            //datePicker;
            corseLabel.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.IsChecked = false;
            rbtnSoftwareDevelopments_Add.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Add.IsChecked = false;
            gradeLabel.Visibility = Visibility.Collapsed;
            textGrade.Visibility = Visibility.Collapsed;
            textGrade.Text = "";
            btnAddStudent.Visibility = Visibility.Collapsed;
            messageAdd.Visibility = Visibility.Collapsed;
            messageAdd.Text = "";
            //Search
            rbtnC_Programming_Search.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Search.IsChecked = false;
            rbtnSoftwareDevelopments_Search.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Search.IsChecked = false;
            searchResualt.Visibility = Visibility.Collapsed;
            searchResualt.Text = "";
            //Check
            btnCheckStudent.Visibility = Visibility.Collapsed;
            //Remove
            btnFindStudent.Visibility = Visibility.Visible;
            btnRemoveStudent.Visibility = Visibility.Visible;
            btnRemoveNextStudent.Visibility = Visibility.Visible;
            messageRemove.Visibility = Visibility.Visible;
            messageRemove.Text = "";
            //Remove, Check
            foundRemoveCheckStudentResult.Visibility = Visibility.Collapsed;
            foundRemoveCheckStudentResult.Text = "";
            //Display
            DisplayResualt.Visibility = Visibility.Collapsed;
            DisplayResualt.Text = "";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Menu
            btnAdd.Visibility = Visibility.Visible;
            btnRemove.Visibility = Visibility.Visible;
            btnSearch.Visibility = Visibility.Collapsed;
            btnCheck.Visibility = Visibility.Visible;
            btnDisplay.Visibility = Visibility.Visible;

            //Add, Remove, Check
            nameLabel.Visibility = Visibility.Collapsed;
            textName.Visibility = Visibility.Collapsed;
            textName.Text = "";
            //Add
            birthLabel.Visibility = Visibility.Collapsed;
            datePicker.Visibility = Visibility.Collapsed;
            //datePicker;
            corseLabel.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.IsChecked = false;
            rbtnSoftwareDevelopments_Add.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Add.IsChecked = false;
            gradeLabel.Visibility = Visibility.Collapsed;
            textGrade.Visibility = Visibility.Collapsed;
            textGrade.Text = "";
            btnAddStudent.Visibility = Visibility.Collapsed;
            messageAdd.Visibility = Visibility.Collapsed;
            messageAdd.Text = "";
            //Search
            rbtnC_Programming_Search.Visibility = Visibility.Visible;
            rbtnC_Programming_Search.IsChecked = false;
            rbtnSoftwareDevelopments_Search.Visibility = Visibility.Visible;
            rbtnSoftwareDevelopments_Search.IsChecked = false;
            searchResualt.Visibility = Visibility.Visible;
            searchResualt.Text = "";
            //Check
            btnCheckStudent.Visibility = Visibility.Collapsed;
            //Remove
            btnFindStudent.Visibility = Visibility.Collapsed;
            btnRemoveStudent.Visibility = Visibility.Collapsed;
            btnRemoveNextStudent.Visibility = Visibility.Collapsed;
            messageRemove.Visibility = Visibility.Collapsed;
            messageRemove.Text = "";
            //Remove, Check
            foundRemoveCheckStudentResult.Visibility = Visibility.Collapsed;
            foundRemoveCheckStudentResult.Text = "";
            //Display
            DisplayResualt.Visibility = Visibility.Collapsed;
            DisplayResualt.Text = "";
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            //Menu
            btnAdd.Visibility = Visibility.Visible;
            btnRemove.Visibility = Visibility.Visible;
            btnSearch.Visibility = Visibility.Visible;
            btnCheck.Visibility = Visibility.Collapsed;
            btnDisplay.Visibility = Visibility.Visible;

            //Add, Remove, Check
            nameLabel.Visibility = Visibility.Visible;
            textName.Visibility = Visibility.Visible;
            textName.Text = "";
            //Add
            birthLabel.Visibility = Visibility.Collapsed;
            datePicker.Visibility = Visibility.Collapsed;
            //datePicker;
            corseLabel.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.IsChecked = false;
            rbtnSoftwareDevelopments_Add.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Add.IsChecked = false;
            gradeLabel.Visibility = Visibility.Collapsed;
            textGrade.Visibility = Visibility.Collapsed;
            textGrade.Text = "";
            btnAddStudent.Visibility = Visibility.Collapsed;
            messageAdd.Visibility = Visibility.Collapsed;
            messageAdd.Text = "";
            //Search
            rbtnC_Programming_Search.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Search.IsChecked = false;
            rbtnSoftwareDevelopments_Search.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Search.IsChecked = false;
            searchResualt.Visibility = Visibility.Collapsed;
            searchResualt.Text = "";
            //Check
            btnCheckStudent.Visibility = Visibility.Visible;
            //Remove
            btnFindStudent.Visibility = Visibility.Collapsed;
            btnRemoveStudent.Visibility = Visibility.Collapsed;
            btnRemoveNextStudent.Visibility = Visibility.Collapsed;
            messageRemove.Visibility = Visibility.Collapsed;
            messageRemove.Text = "";
            //Remove, Check
            foundRemoveCheckStudentResult.Visibility = Visibility.Collapsed;
            foundRemoveCheckStudentResult.Text = "";
            //Display
            DisplayResualt.Visibility = Visibility.Collapsed;
            DisplayResualt.Text = "";

        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            //Menu
            btnAdd.Visibility = Visibility.Visible;
            btnRemove.Visibility = Visibility.Visible;
            btnSearch.Visibility = Visibility.Visible;
            btnCheck.Visibility = Visibility.Visible;
            btnDisplay.Visibility = Visibility.Collapsed;

            //Add, Remove, Check
            nameLabel.Visibility = Visibility.Collapsed;
            textName.Visibility = Visibility.Collapsed;
            textName.Text = "";
            //Add
            birthLabel.Visibility = Visibility.Collapsed;
            datePicker.Visibility = Visibility.Collapsed;
            //datePicker;
            corseLabel.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Add.IsChecked = false;
            rbtnSoftwareDevelopments_Add.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Add.IsChecked = false;
            gradeLabel.Visibility = Visibility.Collapsed;
            textGrade.Visibility = Visibility.Collapsed;
            textGrade.Text = "";
            btnAddStudent.Visibility = Visibility.Collapsed;
            messageAdd.Visibility = Visibility.Collapsed;
            messageAdd.Text = "";
            //Search
            rbtnC_Programming_Search.Visibility = Visibility.Collapsed;
            rbtnC_Programming_Search.IsChecked = false;
            rbtnSoftwareDevelopments_Search.Visibility = Visibility.Collapsed;
            rbtnSoftwareDevelopments_Search.IsChecked = false;
            searchResualt.Visibility = Visibility.Collapsed;
            searchResualt.Text = "";
            //Check
            btnCheckStudent.Visibility = Visibility.Collapsed;
            //Remove
            btnFindStudent.Visibility = Visibility.Collapsed;
            btnRemoveStudent.Visibility = Visibility.Collapsed;
            btnRemoveNextStudent.Visibility = Visibility.Collapsed;
            messageRemove.Visibility = Visibility.Collapsed;
            messageRemove.Text = "";
            //Remove, Check
            foundRemoveCheckStudentResult.Visibility = Visibility.Collapsed;
            foundRemoveCheckStudentResult.Text = "";
            //Display
            DisplayResualt.Visibility = Visibility.Visible;
            DisplayResualt.Text = "";


            //Count how many students was found
            int count = 0;

            //Sort the list
            myStudentList.Sort((x, y) => x.Name.CompareTo(y.Name));

            //Go though list and write the names
            foreach (Students stud in myStudentList)
            {
                //Write student info
                DisplayResualt.Text += infoStudent(stud);

                count++;
            }

            if (0 < count)
            {
                //Write student info
                DisplayResualt.Text += $"Students in this program: {count}";
            }
            else
            {
                //Write error message
                DisplayResualt.Text += "No students are in this program.";
            }
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //Clear message
            messageAdd.Text = "";

            //Fields for creating new student in list 
            string name = "";
            DateTime birthDate = DateTime.MinValue;
            string course = "";
            int grade = 0;

            //Declare and create a int to hold if user input is correct
            int correct = 0;

            if (textName.Text != "")
            {
                //Get and set name from user
                name = textName.Text;

                correct++;
            }
            else
            {
                messageAdd.Visibility = Visibility.Visible;
                messageAdd.Text += "Please enter a name.\n";
            }

            //Check if input is correct
            if (datePicker.SelectedDate.HasValue)
            {
                birthDate = datePicker.SelectedDate.Value.Date;
                correct++;
            }
            else
            {
                messageAdd.Visibility = Visibility.Visible;
                messageAdd.Text += "Please enter a date.\n";
            }

            if (rbtnC_Programming_Add.IsChecked == true)
            {
                course = "C# Programming";
                correct++;
            }
            else if (rbtnSoftwareDevelopments_Add.IsChecked == true)
            {
                course = "Software development";
                correct++;
            }
            else
            {
                messageAdd.Visibility = Visibility.Visible;
                messageAdd.Text += "Please select a course.\n";
            }

            //Check if input is correct
            if (int.TryParse(textGrade.Text, out grade))
            {
                if (0 < grade && grade < 6)
                {
                    correct++;
                }
                else
                {
                    messageAdd.Visibility = Visibility.Visible;
                    messageAdd.Text += "Please enter a grade between number 1-5.";
                }
            }
            else
            {
                messageAdd.Visibility = Visibility.Visible;
                messageAdd.Text += "Please enter a grade between number 1-5.";
            }
            if (correct == 4)
            {
                //Create and and student to list
                myStudentList.Add(new Students(name, birthDate, course, grade));

                //Show message
                messageAdd.Visibility = Visibility.Visible;
                messageAdd.Text = $"{name} had been added.";

                //Clear input
                textName.Text = "";
                datePicker.SelectedDate = null; 
                rbtnC_Programming_Add.IsChecked = false;
                rbtnSoftwareDevelopments_Add.IsChecked = false;
                textGrade.Text = "";
            }
        }

        private void btnCheckStudent_Click(object sender, RoutedEventArgs e)
        {
            //Clear textbox
            foundRemoveCheckStudentResult.Text = "";

            //Declare and create a int to hold number of studenst found
            int found = 0;
            foreach (Students stud in myStudentList)
            {
                if (stud.Name.ToUpper().Contains(textName.Text.ToUpper()))
                {
                    //Write student info
                    foundRemoveCheckStudentResult.Visibility = Visibility.Visible;
                    foundRemoveCheckStudentResult.Text += infoStudent(stud);

                    //Set found to true because student wqas found
                    found ++;
                }
            }

            //Check if a student was not found
            if (found == 0)
            {
                foundRemoveCheckStudentResult.Visibility = Visibility.Visible;
                foundRemoveCheckStudentResult.Text = $"No student was found.";
            }
            else
            {
                foundRemoveCheckStudentResult.Text += $"Students found: {found}";
            }
        }

        private void btnFindStudent_Click(object sender, RoutedEventArgs e)
        {
            //Put students in list
            foundRemoveStudentList = myStudentList.Where(s => s.Name.ToUpper().Contains(textName.Text.ToUpper())).ToList();
            foundRemoveStudentIndex = 0;

            if (foundRemoveStudentList.Count > 0)
            {
                if(foundRemoveStudentList.Count == 1)
                {
                    btnRemoveNextStudent.Visibility = Visibility.Collapsed;
                }
                else
                {
                    btnRemoveNextStudent.Visibility = Visibility.Visible;
                }
                //Write student info
                foundRemoveCheckStudentResult.Visibility = Visibility.Visible;
                foundRemoveCheckStudentResult.Text = infoStudent(foundRemoveStudentList[foundRemoveStudentIndex]);
            }
            else
            {
                messageRemove.Visibility = Visibility.Visible;
                messageRemove.Text = $"No student was found.";
            }
        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            var studentRemove = foundRemoveStudentList[foundRemoveStudentIndex];

            //Rmove the selected student
            if (studentRemove != null)
            {
                //Message that student was removed
                messageRemove.Text = $"{studentRemove.Name} has been removed.";

                //Remove student
                myStudentList.Remove(studentRemove);
            }

            foundRemoveStudentList = new List<Students>();
            foundRemoveStudentIndex = 0;

            foundRemoveCheckStudentResult.Visibility = Visibility.Collapsed;
            btnRemoveNextStudent.Visibility = Visibility.Collapsed;

        }

        private void rbtnSoftwareDevelopments_Search_Checked(object sender, RoutedEventArgs e)
        {
            //Clear list
            searchResualt.Text = "";

            //Count how many students was found
            int count = 0;

            //Go though list and write the names
            foreach (Students stud in myStudentList)
            {
                if (stud.Course.Contains("C# Programming"))
                {
                    //Write student info
                    searchResualt.Visibility = Visibility.Visible;
                    searchResualt.Text += infoStudent(stud);

                    count++;
                }
            }
            if (0 < count)
            {
                //Write student info
                searchResualt.Visibility = Visibility.Visible;
                searchResualt.Text += $"Students in this course: {count}";
            }
            else
            {
                //Write error message
                searchResualt.Visibility = Visibility.Visible;
                searchResualt.Text = "No students are in this course.";
            }
        }

        private void rbtnC_Programming_Search_Checked(object sender, RoutedEventArgs e)
        {
            //Clear list
            searchResualt.Text = "";

            //Count how many students was found
            int count = 0;

            //Go though list and write the names
            foreach (Students stud in myStudentList)
            {
                if (stud.Course.Contains("Software development"))
                {
                    //Write student info
                    searchResualt.Visibility = Visibility.Visible;
                    searchResualt.Text += infoStudent(stud);
                    count++;
                }
            }
            if (0 < count)
            {
                //Write student info
                searchResualt.Visibility = Visibility.Visible;
                searchResualt.Text += $"Students in this course: {count}";
            }
            else
            {
                //Write error message
                searchResualt.Visibility = Visibility.Visible;
                searchResualt.Text = "No students are in this course.";
            }
        }
        private string infoStudent(Students student)
        {
            //Write information about student
            string text = $"Name: {student.Name} \tBirth date: {student.BirthDate.ToString("d")} \tCourse: {student.Course} \tGrade: {student.Grade}\n";
            return text;
        }

        private void btnRemoveNextStudent_Click(object sender, RoutedEventArgs e)
        {
            foundRemoveStudentIndex++;

            if(foundRemoveStudentList.Count <= foundRemoveStudentIndex)
            {
                foundRemoveStudentIndex = 0;
            }

            if(foundRemoveStudentList.Count > 0)
            {
                //Write student info
                foundRemoveCheckStudentResult.Visibility = Visibility.Visible;
                foundRemoveCheckStudentResult.Text = infoStudent(foundRemoveStudentList[foundRemoveStudentIndex]);
            }
            
        }
    }
}
