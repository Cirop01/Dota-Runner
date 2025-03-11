using UnityEngine;

namespace YG
{
    public class LangYGAdditionalText : MonoBehaviour
    {
        public enum Side { Left, Right };
        public Side side;

        public string additionalText
        {
            get => _additionalText;
            set
            {
                _additionalText = value;
                AssignAdditionalText();
            }
        }

        public string _additionalText;

        public void AssignAdditionalText(LanguageYG languageYG) { }

        public void AssignAdditionalText() { }
    }
}