using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballGen : MonoBehaviour {

    //public GameObject theFireball;
    //public Transform genPoint;

    public float distance;
   /* private float[] fireballWidth;
    public float distanceMin;
    public float distanceMax;
	private int select;*/
    public ObjectPooler objPool;

    // Use this for initialization
   /* void Start()
    {
		fireballWidth = new float[objPool.Length];
		for(int i = 0; i < objPool.Length; i++){
			fireballWidth [i] = objPool[i].pooledObject.GetComponent<BoxCollider2D> ().size.x;
		}

    }

    // Update is called once per frame
    void Update()
    {
		if (transform.position.x < genPoint.position.x) {

			distance = Random.Range (distanceMin, distanceMax);
			select = Random.Range (0, objPool.Length);
			transform.position = new Vector3 (transform.position.x + fireballWidth[select] + distance, transform.position.y, transform.position.z);

			//Instantiate (/*platform objPool[select], transform.position, transform.rotation);
			GameObject newFireball = objPool[select].GetPooledObject();

			newFireball.transform.position = transform.position;
			newFireball.transform.rotation = transform.rotation;
			newFireball.SetActive (true);
		}
    }*/

	public void FireballMaker(Vector3 make){
		GameObject fireball = objPool.GetPooledObject ();
		fireball.transform.position = make;
		fireball.SetActive (true);

		GameObject fireball1 = objPool.GetPooledObject ();
		fireball1.transform.position = new Vector3(make.x, make.y - distance, make.z);
		fireball1.SetActive (true);

		GameObject fireball2 = objPool.GetPooledObject ();
		fireball2.transform.position = new Vector3(make.x, make.y + distance, make.z);
		fireball2.SetActive (true);
	}
}
