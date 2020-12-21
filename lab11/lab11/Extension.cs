using System;
using System.Collections.Generic;
namespace Lab_11.Entities
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> list, StudentPredicateDelegate spd)
        {
            List<Student> reqList = new List<Student>();
            foreach (Student st in list)
            {
                if (spd.Invoke(st))
                    reqList.Add(st);
            }
            return reqList;
        }

        public static void DisplayList(this List<Student> list)
        {
            Console.WriteLine("~~~ INFORMATION ~~~");

            foreach (Student st in list)
            {
                Console.WriteLine("First Name: {0}", st.FirstName);
                Console.WriteLine("Last Name: {0}", st.LastName);
                Console.WriteLine("Age: {0}", st.Age);
            }
        }
    }
}
