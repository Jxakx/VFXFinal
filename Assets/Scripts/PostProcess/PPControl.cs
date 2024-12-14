using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PPControl : MonoBehaviour
{
    [SerializeField] private Material _PPExtraTimeMaterial;
    [SerializeField] private Material _PPFuriaMaterial;
    [SerializeField] private bool _IsOn;
    [SerializeField] private bool _IsOnFuria;
    public ParticleSystem psPolvo1;
    public ParticleSystem psPolvo2;
    public ParticleSystem psPolvo3;
    public ParticleSystem psPolvo4;
    public ParticleSystem psPolvo5;
    public ParticleSystem psPolvo6;
    public ParticleSystem psHumo1;
    public ParticleSystem psHumo2;
    public ParticleSystem psHumo3;

    private void Start()
    {
        psPolvo1.Stop();
        psPolvo2.Stop();
        psPolvo3.Stop();
        psPolvo4.Stop();
        psPolvo5.Stop();
        psPolvo6.Stop();
        psHumo1.Stop();
        psHumo2.Stop();
        psHumo3.Stop();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TurnOnOffET();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            TurnOnOffFuria();
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

    public void TurnOnOffFuria()
    {
        if (_IsOnFuria)
        {
            _PPFuriaMaterial.SetFloat("_PPIntensidad", 0f);
            _PPFuriaMaterial.SetFloat("_Emissive", 0f);
            _IsOnFuria = false;
            psPolvo1.Stop();
            psPolvo2.Stop();
            psPolvo3.Stop();
            psPolvo4.Stop();
            psPolvo5.Stop();
            psPolvo6.Stop();
            psHumo1.Stop();
            psHumo2.Stop();
            psHumo3.Stop();

        }
        else
        {
            _PPFuriaMaterial.SetFloat("_PPIntensidad", 0.85f);
            _PPFuriaMaterial.SetFloat("_Emissive", 4f);
            _IsOnFuria = true;
            
            psPolvo1.Play();
            psPolvo2.Play();
            psPolvo3.Play();
            psPolvo4.Play();
            psPolvo5.Play();
            psPolvo6.Play();
            psHumo1.Play();
            psHumo2.Play();
            psHumo3.Play();
        }
    }
}
