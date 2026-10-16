using UnityEngine;
using UnityEngine.UI;

public class _0x7ed6a501 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x7267b4eb.Instance._0x6ddc7496(this.IsPhysicsRunOnClick));
    }
}