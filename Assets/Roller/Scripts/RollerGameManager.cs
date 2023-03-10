using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RollerGameManager : Singleton<RollerGameManager>
{
    [SerializeField] Slider healthMeter;
    [SerializeField] TMP_Text scoreUI;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform playerStart;
    
    public void SetHealth(int health)
    {
        healthMeter.value = Mathf.Clamp(health, 0, 100);
    }

    public void SetScore(int score)
    {
        scoreUI.text = score.ToString("D6");
    }

	private void Start()
	{
		Instantiate(playerPrefab, playerStart.position, playerStart.rotation);
	}
}
