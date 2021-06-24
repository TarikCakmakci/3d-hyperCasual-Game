using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplama : MonoBehaviour
{
    public Text t1,t2,t3,t4;
    float say1,say2,say3,say4 = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mor")
        {
            Destroy(other.gameObject);
            say1++;
            t1.text = say1.ToString();
        }
        if (other.gameObject.tag == "beyaz")
        {
            Destroy(other.gameObject);
            say2++;
            t2.text = say2.ToString();
        }
        if (other.gameObject.tag == "kirmizi")
        {
            Destroy(other.gameObject);
            say3++;
            t3.text = say3.ToString();
        }
        if (other.gameObject.tag == "sari")
        {
            Destroy(other.gameObject);
            say4++;
            t4.text = say4.ToString();
        }
    }
}
