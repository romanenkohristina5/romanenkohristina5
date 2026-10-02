using UnityEngine;
using UnityEngine.UI;

public class _0x943c6c4c : MonoBehaviour
{
    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public Button Button;
    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x0e2f9237.Instance._0xface4a02();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x0e2f9237.Instance._0x60ef6ae8());
        else
            this.Button.onClick.AddListener(() => _0x0e2f9237.Instance._0xa4c53cf2(this.PopToShowIndex));
    }
}