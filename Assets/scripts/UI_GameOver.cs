using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		GameManager.Instance.EventGameOver += OnGameOver;
        gameObject.SetActive(false);
	}

	private void OnDestroy()
	{
		GameManager.Instance.EventGameOver -= OnGameOver;
	}

	private void OnGameOver()
	{
		Debug.Log("Matis: on game over");
		gameObject.SetActive(true);
	}

	public void OnPlayClicked()
	{
		gameObject.SetActive(false);
		GameManager.Instance.RestartGame();
	}
}
