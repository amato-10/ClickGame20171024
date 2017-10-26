using UnityEngine;
using System.Collections;

public class TergetMnagere : MonoBehaviour {

    public GameObject tergetPrefab;
    float ran = Random.Range(4.0f, -4.0f);
    void Start()
    {
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        GameObject terget = Instantiate(tergetPrefab) as GameObject;
        float ran = Random.Range(4.0f, -4.0f);
        terget.transform.position = new Vector3(ran, 0.5f, ran);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
