using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public GameObject QuizObject2;
    public GameObject TimeObject2;
	// Use this for initialization
	void Start () {
        QuizObject2.SetActive(false);
        TimeObject2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            QuizObject2.SetActive(true);
            TimeObject2.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
