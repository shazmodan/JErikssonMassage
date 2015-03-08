[assembly: WebActivator.PreApplicationStartMethod(typeof(JErikssonMassage.App_Start.SquishItLess), "Start")]

namespace JErikssonMassage.App_Start
{
    using SquishIt.Framework;
    using SquishIt.Less;

    public class SquishItLess
    {
        public static void Start()
        {
            Bundle.RegisterStylePreprocessor(new LessPreprocessor());
        }
    }
}