using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCSharp : MonoBehaviour
{
    [Header("分數"),Range(-100, 100)]
    public int Score = 69; // 整數
    [Header("速度"), Range(-15f, 15f)]
    public float Speed = 2f; // 浮點數
    [Header("智商"),Tooltip("可增加提示")]
    public string IQ = "200"; // 字串顯示
    [Header("任務")]
    public bool missing = true; // 布林 (true or false)

    [Header("二維")]
    public Vector2 v2 = new Vector2(5, 5);
    [Header("三維")]
    public Vector3 v3 = new Vector3(3, 3, 3);
    public Vector3 zero = Vector3.zero;

    public Color white = Color.white;
    public Color black = new Color(0f, 0f, 0f);

    public AudioClip sound;
    public Camera cam;
    public Light lig;
    public Transform camPos;
    public GameObject obj;
    public Debug deb;
}
