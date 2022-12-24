using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumberListing : MonoBehaviour
{
    [SerializeField]
    private Text number;

    public GenerateNumber generateNumber;
    // Start is called before the first frame update
    public void Start()
    {
        //System.Random rnd = new System.Random();
        //int num = rnd.Next(1,50);

        //number.text = num.ToString();
        //GenerateNumber sn = gameObject.GetComponent<GenerateNumber>();
        int test = GenerateNumber.randrom();
        number.text = test.ToString();
    }
}
