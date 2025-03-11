using System;
using UnityEngine;
using UnityEngine.UI;

namespace YG
{
    public class GraphicSettingsYG : MonoBehaviour
    {
        public Dropdown dropdown;
        public Text labelText;
        public Text itemText;
        public int fontNumber;
        [Space(5)]
        [Header("Translate")]
        public string[] ru = new string[6];
        public string[] en = new string[6];
        public string[] tr = new string[6];
        public string[] az = new string[6];
        public string[] be = new string[6];
        public string[] he = new string[6];
        public string[] hy = new string[6];
        public string[] ka = new string[6];
        public string[] et = new string[6];
        public string[] fr = new string[6];
        public string[] kk = new string[6];
        public string[] ky = new string[6];
        public string[] lt = new string[6];
        public string[] lv = new string[6];
        public string[] ro = new string[6];
        public string[] tg = new string[6];
        public string[] tk = new string[6];
        public string[] uk = new string[6];
        public string[] uz = new string[6];
        public string[] es = new string[6];
        public string[] pt = new string[6];
        public string[] ar = new string[6];
        public string[] id = new string[6];
        public string[] ja = new string[6];
        public string[] it = new string[6];
        public string[] de = new string[6];
        public string[] hi = new string[6];

        public static Action onQualityChange;

        void Awake() { }
        public void SetQuality() { }

        private void SwitchLanguage(string lang) { }
    }
}
