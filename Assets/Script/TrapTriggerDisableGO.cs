using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTriggerDisableGO : MonoBehaviour
{
    public GameObject targetGO;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            targetGO.SetActive(false);
        }
    }
}
