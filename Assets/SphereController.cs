using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

    public GameObject tergetPrefab;

	public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
    void Start () {
	}
}
