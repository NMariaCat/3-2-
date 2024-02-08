
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2improved
{
    public class Program
    {
        static void Main()
        {
            //OneDimentionArr OneD = new OneDimentionArr();
            //TwoDimentionArr TwoD = new TwoDimentionArr();
            //SteppedArr StepD = new SteppedArr();
            Base[] arrs = new Base[3];
            arrs[0] = new OneDimentionArr();
            arrs[1] = new TwoDimentionArr();
            arrs[2] = new SteppedArr();

            foreach (Base i in arrs)
            {
                //i.Initializ();
                i.Output();
                i.countAverage();
            }

        }
    }
}
    

    

    



    

