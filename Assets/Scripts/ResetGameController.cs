using Assets.Scripts.Interfaces;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResetGameController : MonoBehaviour
{
    public Button ResetGameButton;
    public Text GasValueText;
    public Text SupplyValueText;
    public GasComponent GasComponent;
    public SuppliesComponent SuppliesComponent;

    // Start is called before the first frame update
    void Start()
    {
        ResetGameButton.onClick.AddListener(OnResetGame);
        OnResetGame();
    }

    private void OnResetGame()
    {
        GasValueText.text = GasComponent.DefaultAmount.ToString();
        SupplyValueText.text = SuppliesComponent.DefaultAmount.ToString();

        var resettableObj = FindObjectsOfType<MonoBehaviour>().OfType<IResettable>();
        foreach(var obj in resettableObj)
        {
            obj.Reset();
        }
    }
}
