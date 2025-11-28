using A11_06102025_NodeInt.CirclePoint;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class ProgramQueue
    {

        static void Main(string[] args)
        {
            int[] a = { 7, -1, 6, 14, 51, 8, 9, -8, 88 };
            Queue<int> q = ArrayToQueue(a);
            Console.WriteLine(q);
            int x = Size(q);
        }

        // عملية خارجية باسم Copy التي تتلقى دور وتعيد نسخة مطابقة له
        public static Queue<T> Copy<T>(Queue<T> q1)
        {
            Queue<T> q2 = new Queue<T>();
            Queue<T> temp = new Queue<T>();
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Head());
                temp.Insert(q1.Remove());
            }

            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
            return q2;
        }



        //عملية خارجية باسم Size التي تتلقى دور وتعيد طوله
        public static int Size<T>(Queue<T> q1)
        {
            int count = 0;
            Queue<T> temp = new Queue<T>();
            while (!q1.IsEmpty())
            {
                count++;
                temp.Insert(q1.Remove());
            }

            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
            return count;
        }




        // عملية خارجية باسم Copy التي تتلقى دور وتعيد نسخة مطابقة له
        public static Queue<int> CopyIntQueue(Queue<int> q1)
        {
            Queue<int> q2 = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Head());
                temp.Insert(q1.Remove());
            }

            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
            return q2;
        }




        //عملية خارجية باسم Size التي تتلقى دور اعداد صحيحة وتعيد طوله
        public static int SizeIntQueue(Queue<int> q1)
        {
            int count = 0;
            Queue<int> temp = new Queue<int>();
            while (!q1.IsEmpty())
            {
                count++;
                temp.Insert(q1.Remove());
            }

            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
            return count;
        }




        // عملية خارجية باسم GetLastValueالتي تتلقى دور نصوص وتعيد اخر قيمة في الدور

        public static string GetLastValue(Queue<string> q1)
        {
            string last = null;
            Queue<string> temp = Copy(q1);
            while (!temp.IsEmpty())
            {
                last = temp.Remove();
            }
            return last;
        }





        //عملية خارجية باسم RevQueueالتي تتلقى دور وتعيد دور جديد يحتوي على نفس القيم ولكن بترتيب عكسي

        public static void RevQueue<T>(Queue<T> q)
        {
            if (!q.IsEmpty())
            {
                T x = q.Remove();
                RevQueue(q);
                q.Insert(x);
            }
        }




        //عملية خارجية باسم RemoveOddالتي تتلقى دور وتحذف القيم الفردية التي فيه

        public static void RemoveOdd(Queue<int> q1)
        {
            Queue<int> temp = new Queue<int>();
            while (!q1.IsEmpty())
            {
                int x = q1.Remove();
                if (x % 2 == 0)
                    temp.Insert(x);
            }
            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
        }


        //عملية خارجية باسم LongestStringالتي تتلقى دور نصوص وتعيد النص الاطول في الدور، اذا كان الدور فارغ تعيد null

        public static string LongestString(Queue<string> q1)
        {
            if (q1.IsEmpty()) return null;
            string longest = q1.Head();
            Queue<string> temp = Copy(q1);
            while (!temp.IsEmpty())
            {
                string s = temp.Remove();
                if (s.Length > longest.Length)
                    longest = s;
            }
            return longest;
        }




        //عملية خارجية باسم ArrayToQueueالتي تتلقى مصفوفة اعداد صحيحة وتعيد دور جديد يحتوي على نفس القيم وبنفس الترتيب

        public static Queue<int> ArrayToQueue(int[] arr)
        {
            Queue<int> q1 = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
                q1.Insert(arr[i]);

            return q1;
        }





        //عملية خارجية باسم GetPointAt التي تتلقى دور نقاط Point
        //وعدد صحيح p
        //وتعيد النقطة التي في المكان p
        //first point is at position 0
        //if p is invalid or queue is empty return null 

        public static Point GetPointAt(Queue<Point> q1, int p)
        {
            if (q1.IsEmpty() || p < 0 || p >= Size(q1))
                return null;

            Queue<Point> temp = Copy(q1);

            for (int i = 0; i < p; i++)
                temp.Remove();

            return temp.Head();
        }




        //عملية خارجية باسم IsUpالتي تتلقى دور وتعيد صدق اذا كان الدور تصاعدي تماما، خلاف ذلك تعيد كذب
        //اذا الدور فارغ تعيد كذب
        //اذا قيمة واحدة صدق

        public static bool IsUp(Queue<int> q1)
        {
            if (q1.IsEmpty()) return false;
            //if (Size(q1) == 1) return true;
            Queue<int> temp = Copy(q1);
            int x = temp.Remove();
            while (!temp.IsEmpty())
            {
                if (temp.Head() <= x)
                    return false;
                x = temp.Remove();
            }
            return true;
        }





        //عملية خارجية باسم AddSorted
        //التي تتلقى دور اعداد صحيحة مرتبة تصاعديا
        // وعدد صحيح x
        // وتضيف x في المكان المناسب للحفاظ على ترتيب الدور

        public static void AddSorted(Queue<int> q1, int x)
        {
            Queue<int> temp = new Queue<int>();
            bool inserted = false;
            while (!q1.IsEmpty())
            {
                int y = q1.Head();
                if (!inserted && x <= y)
                {
                    temp.Insert(x);
                    inserted = true;
                }
                else
                {
                    temp.Insert(y);
                    q1.Remove();
                }
            }
            if (!inserted)
                temp.Insert(x);
            while (!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
        }





        //عملية خارجية باسم Exists 
        // التي تتلقى دور اعداد صحيحة وعدد صحيح x
        // وتعيد صدق اذا كان x موجودا في الدور، خلاف ذلك تعيد كذب

        public static bool Exists(Queue<int> q1, int x)
        {
            Queue<int> temp = Copy(q1);
            while (!temp.IsEmpty())
            {
                if (temp.Remove() == x)
                    return true;
            }
            return false;
        }





        //عملية خارجية باسم RemoveCheapest
        // التي تتلقى دور منتجات Product
        // و تحذف المنتج الاكثر رخصا في الدور






        //عملية خارجية باسم MergeQueues
        // التي تتلقى دورين اعداد صحيحة مرتبة تصاعديا
        // و تعيد دور جديد يحتوي على نفس القيم من الدورين وبترتيب تصاعدي





        //عملية خارجية باسم IsMath
        //التي تتلقى دور اعداد صحيحة
        //وتعيد صدق اذا كان الدور يمثل متتالية حسابية، خلاف ذلك تعيد كذب





        //عملية خارجية باسم RarChars
        //التي تتلقى دور رموز  #
        //وتعيد دور جديد يحتوي 






        //p value at position p in queue q
        //if p is invalid or queue is empty return -999
        //first position is 0
        //example: q=[7,-1,6,14,51,8,9,-8]
        //GetValueAt(q,3) returns 14
        //تعيد القيمة في المكان p في الدور q
        public static int GetValueAt(Queue<int> q, int p)
        {
            if (q.IsEmpty() || p < 0 || p >= Size(q))
                return -999;
            Queue<int> temp = Copy(q);
            for (int i = 0; i < p; i++)
                temp.Remove();
            return temp.Head();
        }





        //r value at rank r in queue q
        //if r is invalid or queue is empty return -999
        //first rank is 1
        //example: q=[7,-1,6,14,51,8,9,-8]
        //GetItemAtRank(q,3) returns 6
        //تعيد القيمة في الترتيب r في الدور q
        public static int GetValueAtRank(Queue<int> q, int r)
        {
            if (q.IsEmpty() || r < 1 || r > Size(q))
                return -999;
            Queue<int> temp = Copy(q);
            for (int i = 1; i < r; i++)
                temp.Remove();
            return temp.Head();
        }




        ///Bagrut 899271.2024.2
        ///
        // 0<m<=Size(q)
        //m=1 or m=Size(q) return false
        //تعيد صدق اذا كان الحد في الترتيب
        //m
        //سحري
        //  خلاف ذلك تعيد كذب
        //حد سحري هو الحد الذي قيمتع تساوي مجموع جاريه (الحد الذي قبله والحد الذي بعده)

        public static bool IsMagic(Queue<int> q, int m)
        {
            if (q.IsEmpty() || m <= 1 || m >= Size(q))
                return false;
            int prev = GetValueAtRank(q, m - 1);
            int x = GetValueAtRank(q, m);
            int next = GetValueAtRank(q, m + 1);
            if (x == (prev + next))
                return true;
            else
                return false;
        }

        public static bool IsMagic2(Queue<int> q, int m)
        {
            if (m == 1 || m == Size(q))
                return false;

            Queue<int> temp = Copy(q);

            for (int i = 0; i < m - 2; i++)
                temp.Remove();
            int prev = temp.Remove();
            int x = temp.Remove();
            int next = temp.Head(); //or temp.Remove();
            return (x == (prev + next));

        }


    }
}
