namespace CarWashApp.UI.Helper
{
    public class ListItem
    {
        public ListItem(string key, Object value)
        {
            Value = value;
            Key = key;
        }
        public string Key { get; set; }
        public Object Value { get; set; }
        public override string ToString()
        {
            return Key;
        }
    }
}
