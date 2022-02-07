using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Block")
        {
            print("Hey");
        }
         if (collision.gameObject.tag == "Obstacle")
        {
            print("GOT hit");
            SceneManager.LoadScene("GameLose");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            print("Hey");
        }

        if (other.gameObject.tag == "Obstacle")
        {
            print("GOT hit");
            SceneManager.LoadScene("GameLose");
        }

    }

}
