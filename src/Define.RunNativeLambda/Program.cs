#define NATIVE_LAMBDA
using System;

namespace Define.RunNativeLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Define.Data.ModelOut outModel = new Data.ModelOut();
            var inModel = (Define.Data.ModelIn)outModel;
            Console.WriteLine(inModel.Value);
            Console.ReadKey();
        }
    }
}
