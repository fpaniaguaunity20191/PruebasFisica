using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oso : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        print(name);
        print(collision.gameObject.name);
    }
}
