using TMPro;
using UnityEngine;

public class MultimeterManager : MonoBehaviour
{
    public RegulatorController regulatorController;
    public DisplayController displayController;
    public TMP_Text displayText;
    private CalculationSystem _calculationSystem = new();

    private void Awake()
    {
        
        regulatorController.OnStateChange += _calculationSystem.Calculate;
        regulatorController.OnStateChange += ChangeDisplayView;
        regulatorController.OnStateChange += ChangeDisplayText;
    }

    private void ChangeDisplayView()
    {
        displayController.SetMeasuresView();
    }

    private void ChangeDisplayText()
    {
        switch (regulatorController.GetCurrentState)
        {
            case RegulatorCurrentState.ResistanceState:
                displayText.text = Measures.Resistance.ToString("0.#");
                break;
            case RegulatorCurrentState.VoltageState:
                displayText.text = Measures.Voltage.ToString("0.#");
                break;
            case RegulatorCurrentState.CurrentStrengthState:
                displayText.text = Measures.CurrentStrength.ToString("0.#");
                break;
            case RegulatorCurrentState.AlternatingCurrentState:
                displayText.text = Measures.AlternativeCurrent.ToString("0.#");
                break;
            default:
                displayText.text = "0";
                break;
        }
    }
    
    
}
