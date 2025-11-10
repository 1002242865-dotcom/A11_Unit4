namespace A11_06102025_NodeInt
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            //Point p1 = new Point();
            //Console.WriteLine(p1);
            //Point p2 = new Point(-9);
            //Console.WriteLine(p2);
            //Point p3 = new Point(5, 8);
            //Console.WriteLine(p3);

            //(20,30) r=7
            Point p = new Point(20, 30);
            Circle c1 = new Circle(7, p);
            Console.WriteLine(c1);

          }

        public static Circle GetHighest(Circle[] arr)
        {
            Circle tmp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].getCenter().getY() > tmp.getCenter().getY())
                    tmp = arr[i];
            }

            return tmp;
        }


        public static Circle GetHighest2(Circle[] arr)
        {
            Circle tmp = null;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != null)
                {
                    tmp = arr[i];
                    i = arr.Length;
                    //break;
                }
                    
            if(tmp==null)
                return null;

           for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                    if (arr[i].getCenter().getY() > tmp.getCenter().getY())
                        tmp = arr[i];
            }

            return tmp;
        }
    }
}
