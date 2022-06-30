using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    private Transform ParentItem;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ParentItem = GameObject.FindGameObjectWithTag("ItemParent").transform;
    }

    public void SpawnItem()
    {
        Debug.Log("(Spawning Item)");
        Vector3 playerPos = new Vector3(player.position.x, player.position.y, player.position.z);
        Instantiate(item, playerPos, Quaternion.identity, ParentItem);       

    }
}
