using UnityEngine;

public class Doorboom : MonoBehaviour
{
    
      void OnMouseOver()
     {
        UIController.actionText = "Open Door";
        UIController.commandText= "Open";
        UIController.uiActive = true;
     }

     void OnMouseExit()
     {
        UIController.actionText = "";
        UIController.commandText= "";
        UIController.uiActive = false;
     }
    
 }
