using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemImage;
    public GameObject Slots;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (inventory.isFull[0] == true)
            {
                
                Debug.Log("Count: " + Slots.transform.childCount);
                foreach (Transform child in Slots.transform)
                {
                    Debug.Log("1");
                    child.GetComponent<Spawn>().SpawnItem();
                    GameObject.Destroy(child.gameObject);
                }
                inventory.isFull[0] = false;
                Debug.Log("2");
            }
        }
    }

    

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemImage, inventory.slots[i].transform.transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
