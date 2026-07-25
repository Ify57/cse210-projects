
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> visibleWords = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWords.Add(i);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            int wordIndex = visibleWords[randomIndex];

            _words[wordIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " - ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}