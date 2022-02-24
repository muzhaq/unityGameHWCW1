using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeObstacle : MonoBehaviour
{
    private float _currentScale = InitScale;
    [SerializeField]
    public const float TargetScale = 6f;
    [SerializeField]
    public const float InitScale = 1f;
    [SerializeField]
    public const int FramesCount = 100;
    [SerializeField]
    public const float AnimationTimeSeconds = 1;
    private float _deltaTime = AnimationTimeSeconds / FramesCount;
    private float _dx = (TargetScale - InitScale) / FramesCount;
    public bool _upScale = true;
    private IEnumerator Breath()
    {
        while (true)
        {
            while (_upScale)
            {
                _currentScale += _dx;
                if (_currentScale > TargetScale)
                {
                    _upScale = false;
                    _currentScale = TargetScale;
                }
                transform.localScale = Vector3.one * _currentScale;
                yield return new WaitForSeconds( _deltaTime );
            }

            while (!_upScale)
            {
                _currentScale -= _dx;
                if (_currentScale < InitScale)
                {
                    _upScale = true;
                    _currentScale = InitScale;
                }
                transform.localScale = Vector3.one * _currentScale;
                yield return new WaitForSeconds( _deltaTime );
            }
        }
    }
    private void Start()
    {
        StartCoroutine( Breath() );
    }

}
