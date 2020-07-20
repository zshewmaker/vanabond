using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NextTurnController : MonoBehaviour, IResettable
{
    public Button NextTurnButton;
    public VanComponent Van;

    void Start()
    {
        NextTurnButton.onClick.AddListener(OnNextTurn);
    }

    void OnNextTurn()
    {
        Van.DecreaseResource("gas", 10);
        Van.DecreaseResource("supplies", 2);
        if (Van.GetResource("gas").Value <= 0 || Van.GetResource("supplies").Value <= 0)
        {
            NextTurnButton.interactable = false;
        }
    }

    public void Reset()
    {
        NextTurnButton.interactable = true;
    }
}
