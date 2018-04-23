using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Player))]
public class PlayerInput : MonoBehaviour {

	Player player;
    private Animator animator;

	void Start () {
		player = GetComponent<Player> ();
        animator = GetComponent<Animator>();
	}

	void Update () {
		Vector2 directionalInput = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		player.SetDirectionalInput (directionalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            player.OnJumpInputDown();

        }
		if (Input.GetKeyUp (KeyCode.Space)) {
			player.OnJumpInputUp ();
		}

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("RunLeft");

        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("RunRight");

        }

    }

}
