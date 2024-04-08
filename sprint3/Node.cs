// File:    Node.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:31:48 AM
// Purpose: Definition of Class Node

using System;

public class Node
{
   private String id;
   private String label;
   private Double score;
   private int posX;
   private int posY;
   
   public System.Collections.Generic.List<EnrolledNode> enrolledNode;
   
   /// <summary>
   /// Property for collection of EnrolledNode
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<EnrolledNode> EnrolledNode
   {
      get
      {
         if (enrolledNode == null)
            enrolledNode = new System.Collections.Generic.List<EnrolledNode>();
         return enrolledNode;
      }
      set
      {
         RemoveAllEnrolledNode();
         if (value != null)
         {
            foreach (EnrolledNode oEnrolledNode in value)
               AddEnrolledNode(oEnrolledNode);
         }
      }
   }
   
   /// <summary>
   /// Add a new EnrolledNode in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddEnrolledNode(EnrolledNode newEnrolledNode)
   {
      if (newEnrolledNode == null)
         return;
      if (this.enrolledNode == null)
         this.enrolledNode = new System.Collections.Generic.List<EnrolledNode>();
      if (!this.enrolledNode.Contains(newEnrolledNode))
         this.enrolledNode.Add(newEnrolledNode);
   }
   
   /// <summary>
   /// Remove an existing EnrolledNode from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveEnrolledNode(EnrolledNode oldEnrolledNode)
   {
      if (oldEnrolledNode == null)
         return;
      if (this.enrolledNode != null)
         if (this.enrolledNode.Contains(oldEnrolledNode))
            this.enrolledNode.Remove(oldEnrolledNode);
   }
   
   /// <summary>
   /// Remove all instances of EnrolledNode from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllEnrolledNode()
   {
      if (enrolledNode != null)
         enrolledNode.Clear();
   }

}