using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GamePush;

public class Scene : MonoBehaviour
{ 

	public void SceneHistory(int numerScenes)
	{
		PlayerPrefs.SetInt("coins", 0);
		SceneManager.LoadScene(numerScenes);
		Time.timeScale = 1;
		ShowFullscreen();
	}
	// Показать fullscreen
	public void ShowFullscreen() => GP_Ads.ShowFullscreen(OnFullscreenStart, OnFullscreenClose);
	
	// Начался показ
	private void OnFullscreenStart() => Debug.Log("ON FULLSCREEN START");
	// Закончился показ
	private void OnFullscreenClose(bool success) => Debug.Log("ON FULLSCREEN CLOSE");
	
}