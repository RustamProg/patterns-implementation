namespace PatternBuilder
{
    public interface IBuilder
    {
        void Reset();
        void SetCpu(string cpu);
        void SetGpu(string gpu);
        void SetRam(int ram);
        void SetUser(string user);
        PersonalComputer GetPersonalComputer();
    }
}