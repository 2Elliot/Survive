using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POW_Saw : MonoBehaviour
{
	PlayerStats playerStats;

	GameObject player;

	private void Start() {
		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
		player = GameObject.FindWithTag("Player");
		transform.position = transform.position + new Vector3(0f, playerStats.area, 0f);
	}

	void Update()
    {
        transform.RotateAround(player.transform.position, new Vector3(0, 0, -1), playerStats.sawSpeed * Time.deltaTime);
    }
}
