using UnityEngine;
using UnityEngine.UI;

public class _0x57e48183 : MonoBehaviour
{
    private int _0xc428fa43;
    private bool _0x982f152a;
    private void Awake()
    {
        if (this._0x7308a95b == null)
            if (!this.TryGetComponent(out this._0x7308a95b))
                this._0x7308a95b = this.GetComponentInChildren<Button>();
    }

    private Button _0x7308a95b;
    private void Start()
    {
        if (this._0x982f152a)
            this._0x7308a95b.onClick.AddListener(() => _0x9ae3504d.Instance._0x2e52709f());
        else
            this._0x7308a95b.onClick.AddListener(() => _0x9ae3504d.Instance._0xdb936680(this._0xc428fa43));
    }
}