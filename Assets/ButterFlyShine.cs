using UnityEngine;

public class ButterflyShine : MonoBehaviour
{
    public Material butterflyMaterial;
    public float minEmission = 1f;
    public float maxEmission = 5f;
    public float pulseSpeed = 2f;

    void Update()
    {
        float emission = minEmission + Mathf.PingPong(Time.time * pulseSpeed, maxEmission - minEmission);
        butterflyMaterial.SetColor("_EmissionColor", butterflyMaterial.color * emission);
    }
}
