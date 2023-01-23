using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    public float rotationRate = 180;

    public GameObject bullet;
    public Transform bulletSpawnLocation;

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

        Vector3 rotation = Vector3.zero;

        rotation.y = Input.GetAxis("Horizontal");

        direction.z = Input.GetAxis("Vertical");

        Quaternion rotate = Quaternion.Euler(rotation * rotationRate * Time.deltaTime);

        transform.rotation = transform.rotation * rotate;

        transform.Translate(direction.normalized * speed * Time.deltaTime);
        //transform.position += direction.normalized * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletSpawnLocation.position, bulletSpawnLocation.rotation);
        }
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			FindObjectOfType<AsteroidGameManager>()?.SetGameOver();
		}
	}
}
