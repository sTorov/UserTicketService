namespace Translator
{
    public class TranslateService
    {
        Dictionary<string, string> _translations;

        public TranslateService()
        {
            _translations = new Dictionary<string, string>();
            _translations.Add("dog", "собака");
            _translations.Add("cat", "кошка");
        }

        public void Add(string oneWord, string twoWord)
        {
            _translations.Add(oneWord, twoWord);
        }

        public string GetTranslation(string word)
        {
            return _translations[word];
        }
    }
}
