using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InterfaceTest1
{

    // A Test behaves as an ordinary method
    [Test]
    public void InterfaceTest1SimplePasses()
    {
        GameObject ui = new GameObject();
        UISurvey.OnOffComponent(ui);
        Assert.IsFalse(ui.activeSelf);
        UISurvey.OnOffComponent(ui);
        Assert.IsTrue(ui.activeSelf);
    }
}
