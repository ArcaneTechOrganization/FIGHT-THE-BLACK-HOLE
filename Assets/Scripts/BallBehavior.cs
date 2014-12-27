using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
    Animator animator;

	// Use this for initialization
	void Start () {
        //gameObject.transform.position = new Vector3(0, 0);
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            gameObject.rigidbody2D.AddForce((mousePos - gameObject.transform.position) * 10.0f);
        }

        animator.SetFloat("Speed", gameObject.rigidbody2D.velocity.magnitude);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bounds")
        {
            animator.SetTrigger("Die");
        }
    }

    public void DieEvent()
    {
        DestroyObject(gameObject);
    }
}
