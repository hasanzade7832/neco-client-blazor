using System.Collections.Generic;

namespace BlazorApp12.Models
{
    public class ColumnModel
    {
        public string Title { get; set; } = "";
        public List<TaskItem> Items { get; set; } = new();
        public string BackgroundCss { get; set; } = "var(--mud-palette-action-default)";
        public bool Collapsed { get; set; }
        public int ExpandedWidth { get; set; } = 280;
        public int CollapsedWidth { get; set; } = 64;
        public bool GlassOnSecond { get; set; }
        public bool Appear { get; set; }
    }
}
