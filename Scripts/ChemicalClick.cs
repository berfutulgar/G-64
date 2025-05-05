using UnityEngine;

public class ChemicalClick : MonoBehaviour
{
    public string chemicalName; // "I", "L", "X" de�erlerinden biri
    public MiniOyun gameController;

    void OnMouseDown()
    {
        gameController.AddChemical(chemicalName);
    }
}
