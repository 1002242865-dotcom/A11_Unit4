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
            int[] a = { 7, -1, 6, 14, 51, 8, 9, -8 };
            Queue<int> q = ArrayToQueue(a);
            int x = Size(q);
        }

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
            while(!q1.IsEmpty())
            {
                q2.Insert(q1.Head());
                temp.Insert(q1.Remove());
            }

            while(!temp.IsEmpty())
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

            while(!temp.IsEmpty())
            {
                q1.Insert(temp.Remove());
            }
            return count;
        }


        // عملية خارجية باسم GetLastValueالتي تتلقى دور نصوص وتعيد اخر قيمة في الدور

        public static string GetLastValue(Queue<string> q1)
        {
            string last = null;
            Queue<string> temp=Copy(q1);
            while (!temp.IsEmpty())
            {
                last = temp.Remove();
            }
            return last;
        }



        //عملية خارجية باسم RevQueueالتي تتلقى دور وتعيد دور جديد يحتوي على نفس القيم ولكن بترتيب عكسي

        //عملية خارجية باسم RemoveOddالتي تتلقى دور وتحذف القيم الفردية التي فيه


        //عملية خارجية باسم LongestStringالتي تتلقى دور نصوص وتعيد النص الاطول في الدور، اذا كان الدور فارغ تعيد null


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

        public static Point GetPointAt(Queue<Point> q1,int p)
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
            while(!temp.IsEmpty())
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


        //عملية خارجية باسم Exists 
        // التي تتلقى دور اعداد صحيحة وعدد صحيح x
        // وتعيد صدق اذا كان x موجودا في الدور، خلاف ذلك تعيد كذب


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











    }

    public class T
    {
    }
}
