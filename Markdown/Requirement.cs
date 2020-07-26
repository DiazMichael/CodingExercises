namespace Markdown
{
    internal class Requirement
    {
        public string APIProperty { get; set; }
        public bool IsMandatory { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Requirement()
        {
        }
    }
}