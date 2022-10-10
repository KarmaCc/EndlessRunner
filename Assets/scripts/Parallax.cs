using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
GameObject player;
Renderer rend;

    float playerStartPos;
    public float speed = 0.7f
{
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent < Renderer.();
        playerStartPos
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
