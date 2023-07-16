using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendShapeTrigger : MonoBehaviour
{
    [Tooltip("Used solely for the developer, to differentiate multiple triggers on one object")]
    public string title = "New Blend Shape Trigger";

    [Tooltip("The mesh with the blend shapes to be affected")]
    public SkinnedMeshRenderer targetMesh;

    [Tooltip("The array Index of the blend shape")]
    public int shapeIndex = 1;
    [Tooltip("The minimum value of the blend shape, even though the inspector sliders go from 0 to 100, it will still blend shape keys from -1000 to 1000 or as far as you want")]
    public int shapeMinWeight = 0;
    [Tooltip("The maximum value of the blend shape, even though the inspector sliders go from 0 to 100, it will still blend shape keys from -1000 to 1000 or as far as you want")]
    public int shapeMaxWeight = 100;

    [Tooltip("Repeat this trigger on a timer")]
    public bool useTimer = false;
    [Tooltip("Add a time variant to give the trigger an offbeat or random effect")]
    public bool useTimerVariation = false;
    [Tooltip("Average time between triggers")]
    public float shapeTimer = 3.0f;
    [Tooltip("How fast to blend the minimum value to max value, and vice versa")]
    public float blendSpeed = 1600.0f;

    //Internal bool used to check if the shape key should be blending to maximum or minimum value
    bool blend = false;

    void Awake()
    {
        if (targetMesh == null)
            targetMesh = GetComponent<SkinnedMeshRenderer>();

        targetMesh.SetBlendShapeWeight(shapeIndex, shapeMinWeight);

        blend = false;

        if (useTimer)
            StartCoroutine(BlendTimerA());
    }

    IEnumerator BlendTimerA()
    {
        yield return new WaitForSeconds(shapeTimer);

        BlendA(useTimer);
    }
    IEnumerator BlendTimerB()
    {
        yield return new WaitForSeconds(shapeTimer * 0.25f);

        BlendB(useTimer);
    }
    public void BlendA(bool repeat)
    {
        blend = true;

        if (repeat)
        {
            int index = Random.Range(0, 3);

            if (index != 0)
            {
                StartCoroutine(BlendTimerA());
            }
            else
            {
                StartCoroutine(BlendTimerB());
            }
        }
    }
    public void BlendB(bool repeat)
    {
        blend = true;

        if (repeat)
        {
            StartCoroutine(BlendTimerA());
        }
    }
    void Update()
    {
        if (blend)
        {
            targetMesh.SetBlendShapeWeight(shapeIndex, targetMesh.GetBlendShapeWeight(shapeIndex) + blendSpeed * Time.deltaTime);

            if (targetMesh.GetBlendShapeWeight(shapeIndex) >= shapeMaxWeight)
            {
                targetMesh.SetBlendShapeWeight(shapeIndex, shapeMaxWeight);

                blend = false;
            }
        }
        else
        {
            if (targetMesh.GetBlendShapeWeight(shapeIndex) > shapeMinWeight)
            {
                targetMesh.SetBlendShapeWeight(shapeIndex, targetMesh.GetBlendShapeWeight(shapeIndex) - blendSpeed * Time.deltaTime);
            }
            else
            {
                if (targetMesh.GetBlendShapeWeight(shapeIndex) <= shapeMinWeight)
                    targetMesh.SetBlendShapeWeight(shapeIndex, shapeMinWeight);
            }
        }
    }
}
