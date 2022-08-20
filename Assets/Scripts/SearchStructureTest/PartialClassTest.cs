using System.Collections;
using System.Collections.Generic;
using UnityEngine;

partial class PartialClassTest : MonoBehaviour
{
    [SerializeField] private GameObject searchObject;
    public void Search() => Debug.Log("Search");

    private void Start()
    {
        Search();
        History();
        TagResult();
    }
}