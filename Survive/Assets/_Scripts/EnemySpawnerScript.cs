using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	private GameObject player;

	public GameObject enemy;

	private EnemyHandler enemyHandler;

	private float timer;

	private void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
		enemyHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyHandler>();
	}

	private void Update() {
		transform.position = player.transform.position;

		SpawnEnemies();
	}

	private void SpawnEnemies() {
		if (timer <= enemyHandler.enemySpawnRate) {
			timer += Time.deltaTime;
			Debug.Log(timer);
		} else {
			timer = 0;
			float randFloat = Random.Range(0, 2 * Mathf.PI);
			float spawnX = Mathf.Sin(randFloat);
			float spawnY = Mathf.Cos(randFloat);
			Instantiate(enemy, transform.position + new Vector3(spawnX, spawnY, 0f) * 20, Quaternion.identity);
		}
	}

}
