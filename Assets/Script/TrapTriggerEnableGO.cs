using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTriggerEnableGO : MonoBehaviour
{
    public GameObject targetGO;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            targetGO.SetActive(true);
        }
    }
}
