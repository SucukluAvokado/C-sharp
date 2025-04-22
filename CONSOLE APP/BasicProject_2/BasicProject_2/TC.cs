using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject_2
{
    internal class TC
    {
        private string tcno;
        public string tc
        {

            get
            {
                return tcno.Substring(0, 5);
            }
            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                     bool sayiMi = char.IsNumber(value[i]);

                        if (sayiMi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;

                        }

                        if (kontrol)
                        {
                            Console.WriteLine("Bilinmeyen karakter.");
                        }
                        else
                        {
                            tcno = value;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz tc 11 haneli olmalı.");
                }

            }


        }
    }     
}
