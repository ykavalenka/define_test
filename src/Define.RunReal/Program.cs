using System;

namespace Define.RunReal
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
