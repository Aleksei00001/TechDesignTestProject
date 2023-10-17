using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonSceneSwapOpen : MonoBehaviour
{
    [SerializeField] private GameObject UIScenSwap;

    private BoxCollider2D boxCollider2D;

    private void Start()
    {
        boxCollider2D = this.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.GetComponent<BoxCollider2D>() != null && boxCollider2D == hit.collider.GetComponent<BoxCollider2D>())
            {
                UIScenSwap.SetActive(true);
            }
        }
    }
}
