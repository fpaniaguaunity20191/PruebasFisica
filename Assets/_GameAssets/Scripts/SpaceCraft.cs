﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCraft : MonoBehaviour {
    public float speed;
    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
