using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{ 

	public void SceneHistory(int numerScenes)
	{
		PlayerPrefs.SetInt("coins", 0);
		SceneManager.LoadScene(numerScenes);
		Time.timeScale = 1;
	}

	
}