using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{

	public float enemySpeed = 5f;
	public float enemySpawnRate = 1f;

	private float timer = 5f;
	private float time = 0f;

	private PlayerStats playerStats;

	private void Start() {
		playerStats = GetComponent<PlayerStats>();
	}

	private void Update() {
		time += Time.deltaTime;

		if (time >= timer) {
			time = 0f;
			enemySpawnRate = enemySpawnRate * 0.9f;
			enemySpeed += 0.1f;
			playerStats.sawSpeed += 10f;
			playerStats.playerSpeed += 0.1f;
		}
	}


}
