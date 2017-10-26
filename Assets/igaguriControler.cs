using UnityEngine;
using System.Collections;

public class igaguriControler : MonoBehaviour {

    // Use this for initialization
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>();
    }
	void Start ()
    {
        //Shoot(new Vector3(0, 200, 2000));
	}
}
