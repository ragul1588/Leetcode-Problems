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
    public IList<int> PostorderTraversal(TreeNode root) {
        
        var li = new List<int>();
        PostorderProblem(root,li);
        return li;
    }
    public void PostorderProblem(TreeNode node, List<int> li){
       if(node == null) return;

       PostorderProblem(node.left,li);
       PostorderProblem(node.right,li);
       li.Add(node.val);
    }
}