using Assets.Scripts.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NextTurnController : MonoBehaviour, IResettable
{
    public Button NextTurnButton;
    public Text GasValueText;
    public Text SupplyValueText;
    public GasComponent GasComponent;
    public SuppliesComponent SuppliesComponent;

    void Start()
    {
        NextTurnButton.onClick.AddListener(OnNextTurn);
    }

    void OnNextTurn()
    {
        var gas = --GasComponent.Amount;
        var supplies = --SuppliesComponent.Amount;
        if (gas <= 0 || supplies <= 0)
        {
            NextTurnButton.interactable = false;
        }

        GasValueText.text = gas.ToString();
        SupplyValueText.text = supplies.ToString();
    }

    public void Reset()
    {
        NextTurnButton.interactable = true;
    }
}
