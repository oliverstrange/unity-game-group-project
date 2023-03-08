using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField] private RectTransform[] options;
    private RectTransform rect;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }
}
