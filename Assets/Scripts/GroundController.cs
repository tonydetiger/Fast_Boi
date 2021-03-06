﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

    public float moveSpeed;

    public Sprite[] roadTypes;

    SpriteRenderer thisSR;

    //Called when it is created
    void Start() {
        thisSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.left * moveSpeed / 100f * Time.timeScale);

        if (transform.position.x <= -10f) {
            transform.position = new Vector3(transform.position.x+(2*12.01f), transform.position.y, transform.position.z);
            thisSR.sprite = roadTypes[(int)Random.Range(0f, roadTypes.Length)];
        }
    }
}
