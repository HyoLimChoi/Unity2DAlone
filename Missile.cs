using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile: MonoBehaviour {
    public GameObject missileobj;
    public GameObject Characterobj;
    public void shoot()
    {
        missileobj.SetActive(!missileobj.active);
        Instantiate(missileobj, Characterobj.transform.position, Quaternion.identity);
    }
    

	void Update () {
       // Instantiate(missileobj, Characterobj.transform.position, Quaternion.identity);
    }


}
