using UnityEngine;
using DG.Tweening;

public class Wood : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer _skinnedMeshRenderer;
    [SerializeField] private Transform _woodTransfrom;
    [SerializeField] private Vector3 _rotationVector;
    [SerializeField] private float _rotationDuration;

    private void Start()
    {
        _woodTransfrom
            .DOLocalRotate(_rotationVector, _rotationDuration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.Linear);
    }

    public void Hit(int keyIndex, float damage)
    {
        float colliderHeight = 2.36f;
        float newWight = _skinnedMeshRenderer.GetBlendShapeWeight(keyIndex) + damage *(100f / colliderHeight);
        _skinnedMeshRenderer.SetBlendShapeWeight(keyIndex, newWight);
    }
}
