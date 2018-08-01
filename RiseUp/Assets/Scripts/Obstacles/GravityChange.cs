using UnityEngine;

public class GravityChange : MonoBehaviour {

    Rigidbody2D rigidBody;
	
	void Awake () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
    private void OnCollisionEnter2D(Collision2D col)
    {
        rigidBody.gravityScale = 1f;
        if (gameObject.GetComponent<MoveObstacle>() != null)
        {
            gameObject.GetComponent<MoveObstacle>().enabled = false;
        }
    }
}
