using UnityEngine;
using System.Collections;

public class TergetMnagere : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
