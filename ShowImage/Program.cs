using System;
using Emgu.CV;
using System.IO;
namespace ShowImage
{
    class Program
    {
        static void Main(string[] args)
        {            
            var zero = CvInvoke.Imread(Path.Join("resources","zero.jpg"));
            CvInvoke.Imshow("zero", zero);
            CvInvoke.WaitKey(0);
        }
    }
}
