using UnityEngine;
using UnityEngine.UI;
#if TMP_YG2
using TMPro;
#endif

namespace YG
{
    public class LanguageYG : MonoBehaviour
    {
#if TMP_YG2
        public TMP_Text textMPComponent;
        public TMP_FontAsset uniqueFontTMP;
#endif
        public Text textLComponent;
        [Space(10)]
        public string text;
        public string ru, en, tr, az, be, he, hy, ka, et, fr, kk, ky, lt, lv, ro, tg, tk, uk, uz, es, pt, ar, id, ja, it, de, hi;
        public bool changeOnlyFont;
        public int fontNumber;
        public Font uniqueFont;
        public LangYGAdditionalText additionalText;
        int baseFontSize;

        public void Serialize() { }

        public void SwitchLanguage(string lang) { }

        public void SwitchLanguage() { }

        public void AssignTranslate() { }

        public void ChangeFont(Font[] fontArray) { }

#if TMP_YG2
        public void ChangeFont(TMP_FontAsset[] fontArray) { }
#endif
    }
}
