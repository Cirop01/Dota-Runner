using UnityEngine;
using UnityEngine.Events;

namespace YG
{
    public class TimerBeforeAdsYG : MonoBehaviour
    {
        [Tooltip("Объект таймера перед показом рекламы. Он будет активироваться и деактивироваться в нужное время.")]
        public GameObject secondsPanelObject;
        [Tooltip("Массив объектов, которые будут показываться по очереди через секунду. Сколько объектов вы поместите в массив, столько секунд будет отчитываться перед показом рекламы.\n\nНапример, поместите в массив три объекта: певый с текстом '3', второй с текстом '2', третий с текстом '1'.\nВ таком случае произойдёт отчет трёх секунд с показом объектов с цифрами перед рекламой.")]
        public GameObject[] secondObjects;

        [Tooltip("Пазуа с помощью компонента ViewingAdsYG.")]
        public bool pauseTo_ViewingAdsYG = true;

        [Space(20)]
        public UnityEvent onShowTimer;
        public UnityEvent onHideTimer;
        public UnityEvent doPause;
    }
}
