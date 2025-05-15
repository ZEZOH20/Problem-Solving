//using System.Collections.Generic;
public class MyQueue {

    Stack<int> queue;
    
    public MyQueue() {
        queue = new Stack<int>();
    }
    
    public void Push(int x) {
        queue.Push(x);
    }
    
    public int Pop() {
         Stack<int> temp = new Stack<int>();
         int top = -1;
        while(queue.Count() > 0){
            int value = queue.Peek();
            if(queue.Count()==1){
                top = value; 
                queue.Pop();
                continue;
            } 
            temp.Push(value);
            queue.Pop();
        }
        while (temp.Count() > 0){
            int value = temp.Peek();
            queue.Push(value);
            temp.Pop();
        }
        return top;
    }
    
    public int Peek() {
         Stack<int> temp = new Stack<int>();
         int top = -1;
        while(queue.Count() > 0){
            int value = queue.Peek();
            if(queue.Count()==1) top = value;
            temp.Push(value);
            queue.Pop();
        }
        while (temp.Count() > 0){
            int value = temp.Peek();
            queue.Push(value);
            temp.Pop();
        }
        return top;
    }
    
    public bool Empty() => queue.Count() == 0;
  
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */