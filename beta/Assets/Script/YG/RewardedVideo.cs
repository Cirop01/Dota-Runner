using UnityEngine;
using YG;
public class RewardedVideo
{
    [SerializeField] private Button Get_award;


    private void Start()
    {
        Get_award.onClick.AddListener(delegate{Open_reward();});
    }

    private void Open_reward()
    {
        YandexGame.RewVideoShow();
    }
    private void Rewarded()
    {
        int coins = PlayerPrefs.GetData("coins_all");
        coins += 100;
        PlayerPrefs.SetInt("coins_all", coins);
        YandexGame.savesData.coins = PlayerPrefs.GetInt("coins_all");
        YandexGame.SaveProgress();
    }
    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += RewardedVideo;
        YandexGame.GetDataEvent += GetData;
    }
    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= RewardedVideo;
        YandexGame.GetDataEvent -= GetData;
    }
}
