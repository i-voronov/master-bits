﻿using System;
using System.Collections;
using NUnit.Framework;

[TestFixture]
public class DirReductionTests
{

    [Test]
    public void Test1()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] b = new string[] { "WEST" };
        Assert.AreEqual(b, MySolution.DirReduction.DirReduc(a));
    }
    [Test]
    public void Test2()
    {
        string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        Assert.AreEqual(b, MySolution.DirReduction.DirReduc(a));
    }

    [Test]
    public void Test3()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] b = new string[] { "WEST" };
        Assert.AreEqual(b, MasterBits.DirReduction.DirReduc(a));
    }
    [Test]
    public void Test4()
    {
        string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        Assert.AreEqual(b, MasterBits.DirReduction.DirReduc(a));
    }
}