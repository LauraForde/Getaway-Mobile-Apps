using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGen : MonoBehaviour
{

    public float speed = 5f;

    void Start()
    {

    }
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }

   /* public GameObject coinSpawn;
    public Transform genPoint;

    public float distance;
    private float coinWidth;
    public float distanceMin;
    public float distanceMax;
    public ObjectPooler objPool;

    // Use this for initialization
    void Start()
    {
        coinWidth = coinSpawn.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genPoint.position.x)
        {
            distance = Random.Range(distanceMin, distanceMax);
            transform.position = new Vector3(transform.position.x + coinWidth + distance, transform.position.y, transform.position.z);
            // Instantiate(theFireball, transform.position, transform.rotation);
            GameObject newCoin = objPool.GetPooledObject();

            newCoin.transform.position = transform.position;
            newCoin.transform.rotation = transform.rotation;
            newCoin.SetActive(true);
        }
    }*/
}
