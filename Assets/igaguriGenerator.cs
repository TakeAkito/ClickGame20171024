using UnityEngine;
using System.Collections;

public class igaguriGenerator : MonoBehaviour{

public GameObject igaguriPrefab;

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab) as GameObject;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<igaguriControler>().Shoot(worldDir.normalized * 2000);
        }
	}
}
