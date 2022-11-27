using UnityEngine;

public class Coll : MonoBehaviour
{
    public int index;

    private BoxCollider _boxCollider;

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
        index = transform.GetSiblingIndex();
    }

    public void HitCollider(float damage)
    {
        float result = _boxCollider.size.y - damage;
        if (result > 0.0f)
            _boxCollider.size = new Vector3(_boxCollider.size.x, _boxCollider.size.y - damage, _boxCollider.size.z);
        else
            Destroy(this.gameObject);
    }

}
