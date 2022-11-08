using System.Reflection.Emit;
public class Node 
{
  Node next = null;

  int data;

  public Node(int d)
  {
    data = d;
  }

  public void AppendToTail(int d)
  {
    Node end =  new Node(d);
    Node n = this;
    while (n.next != null) n = n.next;
    n.next = end;
  }

  public Node Delete(Node head, int d)
  {
    Node n = head;

    if (n.data == d) return head.next;

    while (n.next != null)
    {
      if(n.next.data == d) 
      {
        n.next = n.next.next;
        return head;
      }
      n = n.next;
    }
    return head;
  }
}