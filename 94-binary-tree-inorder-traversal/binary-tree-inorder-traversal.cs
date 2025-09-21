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
    public IList<int> InorderTraversal(TreeNode root) {
        
        var li = new List<int>();
        InorderTraversalProblem(root,li);
        return li;
    }
    public void InorderTraversalProblem(TreeNode node, List<int> li){
       if(node == null) return;
 
       InorderTraversalProblem(node.left,li);
       li.Add(node.val);
       InorderTraversalProblem(node.right,li);
    }
}