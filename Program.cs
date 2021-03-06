using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Projectbravo
{
    class Program
    {
        static List<string> employee = new List<string>() { "" };


        static void AddInfo()
        {
            string F_name, L_name;
            Console.WriteLine("Please enter the employee's first name");
            F_name = Console.ReadLine();
            Console.WriteLine("Please enter the employee's last name");
            L_name = Console.ReadLine();
            Console.WriteLine("The Employee: " + F_name + " " + L_name + "'s information has been successfully ADDED.");
            employee.Add(F_name + " " + L_name);



        }

        static void StoredInfo()
        {


            for (int i = 0; i < employee.Count; i++)
                if (employee.Count == 1)
                    Console.WriteLine("Sorry, no information available at the moment." +
                        "\nPlease, Add information first. ");
                else
                {
                    if (i == 0)
                        Console.WriteLine("The STORED Employee Information:");
                    else
                    { Console.WriteLine("Employee:" + i + " " + employee[i]); }
                }
        }

        static void InsertInfo()
        {
            for (int i = 0; i < employee.Count; i++)

                if (employee.Count == 1)
                    Console.WriteLine("Sorry, no information available at the moment." +
                        "\n*The information can only be inserted at location 1* ");
                else
                {
                    if (i == 0)
                        Console.WriteLine("The stored Employee Information at the moment:");
                    else
                    { Console.WriteLine("Employee:" + i + " " + employee[i]); }
                }

            Console.WriteLine("Please enter the location number " +
                "\nwhere you would like to INSERT the Employee's information. ");
            int Emp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee's first name");
            string F_name = Console.ReadLine();
            Console.WriteLine("Please enter the employee's last name");
            string L_name = Console.ReadLine();
            if (Emp > employee.Count)
                Console.WriteLine("Invalid location number, please try again");
            else
            {
                Console.WriteLine("The Employee's information has been successfully INSERTED: " + ("Employee:" + Emp + " " + F_name + " " + L_name));
                employee.Insert(Emp, F_name + " " + L_name);
                for (int i = 0; i < employee.Count; i++)

                    if (i == 0)
                        Console.WriteLine("The stored Employee Information now:");
                    else
                    { Console.WriteLine("Employee:" + i + " " + employee[i]); }
            }
        }

        static void DeleteInfo()
        {

            {
                for (int i = 0; i < employee.Count; i++)
                    if (employee.Count == 1)
                        Console.WriteLine("Sorry, no information available at the moment.");
                    else
                    {

                        if (i == 0)
                            Console.WriteLine("The stored Employee Information at the moment:");
                        else
                        { Console.WriteLine("Employee:" + i + " " + employee[i]); }
                    }
                int Emp;
                if (employee.Count == 1)
                    Console.WriteLine("");
                else
                {
                    Console.WriteLine("Please enter the Employee's number" +
                        "\nto DELETE their information");
                    Emp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Employee's information has been successfully DELETED");
                    employee.RemoveAt(Emp);


                    for (int i = 0; i < employee.Count; i++)

                        if (i == 0)
                            Console.WriteLine("The stored Employee Information now:");
                        else
                        { Console.WriteLine("Employee:" + i + " " + employee[i]); }
                }
            }
        }
        static void UpdateInfo()
        {
            for (int i = 0; i < employee.Count; i++)
                if (employee.Count == 1)
                    Console.WriteLine("Sorry, no information available at the moment." +
                        "\nPlease, Add information first.");
                else
                {
                    if (i == 0)
                        Console.WriteLine("The stored Employee Information at the moment:");
                    else
                    { Console.WriteLine("Employee:" + i + " " + employee[i]); }
                }

            int Emp;
            Console.WriteLine("Please enter the Employee's number" +
                     "\nto UPDATE their information");
            Emp = Convert.ToInt32(Console.ReadLine());
            employee.RemoveAt(Emp);
            Console.WriteLine("Enter the Employees First name");
            string F_name = Console.ReadLine();
            Console.WriteLine("Enter the Employees last name");
            string L_name = Console.ReadLine();
            Console.WriteLine("Enter email address of the employee");
            Console.WriteLine("The Employee's information has been successfully UPDATED");
            employee.Insert(Emp, F_name + " " + L_name);

            if (employee.Count == 1)
                Console.WriteLine("");
            else
            {
                for (int i = 0; i < employee.Count; i++)

                    if (i == 0)
                        Console.WriteLine("The UPDATED stored Employee Information:");
                    else
                    { Console.WriteLine("Employee:" + i + " " + employee[i]); }
            }

        }

        static void SearchInfo()
        {
            if (employee.Count == 1)
                Console.WriteLine("Sorry, no information available at the moment." +
                        "\nPlease, Add information first. ");
            else
            {
                Console.WriteLine("Please enter the Employee's details" +
                         "\nto SEARCH their information");
                Console.WriteLine("Enter the Employees First name");
                string F_name = Console.ReadLine();
                Console.WriteLine("Enter the Employees last name");
                string L_name = Console.ReadLine();



                if (employee.Contains(F_name + " " + L_name))
                {
                    Console.WriteLine("The Employee: " + F_name + " " + L_name + "'s information exist on location: " + employee.IndexOf(F_name + " " + L_name));
                }
                else
                {
                    Console.WriteLine("The Employee: " + F_name + " " + L_name + "'s information doest not exist in the record!!!! Please try another name");

                }
            }


        }
        static void Main(string[] args)
        {
            int no;
            do
            {
                Console.Clear();
                Console.WriteLine("==========EMPLOYEE INFORMATION==========");
                Console.WriteLine("Please enter '1' to ADD information," +
                    "\nPlease enter '2' to INSERT information at a specific location, " +
                    "\nPlease enter '3' to UPDATE the information," +
                    "\nPlease enter '4' to DELETE the information," +
                    "\nPlease enter '5' to SEARCH the information" +
                    "\nPlease enter '6' to access the STORED information" +
                    "\nPlease enter your choice:");
                string option = Console.ReadLine();
                char yes;


                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("You have selected the *ADD* information option");
                        int num;
                        do
                        {
                            Console.WriteLine("How many employee you want to register: ");
                            num = int.Parse(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("Information of Employee number: " + (i + 1));
                                AddInfo();
                            }
                            Console.WriteLine("Would you like to ADD more: Enter 'y' to continue" +
                                "\n or simply enter 'x' to cancel ");
                            yes = char.Parse(Console.ReadLine());
                        } while (yes == 'y');
                        break;
                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("You have selected the *INSERT* information option");
                            InsertInfo();
                            Console.WriteLine("Would you like to INSERT more: Enter 'y' to continue" +
                                   "\n or simply enter 'x' to cancel ");
                            yes = char.Parse(Console.ReadLine());
                        } while (yes == 'y');
                        break;
                    case "3":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("You have selected the *UPDATE* information option");
                            UpdateInfo();
                            Console.WriteLine("Would you like to UPDATE more: Enter 'y' to continue" +
                                       "\n or simply enter 'x' to cancel ");
                            yes = char.Parse(Console.ReadLine());
                        } while (yes == 'y');
                        break;
                    case "4":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("You have selected the *DELETE* information option");
                            DeleteInfo();
                            Console.WriteLine("Would you like to DELETE more: Enter 'y' to continue" +
                                   "\n or simply enter 'x' to cancel ");
                            yes = char.Parse(Console.ReadLine());
                        } while (yes == 'y');
                        break;
                    case "5":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("You have selected the *SEARCH* information option");
                            SearchInfo();
                            Console.WriteLine("Would you like to SEARCH more: Enter 'y' to continue" +
                                       "\n or simply enter 'x' to cancel ");
                            yes = char.Parse(Console.ReadLine());
                        } while (yes == 'y');
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("You have selected the *STORED* information access option");
                        StoredInfo();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You must choose between (1 to 6)!!!");
                        break;

                }
                Console.WriteLine("Please enter '0' to open the Main Menu");
                no = int.Parse(Console.ReadLine());
            } while (no == 0);
            Console.ReadKey();
        }
    }
}
