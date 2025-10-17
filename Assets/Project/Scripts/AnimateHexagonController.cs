using UnityEngine;
using UnityEngine.TextCore.Text;

public class AnimateHexagonController : MonoBehaviour
{

    [SerializeField] float degressPerSecond = 30.0f;

    private float maxRotationTime = 1.0f;
    private float currentRotationTime = 0.0f;

    [SerializeField] private AnimationCurve rotationCurve;
    [SerializeField] private AnimationCurve scaleCurve;
    [SerializeField] private Gradient colorGradient;

    void Update()
    {
        //cada segon va de 0 a 30 grados

        currentRotationTime += Time.deltaTime;
        float t = currentRotationTime / maxRotationTime;

        t = t - (int)t;

        float rotationlerpValue = rotationCurve.Evaluate(t);

        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, degressPerSecond * rotationlerpValue);

        float scaleLerpValue = scaleCurve.Evaluate(t);
        this.transform.localScale = Vector3.one + Vector3.one * scaleLerpValue;

        Color colorLerpValue = colorGradient.Evaluate(t);
        this.GetComponent<SpriteRenderer>().color = colorLerpValue;
    }
}
