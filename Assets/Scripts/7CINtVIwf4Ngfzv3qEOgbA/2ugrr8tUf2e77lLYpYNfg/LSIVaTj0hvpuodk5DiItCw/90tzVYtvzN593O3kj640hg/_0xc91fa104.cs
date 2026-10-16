using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xc91fa104 : MonoBehaviour
{
    public void Show()
    {
        this._0xa100eca9();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x9ae3504d.Instance._0xd037a24f(_0x9ae3504d.Instance.CurrentPanelIndex);
            });
        }
    }

    public bool IsScaledDownOnAwake = true;
    public void _0x3cbfe248()
    {
        this._0xea0c84b9();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0xa100eca9()
    {
        if (this.OuterBackground != null)
        {
            Image _0xaf68de2f = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xaf68de2f, true);
            _0xaf68de2f.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public GameObject Content;
    public TMP_Text MainText;
    private void _0x4e570155()
    {
        if (this.OuterBackground != null)
        {
            Image _0xb3e18fa7 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xb3e18fa7, true);
            _0xb3e18fa7.DOFade(1f, 0f);
        }
    }

    public GameObject OuterBackground;
    public void _0x35597722()
    {
        this._0x4e570155();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x9ae3504d.Instance._0xd037a24f(_0x9ae3504d.Instance.CurrentPanelIndex);
    }

    public Ease Ease = Ease.OutSine;
    private void _0xea0c84b9()
    {
        if (this.OuterBackground != null)
        {
            Image _0x82f5510f = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x82f5510f, true);
            _0x82f5510f.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x65d493a4()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd95d7009 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd95d7009, true);
            _0xd95d7009.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private bool _0x8cc77569 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public float ScaleDuration = 0.4f;
    public TMP_Text HeaderText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x65d493a4();
    }
}