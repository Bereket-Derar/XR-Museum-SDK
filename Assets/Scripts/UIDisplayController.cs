using System.Collections;
using UnityEngine;
public class UIDisplayController : MonoBehaviour
{
   
    public GameObject uiElement;
    void Awake()
    {
       
        uiElement.SetActive(true);
        
        StartCoroutine(DisableUIAfterTime(35f));
    }
   
    IEnumerator DisableUIAfterTime(float delay)
    {
       
        yield return new WaitForSeconds(delay);
     
        uiElement.SetActive(false);
    }
}








