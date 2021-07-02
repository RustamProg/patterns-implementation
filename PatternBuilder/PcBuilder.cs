namespace PatternBuilder
{
    public class PcBuilder: IBuilder
    {
        private PersonalComputer _pc = new PersonalComputer();

        public PcBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pc = new PersonalComputer();
        }

        public void SetCpu(string cpu)
        {
            _pc.CpuName = cpu;
        }

        public void SetGpu(string gpu)
        {
            _pc.GpuName = gpu;
        }

        public void SetRam(int ram)
        {
            _pc.RamValueGBytes = ram;
        }

        public void SetUser(string user)
        {
            _pc.PcUser = user;
        }

        public PersonalComputer GetPersonalComputer()
        {
            return _pc;
        }
    }
}