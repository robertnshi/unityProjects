using UnityEngine;

public class MoveObstacle : MonoBehaviour {
    public float startX;
    public float endX;
    public float moveSpeed = 2f;

    private int dir = 1;

	void Awake () {
		
	}
	
	void FixedUpdate () {
        transform.position = new Vector2(transform.position.x + moveSpeed * dir * Time.deltaTime, transform.position.y);

        if (dir == 1 && transform.position.x >= endX)
        {
            dir = -1;
        }

        if (dir == -1 && transform.position.x <= startX)
        {
            dir = 1;
        }
	}
}
