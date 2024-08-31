﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour {
    [SerializeField] private GameObject plane;
    private Vector3 offset = new Vector3(90f, 4f, 8f);

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.position = plane.transform.position + offset;
    }
}
