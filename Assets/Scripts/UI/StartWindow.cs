using System.Collections;
using System.Collections.Generic;
using CookingPrototype.Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace CookingPrototype.UI {
	public class StartWindow : MonoBehaviour {
		public TMP_Text GoalText = null;
		public Button OkButton = null;
		public GameObject IngameGoalInfo = null;

		bool _isInit = false;
		
		void Init()
		{
			var gc = GameplayController.Instance;

			OkButton.onClick.AddListener(gc.StartGame);
		}

		public void UpdateGoalText() {
			GoalText.text = $"{GameplayController.Instance.OrdersTarget}";
		}

		public void Show () {
			if ( !_isInit ) {
				Init();
			}

			var gc = GameplayController.Instance;

			UpdateGoalText();
			gameObject.SetActive(true);
			IngameGoalInfo.SetActive(false);
		}

		public void Hide() {
			gameObject.SetActive(false);
			IngameGoalInfo.SetActive(true);
		}
	}
}
