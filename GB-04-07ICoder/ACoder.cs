using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_04_07ICoder
{
    public interface ICoder
    {
        string Encode(string enc);

        string Decode(string dec);

    }


    public class ACoder : ICoder
    {
        string a = "sdf";

        

        public string Decode(string dec)
        {
            char [] c = dec.ToCharArray();

            

           

            throw new NotImplementedException();
        }

        public string Encode(string enc)
        {
            throw new NotImplementedException();
        }
    }
}
