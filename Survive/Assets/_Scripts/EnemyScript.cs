using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private GameObject player;
	private Rigidbody2D enemyRigidbody2D;
	private AIBase aiBase;
	private AIDestinationSetter aiDestinationSetter;

	public GameObject xp;

	private EnemyHandler enemyHandler;

	private void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
		enemyHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyHandler>();
		enemyRigidbody2D = GetComponent<Rigidbody2D>();
		aiDestinationSetter = GetComponent<AIDestinationSetter>();
		aiBase = GetComponent<AIBase>();
		aiBase.maxSpeed = enemyHandler.enemySpeed;
		aiDestinationSetter.target = player.transform;
	}

	private void Update() {
		//transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * enemyHandler.enemySpeed);
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			Destroy(this.gameObject);
			Debug.Log("Hit!");
		} else if (collision.CompareTag("PowerUps")) {
			if (Random.Range(0, 2) == 0) {
				Instantiate(xp, transform.position, Quaternion.identity);
			}
			Destroy(this.gameObject);
		}
	}

}
