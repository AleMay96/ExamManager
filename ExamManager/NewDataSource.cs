using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager
{
    class NewDataSource : DataSource
    {
        IEnumerable<Student> DataSource.AllStudents()
        {
            throw new NotImplementedException();
        }

        Student DataSource.Insert(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
