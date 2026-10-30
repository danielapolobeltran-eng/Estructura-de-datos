using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;
    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Inserción Recursiva Preservando Propiedad BST
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);
        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);
        return root;
    }

    // Búsqueda de un Elemento O(log N)
    public bool Search(Node root, int key)
    {
        if (root == null) return false;
        if (root.Data == key) return true;
        return key < root.Data
             ? Search(root.Left, key)
             : Search(root.Right, key);
    }
}

// --- FUNCION PRINCIPAL INCLUIDA ---
class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Ejercicio 1 de la guía pág 9
        int[] claves = { 45, 23, 67, 12, 34, 56, 89 };
        Console.WriteLine("Insertando claves: [45, 23, 67, 12, 34, 56, 89]");
        foreach (int c in claves)
        {
            bst.Insert(c);
        }

        Console.WriteLine("\nArbol creado correctamente. Raiz: " + bst.Root.Data);

        // Prueba de búsqueda O(log N)
        Console.WriteLine("\n--- PRUEBA DE BUSQUEDA ---");
        Console.WriteLine("Buscar 34: " + bst.Search(bst.Root, 34) + " (Existe)");
        Console.WriteLine("Buscar 56: " + bst.Search(bst.Root, 56) + " (Existe)");
        Console.WriteLine("Buscar 100: " + bst.Search(bst.Root, 100) + " (No existe)");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
