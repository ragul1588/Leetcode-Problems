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
    public IList<int> PreorderTraversal(TreeNode root) {
        var li = new List<int>();
        PreorderProblem(root,li);
        return li;
    }
    public void PreorderProblem(TreeNode node, List<int> li){
      if(node == null) return;

      li.Add(node.val);
      PreorderProblem(node.left,li);
      PreorderProblem(node.right,li);
    }
}