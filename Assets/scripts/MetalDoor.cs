using UnityEngine;

public class MetalDoor : MonoBehaviour
{
    
      void OnMouseOver()
     {
       if(PlayerCasting.distanceFromTarget < 3)
        UIController.actionText = "Open Door";
        UIController.commandText= "Open";
        UIController.uiActive = true;
     }
    else
    {
       
        UIController.actionText = "";
        UIController.commandText= "";
        UIController.uiActive = false;
    }
     void OnMouseExit()
     {
        UIController.actionText = "";
        UIController.commandText= "";
        UIController.uiActive = false;
     }
    
 }
