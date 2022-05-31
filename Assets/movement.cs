 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public float speed;
    public Text skor;
    public float gravity;
    public float jumpHeight;
    Vector3 velocity;
    bool isGrounded;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey (KeyCode.UpArrow)) {
            transform.Translate (0,0,speed);
        }
        if (Input.GetKey (KeyCode.DownArrow)) {
            transform.Translate (0,0,-speed);
        }
        if (Input.GetKey (KeyCode.RightArrow)) {
            transform.Translate (speed,0,0);
        }
        if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.Translate (-speed,0,0);
        }
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
    }

    void OnTriggerEnter(Collider obj){
        if (obj.gameObject.tag == "target") {
            Destroy (obj.gameObject);
            score += 10;
            skor.text = "Skor : " + score.ToString();
            GameObject.Find ("suara target").GetComponent<AudioSource>().Play();
        }
    }

    void OnCollisionEnter(Collision obj){
        if (obj.gameObject.name == "wall"){
            GameObject.Find ("suara wall").GetComponent<AudioSource>().Play();
        }
    }
}
