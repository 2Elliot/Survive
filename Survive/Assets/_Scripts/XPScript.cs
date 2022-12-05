using UnityEngine;

public class XPScript : MonoBehaviour
{
	PlayerStats playerStats;

	private void Awake() {
		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			playerStats.xp++;
			Destroy(this.gameObject);
		}
	}

}
