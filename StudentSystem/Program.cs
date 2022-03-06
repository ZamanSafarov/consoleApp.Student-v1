using StudentSystem.Infrastructure;
using StudentSystem.Managers;
using System;
using System.Text;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Student System v.1";


            


            var groupMgr = new GroupManager();
            var studentMgr = new StudentManager();
        readMenu:
            PrintMenu();
            Menu m = ScannerManager.ReadMenu("menudan secin: ");
            switch (m)
            {
                case Menu.GroupAdd:
                    Console.Clear();
                    Group g = new Group();
                    g.Name = ScannerManager.ReadString("Qrupun adin daxil edin: ");
                    g.Speciality = ScannerManager.ReadString("Qrupun ixtisasini daxil eidn: ");

                    groupMgr.Add(g);
                    goto case Menu.GroupAll;
                    break;
                case Menu.GroupEdit:
                    break;
                case Menu.GroupRemove:
                    break;
                case Menu.GroupSingle:
                    break;
                case Menu.GroupAll:
                    Console.Clear();
                    ShowAllGroups(groupMgr);
                    goto readMenu;
                    break;
                case Menu.StudentAdd:
                    Console.Clear();
                    Student s = new Student();
                    s.Name = ScannerManager.ReadString("Telebenin adi: ");
                    s.Surname = ScannerManager.ReadString("Telebenin soyadi: ");
                    s.BirthDate = ScannerManager.ReadDate("Telebenin dogum tarixi: ");
                    Console.WriteLine("---------------");
                    ShowAllGroups(groupMgr);
                    Console.WriteLine("---------------");
                    s.GroupId = ScannerManager.ReadInteger("Telebenin Grupu: ");

                    studentMgr.Add(s);
                    goto case Menu.StudentsAll;
                    break;
                case Menu.StudentEdit:
                    break;
                case Menu.StudentRemove:
                    break;
                case Menu.StudentSingle:
                    break;
                case Menu.StudentsAll:
                    Console.Clear();
                    ShowAllStudents(studentMgr);
                    goto readMenu;
                    break;
                case Menu.All:
                    Console.Clear();
                    ShowAllGroups(groupMgr);
                    ShowAllStudents(studentMgr);
                    break;
                case Menu.Exit:
                    goto lEnd;
                    break;
                default:
                    break;
            }



            lEnd:
            Console.WriteLine("End......");
            Console.WriteLine("cixmaq ucun her hansi bir duymeni sixin");
            Console.ReadKey();
        }
        static void PrintMenu()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));
            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Menu m = (Menu)Enum.Parse(typeof(Menu), item);
                Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
            }
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
        static void ShowAllGroups(GroupManager groupMgr)
        {
            Console.WriteLine("##################Groups#################");
            foreach (var item in groupMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }
        static void ShowAllStudents(StudentManager studentMgr)
        {
            Console.WriteLine("##################Students#################");
            foreach (var item in studentMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
