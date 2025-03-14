using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PlayerPrefs = RedefineYG.PlayerPrefs;
public class Scenes : MonoBehaviour
{ 

	public void SceneHistory(int numerScenes)
	{
		PlayerPrefs.SetInt("coins", 0);
		SceneManager.LoadScene(numerScenes);
		Time.timeScale = 1;
		PlayerPrefs.Save();
	}

	
}