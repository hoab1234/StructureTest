using System.Collections;
using System.Collections.Generic;
using UnityEngine;

partial class PartialClassTest : MonoBehaviour
{
    [SerializeField] private GameObject tagResultObject;

    public void TagResult() => Debug.Log("tag result");
}
