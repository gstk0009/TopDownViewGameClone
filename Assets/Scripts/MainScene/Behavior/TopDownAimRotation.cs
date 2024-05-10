using UnityEngine;
using UnityEngine.UIElements;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer pangRenderer;
    [SerializeField] private SpriteRenderer knightRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        Rotate(direction);
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(SelectPlayerSystem.selectPang)
            pangRenderer.flipX = Mathf.Abs(rotZ) > 90;

        if(SelectPlayerSystem.selectKnight)
            knightRenderer.flipX = Mathf.Abs(rotZ) > 90;
    }
}