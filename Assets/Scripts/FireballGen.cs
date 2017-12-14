using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballGen : MonoBehaviour {

    public GameObject theFireball;
    public Transform genPoint;

    public float distance;
    private float fireballWidth;
    public float distanceMin;
    public float distanceMax;
    public ObjectPooler objPool;

    // Use this for initialization
    void Start()
    {
        fireballWidth = theFireball.GetComponent<BoxCollider2D>().size.y;
    }
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < genPoint.position.x)
        {
            distance = Random.Range(distanceMin, distanceMax);
            transform.position = new Vector3(transform.position.x + fireballWidth + distance, transform.position.y,  transform.position.z);
            // Instantiate(theFireball, transform.position, transform.rotation);
            GameObject newFireball = objPool.GetPooledObject();

            newFireball.transform.position = transform.position;
            newFireball.transform.rotation = transform.rotation;
            newFireball.SetActive(true);
        }
	}
}
