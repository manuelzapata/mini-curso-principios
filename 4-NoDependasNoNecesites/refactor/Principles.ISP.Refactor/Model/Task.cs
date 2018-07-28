namespace Principles.ISP.Refactor.Model
{
    class Task
    {

        public int TaskId { get; set; }
        public string Name { get; set; }
        public int EstimationPoints { get; set; }
        public bool Done { get; set; }

    }
}
