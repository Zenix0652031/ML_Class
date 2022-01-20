using UnityEngine;
using UnityEngine.UI;

namespace ArtificialTankDriver
{
	public class UIController : MonoBehaviour {

		public Text label;
		public Image bar;
		public WorldController controller;

		private void Update () {
			label.text = $"Epoch : {controller.epoch}";
			bar.fillAmount = (float)controller.currentStepsInEpoch / controller.totalStepsPerEpoch;
		}
	}
}

