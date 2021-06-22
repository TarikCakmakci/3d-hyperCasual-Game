using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplama : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cicek")
        {
            Destroy(other.gameObject);
        }
    }
}
