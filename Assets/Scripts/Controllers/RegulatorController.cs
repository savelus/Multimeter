using System;
using System.Collections.Generic;
using Data;
using UnityEngine;
using Views;

namespace Controllers
{
    public class RegulatorController : MonoBehaviour
    {
        public Action OnStateChange;
        public Regulator regulator;
    
        private int _intCurrentState;
        private bool _onModeSelection;
        private List<GameObject> _stateCursors;
        public RegulatorCurrentState GetCurrentState => (RegulatorCurrentState)_intCurrentState;
    

        private void Awake()
        {
            _stateCursors = regulator.stateCursors;
        }
        private void OnMouseEnter()
        {
            regulator.material.color = Color.blue;
            _onModeSelection = true;
        }

        private void OnMouseExit()
        {
            regulator.material.color = Color.white;
            _onModeSelection = false;
        }

        private void OnMouseOver()
        {
            var currentMouseWheel = Input.GetAxis("Mouse ScrollWheel");
            if(currentMouseWheel == 0 ) return;
            SetNewCurrentState(currentMouseWheel);
        }

        private void SetNewCurrentState(float currentMouseWheel)
        {
            if (currentMouseWheel > 0)
            {
                _intCurrentState = (_intCurrentState + 1) % 5;
            }
            else
            {
                _intCurrentState = (_intCurrentState + 4) % 5;
            }
            SetState(_intCurrentState);
        
            OnStateChange?.Invoke();
        }
        private void SetState(int currentState)
        {
            for (int i = 0; i < _stateCursors.Count; i++)
            {
                _stateCursors[i].SetActive(i == currentState);
            }
        }

    }
}