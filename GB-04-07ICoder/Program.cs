using System;
using System.Text;

namespace GB_04_07ICoder
{
    class Program
    {
        static void Main(string[] args)
        {


            string str=  Console.ReadLine();
            
            char[]strChar= str.ToCharArray();

            char[] abc = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                          'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т',
                          'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                          'Э', 'Ю', 'Я'};

            StringBuilder sb = new StringBuilder();
            int num;
            const int numMax = 33;
            bool isUpper=true;
            char up;
            foreach (var i in strChar)
            {
                num = 0;
                isUpper = char.IsUpper(i);
                if (!isUpper)
                {
                    up= char.ToUpper(i);
                }
                else
                {
                    up = i;
                }

                foreach (var iAbc in abc)
                {
                    num++;
                    if (up == iAbc)
                    {
                        if (num== numMax)
                        {
                            if (isUpper)
                            {
                                sb.Append(abc[0]);
                            }
                            else
                            {
                                up = char.ToLower(abc[0]);
                                sb.Append(up);
                            }
                        }
                        else
                        {
                            if (isUpper)
                            {
                                sb.Append( abc[num]);
                            }
                            else
                            {
                                up = char.ToLower(abc[num]);
                                sb.Append(up);
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sb);
            sb.Clear();


            foreach (var i in strChar)
            {
                num = 0;
                isUpper = char.IsUpper(i);
                if (!isUpper)
                {
                    up = char.ToUpper(i);
                }
                else
                {
                    up = i;
                }

                foreach (var iAbc in abc)
                {
                    num++;
                    if (up == iAbc)
                    {

                        if (isUpper)
                        {
                            sb.Append(abc[numMax-num]);
                        }
                        else
                        {
                            up = char.ToLower(abc[numMax - num]);
                            sb.Append(up);
                        }

                    }
                }
            }

            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
