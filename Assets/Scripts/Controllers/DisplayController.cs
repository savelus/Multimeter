using Data;
using UnityEngine;
using Views;

namespace Controllers
{
    public class DisplayController : MonoBehaviour
    {
        public DisplayMeasures displayMeasures;
    
        public void SetMeasuresView()
        {
            displayMeasures.voltageMeasure.text = Measures.Voltage.ToString("0.#");
            displayMeasures.resistanceMeasure.text = Measures.Resistance.ToString("0.#");
            displayMeasures.currentStrenghtMeasure.text = Measures.CurrentStrength.ToString("0.#");
            displayMeasures.alternatingCurrentMeasure.text = Measures.AlternativeCurrent.ToString("0.#");
        }
    
    }
}