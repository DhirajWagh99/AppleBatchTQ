using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExpPro
{
     class Class1NonGeneric
    {
        static void Main(string[] args)
        {
            ArrayList a1=new ArrayList();
            a1.Add(1);
            a1.Add("Dhiraj");
            List<int> a2=new List<int>();
            a2.Add(2);
            a2.Add(3);
        }
    }
    //class Teacher:IComparable<Student>

    //{
    //    string sname;
    //    int percentage;

       

    //    public Teacher(string sname, int percentage)
    //    {
    //        this.Sname = sname;
    //        this.Percentage = percentage;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name={Sname} percentage={Percentage}";
    //    }

    //    public int CompareTo(Student s2)
    //    {
    //        return Sname.CompareTo(s2.sname);
    //    }
    //    public string Sname { get => sname; set => sname = value; }
    //    public int Percentage { get => percentage; set => percentage = value; }



    //}

}
