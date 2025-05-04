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
     List<int> result = new List<int>();
     InorderTraversal(root , result);
     return result;

    }
   void InorderTraversal(TreeNode node , List<int> result){
        if(node == null)  return;
        InorderTraversal(node.left , result); // Visit left subtree
        result.Add(node.val); // add value
        InorderTraversal(node.right , result); // Visit right subtree
   }
}