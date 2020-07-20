using Assets.Scripts.Interfaces;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResetGameController : MonoBehaviour
{
    public Button ResetGameButton;
    public VanComponent Van;

    void Start()
    {
        ResetGameButton.onClick.AddListener(OnResetGame);
    }

    private void OnResetGame()
    {
        Van.ResetResourcesToDefault();

        var resettables = FindObjectsOfType<MonoBehaviour>().OfType<IResettable>();
        foreach (var resettable in resettables)
        {
            resettable.Reset();
        }
    }
}
