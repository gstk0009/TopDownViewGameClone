using UnityEngine;
using UnityEngine.UIElements;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer pangRenderer;
    [SerializeField] private SpriteRenderer knightRenderer;

    private TopDownController controller;
    PlayerActiveSystem activeSystem;

    private bool selectPang = false;
    private bool selectKnight = false;

    private void Awake()
    {
        activeSystem = GetComponent<PlayerActiveSystem>();
        controller = GetComponent<TopDownController>();
    }

    public void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        Rotate(direction);
    }

    private void Rotate(Vector2 direction)
    {
        selectPang = activeSystem.pangObject.activeSelf;
        selectKnight = activeSystem.knightObject.activeSelf;

        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(selectPang && !selectKnight)
            pangRenderer.flipX = Mathf.Abs(rotZ) > 90;

        if(selectKnight && !selectPang)
            knightRenderer.flipX = Mathf.Abs(rotZ) > 90;
    }
}