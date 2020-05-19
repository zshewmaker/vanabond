using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
	public class BuySuppliesController : MonoBehaviour
	{
		public Button BuySuppliesButton;
		public Text MoneyText;
		public MoneyComponent MoneyComponent;
		public Text SuppliesText;
		public SuppliesComponent SuppliesComponent;

		void Start()
		{
			BuySuppliesButton.onClick.AddListener(OnBuySupplies);
		}

		void OnBuySupplies()
		{
			if (MoneyComponent.Amount <= 0)
			{
				return;
			}

			var money = --MoneyComponent.Amount;
			MoneyText.text = money.ToString();
			var supplies = ++SuppliesComponent.Amount;
			SuppliesText.text = supplies.ToString();
		}
	}
}
