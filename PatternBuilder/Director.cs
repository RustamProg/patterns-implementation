namespace PatternBuilder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set => _builder = value;
        }

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetWeakConfiguration()
        {
            _builder.SetCpu("Intel Pentium Dual Core");
            _builder.SetGpu("None");
            _builder.SetRam(1);
            _builder.SetUser("Vasiliy");
        }

        public void SetStrongConfiguration()
        {
            _builder.SetCpu("Intel Core I9 11900K");
            _builder.SetGpu("NVIDIA RTX 3090");
            _builder.SetRam(32);
            _builder.SetUser("Rustam");
        }
    }
}