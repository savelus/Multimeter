using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class DisplayController : MonoBehaviour
{
    public DisplayMeasures displayMeasures;
    
    public void SetMeasuresView()
    {
        displayMeasures.VoltageMeasure.text = Measures.Voltage.ToString("0.00");
        displayMeasures.ResistanceMeasure.text = Measures.Resistance.ToString("0.00");
        displayMeasures.CurrentStrenghtMeasure.text = Measures.CurrentStrength.ToString("0.00");
        displayMeasures.AlternatingCurrentMeasure.text = Measures.AlternativeCurrent.ToString("0.00");
    }
    
}