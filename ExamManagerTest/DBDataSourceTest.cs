using ExamManager;
using System;
using Xunit;

namespace ExamManagerTest
{
    public class DBDataSourceTest
    {
        public const string TEST_NAME = "TEST_NAME";
        public const string TEST_SURNAME = "TEST_SURNAME";
        public const int TEST_AGE = 1000;
        public const Sex TEST_SEX = Sex.c;
        public const int TEST_GRADE = 100;
        private Student testStudent;

        public DBDataSourceTest()
        {
            testStudent = new Student(0,TEST_NAME,TEST_SURNAME,TEST_AGE,TEST_SEX,TEST_GRADE);
        }

        [Fact]
        public void InsertTest()
        {
            DBDataSource ds = new DBDataSource();
            Student s = ds.Insert (testStudent);
            Assert.NotEqual(0, s.Id);
            Assert.True(Utilities.DelById(s.Id));
        }
    }
}
