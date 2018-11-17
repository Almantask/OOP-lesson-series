namespace OOP_lesson_series.Lesson_6_Events
{
    public class ReportEventEndArgs : ReportEventStartArgs
    {
        public int Contribution { set; get; }

        public ReportEventEndArgs(string name, int contribution):base(name)
        {
            Contribution = contribution;
        }
    }
}