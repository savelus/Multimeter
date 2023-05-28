using Data;
using UnityEngine;

namespace Controllers
{
    public class CalculationSystem
    {
        public void Calculate()
        {
            var power = Measures.Power;
            var resistance = Measures.Resistance;

            Measures.Voltage = GetVoltage(power, resistance);
            Measures.CurrentStrength = GetCurrentStrength(power, resistance);
        }

        private float GetVoltage(float power, float resistance) => Mathf.Sqrt(power * resistance);
        private float GetCurrentStrength(float power, float resistance) => Mathf.Sqrt(power / resistance);
    }
}