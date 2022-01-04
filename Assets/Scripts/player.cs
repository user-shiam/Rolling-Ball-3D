using System.Collections;

using UnityEngine;

public class player : MonoBehaviour
{  
     
    public float speed;
    private Rigidbody rb;
    private float ScreenWidth;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
ScreenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
      int i = 0;
		
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
				//move right
				RunCharacter (1.0f);
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				//move left
				RunCharacter (-1.0f);
			}
			++i;
		}

    }
  
	private void RunCharacter(float horizontalInput){
		
		rb.AddForce(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0),ForceMode.Impulse);

	}
}
