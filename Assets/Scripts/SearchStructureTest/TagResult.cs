using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagResult : PopGameObject
{
    List<string> resultTags;

    public void Search(string tag) => Show("Search result"); 
}
