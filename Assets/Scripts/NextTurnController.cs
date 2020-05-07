using UnityEngine;
using UnityEngine.UI;

public class NextTurnController : MonoBehaviour
{
    public Button NextTurnButton;
    public Text GasValueText;
    public Text SupplyValueText;
    public GasComponent GasComponent;
    public SuppliesComponent SuppliesComponent;

    void Start()
    {
        NextTurnButton.onClick.AddListener(OnNextTurn);
        GasValueText.text = GasComponent.Amount.ToString();
        SupplyValueText.text = SuppliesComponent.Amount.ToString();
    }

    void OnNextTurn()
    {
        var gas = --GasComponent.Amount;
        var supplies = --SuppliesComponent.Amount;
        if (gas <= 0 || supplies <= 0)
        {
            Debug.Log("you ded");
            NextTurnButton.interactable = false;
        }

        GasValueText.text = gas.ToString();
        SupplyValueText.text = supplies.ToString();
    }
}
