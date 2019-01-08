using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ExamManagerTest
{
    static class Utilities
    {
        public const string CHECK_IF_STUDENT_EXIST_QUERY =
            @"select id from studente
               where id = @Id";

        public const string DELETE_STUDENT_BY_ID_COMMAND =
            @"delete from studente
               where id = @Id";

        public const string connString =
                @"Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=scuola;Integrated Security=True;";


        public static bool FindById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(CHECK_IF_STUDENT_EXIST_QUERY, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = command.ExecuteReader();

                    return reader.Read();
                }
            }
        }

        public static bool DelById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(DELETE_STUDENT_BY_ID_COMMAND, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    return command.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
