using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LandControl : MonoBehaviour {

    private Sequence landSequence;
	// Use this for initialization
	void Start () {
        // land continue moving
        landSequence = DOTween.Sequence();

        landSequence.Append(transform.DOMoveX(transform.position.x - 0.48f, 0.5f).SetEase(Ease.Linear))
            .Append(transform.DOMoveX(transform.position.x, 0f).SetEase(Ease.Linear))
            .SetLoops(-1);
    }

	private void OnEnable()
	{
		GameManager.Instance.EventGameOver += GameOver;
	}

	private void OnDisable()
	{
		if (GameManager.Instance != null)
			GameManager.Instance.EventGameOver -= GameOver;
	}

	// Update is called once per frame
	void Update () {
	
	}

    public void GameOver()
    {
        landSequence.Kill();
    }
}
