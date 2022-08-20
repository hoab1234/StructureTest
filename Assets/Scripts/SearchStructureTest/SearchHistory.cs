using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchHistory : PopGameObject
{
    private List<string> searchHistory;
    private string keyword;

    public GameObject SearchPrefab;
    public GameObject TagResultPrefab;

    private void Search(string keyword)
    {
        if(keyword.Contains("#"))
        {
            Show("Tag Search Result Panel");
        }
        else
        {
            Show("Search Result Panel");
        }
    }
}
