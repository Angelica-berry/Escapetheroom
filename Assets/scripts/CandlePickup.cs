using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CandlePickup : MonoBehaviour
{
    [SerializeField] bool canPick = false;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;

    private void Update()
    {
        if (canPick && Input.GetKeyDown(KeyCode.E))
        {
            PickupCandle();
        }
    }

    private void PickupCandle()
    {
        // Disable collider so it can't be picked up again
        BoxCollider col = GetComponent<BoxCollider>();
        if (col != null)
            col.enabled = false;

        // Hide candle on table
        if (tableCandle != null)
            tableCandle.SetActive(false);

        // Show candle in hand
        if (handCandle != null)
            handCandle.SetActive(true);

        // Optional: hide interaction text
        if (textOnScreen != null)
            textOnScreen.SetActive(false);

        canPick = false;
    }

    // ========================
    // Mouse-based interaction (for desktop testing)
    // ========================
    private void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5f)
        {
            canPick = true;
            UIController.actionText = "Candle";
            UIController.commandText = "Pick Up";
            UIController.uiActive = true;
        }
        else
        {
            canPick = false;
            ClearUI();
        }
    }

    private void OnMouseExit()
    {
        canPick = false;
        ClearUI();
    }

    private void ClearUI()
    {
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
}