using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GenerateNumber : MonoBehaviour
{
    [SerializeField]
    private Transform content;
    [SerializeField]
    private GameObject listing;
    [SerializeField]
    private Text number;
    [SerializeField]
    private GameObject lotteryMachine;
    //public List<InventorySlot> inventorySlots = new List<InventorySlot>(50);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int randrom()
    {
        var rand = new System.Random();
        List<int> listNumbers = new List<int>();
        int number = 0;
        do
        {
            number = rand.Next(1, 49);
        } while (listNumbers.Contains(number));
        listNumbers.Add(number);
        foreach (int myStringList in listNumbers)
        {
            Console.WriteLine(myStringList);
        }

        return number;
    }

    public void CreateNumber()
    {
        GameObject listings = Instantiate(listing, content);
    }

    public void Rotate()
    {
        Quaternion targetRotation = Quaternion.Euler(0, 0, 180);
        lotteryMachine.transform.rotation = Quaternion.Slerp(transform.rotation,
            targetRotation,Time .deltaTime );
    }
}
