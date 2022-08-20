using System.Collections;
using System.Collections.Generic;
using UnityEngine;

partial class PartialClassTest : MonoBehaviour
{
    [SerializeField] private GameObject historyObject;

    public void History() => Debug.Log("history from partial history class");
}
