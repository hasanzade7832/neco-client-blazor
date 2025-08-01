namespace BlazorApp12.Models
{
    public class MenuItemModel
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public bool HasSubmenu { get; set; }

        public MenuItemModel() { }

        public MenuItemModel(string icon, string text, bool hasSubmenu)
        {
            Icon = icon;
            Text = text;
            HasSubmenu = hasSubmenu;
        }
    }
}
