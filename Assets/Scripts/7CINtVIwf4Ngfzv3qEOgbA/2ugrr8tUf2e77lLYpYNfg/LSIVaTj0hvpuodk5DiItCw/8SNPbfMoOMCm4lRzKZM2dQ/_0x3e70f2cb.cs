using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x3e70f2cb : MonoBehaviour
{
    public static void HideAllPops()
    {
        _0x0e2f9237.Instance._0x60ef6ae8();
    }

    public bool IsScaledDownOnAwake = true;
    public Image ContentImage;
    public TMP_Text ContentHeaderText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x6f5b8daa();
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    public bool IsOnlyYScale;
    private void _0x6f5b8daa()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentMainText;
    private bool _0x1d9c9eef => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public float scaleDuration = 0.4f;
    public void _0xec0fd8cf()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public Ease ease = Ease.OutSine;
    public GameObject Content;
}