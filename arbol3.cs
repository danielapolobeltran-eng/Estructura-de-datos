
using System;

// Clase que representa cada nodo del árbol
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

// Clase para eliminar nodos del árbol BST
public class BSTDeletion
{
    // Método para eliminar un nodo
    public Node DeleteNode(Node root, int key)
    {
        if (root == null)
            return root;

        // Buscar el nodo que se desea eliminar
        if (key < root.Data)
        {
            root.Left = DeleteNode(root.Left, key);
        }
        else if (key > root.Data)
        {
            root.Right = DeleteNode(root.Right, key);
        }
        else
        {
            // Caso 1: El nodo no tiene hijos
            if (root.Left == null && root.Right == null)
                return null;

            // Caso 2: El nodo tiene un solo hijo
            if (root.Left == null)
                return root.Right;

            if (root.Right == null)
                return root.Left;

            // Caso 3: El nodo tiene dos hijos
            // Buscar el sucesor inorden
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // Método para encontrar el menor valor
    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }

    // Mostrar el árbol en recorrido Inorden
    public void InOrder(Node root)
    {
        if (root == null)
            return;

        InOrder(root.Left);
        Console.Write(root.Data + " ");
        InOrder(root.Right);
    }
}

// Clase principal
public class Program
{
    public static void Main(string[] args)
    {
        // Crear el árbol BST
        Node root = new Node(50);

        root.Left = new Node(30);
        root.Right = new Node(70);

        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);

        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        // Crear objeto de eliminación
        BSTDeletion bst = new BSTDeletion();

        // Mostrar árbol original
        Console.WriteLine("===== ELIMINACION EN ARBOL BST =====");

        Console.Write("\nArbol original (Inorden): ");
        bst.InOrder(root);

        // Solicitar valor a eliminar
        Console.Write("\n\nIngrese el valor que desea eliminar: ");
        int key = Convert.ToInt32(Console.ReadLine());

        // Eliminar el nodo
        root = bst.DeleteNode(root, key);

        // Mostrar árbol después de eliminar
        Console.Write("\nArbol despues de eliminar: ");
        bst.InOrder(root);

        Console.WriteLine("\n\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
