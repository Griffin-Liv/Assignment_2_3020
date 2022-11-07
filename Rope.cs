class Node{
    private string s;
    private int length;
    private Node left, right;
}


class Rope{
    private Node root;


    public Rope(){}


    public Rope(string S){
        Node curr_node = (ref)this.root;
        Node prev_node;

        this.root.length = S.length;
        
        while(RopeRecurssive(curr_node, S)){
            
        }
        

    }


    private bool RopeRecurssive(Node node, string s){
        
    }

    public Rope Concatenate(Rope R1, Rope R2){

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
        return this.root.length;
    }


    public string ToString(){

    }


    public void PrintRope(){

    }
}
