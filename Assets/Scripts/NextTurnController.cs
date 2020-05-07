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
    }

    void OnNextTurn()
    {
        GasComponent.Amount--;
        SuppliesComponent.Amount--;
        GasValueText.text = GasComponent.Amount.ToString();
        SupplyValueText.text = SuppliesComponent.Amount.ToString();
    }
}
