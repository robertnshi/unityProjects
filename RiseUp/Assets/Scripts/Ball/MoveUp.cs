using UnityEngine;

public class MoveUp : MonoBehaviour {
    public float upSpeed = 3f;

    void Awake () {
		
	}
	
	void FixedUpdate () {
        Move();
	}

    void Move()
    {
        float y = upSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x, transform.position.y + y);
    }
}
