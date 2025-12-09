using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesConsoleApp;

class Container<T>
{
    private T item;

    public T Item
    {
        get { return item; }
        set { item = value; }
    }

    public Container(T item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechowywana: {Item}");
    }
}

class ContainerInt
{
    private int item;

	public int Item
	{
		get { return item; }
		set { item = value; }
	}

    public ContainerInt(int item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechowywana: {Item}");
    }
}

class ContainerString
{
    private string item;

    public string Item
    {
        get { return item; }
        set { item = value; }
    }

    public ContainerString(string item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechowywana: {Item}");
    }
}

/*
class Container_dfgdnhfghjdghjcfgh
{
    private int item;

    public int Item
    {
        get { return item; }
        set { item = value; }
    }

    public Container_dfgdnhfghjdghjcfgh(int item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechowywana: {Item}");
    }
}

class Container_sdfhsdfghdf
{
    private string item;

    public string Item
    {
        get { return item; }
        set { item = value; }
    }

    public Container_sdfhsdfghdf(string item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechowywana: {Item}");
    }
}
*/