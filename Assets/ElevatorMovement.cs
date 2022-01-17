using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    private float speed = 0f;
    public GameObject player;
    public GameObject door1;
    public GameObject door2;
    AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speed != 0 && transform.position.y < 170)
        {
            Vector3 vector = Vector3.up * speed * Time.deltaTime;
            transform.Translate(vector);
            player.transform.Translate(vector);

            if (door1.transform.position.x < -60.75)
                door1.transform.Translate(Vector3.right * 0.7f * Time.deltaTime);
            if (door2.transform.position.x > -59.25)
                door2.transform.Translate(Vector3.left * 0.7f * Time.deltaTime);
        }

        if (transform.position.y >= 170)
        {
            music.Stop();
            if (door1.transform.position.x > -62)
                door1.transform.Translate(Vector3.left * 0.7f * Time.deltaTime);
            if (door2.transform.position.x < -58)
                door2.transform.Translate(Vector3.right * 0.7f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            speed = 5f;
            music.Play();
        }
    }
}