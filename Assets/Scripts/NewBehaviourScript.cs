using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            gameObject.rigidbody2D.AddForce((mousePos + gameObject.transform.position) * 1f);
        }

       
	}
}
