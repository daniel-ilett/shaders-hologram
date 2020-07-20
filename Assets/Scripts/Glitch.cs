using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch : MonoBehaviour
{
    private Material material;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;

        StartCoroutine(GlitchRoutine());
    }

    private IEnumerator GlitchRoutine()
    {
        while(true)
        {
            material.SetFloat("_GlitchStrength", 0.0f);
            material.SetFloat("_ScanlineOffset", 0.0f);
            yield return new WaitForSeconds(0.25f);

            material.SetFloat("_GlitchStrength", 0.15f);
            material.SetFloat("_ScanlineOffset", 0.5f);
            yield return new WaitForSeconds(0.25f);

            material.SetFloat("_GlitchStrength", 0.0f);
            material.SetFloat("_ScanlineOffset", 0.0f);
            yield return new WaitForSeconds(0.5f);

            material.SetFloat("_GlitchStrength", 0.1f);
            material.SetFloat("_ScanlineOffset", 0.5f);
            yield return new WaitForSeconds(0.1f);

            material.SetFloat("_GlitchStrength", 0.0f);
            material.SetFloat("_ScanlineOffset", 0.0f);
            yield return new WaitForSeconds(0.1f);

            material.SetFloat("_GlitchStrength", 0.05f);
            material.SetFloat("_ScanlineOffset", 0.5f);
            yield return new WaitForSeconds(0.1f);

            material.SetFloat("_GlitchStrength", 0.0f);
            material.SetFloat("_ScanlineOffset", 0.0f);
            yield return new WaitForSeconds(0.4f);

            material.SetFloat("_GlitchStrength", 0.1f);
            material.SetFloat("_ScanlineOffset", 0.5f);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
