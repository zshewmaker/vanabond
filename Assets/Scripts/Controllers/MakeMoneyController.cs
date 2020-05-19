using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
	public class MakeMoneyController : MonoBehaviour
	{
		public Button MakeMoneyButton;
		public Text MoneyText;
		public MoneyComponent MoneyComponent;

		void Start()
		{
			MakeMoneyButton.onClick.AddListener(OnNextTurn);
		}

		void OnNextTurn()
		{
			var money = ++MoneyComponent.Amount;
			MoneyText.text = money.ToString();
		}
	}
}
