#define NATIVE
#define NATIVE_LAMBDA

namespace Define.Data
{
    public class ModelIn
    {
        public string Value { get; set; }

        public static explicit operator ModelIn(ModelOut model)
        {
#if NATIVE
            return model == null ? null : new ModelIn() { Value = "NativeIn" };
#elif NATIVE_LAMBDA
            return model == null ? null : new ModelIn() { Value = "NativeLambdaIn" };
#endif
            return model == null ? null : new ModelIn() { Value = "RealIn" };
        }
    }

    public class ModelOut
    {
       
    }
}