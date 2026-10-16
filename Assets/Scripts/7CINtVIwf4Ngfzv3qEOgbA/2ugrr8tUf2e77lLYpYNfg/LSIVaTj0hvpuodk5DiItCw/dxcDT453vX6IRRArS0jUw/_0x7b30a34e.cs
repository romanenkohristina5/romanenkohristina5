using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x7b30a34e : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x7267b4eb.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x7267b4eb.Instance.LoadSceneByIndex(this.LoadSceneId));
    }
}