using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchResult : PopGameObject
{
    string keyowrd;

    private void TouchInput() => Show("history");

    public void GetSearchResult(string tag = "") => Debug.Log("Search Result");
}
