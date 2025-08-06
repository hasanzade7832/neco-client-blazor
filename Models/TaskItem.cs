namespace BlazorApp12.Models
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public bool IsCollapsed { get; set; }

        // ← این دو را اضافه کنید:
        public bool CompletedTask { get; set; }
        public int Delay { get; set; }

    }
}
