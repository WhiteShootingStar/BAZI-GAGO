using Cwiczenia6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cwiczenia6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Emp> Emps { get; set; }
        public List<Dept> Depts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            Example();
        }

        public void LoadData()
        {
            Emps = new List<Emp>();
            Depts = new List<Dept>();

            Emps.Add(new Emp
            {
                Empno = 7369,
                Ename = "SMITH",
                Job = "CLERK",
                Mgr = 7902,
                HireDate = new DateTime(1980, 12, 17),
                Sal=800,
                Comm=0,
                Deptno=20
            });

            Emps.Add(new Emp
            {
                Empno = 7499,
                Ename = "ALLEN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 20),
                Sal = 1600,
                Comm = 300,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7521,
                Ename = "WARD",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 22),
                Sal = 1250,
                Comm = 500,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7566,
                Ename = "JONES",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 4, 2),
                Sal = 2975,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7654,
                Ename = "MARTIN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 28),
                Sal = 1250,
                Comm = 1400,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7698,
                Ename = "BLAKE",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 5, 1),
                Sal = 2850,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7782,
                Ename = "CLARK",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 6, 9),
                Sal = 2450,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7788,
                Ename = "SCOTT",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate = new DateTime(1982, 12, 9),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7839,
                Ename = "KING",
                Job = "PRESIDENT",
                Mgr = null,
                HireDate = new DateTime(1981, 11, 17),
                Sal = 5000,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7844,
                Ename = "TURNER",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 8),
                Sal = 1500,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7876,
                Ename = "ADAMS",
                Job = "CLERK",
                Mgr = 7788,
                HireDate = new DateTime(1983, 1, 12),
                Sal = 1100,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7900,
                Ename = "JAMES",
                Job = "CLERK",
                Mgr = 7698,
                HireDate = new DateTime(1981, 12, 3),
                Sal = 950,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7902,
                Ename = "FORD",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate= new DateTime(1981, 12, 3),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7934,
                Ename = "MILLER",
                Job = "CLERK",
                Mgr = 7782,
                HireDate = new DateTime(1982, 1, 23),
                Sal = 1300,
                Comm = 0,
                Deptno = 10
            });

            Depts.Add(new Dept
            {
                Deptno=10,
                Dname= "ACCOUNTING",
                Loc= "NEW YORK"
            });

            Depts.Add(new Dept
            {
                Deptno = 20,
                Dname = "RESEARCH",
                Loc = "DALLAS"
            });

            Depts.Add(new Dept
            {
                Deptno = 30,
                Dname = "SALES",
                Loc = "CHICAGO"
            });

            Depts.Add(new Dept
            {
                Deptno = 40,
                Dname = "OPERATIONS",
                Loc = "BOSTON"
            });
        }

        private void Example()
        {
            //Query syntax
            var result = from e in Emps
                         where e.Ename.StartsWith("K")
                         select e;

            //Lambda and Extension methods syntax
            var result2 = Emps.Where(e => e.Ename.StartsWith("K"));


            DataGrid.ItemsSource = result.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.OrderBy(a => a.Ename).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           var res = Emps.OrderBy(a => a.Deptno).OrderByDescending(a => a.Sal).ToList();
            DataGrid.ItemsSource = from a in res select new { name =a.Ename, no =a.Empno, dept =a.Deptno, comm = a.Comm, boss =a.Mgr ,job= a.Job, hird =a.HireDate };
                
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from a in Emps where a.Job.Equals("CLERK") select new { name =a.Ename, no = a.Empno, job =a.Job, dept = a.Deptno};
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a => a.Ename.StartsWith("S")).ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a => a.Mgr == null).ToList();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a => a.Sal < 1000 || a.Sal > 2000).ToList();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from a in Emps select new {temp =a.Ename + " Works in depatment " +a.Deptno };
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a => a.Job.Equals("CLERK") && a.Sal > 1000 && a.Sal < 2000).ToList();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a => a.Job.Equals("CLERK") || (a.Sal > 1000 && a.Sal < 2000)).ToList();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a => (a.Job.Equals("MANAGER") && a.Sal > 1000) || a.Job.Equals("SALESMAN")).ToList();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from a in Emps join dept in Depts on a.Deptno equals dept.Deptno select  new {first =a.Sal,a.Mgr,a.Job,a.HireDate,a.Comm,a.Deptno,a.Empno,a.Ename, second =dept.Deptno, dept.Dname, dept.Loc };
            
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var res = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) =>  new { first = emp.Sal, emp.Mgr, emp.Job, emp.HireDate, emp.Comm, emp.Deptno, emp.Empno, emp.Ename, second = dept.Deptno, dept.Dname, dept.Loc }).OrderBy(dept=>dept.Dname);
            DataGrid.ItemsSource = res;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(emp=>emp.Sal>1500).Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new { name = emp.Ename, loc = dept.Loc, no = dept.Deptno });
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from emp in Emps join depts in Depts on emp.Deptno equals depts.Deptno where depts.Loc.Equals("DALLAS") select emp;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from emp in Emps group emp by new {kek= Emps.Average(a=>a.Sal)}into g  select new { Salary = g.Average(a=>a.Sal) };
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from emp in Emps where emp.Job.Equals("CLERK") group emp by emp.Job into g select new { Salary = g.Min(a => a.Sal) };
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = from emp in Emps group emp by new { kek = Emps.Count(a => a.Deptno == 20) } into g select new { Amount = g.Count(a=>a.Deptno==20)};
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(a=>!a.Job.Equals("MANAGER")).GroupBy(a => a.Job).Select(a => new { AVERAGE = a.Average(p => p.Sal), Job=a.Key.ToString() });
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(emp => emp.Sal == Emps.Min(a => a.Sal));
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(emp => emp.Job.Equals(Emps.Where(a => a.Ename.Equals("BLAKE")).Select(a=>a.Job).First()));
            Console.WriteLine(Emps.Where(a => a.Ename.Equals("BLAKE")).Select(a => a.Job).First());
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        { var sals = from emp in Emps group emp by emp.Deptno into g select new { Value = g.Min(sal=>sal.Sal) };
           
            DataGrid.ItemsSource = sals;
            var result = Emps.Where(emp => sals.Any(a=>a.Value==emp.Sal));
            DataGrid.ItemsSource = result;
           
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Emps.Where(emp => emp.Sal == Emps.Where(a => a.Deptno == emp.Deptno).Select(a => a.Sal).First());
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            if (Emps.Any(emp => emp.Sal == Emps.Where(a => a.Deptno == 30).Select(a => a.Sal).First())) {
                DataGrid.ItemsSource = Emps.Where(emp=>emp.Sal == Emps.Where(a => a.Deptno == 30).Select(a => a.Sal).First());
            }
        }
    }
}
