using System;
using program;
namespace student
{
	public partial class Student
	{
        private string name;
        private string surname;
		private string fathername;
		private dateTime.DateTime bornDate;
		private adress.Adress adress;
		private string phoneNum;
		private int[] HW;
        private int[] finalWorks;
        private int[] exams;

        public Student()
		{
			name = "";
			surname = "";
			fathername = "";
			bornDate = new dateTime.DateTime();
			adress = new adress.Adress();
            phoneNum = "";
		}

        public Student(string n, string sn, string fn, dateTime.DateTime dt, adress.Adress ad, string num, int[] hw, int[] fw, int[] e)
        {
            name = n;
            surname = sn;
            fathername = fn;
            bornDate = dt;
            adress = ad;
            phoneNum = num;
            HW = hw;
            finalWorks = fw;
            exams = e;
        }

        public Student(Student s)
        {
            name = s.GetName();
            surname = s.GetSurname();
            fathername = s.GetFathername();
            bornDate = s.GetBornDate();
            adress = s.GetAdress();
            phoneNum = s.GetPhoneNum();
            HW = s.GetHWGrades();
            finalWorks = s.GetFWGrades();
            exams = s.GetExamGrades();
        }

        public void Print()
        {
            Console.WriteLine(this.GetName() + " " + this.GetFathername() + " " + this.GetSurname());
            Console.WriteLine(this.GetBornDate());
            Console.WriteLine(this.GetAdress();
            Console.WriteLine(this.GetPhoneNum());
            Console.WriteLine(this.GetHWGrades());
            Console.WriteLine(this.GetFWGrades());
            Console.WriteLine(this.GetExamGrades());
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetFathername()
        {
            return fathername;
        }
        public dateTime.DateTime GetBornDate()
        {
            return bornDate;
        }
        public adress.Adress GetAdress()
        {
            return adress;
        }
        public string GetPhoneNum()
        {
            return phoneNum;
        }
        public int[] GetHWGrades()
        {
            return HW;
        }
        public int[] GetFWGrades()
        {
            return finalWorks;
        }
        public int[] GetExamGrades()
        {
            return exams;
        }

        public void SetName(string n)
        {
            name = n;
        }
        public void SetSurname(string sn)
        {
            surname = sn;
        }
        public void SetFathername(string fn)
        {
            fathername = fn;
        }
        public void SetBornDate(dateTime.DateTime dt)
        {
            bornDate = dt;
        }
        public void SetAdress(adress.Adress ad)
        {
            adress = ad;
        }
        public void SetPhoneNum(string num)
        {
            phoneNum = num;
        }
    }
}

namespace adress
{
	public partial class Adress
	{
		private string city;
        private string street;
        private int houseNum;

		public Adress()
		{
			city = "";
			street = "";
			houseNum = 0;
		}
	}
}

namespace dateTime
{
    public partial class DateTime
    {
        private int day;
        private int month;
        private int year;

        public DateTime()
        {
            day = 1;
            month = 1;
            year = 0;
        }
    }
}