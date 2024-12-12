using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPControl : MonoBehaviour
{
    [SerializeField] private Material _PPExtraTimeMaterial;
    [SerializeField] private bool _IsOn;
    [SerializeField] private bool _IsOnOutline;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TurnOnOffET();
        }
    }

    public void TurnOnOffET()
    {
        if (_IsOn)
        {
            _PPExtraTimeMaterial.SetFloat("_PP_Intensity", 0f);
            _IsOn = false;
        }
        else
        {
            _PPExtraTimeMaterial.SetFloat("_PP_Intensity", 1);
            _IsOn = true;
        }
    }
}
