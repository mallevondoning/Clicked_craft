using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<ItemData> ItemIDList = new List<ItemData>();

    private void Awake()
    {
        int ItemIDLength = System.Enum.GetNames(typeof(ItemID)).Length;

        for (int i = 1; i < ItemIDLength ; i++)
        {
            ItemData tempItemData = new ItemData();

            tempItemData.ItemID = (ItemID)i;
            tempItemData.Amount = 0;

            ItemIDList.Add(tempItemData);
        }
    }
}
