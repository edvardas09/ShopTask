using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainShopBTNs : MonoBehaviour
{
    public GameObject ArmorMenu;
    public GameObject HelmetsMenu;

    private bool ArmorFirst = true;
    private bool HelmetsFirst = true;

    public void OpenArmor()
    {
        HelmetsMenu.SetActive(false);
        ArmorMenu.SetActive(true);

        if (ArmorFirst)
        {
            ArmorFirst = false;
            Button item = ArmorMenu.GetComponentInChildren<Button>(true);
            int down = 0;

            for (int i = 0; i < ClothesDB.Item_ID.Length; i++)
            {
                if (ClothesDB.Item_Name[i] == null)
                {
                    break;
                }
                if (ClothesDB.Item_Name[i] == "body")
                {
                    Button item_clone = Instantiate(item);
                    item_clone.image.sprite = ClothesDB.Image[i];
                    item_clone.transform.parent = item.transform.parent;
                    item_clone.transform.localScale = item.transform.localScale;
                    item_clone.name = ClothesDB.Item_ID[i].ToString();
                    item_clone.GetComponentInChildren<Text>().text = ClothesDB.Price[i].ToString();

                    if (ClothesDB.Purchased[i] == false)
                        item_clone.gameObject.transform.Find("Button").GetComponentInChildren<Text>().text = "Buy";


                    else if (ClothesDB.Equipped[i] == false)
                        item_clone.gameObject.transform.Find("Button").GetComponentInChildren<Text>().text = "Equip";

                    else
                        item_clone.gameObject.transform.Find("Button").GetComponentInChildren<Text>().text = "Remove";

                    item_clone.gameObject.SetActive(true);
                    down++;
                }
            }
        }
    }


    public void OpenHelmets()
    {       
        ArmorMenu.SetActive(false);
        HelmetsMenu.SetActive(true);

        if (HelmetsFirst)
        {
            HelmetsFirst = false;
            Button item = HelmetsMenu.GetComponentInChildren<Button>(true);
            int down = 0;

            for (int i = 0; i < ClothesDB.Item_ID.Length; i++)
            {
                if (ClothesDB.Item_Name[i] == null)
                {
                    break;
                }
                if (ClothesDB.Item_Name[i] == "helmet")
                {
                    Button item_clone = Instantiate(item);
                    item_clone.image.sprite = ClothesDB.Image[i];
                    item_clone.transform.parent = item.transform.parent;
                    item_clone.transform.localScale = item.transform.localScale;
                    item_clone.name = ClothesDB.Item_ID[i].ToString();
                    item_clone.GetComponentInChildren<Text>().text = ClothesDB.Price[i].ToString();

                    if (ClothesDB.Purchased[i] == false)
                        item_clone.gameObject.transform.Find("Button").GetComponentInChildren<Text>().text = "Buy";


                    else if (ClothesDB.Equipped[i] == false)
                        item_clone.gameObject.transform.Find("Button").GetComponentInChildren<Text>().text = "Equip";

                    else
                        item_clone.gameObject.transform.Find("Button").GetComponentInChildren<Text>().text = "Remove";

                    item_clone.gameObject.SetActive(true);
                    down++;
                }
            }
        }
    }
}
