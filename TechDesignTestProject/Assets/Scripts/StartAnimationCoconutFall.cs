using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationCoconutFall : MonoBehaviour
{
    [SerializeField] private bool loop;

    [SerializeField] private bool pressMouse;

    [SerializeField] private float animationTime;
    private float animationTimer;

    [SerializeField] private Vector2 rangeStartAnimationX;
    [SerializeField] private Vector2 rangeStartAnimationY;

    [SerializeField] private BoxCollider2D boxCollider2D;

    [SerializeField] private Animator animator;

    [SerializeField] private GameObject animationObject;

    private void Start()
    {
        animationTimer = animationTime;
        animator.Play(0,0,1);
    }

    private void Update()
    {
        if (animationTimer < animationTime)
        {
            animationTimer += Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && animationTimer >= animationTime && pressMouse == true)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null &&  hit.collider.GetComponent<BoxCollider2D>() != null && boxCollider2D == hit.collider.GetComponent<BoxCollider2D>())
            {
                animationPlay();
            }
        }
        else if (animationTimer >= animationTime && loop == true)
        {
            animationPlay();
        }
    }

    private void animationPlay()
    {
        animator.Play(0, 0, 0);
        animationTimer = 0;
        animationObject.transform.localPosition = new Vector2(Random.Range(rangeStartAnimationX.x, rangeStartAnimationX.y), Random.Range(rangeStartAnimationY.x, rangeStartAnimationY.y));
    }
}
