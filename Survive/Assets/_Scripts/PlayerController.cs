using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {

	private PlayerInputActions playerInputActions;
	private PlayerStats playerStats;


	void Start() {

		playerInputActions = new();
		playerInputActions.Player.Enable();
		playerInputActions.Player.Pause.performed += Pause;
		playerInputActions.Player.Enter.performed += Enter;

		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
	}

	private void Update() {
		Move();
	}

	private void Move() {
		Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
		transform.Translate(playerStats.playerSpeed * Time.deltaTime * inputVector);
	}

	public void Pause(InputAction.CallbackContext context) {
		if (context.performed) {
			Debug.Log("Pause");
		}
	}

	public void Enter(InputAction.CallbackContext context) {
		if (context.performed) {
			Debug.Log("Enter");
		}
	}
}
