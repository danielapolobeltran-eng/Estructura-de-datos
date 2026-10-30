
using System;
using System.Collections.Generic;

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

// Clase para realizar los recorridos del árbol
public class TreeTraversals
{
    // 1. Recorrido Preorden (Raíz, Izquierda, Derecha)
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden (Izquierda, Raíz, Derecha)
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. Recorrido Posorden (Izquierda, Derecha, Raíz)
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. Recorrido por niveles (BFS)
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// Clase principal del programa
public class Program
{
    public static void Main(string[] args)
    {
        // Crear el árbol binario
        Node root = new Node(1);

        root.Left = new Node(2);
        root.Right = new Node(3);

        root.Left.Left = new Node(4);
        root.Left.Right = new Node(5);

        root.Right.Left = new Node(6);
        root.Right.Right = new Node(7);

        // Crear objeto de recorridos
        TreeTraversals traversal = new TreeTraversals();

        // Mostrar los recorridos
        Console.WriteLine("===== RECORRIDOS DEL ARBOL BINARIO =====");

        Console.Write("\n1. Recorrido Preorden: ");
        traversal.PreOrder(root);

        Console.Write("\n2. Recorrido Inorden: ");
        traversal.InOrder(root);

        Console.Write("\n3. Recorrido Posorden: ");
        traversal.PostOrder(root);

        Console.Write("\n4. Recorrido por niveles (BFS): ");
        traversal.LevelOrder(root);

        Console.WriteLine("\n\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
