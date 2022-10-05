using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceManager : MonoBehaviour
{
    public static DistanceManager instance;

    private Vector3 bgColor;

    public Material bgMat;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeBackground(Color col)
    {
        bgMat.SetColor("green", col );

        Debug.Log("Current Bg: green");

    }
}
