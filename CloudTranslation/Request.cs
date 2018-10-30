namespace Minami.CloudTranslation
{
    public class Request
    {
        public string[] q { get; set; }
        public string target { get; set; }
        public string format { get; set; }
        public string source { get; set; }

        public Request(string[] text, string target, string format, string source)
        {
            this.q = text;
            this.target = target;
            this.format = format;
            this.source = source;
        }

        public Request(string[] text, string target, string format)
        {
            this.q = text;
            this.target = target;
            this.format = format;
        }
    }
}
