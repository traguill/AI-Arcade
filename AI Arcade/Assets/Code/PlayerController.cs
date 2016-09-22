using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3.5f;

    Vector3 speed_vec = new Vector3();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        speed_vec.Set(0, 0, 0);

	    if(Input.GetKey(KeyCode.RightArrow))
        {
             speed_vec.x = Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x = Time.deltaTime * -speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed_vec.z = Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed_vec.z = Time.deltaTime * -speed;
        }

        transform.position += speed_vec;
	}


  
}
