using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private IItem item;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            item.OnItemPickedUp();
        }
    }
}
