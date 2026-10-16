using UnityEngine;

// Spawning helpers for the world-space art of the shaft. Every prefab under
// Assets/Prefabs/Generated ships Sliced with a real m_Size, so the size handed in here
// is the single source of truth and the sprite's native pixel size never leaks in.
public static class _0x4051eae7
{
    public static SpriteRenderer Spawn(GameObject _0x5465ea27, Transform _0xe698b9f6, Vector3 _0x4aa3c4b7, Vector2 _0xfdc7b00b, int _0x316d6154, Color _0xfa490c54)
    {
        if (_0x5465ea27 == null)
        {
            return null;
        }

        GameObject _0xb97c944a = Object.Instantiate(_0x5465ea27, _0xe698b9f6);
        _0xb97c944a.transform.localPosition = _0x4aa3c4b7;
        _0xb97c944a.transform.localRotation = Quaternion.identity;
        _0xb97c944a.transform.localScale = Vector3.one;
        SpriteRenderer _0x38087556 = _0xb97c944a.GetComponent<SpriteRenderer>();
        if (_0x38087556 != null)
        {
            _0x38087556.drawMode = SpriteDrawMode.Sliced;
            _0x38087556.size = _0xfdc7b00b;
            _0x38087556.sortingOrder = _0x316d6154;
            _0x38087556.color = _0xfa490c54;
        }

        return _0x38087556;
    }

    public static void Resize(SpriteRenderer _0xf7d3ea9e, Vector2 _0xffdc9b0c)
    {
        if (_0xf7d3ea9e != null)
        {
            _0xf7d3ea9e.size = _0xffdc9b0c;
        }
    }

    public static void MoveXY(Transform _0x247b17d1, float _0xa5c9013d, float _0x4df60245)
    {
        if (_0x247b17d1 != null)
        {
            Vector3 _0x4262f958 = _0x247b17d1.localPosition;
            _0x247b17d1.localPosition = new Vector3(_0xa5c9013d, _0x4df60245, _0x4262f958.z);
        }
    }

    public static void MoveY(Transform _0x9474f2b1, float _0x2dff93eb)
    {
        if (_0x9474f2b1 != null)
        {
            Vector3 _0x5f61fbc2 = _0x9474f2b1.localPosition;
            _0x9474f2b1.localPosition = new Vector3(_0x5f61fbc2.x, _0x2dff93eb, _0x5f61fbc2.z);
        }
    }

    public static void SetAlpha(SpriteRenderer _0x325c3eb9, float _0x7558a673)
    {
        if (_0x325c3eb9 != null)
        {
            Color _0xd8428b1a = _0x325c3eb9.color;
            _0x325c3eb9.color = new Color(_0xd8428b1a.r, _0xd8428b1a.g, _0xd8428b1a.b, _0x7558a673);
        }
    }
}