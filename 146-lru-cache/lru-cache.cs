public class LRUCache {
    
   Dictionary<int,Node> map = new Dictionary<int, Node>();
   int _capacity = 0;

   Node head = new Node(0,0);
   Node tail = new Node(0,0);

    public LRUCache(int capacity) {
        _capacity = capacity;
        head.next = tail; 
        tail.prev = head;
    }
    
    public int Get(int key) {
      if(map.ContainsKey(key)){
        Node temp = map[key];
        remove(temp);
        insert(temp);
        return temp.value;
      }
      return -1;
    }
    
    public void Put(int key, int value) {
        if(map.ContainsKey(key)){
             remove(map[key]);
        }
        if(_capacity == map.Count){
             remove(tail.prev);
        }
        insert(new Node(key,value));
    }
    
    public void remove(Node node) {
        map.Remove(node.key);
       node.prev.next = node.next;
       node.next.prev = node.prev;
    }
    public void insert(Node node){
        map[node.key] = node;
        node.next = head.next;
        node.next.prev = node;
        head.next = node;
        node.prev = head;
    }


    public class Node {
      public int key;
      public int value;
      public Node prev;
      public Node next;

    public Node(int _key, int _value){
        key = _key;
        value = _value;
    }
    }
}


/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */