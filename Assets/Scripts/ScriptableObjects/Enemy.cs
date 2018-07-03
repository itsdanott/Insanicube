﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Insanicube Design/Enemy")]
public class Enemy : ScriptableObject {

    public new string name;

    public Mesh mesh;

    public int score;

    public float minSpeed, maxSpeed;
}