/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        var ListOfcurrentList = new List<IList<int>>();

        if(root == null) return ListOfcurrentList;

        var currentQueue = new Queue<TreeNode>();
        currentQueue.Enqueue(root);
        
        while(currentQueue.Count > 0){
        var currentList = new List<int>();
        int range = currentQueue.Count;
        for(int i=0; i<range; i++){
            TreeNode currentNode = currentQueue.Dequeue(); 
            currentList.Add(currentNode.val);

            if(currentNode.left != null) currentQueue.Enqueue(currentNode.left);
            if(currentNode.right != null) currentQueue.Enqueue(currentNode.right);
        }
          ListOfcurrentList.Add(currentList);
        }
      return ListOfcurrentList;
    }
}