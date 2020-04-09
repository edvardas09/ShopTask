using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Shoping : MonoBehaviour
{
    public Text money;
    public GameObject head;
    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        money.text = "Money: " + ClothesDB.money.ToString();
    }

    public void UseItem()
    {
        GameObject pressedButton = EventSystem.current.currentSelectedGameObject;
        int id = int.Parse(pressedButton.transform.parent.name);

        if(ClothesDB.Purchased[id] == false)
        {
            if (ClothesDB.Price[id] <= ClothesDB.money)
            {
                ClothesDB.money -= ClothesDB.Price[id];
                ClothesDB.Purchased[id] = true;
                pressedButton.GetComponentInChildren<Text>().text = "Equip";
                money.text = "Money: " + ClothesDB.money.ToString();
            }
            else
                StartCoroutine(InsufficentMoney());
        }

        else if(ClothesDB.Purchased[id] == true && ClothesDB.Equipped[id] == false)
        {
            if(ClothesDB.Item_Name[id] == "body")
            {
                body.GetComponent<SpriteRenderer>().sprite = ClothesDB.Image[id];
            }
            else
                head.GetComponent<SpriteRenderer>().sprite = ClothesDB.Image[id];

            pressedButton.GetComponentInChildren<Text>().text = "Remove";
            ClothesDB.Equipped[id] = true;
        }

        else
        {
            if (ClothesDB.Item_Name[id] == "body")
            {
                body.GetComponent<SpriteRenderer>().sprite = null;
            }
            else
                head.GetComponent<SpriteRenderer>().sprite = null;

            pressedButton.GetComponentInChildren<Text>().text = "Equip";
            ClothesDB.Equipped[id] = false;
        }
    }

    IEnumerator InsufficentMoney()
    {
        money.color = Color.red;
        yield return new WaitForSeconds(2);
        money.color = Color.white;
    }
}
