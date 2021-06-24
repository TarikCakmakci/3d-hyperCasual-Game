using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtySystem : MonoBehaviour
{
    
    public GameObject dusman;
    private bool olum;
    public Image kalp1,kalp2,kalp3;
    public float can = 3;
    
    void Update()
    {
        if (olum == true)
        {
            Debug.Log("Öldünüz");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "dusman")
        {
            Destroy(other.gameObject);
            switch (can)
            {
                case 1:
                    can--;
                    Destroy(kalp3);
                    olum = true;
                    break;
                case 2:
                    can--;
                    Destroy(kalp2);
                    break;
                case 3:
                    can--;
                    Destroy(kalp1);
                    break;


           
                }
            }
        }
        
    }

