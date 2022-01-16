using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSizeChanger : MonoBehaviour
{
    private float _elapsedTime;

    public RectTransform Target;

    public AnimationCurve SizeCurve;
    public Vector2 MinSize;
    public Vector2 MaxSize;
    public float Duration;

    
    void Update()
    {
        Target.sizeDelta = Vector2.Lerp(MinSize, MaxSize, SizeCurve.Evaluate(_elapsedTime / Duration));

        _elapsedTime += Time.deltaTime;
        if (_elapsedTime > Duration)
            _elapsedTime -= Duration;                
    }
}
