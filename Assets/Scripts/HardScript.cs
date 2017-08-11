using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardScript : MonoBehaviour
{

	private int hp = 2;
	public GameManager gameManager;

	private void OnCollisionEnter()
	{
		hp--;
		if (hp == 0)
		{
			Destroy(gameObject);
			gameManager.score += 30;
		}
	}
}
