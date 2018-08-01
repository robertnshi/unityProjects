using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class BallMove : MonoBehaviour {
    public float moveSpeed = 2f;
    public float upSpeed = 3f;

	void Awake () {
		
	}
	
	void FixedUpdate () {
		if (CrossPlatformInputManager.GetButton("Fire1")){
            Move();
        }
        MoveUp();
	}

    void Move()
    {
        // 计算小球的偏移距离
        float x = CrossPlatformInputManager.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
        float y = CrossPlatformInputManager.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
    }

    void MoveUp()
    {
        float y = upSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x, transform.position.y + y);
    }
}
