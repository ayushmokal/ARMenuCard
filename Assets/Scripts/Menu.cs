using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] food;
    public Text price;
   

    public void openPizza()
    {
      for (int i=0; i< food.Length; i++)
      {
        food[i].gameObject.SetActive(false);
      }
      food[0].gameObject.SetActive(true);
      price.text = "Price: 230rs";
    }

    public void openChicken()
    {
       for (int i=0; i< food.Length; i++)
      {
        food[i].gameObject.SetActive(false);
      }
      food[1].gameObject.SetActive(true);
      price.text = "Price: 300rs";
    }

     public void openCoffee()
    {
       for (int i=0; i< food.Length; i++)
      {
        food[i].gameObject.SetActive(false);
      }
      food[2].gameObject.SetActive(true);
      price.text = "Price: 430rs";
    }


     public void openCombo()
    {
       for (int i=0; i< food.Length; i++)
      {
        food[i].gameObject.SetActive(false);
      }
      food[3].gameObject.SetActive(true);
      price.text = "Price: 90rs";
    }
}

