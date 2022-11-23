using System;

public class Node{
    
    private string s;
    private int length;
    private Node left, right;

    public string S{
        get{return this.s;}
        set{this.s = value;}
    }

    public int Length{
        get{return this.length;}
        set{this.length = value;}
    }

    public Node Left{
        get{return this.left;}
        set{this.left = value;}
    }

    public Node Right{
        get{return this.right;}
        set{this.right = value;}
    }


    public Node()
    {
        this.s = "";
        this.length = 0;
    }
    
}


class Rope{
    private Node root;


    public Rope(){}


    public Rope(string str)
    {
        if(str.Length > 6){
            RecursiveConstructor(str, this.root);
        }
        else{
            this.root.S = str;
            this.root.Length = str.Length;
        }
    }


    private void RecursiveConstructor(string str, Node current)
    {
        current.Left = new Node();
        current.Right = new Node();

        string left_half = str.Substring(0, Convert.ToInt32((str.Length / 2)) + (str.Length % 2));
        string right_half = str.Substring(Convert.ToInt32((str.Length / 2)) + (str.Length % 2), Convert.ToInt32((str.Length / 2)));

        current.Length = str.Length;

        
        current.Left.Length = left_half.Length;
        current.Right.Length = right_half.Length;

        if(left_half.Length > 6){
            RecursiveConstructor(left_half, current.Left);
            RecursiveConstructor(right_half, current.Right);
        }
        else{
            current.Left.S = left_half;
            current.Right.S = right_half;
        }

    }

    public Rope Concatenate(Rope R1, Rope R2){
        Rope rope = new Rope();
        
        rope.root.Length = R1.Length() + R2.Length();
        rope.root.Left = R1.root;
        rope.root.Right = R2.root;

        return rope;

    }


    public void Split(int i, Rope R1, Rope R2){

    }


    public void Insert(string S, int i){

    }


    public void Delete(int i, int j){

    }


    public string Substring(int i, int j){

    }


    public char CharAt(int i){

    }


    public int IndexOf(char c){

    }


    public void Reverse(){

    }


    public int Length(){
        return this.root.Length;
    }


    public string ToString(){

    }


    public void PrintRope(){

    }
}
