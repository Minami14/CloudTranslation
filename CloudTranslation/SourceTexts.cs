namespace Minami.CloudTranslation
{
    public class SourceTexts
    {
        public string[] Texts { get; set; }

        public SourceTexts(params string[] texts)
        {
            Texts = texts;
        }
    }
}
