using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateClothes : MonoBehaviour
{
    public int id = 0;
    // Start is called before the first frame update
    void Start()
    {
        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 300;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_2/PNG/Front/Body_clothes");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 300;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_2/PNG/Back/Body_clothes");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 100;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_1/PNG/Front/Body_clothes");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 100;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_1/PNG/Back/Body_clothes");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 20;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-891167-blacksmith-herbalist-hunter-jeweler-free-npc-character-pack/Herbalist/PNG/Vector Parts/Body");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 30;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-891167-blacksmith-herbalist-hunter-jeweler-free-npc-character-pack/Jeweler/PNG/Vector Parts/Body");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 50;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-891167-blacksmith-herbalist-hunter-jeweler-free-npc-character-pack/Blacksmith/PNG/Vector Parts/Body");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "body";
        ClothesDB.Price[id] = 70;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-891167-blacksmith-herbalist-hunter-jeweler-free-npc-character-pack/Hunter/PNG/Vector Parts/Body");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "helmet";
        ClothesDB.Price[id] = 100;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_1/PNG/Front/Hat");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "helmet";
        ClothesDB.Price[id] = 100;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_1/PNG/Back/Hat");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "helmet";
        ClothesDB.Price[id] = 100;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_1/PNG/Left_Side/Hat");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "helmet";
        ClothesDB.Price[id] = 100;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_1/PNG/Right_Side/Hat");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

        ClothesDB.Item_ID[id] = id;
        ClothesDB.Item_Name[id] = "helmet";
        ClothesDB.Price[id] = 300;
        ClothesDB.Image[id] = Resources.Load<Sprite>("craftpix-901123-free-warrior-4-direction-character-sprites/Warrior_clothes_2/PNG/Front/Hat");
        ClothesDB.Purchased[id] = false;
        ClothesDB.Equipped[id] = false;
        id++;

    }


}
