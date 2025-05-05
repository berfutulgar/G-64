using UnityEngine;

public class DragPuzzlePiece : MonoBehaviour
{
    public Vector3 targetPosition;
    public float snapDistance = 1.2f;

    private bool isDragging = false;
    private bool isSnapped = false;

    void Update()
    {
        if (isSnapped) return;

        if (isDragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0f);
        }

        if (!isDragging && Vector3.Distance(transform.position, targetPosition) < snapDistance)
        {
            transform.position = targetPosition;
            isSnapped = true;
            BoruCheck.TotalSnapped++;
        }
    }

    void OnMouseDown()
    {
        if (!isSnapped)
            isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
