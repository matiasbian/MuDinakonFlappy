using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private static GameManager _instance;
	public static GameManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<GameManager>();
				DontDestroyOnLoad(_instance);
			}

			return _instance;
		}
	}

	public Action EventGameOver;

	public void GameOver()
	{
		EventGameOver?.Invoke();
	}

	public void RestartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}
}
