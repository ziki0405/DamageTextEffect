using UnityEngine;
using TMPro;

public class DamageTextEffect : MonoBehaviour
{
    public float floatDistance = 30f; // 上升像素
    public float duration = 1.0f;     // 总时长
    public float fadeInTime = 0.15f;  // 淡入时长
    public float fadeOutTime = 0.2f;  // 淡出时长

    private TextMeshProUGUI text;
    private Vector3 startPos;
    private Vector3 endPos;
    private float timer = 0f;

    void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        startPos = transform.position;
        endPos = startPos + Vector3.up * floatDistance;
        SetAlpha(0f);
    }

    void Update()
    {
        timer += Time.deltaTime;
        float t = timer / duration;

        // 上升动画
        transform.position = Vector3.Lerp(startPos, endPos, t);

        // 淡入
        if (timer < fadeInTime)
        {
            SetAlpha(Mathf.Lerp(0, 1, timer / fadeInTime));
        }
        // 淡出
        else if (timer > duration - fadeOutTime)
        {
            SetAlpha(Mathf.Lerp(1, 0, (timer - (duration - fadeOutTime)) / fadeOutTime));
        }
        else
        {
            SetAlpha(1f);
        }

        if (timer >= duration)
        {
            Destroy(gameObject);
        }
    }

    void SetAlpha(float a)
    {
        if (text != null)
        {
            var c = text.color;
            c.a = a;
            text.color = c;
        }
    }
} 