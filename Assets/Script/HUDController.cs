﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HUDController : MonoBehaviour
{
    public Text hungerText;
    public Text friendshipText;
    public Text isSickText;

    public GameObject Rock;
    // Start is called before the first frame update
    void Start()
    {
       /* hungerText.text = "I'm hungry";
        friendshipText.text = "Hello";
        isSickText.text = "Healthy"; */
    }

    // Update is called once per frame
    void Update()
    {
        hungerText.text = Rock.GetComponent<RockController>().hunger.ToString();
        friendshipText.text = Rock.GetComponent<RockController>().friendship.ToString();
        isSickText.text = Rock.GetComponent<RockController>().isSick.ToString();
    }

   public void FeedRock()
    {
        Rock.GetComponent<RockController>().hunger += 2;
    }
    public void playwithrock()
    {
        Rock.GetComponent<RockController>().friendship += 2;
    }
    public void Vet()
    {
        Rock.GetComponent<RockController>().isSick = false;
    }
}
