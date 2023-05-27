using System;
using UnityEngine;

public class RegulatorController : MonoBehaviour
{
    public Regulator Regulator;
    private int _intCurrentState;
    private RegulatorCurrentState _currentState;
    private bool _onModeSelection;
    private void OnMouseEnter()
    {
        Regulator.Material.color = Color.blue;
        _onModeSelection = true;
        
    }

    private void OnMouseExit()
    {
        Regulator.Material.color = Color.white;
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
            _intCurrentState -= 1;
            if (_intCurrentState < 0) _intCurrentState = 4;
        }
        SetState(_intCurrentState);
    }
    private void SetState(int currentState)
    {
        var stateCursors = Regulator.StateCursors;
        for (int i = 0; i < stateCursors.Count; i++)
        {
            stateCursors[i].SetActive(i == currentState);
        }
    }

}