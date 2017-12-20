using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGen : MonoBehaviour
{
    public ObjectPooler objPool;
	public float distance;

	public void CoinMaker(Vector3 make){
		GameObject coin = objPool.GetPooledObject ();
		coin.transform.position = make;
		coin.SetActive (true);

		GameObject coin1 = objPool.GetPooledObject ();
		coin1.transform.position = new Vector3(make.x - distance, make.y, make.z);
		coin1.SetActive (true);

		GameObject coin2 = objPool.GetPooledObject ();
		coin2.transform.position = new Vector3(make.x + distance, make.y, make.z);
		coin2.SetActive (true);
	}
}
