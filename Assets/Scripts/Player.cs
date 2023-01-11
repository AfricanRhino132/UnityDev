using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10), Tooltip("Speed of player")]float speed = 5;

    public GameObject bullet;

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        //transform.position = new Vector3(2, 3, 2);
        //transform.rotation = Quaternion.Euler(30, 30, 30);
        //transform.localScale = Vector3.one * Random.value * 5;

        Vector3 direction = Vector3.zero;

        //direction.x = Input.GetAxis("Horizontal");
        //direction.z = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -1;
        }

        transform.position += direction.normalized * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }
}
