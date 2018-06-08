using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearDes : MonoBehaviour
{
    public Text Cleartext;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Cleartext.text = "Congratulations!!";
            Destroy(this.gameObject);
        }
    }
}
