using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public interface IBatch
    {
		string GetAllStudentsInfo();
		string GetStudentById(int id);
		bool RemoveStudentById(int id);
		bool UpdateStudentById(int id, string fullName, string major,
			int age, string className, double mark);
		void AddStudent(int id, string fullName, string major,
			int age, string className, double mark);
		string GetStatistics();
	}
}
