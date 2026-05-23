using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlePickup : MonoBehaviour
{
    [SerializeField] bool canPick;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;


    void Update()
    {
        if (canPick == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                tableCandle.SetActive(false);
                handCandle.SetActive(true);
                
<<<<<<< HEAD
=======
                // Activate webEvent without pausing
                if (webEvent != null)
                {
                    Time.timeScale = 1f;
                    webEvent.SetActive(true);
                }
                
                return;
>>>>>>> 4f70f3897f3d3d9742e6c7234a85e0f6cc887f62
            }
        }
    }

    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
            canPick = true;
            UIController.actionText = "Candle";
            UIController.commandText = "Pick Up";
            UIController.uiActive = true;
        }
        else
        {
            canPick = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }
    }

    void OnMouseExit()
    {
        canPick = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
}