using UnityEngine;

namespace YG
{
    public class AdNotificationYG : MonoBehaviour
    {
        [Tooltip("Объект, который будет активироваться перед открытием рекламы. И деактивироваться при открытии.")]
        public GameObject notificationObj;
        [Min(0.1f), Tooltip("Максимальное время показа объекта нотификации. Если реклама так и не будет показана, то объект скроется через указанное в данном параметре время.")]
        public float waitingForAds = 1;

        public static bool isShowNotification;
        public static AdNotificationYG Instance;
    }
}